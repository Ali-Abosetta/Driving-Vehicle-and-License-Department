using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DrivingVehicleLicenseDepartment.CustomControls;
using Krypton.Toolkit;
using BLL;

namespace DrivingVehicleLicenseDepartment.Forms.Users
{
    public partial class frmUserCard : KryptonForm
    {

        public frmUserCard(int UserID)
        {
            InitializeComponent();
            userCard1.User = BLL.Users.Find(UserID);
        }

        public frmUserCard(BLL.Users user)
        {
            InitializeComponent();
            userCard1.User = user;
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
