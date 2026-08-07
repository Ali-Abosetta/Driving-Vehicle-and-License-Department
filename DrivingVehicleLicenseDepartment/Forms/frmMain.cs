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
using DrivingVehicleLicenseDepartment.Forms;
using DrivingVehicleLicenseDepartment.Global;
using DrivingVehicleLicenseDepartment.Forms.Users;
using DrivingVehicleLicenseDepartment.Forms.Applications.ApplicationTypes;
using DrivingVehicleLicenseDepartment.Forms.Drivers;
using DrivingVehicleLicenseDepartment.Forms.Licenses;
using DrivingVehicleLicenseDepartment.Forms.People;
using DrivingVehicleLicenseDepartment.Forms.Applications;
using DrivingVehicleLicenseDepartment.Forms.Licenses.DetainLicenses;
using DrivingVehicleLicenseDepartment.Forms.Licenses.InternationalDrivingLicense;
using DrivingVehicleLicenseDepartment.Forms.Licenses.LocalDrivingLicense;
using DrivingVehicleLicenseDepartment.Forms.Tests.TestTyps;
using Krypton.Toolkit;

namespace DrivingVehicleLicenseDepartment
{
    public partial class frmMain : KryptonForm
    {

        private frmLogin _Login;
        public frmMain(frmLogin login)
        {
            InitializeComponent();
            _Login = login;
        }

        private void frmMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            _Login.Show();
            this.Close();
        }

        private void btnPeople_Click(object sender, EventArgs e)
        {
            using (frmPeople people = new frmPeople())
            {
                people.ShowDialog();
            }

        }

        private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
        {

            clsGlobal.Logout();
            _Login.Show();
            this.Close();

        }

        private void currentUserInformationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using(frmUserCard frm = new frmUserCard(clsGlobal.User))
            {
                frm.ShowDialog();
            }
        }

        private void btnUsers_Click(object sender, EventArgs e)
        {
            using (frmUsers users = new frmUsers())
            {
                users.ShowDialog();
            }
        }

        private void changePasswordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using(frmChangePassword changePassword = new frmChangePassword(clsGlobal.User))
            {
                changePassword.ShowDialog();
            }
        }

        private void manageApplicationTypesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (frmApplicationTypes frmApp = new frmApplicationTypes()) 
            {
                frmApp.ShowDialog();
            }
        }

        private void manageTestTypesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (frmTestTypes frmApp = new frmTestTypes()) 
            {
                frmApp.ShowDialog();
            }
        }

        private void localLisenceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (frmAddNewLocalLicense localLicense = new frmAddNewLocalLicense(clsGlobal.User))
            {
                localLicense.ShowDialog();
            }
        }

        private void localDrivingLicenseApplicationsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (frmLocalDrivingLicenseApplication frm = new frmLocalDrivingLicenseApplication())
            {
                frm.ShowDialog();
            }
        }

        private void btnDrivers_Click(object sender, EventArgs e)
        {
            using (frmDrivers frmDrivers = new frmDrivers())
            {
                frmDrivers.ShowDialog();
            }
        }

        private void internationalLisenceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (frmAddInternationalLicense frm =  new frmAddInternationalLicense())
            {
                frm.ShowDialog();
            }
        }

        private void internationalDrivingLicenseApplicationsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (frmInternationalDrivingLicensesApplications frm = new frmInternationalDrivingLicensesApplications())
            {
                frm.ShowDialog();
            }
        }

        private void renewDrivingLicenseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (frmRenewLicense frm = new frmRenewLicense())
            {
                frm.ShowDialog();
            }
        }

        private void replaceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (frmReplaceLicense frm = new frmReplaceLicense())
            {
                frm.ShowDialog();
            }
        }

        private void manageDetainedLicensesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (frmDetainedLicenses frm = new frmDetainedLicenses())
            {
                frm.ShowDialog();
            }
        }

        private void detainALisenceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (frmDetainLicense frm = new frmDetainLicense())
            {
                frm.ShowDialog();
            }
        }

        private void releaseDetainedLisenceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (frmReleaseDetainedLicense frm = new frmReleaseDetainedLicense())
            {
                frm.ShowDialog();
            }
        }
    }
}
