using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Krypton.Toolkit;
using BLL;
using DrivingVehicleLicenseDepartment.Global;

namespace DrivingVehicleLicenseDepartment
{
    public partial class frmLogin : KryptonForm
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {


            if (clsGlobal.Login(txtUserName.Text, txtPassword.Text))
            {
                if (!clsGlobal.User.IsActive)
                {
                    KryptonMessageBox.Show("This user is not active right now, contact the management."
                        , "Inactive user",
                        KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Warning, false);
                    return;
                }

                if (chkRememberMe.Checked)
                {
                    clsGlobal.RememberCredentials(txtUserName.Text, txtPassword.Text);
                }
                else
                {
                    clsGlobal.RememberCredentials("", "");
                }

                using (frmMain Main = new frmMain(this))
                {
                    this.Hide();
                    Main.ShowDialog();
                }
            }

            else
            {
                KryptonMessageBox.Show("Invalid Username or Password!", "Wrong username or password", 
                    KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Warning, false);
            }

        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            if (clsGlobal.GetRememberedCredentials(out string username, out string password))
            {
                txtUserName.Text = username;
                txtPassword.Text = password;
                chkRememberMe.Checked = true;
                btnLogin.Focus();
            }
        }
    }
}
