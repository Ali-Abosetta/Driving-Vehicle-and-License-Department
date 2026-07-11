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
using Krypton.Toolkit;

namespace DrivingVehicleLicenseDepartment.Forms.ApplicationTypes
{
    public partial class frmEditApplicationTyps : KryptonForm
    {

        public delegate void DataBackEventHandler(object sender, ApplicationsTypes app);
        public event DataBackEventHandler DataBack;

        private ApplicationsTypes _app = new ApplicationsTypes();
        public frmEditApplicationTyps(ApplicationsTypes app)
        {
            InitializeComponent();
            _app = app;
        }
        public frmEditApplicationTyps(int ApplicationID)
        {
            InitializeComponent();
            _app = ApplicationsTypes.Find(ApplicationID);
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            _app.ApplicationTypeTitle = txtTitle.Text;
            _app.ApplicationFees = Convert.ToDecimal(txtFees.Text);

            if (_app.Save())
            {
                KryptonMessageBox.Show("Data Saved Successfully.",
                    "Saved", KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Information);

                DataBack?.Invoke(this, _app);
            }
            
            else
            {
                KryptonMessageBox.Show("Error: Data Is not Saved Successfully.",
                    "Error", KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Error);
            }
        }

        private void frmEditApplication_Load(object sender, EventArgs e)
        {
            lblID.Text = _app.ApplicationTypeID.ToString();
            txtTitle.Text = _app.ApplicationTypeTitle;
            txtFees.Text = _app.ApplicationFees.ToString();
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
    }
}
