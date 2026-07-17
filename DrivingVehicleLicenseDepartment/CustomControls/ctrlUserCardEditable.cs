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

namespace DrivingVehicleLicenseDepartment.CustomControls
{
    public partial class ctrlUserCardEditable : UserControl
    {
        private Users _user = new Users();
        public Users User
        {
            get
            {
                return _user;
            }
            set
            {
                if (value != null)
                {
                    lblUserID.Text = value.UserID.ToString();
                    lblUserName.Text = value.UserName;
                    lblActive.Text = value.IsActive ? "Active" : "Not active";

                    ctrlPersonCardEditable1.Person = value.PersonInfo;

                    _user = value;
                }
            }
        }
        public ctrlUserCardEditable()
        {
            InitializeComponent();
        }
    }
}
