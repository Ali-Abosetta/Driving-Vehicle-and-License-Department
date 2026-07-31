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
    public partial class ctrlDetainInfo : UserControl
    {
        private DetainedLicenses _Detained;
        public DetainedLicenses Detained
        {
            get
            {
                return _Detained;
            }
            set
            {
                if(value != null)
                {

                    if (value.DetainID > 0)
                    {
                        lblDetainID.Text = value.DetainID.ToString();
                    }

                    lblDetainDate.Text = value.DetainDate.ToString("dd/MM/yyyy");
                    lblLicenseID.Text = value.LicenseID.ToString();
                    lblUser.Text = value.CreatedByUserInfo.UserName;

                    _Detained = value;
                }
            }
        }

        public ctrlDetainInfo()
        {
            InitializeComponent();
        }

        private void txtFineFees_TextChanged(object sender, EventArgs e)
        {
            if(!string.IsNullOrWhiteSpace(txtFineFees.Text))
                _Detained.FineFees = Convert.ToDecimal(txtFineFees.Text);
        }
    }
}
