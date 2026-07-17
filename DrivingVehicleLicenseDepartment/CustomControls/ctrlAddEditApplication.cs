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
    public partial class ctrlAddEditApplication : UserControl
    {

        private Users _User;
        public Users User
        {
            get 
            {
                return _User;
            }
            set 
            {
                _User = value;

                if(value != null)
                    lblUser.Text = value.UserName;
            }
        }
        public int LicenseClassID { get; set; } = 3;
        public int ApplicantPersonID { get; set; }

        private Applications _Application = new Applications();
        public Applications Application
        {
            get
            {

                _Application.ApplicantPersonID = ApplicantPersonID;
                _Application.ApplicationDate = DateTime.Now;
                _Application.ApplicationTypeID = 1; //This is the Application type id of new local DL
                _Application.ApplicationStatus = ((int)Applications.enStatus.New); // New by default in here
                _Application.LastStatusDate = DateTime.Now;
                _Application.PaidFees = 15;
                _Application.CreatedByUserID = User.UserID;

                return _Application;
            }

            set
            {
                lblID.Text = value.ApplicationID.ToString();
                lblDate.Text = value.ApplicationDate.ToString("dd/MM/yyyy");
            }
        }

        public ctrlAddEditApplication()
        {
            InitializeComponent();

            lblDate.Text = DateTime.Now.ToString("dd/MM/yyyy");
            cmbClasses.SelectedIndex = 2;
        }

        public void refresh()
        {
            lblID.Text = _Application.ApplicationID.ToString();
            lblUser.Text = _User.UserName.ToString();
            lblDate.Text = DateTime.Now.ToString("dd/MM/yyyy");
        }
        private void cmbClasses_SelectedIndexChanged(object sender, EventArgs e)
        {
            LicenseClassID = ((int)cmbClasses.SelectedIndex) + 1;
        }


        public void ApplyInitApplicationInfo()
        {
            lblID.Text = "N/A";
            lblDate.Text = DateTime.Now.ToString("dd/MM/yyyy");
            lblFees.Text = "15";
        }
    }
}
