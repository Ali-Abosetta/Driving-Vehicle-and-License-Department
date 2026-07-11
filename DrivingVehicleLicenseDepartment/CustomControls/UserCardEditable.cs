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
    public partial class UserCardEditable : UserControl
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

                    ctrlPersonCardEditable1.Person = People.Find(value.PersonID);

                    _user = value;
                }
            }
        }
        public UserCardEditable()
        {
            InitializeComponent();
        }
    }
}
