using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DrivingVehicleLicenseDepartment.CustomControls;
using DrivingVehicleLicenseDepartment.Forms.Drivers;
using Krypton.Toolkit;

namespace DrivingVehicleLicenseDepartment.Forms.Licenses.DetainLicenses
{
    public partial class frmDetainLicense : Form
    {
        private BLL.Users _CurrentUser;
        private BLL.Licenses _License;
        public frmDetainLicense(BLL.Users user)
        {
            InitializeComponent();
            _CurrentUser = user;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lblShowLicenseHistory_LinkClicked(object sender, EventArgs e)
        {
            using (frmLicenseHistory frm = new frmLicenseHistory(ctrlDetainLicenseWithFilter1.License.DriverInfo.PersonInfo))
            {
                frm.ShowDialog();
            }
        }

        private void lblShowLicenseInfo_LinkClicked(object sender, EventArgs e)
        {
            using (frmDriverLicenseInfo frm = new frmDriverLicenseInfo(ctrlDetainLicenseWithFilter1.License))
            {
                frm.ShowDialog();
            }
        }

        private void ctrlDetainLicenseWithFilter1_OnLicenseSelected(object sender, EventArgs e)
        {
            lblShowLicenseHistory.Enabled = true;
            lblShowLicenseInfo.Enabled = true;
            _License = ctrlDetainLicenseWithFilter1.License;

            if (BLL.DetainedLicenses.IsDetainedByLicenseID(_License.LicenseID))
            {
                KryptonMessageBox.Show($"This license is already detained.", "Detained license",
                    KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Warning, false);
                return;
            }

            BLL.DetainedLicenses detainedLicense = new BLL.DetainedLicenses();

            detainedLicense.LicenseID = _License.LicenseID;
            detainedLicense.LicenseInfo = _License;

            detainedLicense.CreatedByUserID = _CurrentUser.UserID;
            detainedLicense.CreatedByUserInfo = _CurrentUser;
            detainedLicense.DetainDate = DateTime.Now;
            
            ctrlDetainLicenseWithFilter1.detainedLicenses = detainedLicense;

            ctrlDetainLicenseWithFilter1.EnableFees = true;
            btnDetain.Enabled = true;
        }

        private void btnDetain_Click(object sender, EventArgs e)
        {
            BLL.DetainedLicenses detainLicenses = ctrlDetainLicenseWithFilter1.detainedLicenses;

            detainLicenses.FineFees = ctrlDetainLicenseWithFilter1.FineFees;
            detainLicenses.IsReleased = false;

            if(!detainLicenses.Save())
            {
                KryptonMessageBox.Show($"Error: Failed to save the detained license on the database", "Error",
                    KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Error, false);
                return;
            }

            KryptonMessageBox.Show($"The License {_License.LicenseID} has been detained " +
                $"with detian ID: {detainLicenses.DetainID}", "License detained",
                KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Information, false);

            this.Close();
        }
    }
}
