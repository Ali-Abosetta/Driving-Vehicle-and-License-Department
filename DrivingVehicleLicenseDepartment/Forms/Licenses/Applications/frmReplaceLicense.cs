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
using DrivingVehicleLicenseDepartment.CustomControls;
using Krypton.Toolkit;

namespace DrivingVehicleLicenseDepartment.Forms.Licenses.Applications
{
    public partial class frmReplaceLicense : Form
    {
        private BLL.Licenses _OldLicense;
        private Users _CurrentUser;
        public frmReplaceLicense(Users user)
        {
            InitializeComponent();

            _CurrentUser = user;
        }

        private void ctrlReplacementLicenseWithFilter1_OnLicenseSelected(object sender, EventArgs e)
        {
            lblShowLicenseHistory.Enabled = true;
            _OldLicense = ctrlReplacementLicenseWithFilter1.OldLicense;

            if (!ctrlReplacementLicenseWithFilter1.OldLicense.IsActive)
            {
                KryptonMessageBox.Show("This license is not active.", "Inactive license warning"
                    , KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Warning, false);
                return;
            }

            BLL.Applications application = new BLL.Applications();
            application.ApplicationDate = DateTime.Now;
            application.ApplicationStatus = (int)BLL.Applications.enStatus.New;

            BLL.ApplicationsTypes appType = null;

            int AppTypeID = ctrlReplacementLicenseWithFilter1.rbDamaged.Checked ?
                (int)BLL.ApplicationsTypes.enApplicationType.ReplaceDamagedDrivingLicense
                : (int)BLL.ApplicationsTypes.enApplicationType.ReplaceLostDrivingLicense;

            appType = ApplicationsTypes
               .Find(AppTypeID);

            if (appType != null)
            {
                application.ApplicationTypeInfo = appType;
                application.ApplicationTypeID = appType.ApplicationTypeID;
                application.PaidFees = appType.ApplicationFees;
            }

            application.CreatedByUserID = _CurrentUser.UserID;
            application.CreatedByUserInfo = _CurrentUser;

            application.ApplicantPersonID = ctrlReplacementLicenseWithFilter1.OldLicense.DriverInfo.PersonID;

            ctrlReplacementLicenseWithFilter1.Application = application;

            btnReplace.Enabled = true;
        }

        private void lblShowLicenseHistory_LinkClicked(object sender, EventArgs e)
        {
            using (frmLicenseHistory frm = new frmLicenseHistory(_OldLicense.DriverInfo.PersonID))
            {
                frm.ShowDialog();
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnReplace_Click(object sender, EventArgs e)
        {
            bool isConfirmed = KryptonMessageBox.Show($"Are you sure that you want to" +
                                $" replace the license with ID {_OldLicense.LicenseID}?",
                                "Confirm", KryptonMessageBoxButtons.YesNo,
                                KryptonMessageBoxIcon.Question, false)
                == DialogResult.Yes;

            if (isConfirmed)
            {
                BLL.Applications application = new BLL.Applications();
                application = ctrlReplacementLicenseWithFilter1.Application;
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
                NewLisences.ExpirationDate = _OldLicense.ExpirationDate;

                NewLisences.Notes = _OldLicense.Notes;
                NewLisences.PaidFees = 0;
                NewLisences.IsActive = true;
                NewLisences.IssueReason = ctrlReplacementLicenseWithFilter1.rbDamaged.Checked ?
                    (int)BLL.Licenses.enIssueReason.DamagedReplacement 
                    : (int)BLL.Licenses.enIssueReason.LostReplacement;

                NewLisences.CreatedByUserID = _CurrentUser.UserID;
                NewLisences.CreatedByUserInfo = _CurrentUser;

                _OldLicense.IsActive = false;

                if (!_OldLicense.Save())
                {
                    KryptonMessageBox.Show("Failed to update the old license active status.",
                        "Error", KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Error, false);
                    return;
                }

                if (!NewLisences.Save())
                {
                    KryptonMessageBox.Show("Failed to repalce the license.",
                        "Error", KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Error, false);
                    return;
                }

                KryptonMessageBox.Show($"The license replaced successfully " +
                    $"with new ID {NewLisences.LicenseID}", "Successful replacement",
                    KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Information, false);

                lblShowLicenseInfo.Enabled = true;
            }
        }
    }
}
