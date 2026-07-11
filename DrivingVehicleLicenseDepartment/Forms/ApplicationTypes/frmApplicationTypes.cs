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
using Krypton.Toolkit;

namespace DrivingVehicleLicenseDepartment.Forms.ApplicationTypes
{
    public partial class frmApplicationTypes : KryptonForm
    {

        private int _SelectedID
        {
            get
            {
                return Convert.ToInt32(dgvApplications.CurrentRow
                .Cells["Application Type ID"].Value);
            }
        }

        private DataTable _ApplicationTypesTable = new DataTable();
        public frmApplicationTypes()
        {
            InitializeComponent();

            _ApplicationTypesTable = ApplicationsTypes.GetAllApplicationTypes();
            dgvApplications.DataSource = _ApplicationTypesTable;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmApplicationTypes_Load(object sender, EventArgs e)
        {
            dgvApplications.Columns["Application Type ID"].Width = 120;
            dgvApplications.Columns["Application Fees"].Width = 150;
        }

        private void EditApplicationType(object sender, EventArgs e)
        {

            using (frmEditApplicationTyps appType = new frmEditApplicationTyps(_SelectedID))
            {
                appType.DataBack += frmEditApplication_DataBack;
                appType.ShowDialog();
            }
        }

        private void frmEditApplication_DataBack(object sender, ApplicationsTypes appType)
        {
            DataRow rowToEdit = _ApplicationTypesTable.Rows.Find(_SelectedID);

            if (rowToEdit != null)
            {
                rowToEdit["Application Type Title"] = appType.ApplicationTypeTitle;
                rowToEdit["Application Fees"] = appType.ApplicationFees;
            }

        }
    }
}
