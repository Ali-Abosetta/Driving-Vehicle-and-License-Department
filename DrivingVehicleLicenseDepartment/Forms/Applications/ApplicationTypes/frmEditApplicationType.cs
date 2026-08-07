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
using DrivingVehicleLicenseDepartment.CustomControls;
using DrivingVehicleLicenseDepartment.Global;
using Krypton.Toolkit;

namespace DrivingVehicleLicenseDepartment.Forms.Applications.ApplicationTypes
{
    public partial class frmEditApplicationTyps : KryptonForm
    {

        public delegate void DataBackEventHandler(object sender, ApplicationsTypes app);
        public event DataBackEventHandler DataBack;

        private ApplicationsTypes _appType = new ApplicationsTypes();
        public frmEditApplicationTyps(ApplicationsTypes app)
        {
            InitializeComponent();
            _appType = app;
        }
        public frmEditApplicationTyps(int ApplicationID)
        {
            InitializeComponent();
            _appType = ApplicationsTypes.Find(ApplicationID);
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

            if 
            (
                string.IsNullOrWhiteSpace(txtTitle.Text) ||
                string.IsNullOrWhiteSpace(txtFees.Text) ||
                !clsFormsUtil.IsNumber(txtFees.Text)
            )
            {
                KryptonMessageBox.Show($"Error: Please fillout the form with valid data{Environment.NewLine}" +
                    $"and take a look at the validation messages on the red points.",
                    "Error", KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Error, false);

                return;
            }

            _appType.ApplicationTypeTitle = txtTitle.Text;
            _appType.ApplicationFees = Convert.ToDecimal(txtFees.Text);

            if (_appType.Save())
            {
                KryptonMessageBox.Show("Data Saved Successfully.",
                    "Saved", KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Information);

                DataBack?.Invoke(this, _appType);
            }

            else
            {
                KryptonMessageBox.Show("Error: Data Is not Saved Successfully.",
                    "Error", KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Error);
            }
        }

        private void frmEditApplication_Load(object sender, EventArgs e)
        {
            lblID.Text = _appType.ApplicationTypeID.ToString();
            txtTitle.Text = _appType.ApplicationTypeTitle;
            txtFees.Text = _appType.ApplicationFees.ToString();
        }

        private void txtTitle_Validating(object sender, CancelEventArgs e)
        {
            KryptonTextBox textbox = (KryptonTextBox)sender;
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
                txtTitle_Validating(sender, e);
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
