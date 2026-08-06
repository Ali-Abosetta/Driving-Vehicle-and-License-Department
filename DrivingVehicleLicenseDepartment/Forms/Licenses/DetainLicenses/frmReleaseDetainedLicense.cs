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
using DrivingVehicleLicenseDepartment.Forms.Drivers;
using DrivingVehicleLicenseDepartment.Global;
using Krypton.Toolkit;

namespace DrivingVehicleLicenseDepartment.Forms.Licenses.DetainLicenses
{
    public partial class frmReleaseDetainedLicense : Form
    {
        private BLL.Licenses _License;
        private BLL.Applications _Application = new BLL.Applications();
        public frmReleaseDetainedLicense()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lblShowLicenseHistory_LinkClicked(object sender, EventArgs e)
        {
            using (frmLicenseHistory frm = new frmLicenseHistory(_License.DriverInfo.PersonInfo))
            {
                frm.ShowDialog();
            }
        }

        private void lblShowLicenseInfo_LinkClicked(object sender, EventArgs e)
        {
            using (frmDriverLicenseInfo frm = new frmDriverLicenseInfo(_License))
            {
                frm.ShowDialog();
            }
        }

        private void ctrlReleaseLicenseWithFilter1_OnLicenseSelected(object sender, EventArgs e)
        {
            lblShowLicenseHistory.Enabled = true;
            lblShowLicenseInfo.Enabled = true;
            _License = ctrlReleaseLicenseWithFilter1.License;

            if (!BLL.DetainedLicenses.IsDetainedByLicenseID(_License.LicenseID))
            {
                KryptonMessageBox.Show($"This license is not detained.", "Undetained license",
                    KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Warning, false);
                return;
            }

            BLL.DetainedLicenses detainedLicenses = BLL.DetainedLicenses.FindByLicenseID(_License.LicenseID);
            ctrlReleaseLicenseWithFilter1.detainedLicenses = detainedLicenses;

            _Application.ApplicationDate = DateTime.Now;
            _Application.ApplicationStatus = (int)BLL.Applications.enStatus.New;

            BLL.ApplicationsTypes appType = new BLL.ApplicationsTypes();

            appType = ApplicationsTypes
            .Find((int)ApplicationsTypes.enApplicationType.RenewDrivingLicense);

            if (appType != null)
            {
                _Application.ApplicationTypeInfo = appType;
                _Application.ApplicationTypeID = appType.ApplicationTypeID;
                _Application.PaidFees = appType.ApplicationFees;
            }

            _Application.CreatedByUserID = clsGlobal.User.UserID;
            _Application.CreatedByUserInfo = clsGlobal.User;

            _Application.ApplicantPersonID = _License.DriverInfo.PersonID;

            btnRelease.Enabled = true;
        }

        private void btnRelease_Click(object sender, EventArgs e)
        {
            bool isConfirmed = KryptonMessageBox.Show($"Are you sure that you want to" +
                $" release the license with ID {_License.LicenseID}?",
                "Confirm", KryptonMessageBoxButtons.YesNo,
                KryptonMessageBoxIcon.Question, false) == DialogResult.Yes;

            if (isConfirmed)
            {
                _Application.ApplicationStatus = (int)BLL.Applications.enStatus.Completed;
                _Application.LastStatusDate = DateTime.Now;

                if (!_Application.Save())
                {
                    KryptonMessageBox.Show("Failed to save the Application.",
                        "Error", KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Error, false);
                    return;
                }

                ctrlReleaseLicenseWithFilter1.detainedLicenses.ReleaseApplicationID = _Application.ApplicationID;
                ctrlReleaseLicenseWithFilter1.detainedLicenses.ReleaseDate = DateTime.Now;
                ctrlReleaseLicenseWithFilter1.detainedLicenses.ReleasedByUserID = clsGlobal.User.UserID;
                ctrlReleaseLicenseWithFilter1.detainedLicenses.IsReleased = true;

                if (!ctrlReleaseLicenseWithFilter1.detainedLicenses.Save())
                {
                    KryptonMessageBox.Show("Failed to update the detained license status.",
                        "Error", KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Error, false);
                    return;
                }

                KryptonMessageBox.Show($"The License {_License.LicenseID} has been released", "License detained",
                    KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Information, false);

                this.Close();
            }
        }
    }
}
