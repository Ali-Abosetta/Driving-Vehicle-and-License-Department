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

namespace DrivingVehicleLicenseDepartment.Forms.Licenses.DetainLicenses
{
    public partial class frmDetainedLicenses : Form
    {
        private Users _CurrentUser;
        private DataTable _DetainedLicensesTable;

        private int SelectedDetainedID
        {
            get
            {
                return Convert.ToInt32(
                    dgvLicenses.CurrentRow.Cells["User ID"].Value
                    );
            }
        }
        public frmDetainedLicenses(Users user)
        {
            InitializeComponent();

            _CurrentUser = user;
            _DetainedLicensesTable = DetainedLicenses.GetDetainedLicensesSummary();
            dgvLicenses.DataSource = _DetainedLicensesTable;

            dgvLicenses.Columns["Detained ID"].Width = 80;
            dgvLicenses.Columns["License ID"].Width = 80;
            dgvLicenses.Columns["Is released"].Width = 80;
            dgvLicenses.Columns["Fine fees"].Width = 80;


            dgvLicenses.Columns["National No."].Width = 100;
            dgvLicenses.Columns["R. Application ID"].Width = 100;
            dgvLicenses.Columns["Detained date"].Width = 100;
            dgvLicenses.Columns["Release date"].Width = 100;

            dgvLicenses.Columns["Full name"].Width = 350;

        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {

            string NationalNo = dgvLicenses.CurrentRow.Cells["National No."].Value.ToString();
            People person = People.FindByNationalNo(NationalNo);

            using (frmLicenseHistory frm = new frmLicenseHistory(person))
            {
                frm.ShowDialog();
            }
        }

        private void showPersonDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string NationalNo = dgvLicenses.CurrentRow.Cells["National No."].Value.ToString();
            People person = People.FindByNationalNo(NationalNo);

            using (frmPersonCard card = new frmPersonCard(person))
            {
                card.ShowDialog();
            }
        }

        private void addNewPersonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int LicenseID = Convert.ToInt32(dgvLicenses.CurrentRow.Cells["License ID"].Value);

            using (frmDriverLicenseInfo frm = new frmDriverLicenseInfo(LicenseID))
            {
                frm.ShowDialog();
            }
        }

        private void btnDetain_Click(object sender, EventArgs e)
        {
            using (frmDetainLicense frm = new frmDetainLicense(_CurrentUser))
            {
                frm.ShowDialog();
            }
        }

        private void btnRelease_Click(object sender, EventArgs e)
        {
            using (frmReleaseDetainedLicense frm = new frmReleaseDetainedLicense(_CurrentUser))
            {
                frm.ShowDialog();
            }
        }
    }
}
