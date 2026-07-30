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

namespace DrivingVehicleLicenseDepartment.Forms.Licenses.InternationalDrivingLicense
{
    public partial class frmInternationalDrivingLicensesApplications : Form
    {

        private Users _CurrentUser;
        private DataTable _InternationalLicensesTable;
        public frmInternationalDrivingLicensesApplications(Users user)
        {
            InitializeComponent();

            _CurrentUser = user;
            _InternationalLicensesTable = InternationalLicenses.GetInternationalLicensesSummary();
            dgvInternationalLicenseApplications.DataSource = _InternationalLicensesTable;
        }

        private void btnAddNew_Click(object sender, EventArgs e)
        {
            using (frmAddInternationalLicense frm = new frmAddInternationalLicense(_CurrentUser))
            {
                frm.ShowDialog();
            }
        }
    }
}
