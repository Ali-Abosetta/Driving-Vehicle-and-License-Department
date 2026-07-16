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

namespace DrivingVehicleLicenseDepartment.Forms.Licenses.LocalDrivingLicense
{
    public partial class frmLocalDrivingLicenseApplicationCard : KryptonForm
    {
        public frmLocalDrivingLicenseApplicationCard(int LocalApplicationID)
        {
            InitializeComponent();

            LocalDrivingLicenseApplications LocalApp = LocalDrivingLicenseApplications.Find(LocalApplicationID);
            ctrlDrivingLicenseApplicationInfo1.LocalApp = LocalApp;

            ctrlApplicationBasicInfo1.application = Applications.Find(LocalApp.ApplicationID);

        }

        public frmLocalDrivingLicenseApplicationCard(
            LocalDrivingLicenseApplications LocalApplication,
            Applications Application)
        {
            InitializeComponent();

            ctrlDrivingLicenseApplicationInfo1.LocalApp = LocalApplication;

            ctrlApplicationBasicInfo1.application = Application;

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
