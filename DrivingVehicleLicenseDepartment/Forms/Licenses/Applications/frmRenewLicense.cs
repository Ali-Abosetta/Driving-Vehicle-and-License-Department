using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
using DrivingVehicleLicenseDepartment.Global;
using DrivingVehicleLicenseDepartment.CustomControls;
using DrivingVehicleLicenseDepartment.Forms.Licenses.InternationalDrivingLicense;
using DrivingVehicleLicenseDepartment.Forms.Licenses.LocalDrivingLicense;
using Krypton.Toolkit;

namespace DrivingVehicleLicenseDepartment.Forms.Licenses.Applications
{
    public partial class frmRenewLicense : KryptonForm
    {
        private BLL.Licenses _OldLicense;
        public frmRenewLicense()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ctrlRenewLicenseWithFilter1_OnLicenseSelected(object sender, EventArgs e)
        {
            lblShowLicenseHistory.Enabled = true;
            _OldLicense = ctrlRenewLicenseWithFilter1.OldLicense;

            if (ctrlRenewLicenseWithFilter1.OldLicense.ExpirationDate > DateTime.Now)
            {
                KryptonMessageBox.Show("This license is not expaired yet.", "Unexpaired license warning"
                    , KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Warning, false);
                return;
            }

            BLL.Applications application = new BLL.Applications();
            application.ApplicationDate = DateTime.Now;
            application.ApplicationStatus = (int)BLL.Applications.enStatus.New;

            BLL.ApplicationsTypes appType = null;
            appType = ApplicationsTypes
               .Find((int)ApplicationsTypes.enApplicationType.RenewDrivingLicense);

            if (appType != null)
            {
                application.ApplicationTypeInfo = appType;
                application.ApplicationTypeID = appType.ApplicationTypeID;
                application.PaidFees = appType.ApplicationFees;
            }

            application.CreatedByUserID = clsGlobal.User.UserID;
            application.CreatedByUserInfo = clsGlobal.User;

            application.ApplicantPersonID = ctrlRenewLicenseWithFilter1.OldLicense.DriverInfo.PersonID;

            ctrlRenewLicenseWithFilter1.Application = application;

            btnRenew.Enabled = true;
        }

        private void ctrlRenewLicenseWithFilter1_OnLicenseNotFound(object sender, EventArgs e)
        {

        }

        private void lblShowLicenseHistory_LinkClicked(object sender, EventArgs e)
        {
            using (frmLicenseHistory frm = new frmLicenseHistory(_OldLicense.DriverInfo.PersonID))
            {
                frm.ShowDialog();
            }
        }

        private void lblShowLicenseInfo_LinkClicked(object sender, EventArgs e)
        {

        }

        private void btnRenew_Click(object sender, EventArgs e)
        {
            bool isConfirmed = KryptonMessageBox.Show($"Are you sure that you want to" +
                $" renew the license with ID {_OldLicense.LicenseID}?",
                "Confirm", KryptonMessageBoxButtons.YesNo,
                KryptonMessageBoxIcon.Question, false) == DialogResult.Yes;

            if (isConfirmed)
            {
                BLL.Applications application = new BLL.Applications();
                application = ctrlRenewLicenseWithFilter1.Application;
                application.ApplicationStatus = (int)BLL.Applications.enStatus.Completed;
                application.LastStatusDate = DateTime.Now;

                if (!application.Save())
                {
                    KryptonMessageBox.Show("Failed to save the Application.",
                        "Error", KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Error, false);
                    return;
                }

                BLL.Licenses NewLisences = new BLL.Licenses();
                
                NewLisences.ApplicationID = application.ApplicationID;
                NewLisences.ApplicationInfo = application;

                NewLisences.DriverID = _OldLicense.DriverID;
                NewLisences.DriverInfo = _OldLicense.DriverInfo;

                NewLisences.LicenseClass = _OldLicense.LicenseClass;
                NewLisences.LicenseClassInfo = _OldLicense.LicenseClassInfo;

                NewLisences.IssueDate = DateTime.Now;
                NewLisences.ExpirationDate = DateTime.Now.AddYears(NewLisences.LicenseClassInfo.DefaultValidityLength);

                NewLisences.Notes = ctrlRenewLicenseWithFilter1.Notes;
                NewLisences.PaidFees = ctrlRenewLicenseWithFilter1.NewFees;
                NewLisences.IsActive = true;
                NewLisences.IssueReason = (int)BLL.Licenses.enIssueReason.Renewal;

                NewLisences.CreatedByUserID = clsGlobal.User.UserID;
                NewLisences.CreatedByUserInfo = clsGlobal.User;

                _OldLicense.IsActive = false;

                if(!_OldLicense.Save())
                {
                    KryptonMessageBox.Show("Failed to update the old license active status.",
                        "Error", KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Error, false);
                    return;
                }

                if (!NewLisences.Save())
                {
                    KryptonMessageBox.Show("Failed to renew the license.",
                        "Error", KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Error, false);
                    return;
                }

                KryptonMessageBox.Show($"The license renewed successfully " +
                    $"with new ID {NewLisences.LicenseID}", "Successful renew",
                    KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Information, false);

                lblShowLicenseInfo.Enabled = true;
            }
        }
    }
}
