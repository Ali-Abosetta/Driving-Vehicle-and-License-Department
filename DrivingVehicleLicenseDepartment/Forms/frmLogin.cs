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

namespace DrivingVehicleLicenseDepartment
{
    public partial class frmLogin : KryptonForm
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private bool IsValidUserNameAndPassword(Users user)
        {
            if (user == null || !user.Password.Equals(txtPassword.Text))
            {
                return false;
            }

            return true;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            Users User = Users.FindByUserName(txtUserName.Text);

            if (IsValidUserNameAndPassword(User))
            {
                if (User.IsActive)
                {
                    using (frmMain Main = new frmMain(User))
                    {
                        Main.ShowDialog();
                        this.Hide();
                    }
                }
                else
                    KryptonMessageBox.Show("This user is not active right now, call the manager.");
            }

            else
                KryptonMessageBox.Show("Invalid Username or Password!");

            this.Show();
        }
    }
}
