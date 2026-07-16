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

namespace DrivingVehicleLicenseDepartment.Forms.Tests.TestTyps
{
    public partial class frmEditTestTypes : KryptonForm
    {
        public delegate void DataBackEventHandler(object sender, TestTypes testType);
        public event DataBackEventHandler DataBack;

        private TestTypes _TestType = new TestTypes();
        public frmEditTestTypes(int TestTypeID)
        {
            InitializeComponent();
            _TestType = TestTypes.Find(TestTypeID);
        }
        public frmEditTestTypes(TestTypes testType)
        {
            InitializeComponent();
            _TestType = testType;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            _TestType.TestTypeTitle = txtTitle.Text;
            _TestType.TestTypeFees = Convert.ToDecimal(txtFees.Text);
            _TestType.TestTypeDescription = rtbDescription.Text;

            if (_TestType.Save())
            {
                KryptonMessageBox.Show("Data Saved Successfully.",
                    "Saved", KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Information);

                DataBack?.Invoke(this, _TestType);
            }

            else
            {
                KryptonMessageBox.Show("Error: Data Is not Saved Successfully.",
                    "Error", KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Error);
            }
        }

        private void frmEditTestTypes_Load(object sender, EventArgs e)
        {
            txtFees.Text = _TestType.TestTypeFees.ToString();
            txtTitle.Text = _TestType.TestTypeTitle;
            rtbDescription.Text = _TestType.TestTypeDescription;
        }
    }
}
