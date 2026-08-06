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

namespace DrivingVehicleLicenseDepartment.Forms.Users.Controls
{
    public partial class ctrlAddEditUser : UserControl
    {

        public delegate void DataBackEventHandler(object sender, BLL.People Person);
        public event DataBackEventHandler DataBack;

        private BLL.Users _user = new BLL.Users();
        public BLL.Users User
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

                lblUserID.Text = value.PersonID == -1? //Magic number
                    "N/A" : value.UserID.ToString();

                txtUsername.Text = value.UserName;
                chkActive.Checked = value.IsActive;

                _user = value;
            }
        }

        public bool AreBoxesFilled
        {
            get
            {
                return
                (
                    !string.IsNullOrEmpty(txtUsername.Text) &&
                    !string.IsNullOrEmpty(txtPassword.Text) &&
                    !string.IsNullOrEmpty(txtConfirmPassword.Text) &&
                    (txtPassword.Text == txtConfirmPassword.Text)
                );
            }
        }

        public ctrlAddEditUser()
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

        public void ApplyInitUserInfo()
        {
            lblUserID.Text = "N/A";
            txtUsername.Text = string.Empty;
            txtPassword.Text = string.Empty;
            txtConfirmPassword.Text = string.Empty;
        }

        private void txtUserName_Validating(object sender, CancelEventArgs e)
        {

            if (string.IsNullOrWhiteSpace(txtUsername.Text))
            {
                RequiredTextBox_Validating(sender, e);
                return;
            }

            if (txtUsername.Text.Trim() != _user.UserName &&
                BLL.Users.IsExistsByUserName(txtUsername.Text.Trim()))
            {
                e.Cancel = false;
                errorProvider1.SetError(txtUsername, "This username is already taken by another user.");
            }
            else
            {
                errorProvider1.SetError(txtUsername, string.Empty);
            }
        }
    }
}
