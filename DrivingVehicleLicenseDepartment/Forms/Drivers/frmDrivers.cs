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
using DrivingVehicleLicenseDepartment.Forms.Licenses;
using Krypton.Toolkit;

namespace DrivingVehicleLicenseDepartment.Forms.Drivers
{
    public partial class frmDrivers : Form
    {
        private DataTable _DriversTable = new DataTable();

        private int SelectedDriverID
        {
            get
            {
                return Convert.ToInt32(
                    dgvDrivers.CurrentRow.Cells["Driver ID"].Value
                    );
            }
        }
        public frmDrivers()
        {
            InitializeComponent();

            _DriversTable = BLL.Drivers.GetDriversSummary();
            dgvDrivers.DataSource = _DriversTable;

            dgvDrivers.Columns["Full Name"].Width = 350;
        }

        private void LicensesHistoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DataRow row = _DriversTable.Rows.Find(SelectedDriverID);

            using (frmLicenseHistory frm = new frmLicenseHistory(Convert.ToInt32(row["Person ID"])))
            {
                frm.ShowDialog();
            }
        }
    }
}
