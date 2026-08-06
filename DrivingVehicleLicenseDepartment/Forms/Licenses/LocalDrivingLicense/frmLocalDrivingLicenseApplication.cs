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
using DrivingVehicleLicenseDepartment.Forms.Drivers;
using DrivingVehicleLicenseDepartment.Forms.Tests.TestAppointments;
using DrivingVehicleLicenseDepartment.Global;
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

        public frmLocalDrivingLicenseApplication()
        {
            InitializeComponent();
            _LocalLicensesTable = LocalDrivingLicenseApplications
                .GetLocalDrivingLicenseApplicationsSummary();
            dgvLocalLicenseApplications.DataSource = _LocalLicensesTable;

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
            using (frmAddNewLocalLicense frm = new frmAddNewLocalLicense(clsGlobal.User))
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
                    BLL.Applications app = null;
                    app = localApp.ApplicationInfo;

                    if (app != null)
                    {
                        app.ApplicationStatus = (int)BLL.Applications.enStatus.Canceled;
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

            using (frmTestAppointments frm = new frmTestAppointments(SelectedApplicationID, testType))
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

            DataRow row = _LocalLicensesTable.Rows.Find(SelectedApplicationID);

            SechduleTestsToolStripMenuItem.Enabled = false;
            scheduleVisionTestToolStripMenuItem.Enabled = false;
            scheduleWrittenTestToolStripMenuItem.Enabled = false;
            scheduleStreetTestToolStripMenuItem.Enabled = false;
            IssueLicenseToolStripMenuItem.Enabled = false;
            if (row["Status"].ToString() == "Completed")
            {
                EditApplicationToolStripMenuItem.Enabled = false;
                DeleteApplicationToolStripMenuItem.Enabled = false;
                CancelToolStripMenuItem.Enabled = false;
                return;
            }


            int passedTests = Convert.ToInt32(row["Passed tests"]);
            if (row["Status"].ToString() == "New")
            {
                SechduleTestsToolStripMenuItem.Enabled = true;
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

        private void IssueLicenseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (frmIssueDrivingLicenseFirstTime frm = new frmIssueDrivingLicenseFirstTime(SelectedApplicationID))
            {
                frm.DataBack += frmIssueDrivingLicenseFirstTime_DataBack;
                frm.ShowDialog();
            }
        }

        private void frmIssueDrivingLicenseFirstTime_DataBack()
        {
            DataRow rowToEdit = _LocalLicensesTable.Rows.Find(SelectedApplicationID);
            if (rowToEdit != null)
            {
                rowToEdit["Status"] = "Completed";
            }
        }

        private void showLicenseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BLL.Licenses license = BLL.Licenses.FindByLocalAppID(SelectedApplicationID);

            if (license != null)
            {
                using (frmDriverLicenseInfo frm = new frmDriverLicenseInfo(license))
                {
                    frm.ShowDialog();
                }
            }
        }

        private void showPersonLicenseHistoryToolStripMenuItem_Click(object sender, EventArgs e)
        {

            LocalDrivingLicenseApplications localApp 
                = LocalDrivingLicenseApplications.Find(SelectedApplicationID);

            if(localApp != null)
            {
                using (frmLicenseHistory frm = new frmLicenseHistory(localApp.ApplicationInfo.ApplicantPersonInfo))
                {
                    frm.ShowDialog();
                }
            }

        }
    }
}
