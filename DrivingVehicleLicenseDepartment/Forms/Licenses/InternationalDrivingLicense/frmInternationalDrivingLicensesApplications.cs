using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DrivingVehicleLicenseDepartment.Global;
using BLL;

namespace DrivingVehicleLicenseDepartment.Forms.Licenses.InternationalDrivingLicense
{
    public partial class frmInternationalDrivingLicensesApplications : Form
    {

        private DataTable _InternationalLicensesTable;
        public frmInternationalDrivingLicensesApplications()
        {
            InitializeComponent();

            _InternationalLicensesTable = InternationalLicenses.GetInternationalLicensesSummary();
            dgvInternationalLicenseApplications.DataSource = _InternationalLicensesTable;
        }

        private void btnAddNew_Click(object sender, EventArgs e)
        {
            using (frmAddInternationalLicense frm = new frmAddInternationalLicense())
            {
                frm.ShowDialog();
            }
        }
    }
}
