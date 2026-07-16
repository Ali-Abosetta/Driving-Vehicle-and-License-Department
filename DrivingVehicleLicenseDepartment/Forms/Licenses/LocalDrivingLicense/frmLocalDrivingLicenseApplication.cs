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
            if(KryptonMessageBox.Show($"Are you sure that you want to cancel the application {SelectedApplicationID}"
                , "Cancel application", KryptonMessageBoxButtons.YesNo, 
                KryptonMessageBoxIcon.Question, false) == DialogResult.Yes)
            {
                LocalDrivingLicenseApplications localApp = null;
                localApp = LocalDrivingLicenseApplications.Find(SelectedApplicationID);
                if (localApp != null)
                {
                    Applications app = null;
                    app = Applications.Find(localApp.ApplicationID);
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

        private void scheduleVisionTestToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (frmVisionTestAppointment frm = new frmVisionTestAppointment(SelectedApplicationID))
            {
                frm.ShowDialog();
            }
        }

        private void scheduleWrittenTestToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (frmWrittenTestAppointment frm = new frmWrittenTestAppointment(SelectedApplicationID))
            {
                frm.ShowDialog();
            }
        }

        private void scheduleStreetTestToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (frmStreetTestAppointment frm = new frmStreetTestAppointment(SelectedApplicationID))
            {
                frm.ShowDialog();
            }
        }
    }
}
