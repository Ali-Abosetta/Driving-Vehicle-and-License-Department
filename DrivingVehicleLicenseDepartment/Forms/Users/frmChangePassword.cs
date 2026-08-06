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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace DrivingVehicleLicenseDepartment.Forms.Users
{
    public partial class frmChangePassword : Form
    {
        BLL.Users _CurrentUser;
        public frmChangePassword(BLL.Users User)
        {
            InitializeComponent();
            userCard1.User = User;
            _CurrentUser = User;
        }

        private void kryptonTextBox1_Validating(object sender, CancelEventArgs e)
        {
            if(txtCurrentPassword.Text != userCard1.User.Password)
            {
                e.Cancel = false;
                errorProvider1.SetError((KryptonTextBox)sender, "Wrong password!");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError((KryptonTextBox)sender, "");
            }
        }

        private void txtConfirmPassword_Validating(object sender, CancelEventArgs e)
        {
            if (txtConfirmPassword.Text != txtNewPassword.Text)
            {
                e.Cancel = false;
                errorProvider1.SetError((KryptonTextBox)sender, "Passwords does not match!");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError((KryptonTextBox)sender, "");
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

            bool IsValid =
                (
                    !string.IsNullOrWhiteSpace(txtCurrentPassword.Text) &&
                    !string.IsNullOrWhiteSpace(txtNewPassword.Text) &&
                    !string.IsNullOrWhiteSpace(txtConfirmPassword.Text) &&
                    (txtCurrentPassword.Text == _CurrentUser.Password) &&
                    (txtNewPassword.Text == txtConfirmPassword.Text)
                );

            if (!IsValid)
            {
                KryptonMessageBox.Show($"Please fill out the form correctly {Environment.NewLine}" +
                    $"and ensure the passwords match.",
                    "Not Saved", KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Error, false);
                return;
            }

            if (_CurrentUser.UpdatePassword(txtConfirmPassword.Text))
            {
                KryptonMessageBox.Show("The Password Updated successfully!", "Updated",
                    KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Information, false);

                this.Close();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
