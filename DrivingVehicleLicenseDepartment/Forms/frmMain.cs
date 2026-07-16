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
using DrivingVehicleLicenseDepartment.Forms.ApplicationTypes;
using DrivingVehicleLicenseDepartment.Forms.Licenses;
using DrivingVehicleLicenseDepartment.Forms.Licenses.LocalDrivingLicense;
using DrivingVehicleLicenseDepartment.Forms.Tests.TestTyps;
using Krypton.Toolkit;

namespace DrivingVehicleLicenseDepartment
{
    public partial class frmMain : KryptonForm
    {
        private int _CurrentUserID;
        private Users _CurrentUser;
        public frmMain(int UserID)
        {
            InitializeComponent();
            _CurrentUserID = UserID;
        }

        public frmMain(Users User)
        {
            InitializeComponent();
            _CurrentUserID = User.UserID;
            _CurrentUser = User;
        }

        private void frmMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
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
            this.Close();
        }

        private void currentUserInformationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using(frmUserCard frm = new frmUserCard(_CurrentUserID))
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
            using(frmChangePassword changePassword = new frmChangePassword(_CurrentUser))
            {
                changePassword.ShowDialog();
            }
        }

        private void detainedToolStripMenuItem_Click(object sender, EventArgs e)
        {

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
            using (frmAddNewLocalLicense localLicense = new frmAddNewLocalLicense(_CurrentUser))
            {
                localLicense.ShowDialog();
            }
        }

        private void manageApplicationsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void localDrivingLicenseApplicationsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (frmLocalDrivingLicenseApplication frm = new frmLocalDrivingLicenseApplication(_CurrentUser))
            {
                frm.ShowDialog();
            }
        }

    }
}
