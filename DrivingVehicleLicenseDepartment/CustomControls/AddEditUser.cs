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

namespace DrivingVehicleLicenseDepartment.CustomControls
{
    public partial class AddEditUser : UserControl
    {

        public delegate void DataBackEventHandler(object sender, People Person);
        public event DataBackEventHandler DataBack;

        private Users _user = new Users();
        public Users User
        {
            get
            {

                _user.Password = txtConfirmPassword.Text;
                _user.UserName = txtUsername.Text;
                _user.IsActive = chkActive.Checked;

                return _user;
            }

            set 
            {

                lblUserID.Text = value.UserID.ToString();
                txtUsername.Text = value.UserName;
                chkActive.Checked = value.IsActive;

                _user = value;
            }
        }

        public AddEditUser()
        {
            InitializeComponent();
        }
        private void RequiredTextBox_Validating(object sender, CancelEventArgs e)
        {
            KryptonTextBox textBox = (KryptonTextBox)sender;

            if (string.IsNullOrWhiteSpace(textBox.Text))
            {
                e.Cancel = false;
                errorProvider1.SetError(textBox, $"{textBox.Tag} is required!");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(textBox, "");
            }
        }



    }
}
