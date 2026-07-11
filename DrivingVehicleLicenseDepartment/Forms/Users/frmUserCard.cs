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

namespace DrivingVehicleLicenseDepartment
{
    public partial class frmUserCard : KryptonForm
    {

        public frmUserCard(int UserID)
        {
            InitializeComponent();
            userCardEditable1.User = Users.Find(UserID);
            userCardEditable1.Enabled = false;
        }

        public frmUserCard(Users user)
        {
            InitializeComponent();
            userCardEditable1.User = user;
            userCardEditable1.Enabled = false;
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
