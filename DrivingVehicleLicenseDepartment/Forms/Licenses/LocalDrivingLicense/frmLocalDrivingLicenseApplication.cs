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
using DrivingVehicleLicenseDepartment.Forms.Tests.TestAppointments;
using Krypton.Toolkit;
using static BLL.TestTypes;

namespace DrivingVehicleLicenseDepartment.Forms.Licenses.LocalDrivingLicense
{
    public partial class frmLocalDrivingLicenseApplication : Form
    {
        private DataTable _LocalLicensesTable = new DataTable();
        private int SelectedApplicationID
        {
            get
            {
                return Convert.ToInt32(
                    dgvLocalLicenseApplications.CurrentRow.Cells["L.D.L Application ID"].Value
                    );
            }
        }
        private Users _CurrentUser;

        public frmLocalDrivingLicenseApplication(Users user)
        {
            InitializeComponent();
            _LocalLicensesTable = LocalDrivingLicenseApplications
                .GetLocalDrivingLicenseApplicationsSummary();
            dgvLocalLicenseApplications.DataSource = _LocalLicensesTable;
            _CurrentUser = user;


            cmbFilter.DataSource = LocalDrivingLicenseApplications.GetSearchFilters();
        }

        private void frmLocalDrivingLicenseApplication_Load(object sender, EventArgs e)
        {
            dgvLocalLicenseApplications.Columns["L.D.L Application ID"].Width = 150;
            dgvLocalLicenseApplications.Columns["National No."].Width = 150;
            dgvLocalLicenseApplications.Columns["Status"].Width = 150;
        }

        private void Search(object sender, EventArgs e)
        {
            if (cmbFilter.SelectedItem == null) return;

            _LocalLicensesTable.DefaultView.RowFilter = $"CONVERT([{cmbFilter.SelectedItem.ToString()}]," +
                $" 'System.String') LIKE '%{txtSearch.Text.Trim()}%'";

            dgvLocalLicenseApplications.DataSource = _LocalLicensesTable;
        }

        private void btnAddNew_Click(object sender, EventArgs e)
        {
            using (frmAddNewLocalLicense frm = new frmAddNewLocalLicense(_CurrentUser))
            {
                frm.DataBack += frmAddNew_DataBack;
                frm.ShowDialog();
            }
        }
        private void frmAddNew_DataBack()
        {
            _LocalLicensesTable = LocalDrivingLicenseApplications
                .GetLocalDrivingLicenseApplicationsSummary();
            dgvLocalLicenseApplications.DataSource = _LocalLicensesTable;
        }

        private void CancelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (KryptonMessageBox.Show($"Are you sure that you want to cancel the application {SelectedApplicationID}"
                , "Cancel application", KryptonMessageBoxButtons.YesNo,
                KryptonMessageBoxIcon.Question, false) == DialogResult.Yes)
            {
                LocalDrivingLicenseApplications localApp = null;
                localApp = LocalDrivingLicenseApplications.Find(SelectedApplicationID);
                if (localApp != null)
                {
                    Applications app = null;
                    app = localApp.ApplicationInfo;

                    if (app != null)
                    {
                        app.ApplicationStatus = (int)Applications.enStatus.Canceled;
                        app.Save();
                        refreshDgv();
                    }
                    else
                    {
                        KryptonMessageBox.Show($"Error while finding the application on the database, call the support"
                        , "Error while canceling application", KryptonMessageBoxButtons.OK,
                        KryptonMessageBoxIcon.Error, false);
                    }
                }
                else
                {
                    KryptonMessageBox.Show($"Error while finding the Local application on the database, call the support"
                    , "Error while canceling application", KryptonMessageBoxButtons.OK,
                    KryptonMessageBoxIcon.Error, false);
                }

            }
        }
        private void refreshDgv()
        {
            dgvLocalLicenseApplications.DataSource
                = LocalDrivingLicenseApplications.GetLocalDrivingLicenseApplicationsSummary();
        }

        private void ShowApplicatoinCard(object sender, EventArgs e)
        {
            using (frmLocalDrivingLicenseApplicationCard
                frm = new frmLocalDrivingLicenseApplicationCard(SelectedApplicationID))

                frm.ShowDialog();
        }

        private void scheduleTestToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ToolStripMenuItem clickedItem = (ToolStripMenuItem)sender;

            enTestType testType = (enTestType)Convert.ToInt32(clickedItem.Tag);

            using (frmTestAppointments frm = new frmTestAppointments(_CurrentUser, SelectedApplicationID, testType))
            {
                frm.DataBack += frmTestAppointments_DataBack;
                frm.ShowDialog();
            }
        }

        private void frmTestAppointments_DataBack(object sender, bool Passed)
        {
            DataRow rowToEdit = _LocalLicensesTable.Rows.Find(SelectedApplicationID);

            if (rowToEdit != null && Passed)
            {
                rowToEdit["Passed tests"] = (Convert.ToInt32(rowToEdit["Passed tests"]) + 1).ToString();
            }



        }

        private void cmsLocalLicenses_Opening(object sender, CancelEventArgs e)
        {

            int passedTests = Convert.ToInt32(dgvLocalLicenseApplications.CurrentRow.Cells["Passed tests"].Value);

            SechduleTestsToolStripMenuItem.Enabled = true;
            scheduleVisionTestToolStripMenuItem.Enabled = false;
            scheduleWrittenTestToolStripMenuItem.Enabled = false;
            scheduleStreetTestToolStripMenuItem.Enabled = false;
            IssueLicenseToolStripMenuItem.Enabled = false;

            switch (passedTests)
            {
                case 0:
                    scheduleVisionTestToolStripMenuItem.Enabled = true;
                    break;
                case 1:
                    scheduleWrittenTestToolStripMenuItem.Enabled = true;
                    break;
                case 2:
                    scheduleStreetTestToolStripMenuItem.Enabled = true;
                    break;
                case 3:
                    SechduleTestsToolStripMenuItem.Enabled = false;
                    IssueLicenseToolStripMenuItem.Enabled = true;
                    break;
            }
        }
    }
}
