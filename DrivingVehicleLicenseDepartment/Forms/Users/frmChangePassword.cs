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

namespace DrivingVehicleLicenseDepartment.Forms
{
    public partial class frmChangePassword : Form
    {
        Users _CurrentUser;
        public frmChangePassword(Users User)
        {
            InitializeComponent();
            userCardEditable1.User = User;
            _CurrentUser = User;
        }

        private void kryptonTextBox1_Validating(object sender, CancelEventArgs e)
        {
            if(txtCurrentPassword.Text != userCardEditable1.User.Password)
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
            if (_CurrentUser.UpdatePassword(txtConfirmPassword.Text))
            {
                if (KryptonMessageBox.Show("The Password Updated successfully!", "Updated",
                    KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Information, false) == DialogResult.OK)
                {
                    txtCurrentPassword.Clear();
                    txtNewPassword.Clear();
                    txtConfirmPassword.Clear();
                }
            }
        }
    }
}
