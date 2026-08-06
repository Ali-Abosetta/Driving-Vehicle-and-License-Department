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

namespace DrivingVehicleLicenseDepartment.Forms.Users.Controls
{
    public partial class ctrlUserCard : UserControl
    {
        private BLL.Users _User = new BLL.Users();
        public BLL.Users User
        {
            get
            {
                return _User;
            }
            set
            {
                if (value != null)
                {
                    lblUserID.Text = value.UserID.ToString();
                    lblUserName.Text = value.UserName;
                    lblActive.Text = value.IsActive ? "Active" : "Not active";

                    ctrlPersonCard1.Person = value.PersonInfo;

                }

                else
                {
                    _ResetUI();
                }

                _User = value;
            }
        }
        public ctrlUserCard()
        {
            InitializeComponent();
        }

        private void _ResetUI()
        {
            ctrlPersonCard1 = null;
            lblUserID.Text = "N/A";
            lblUserName.Text = "N/A";
            lblActive.Text = "N/A";
        }

    }
}
