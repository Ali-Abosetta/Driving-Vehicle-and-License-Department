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
using Krypton.Toolkit;
using static System.Net.Mime.MediaTypeNames;

namespace DrivingVehicleLicenseDepartment.Forms.Licenses.LocalDrivingLicense
{
    public partial class frmIssueDrivingLicenseFirstTime : KryptonForm
    {

        public delegate void DatabackEventHandler();
        public event DatabackEventHandler DataBack;

        private Users _CurrentUser = new Users();
        private Applications _App = new Applications();
        private LocalDrivingLicenseApplications _LocalApp = new LocalDrivingLicenseApplications();
        private BLL.Drivers _Driver = null;
        private BLL.Licenses _License = new BLL.Licenses();

        public frmIssueDrivingLicenseFirstTime(Users user, int LocalAppID)
        {
            InitializeComponent();

            _CurrentUser = user;
            _LocalApp = LocalDrivingLicenseApplications.Find(LocalAppID);
            _App = _LocalApp.ApplicationInfo;

            ctrlDrivingLicenseApplicationInfo1.LocalApp = _LocalApp;
            ctrlApplicationBasicInfo1.application = _App;

        }

        public frmIssueDrivingLicenseFirstTime(Users user, LocalDrivingLicenseApplications localApp)
        {
            InitializeComponent();

            _CurrentUser = user;
            _LocalApp = localApp;
            _App = _LocalApp.ApplicationInfo;

            ctrlDrivingLicenseApplicationInfo1.LocalApp = _LocalApp;
            ctrlApplicationBasicInfo1.application = _App;
        }
        private void initDriver()
        {
            _Driver = new BLL.Drivers();
            _Driver.PersonID = _App.ApplicantPersonID;
            _Driver.CreatedByUserID = _CurrentUser.UserID;
            _Driver.CreatedDate = DateTime.Now;
        }

        private void btnIssue_Click(object sender, EventArgs e)
        {
            _Driver = BLL.Drivers.FindDriverByPersonID(_App.ApplicantPersonID);

            if(_Driver == null)
            {
                initDriver();
                _Driver.Save();
            }

            _License.ApplicationID = _App.ApplicationID;
            _License.DriverID = _Driver.DriverID;
            _License.LicenseClass = _LocalApp.LicenseClassInfo.LicenseClassID;
            _License.IssueDate = DateTime.Now;
            _License.ExpirationDate = DateTime.Now.AddYears(_LocalApp.LicenseClassInfo.DefaultValidityLength);
            _License.Notes = rtbNotes.Text;
            _License.PaidFees = _LocalApp.LicenseClassInfo.ClassFees;
            _License.IsActive = true;
            _License.IssueReason = (int)BLL.Licenses.enIssueReason.FirstTime;
            _License.CreatedByUserID = _CurrentUser.UserID;

            if (_License.Save())
            {
                _App.ApplicationStatus = (int)Applications.enStatus.Completed; 
                _App.Save();

                KryptonMessageBox.Show("License issued Successfully.",
                "Successfull issue", KryptonMessageBoxButtons.OK,
                KryptonMessageBoxIcon.Information, false);

                DataBack?.Invoke();
                this.Close();
            }

            else
            {
                KryptonMessageBox.Show("Error: couldn't issue the License.",
                    "Error", KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Error, false);
            }

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
