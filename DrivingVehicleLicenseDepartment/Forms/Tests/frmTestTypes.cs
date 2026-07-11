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
using DrivingVehicleLicenseDepartment.Forms.ApplicationTypes;

namespace DrivingVehicleLicenseDepartment.Forms.Tests
{
    public partial class frmTestTypes : Form
    {

        private int _SelectedID
        {
            get
            {
                return Convert.ToInt32(dgvTestTypes.CurrentRow
                .Cells["Test Type ID"].Value);
            }
        }

        private DataTable _TestTypesTable = new DataTable();
        public frmTestTypes()
        {
            InitializeComponent();

            _TestTypesTable = TestTypes.GetAllTestTypes();
            dgvTestTypes.DataSource = _TestTypesTable;

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmEditTest_DataBack(object sender, TestTypes testType)
        {
            DataRow rowToEdit = _TestTypesTable.Rows.Find(_SelectedID);

            if (rowToEdit != null)
            {
                rowToEdit["Test Type Title"] = testType.TestTypeTitle;
                rowToEdit["Test Type Fees"] = testType.TestTypeFees;
                rowToEdit["Test Type Description"] = testType.TestTypeDescription;
            }

        }

        private void Edit(object sender, EventArgs e)
        {
            using (frmEditTestTypes frm = new frmEditTestTypes(_SelectedID))
            {

                frm.DataBack += frmEditTest_DataBack;
                frm.ShowDialog();

            }
        }

        private void frmTestTypes_Load(object sender, EventArgs e)
        {
            dgvTestTypes.Columns["Test Type ID"].Width = 100;
            dgvTestTypes.Columns["Test Type Fees"].Width = 100;
            dgvTestTypes.Columns["Test Type Title"].Width = 150;
        }
    }
}
