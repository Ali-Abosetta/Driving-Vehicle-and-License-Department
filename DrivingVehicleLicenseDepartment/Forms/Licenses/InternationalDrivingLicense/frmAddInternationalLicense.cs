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

namespace DrivingVehicleLicenseDepartment.Forms.Licenses.InternationalDrivingLicense
{
    public partial class frmAddInternationalLicense : KryptonForm
    {
        private BLL.Users _CurrentUser;
        private BLL.Licenses _License;
        private InternationalLicenses _InternationalLicense;
        private BLL.Drivers _Driver;
        public frmAddInternationalLicense(BLL.Users currentUser)
        {
            InitializeComponent();
            _CurrentUser = currentUser;
        }

        private void ctrlLicenseApplicationWithFilter1_OnLicenseSelected(object sender, EventArgs e)
        {
            lblShowLicenseHistory.Enabled = true;
            btnIssue.Enabled = true;
        }

        private void ctrlLicenseApplicationWithFilter1_OnLicenseSelected_1(object sender, EventArgs e)
        {

            if (ctrlLicenseApplicationWithFilter1.License.LicenseClass != 3)
            {
                KryptonMessageBox.Show("The License should be an Ordinary license.", "Wrong license type"
                    , KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Warning, false);
                return;
            }

            else if (!ctrlLicenseApplicationWithFilter1.License.IsActive)
            {
                KryptonMessageBox.Show("The License should be Active.", "Inactive license warning"
                        , KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Warning, false);
                return;
            }

            else if (ctrlLicenseApplicationWithFilter1.License.ExpirationDate < DateTime.Now)
            {
                KryptonMessageBox.Show("The License shouldn't be Expaired.", "Expaired license warning"
                        , KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Warning, false);
                return;
            }

            _License = ctrlLicenseApplicationWithFilter1.License; 
            //int ActiveInternationalLincesID = BLL.InternationalLicenses
            //    .GetActiveInternationalLicenseIDByDriverID(ctrlLicenseApplicationWithFilter1.License.DriverID);

            _InternationalLicense = InternationalLicenses.FindByDriverID(_License.DriverInfo.DriverID);
            if (_InternationalLicense != null)
            {
                if (_InternationalLicense.InternationalLicenseID > 0)
                {
                    KryptonMessageBox.Show(
                        $"This driver already has an active international license with ID: " +
                        $"{_InternationalLicense.InternationalLicenseID}.",
                        "International driver warninig", KryptonMessageBoxButtons.OK,
                        KryptonMessageBoxIcon.Warning, false);

                    lblShowLicenseHistory.Enabled = true;
                    lblShowLicenseInfo.Enabled = true;
                    return;
                }
            }


            BLL.Applications application = new BLL.Applications();
            application.ApplicationDate = DateTime.Now;
            application.ApplicationStatus = (int)BLL.Applications.enStatus.New;

            BLL.ApplicationsTypes appType = null;
            appType = ApplicationsTypes
               .Find((int)ApplicationsTypes.enApplicationType.NewInternationalLicense);
            if(appType != null)
            {
                application.ApplicationTypeInfo = appType;
                application.ApplicationTypeID = appType.ApplicationTypeID;
                application.PaidFees = appType.ApplicationFees;
            }

            application.CreatedByUserID = _CurrentUser.UserID;
            application.CreatedByUserInfo = _CurrentUser;

            application.ApplicantPersonID = ctrlLicenseApplicationWithFilter1.License.DriverInfo.PersonID;

            ctrlLicenseApplicationWithFilter1.Application = application;

            btnIssue.Enabled = true;
            lblShowLicenseHistory.Enabled = true;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnIssue_Click(object sender, EventArgs e)
        {
            BLL.Applications app = ctrlLicenseApplicationWithFilter1.Application;

            app.ApplicationStatus = (int)BLL.Applications.enStatus.Completed;
            app.LastStatusDate = DateTime.Now;

            if (!app.Save())
            {
                KryptonMessageBox.Show("Failed to save the Application.", 
                    "Error", KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Error, false);
                return;
            }

            BLL.InternationalLicenses internationalLicense = new BLL.InternationalLicenses();
            internationalLicense.ApplicationID = app.ApplicationID;
            internationalLicense.DriverID = ctrlLicenseApplicationWithFilter1.License.DriverID;
            internationalLicense.IssuedUsingLocalLicenseID = ctrlLicenseApplicationWithFilter1.License.LicenseID;
            internationalLicense.IssueDate = DateTime.Now;
            internationalLicense.ExpirationDate = DateTime.Now.AddYears(1); 
            internationalLicense.IsActive = true;
            internationalLicense.CreatedByUserID = _CurrentUser.UserID;

            if (!internationalLicense.Save())
            {
                KryptonMessageBox.Show("Failed to issue the International License.",
                    "Error", KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Error, false);
                return;
            }

            KryptonMessageBox.Show($"International License Issued Successfully with ID:" +
                $" {internationalLicense.InternationalLicenseID}",
                "Success", KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Information, false);

            _InternationalLicense = internationalLicense;

            btnIssue.Enabled = false;
            lblShowLicenseInfo.Enabled = true;
        }

        private void lblShowLicenseHistory_LinkClicked(object sender, EventArgs e)
        {
            using (frmLicenseHistory frm = new frmLicenseHistory(_License.DriverInfo.PersonID))
            {
                frm.ShowDialog();
            }
        }

        private void lblShowLicenseInfo_LinkClicked(object sender, EventArgs e)
        {
            using (frmInternationalLicenseCard frm = new frmInternationalLicenseCard(_InternationalLicense))
            {
                frm.ShowDialog();
            }
        }
    }
}
