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
using DrivingVehicleLicenseDepartment.Global;
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


            if
            (
                string.IsNullOrWhiteSpace(txtTitle.Text) ||
                string.IsNullOrWhiteSpace(txtFees.Text) ||
                string.IsNullOrWhiteSpace(rtbDescription.Text) ||
                !clsFormsUtil.IsNumber(txtFees.Text)
            )
            {
                KryptonMessageBox.Show($"Error: Please fillout the form with valid data{Environment.NewLine}" +
                    $"and take a look at the validation messages on the red points.",
                    "Error", KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Error, false);

                return;
            }

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

        private void TextBox_Validating(object sender, CancelEventArgs e)
        {
            KryptonTextBox textbox = (KryptonTextBox)sender;
            if (string.IsNullOrWhiteSpace(textbox.Text))
            {
                e.Cancel = false;
                errorProvider1.SetError(textbox, $"The {textbox.Tag.ToString()} should be assigned!");
            }

        }

        private void RichTextBox_Validating(object sender, CancelEventArgs e)
        {
            KryptonRichTextBox textbox = (KryptonRichTextBox)sender;
            if (string.IsNullOrWhiteSpace(textbox.Text))
            {
                e.Cancel = false;
                errorProvider1.SetError(textbox, $"The {textbox.Tag.ToString()} should be assigned!");
            }

        }

        private void txtFees_Validating(object sender, CancelEventArgs e)
        {
            KryptonTextBox textBox = (KryptonTextBox)sender;

            if (string.IsNullOrWhiteSpace(textBox.Text))
            {
                TextBox_Validating(sender, e);
                return;
            }

            if (!clsFormsUtil.IsNumber(txtFees.Text))
            {
                e.Cancel = false;
                errorProvider1.SetError(textBox, $"This text box is numbers only!");
            }

        }
    }
}
