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
    public partial class ctrlInternationLicenseApplicationBasicInfo : UserControl
    {
        private Applications _Application;
        public Applications Application
        {
            get
            {
                return _Application;
            }
            set
            {
                if (value != null)
                {

                    if (value.ApplicationID != -1)
                    {
                        lblApplicationID.Text = value.ApplicationID.ToString();
                    }
                    lblApplicationDate.Text = value.ApplicationDate.ToString("dd/MM/yyyy");
                    lblIssueDate.Text = value.ApplicationDate.ToString("dd/MM/yyyy");
                    lblExpirationDate.Text = value.ApplicationDate.AddYears(1).ToString("dd/MM/yyyy");
                    lblFees.Text = value.ApplicationTypeInfo.ApplicationFees.ToString();
                    lblUser.Text = value.CreatedByUserInfo.UserName;

                    _Application = value;
                }
            }
        }

        private InternationalLicenses _InternationalLicense;
        public InternationalLicenses InternationalLicense
        {
            get
            {
                return _InternationalLicense;
            }
            set
            {
                if (value != null)
                {
                    lblInternationLicenseID.Text = value.InternationalLicenseID.ToString();
                    lblLocalLicenseID.Text = value.IssuedUsingLocalLicenseID.ToString();
                }
            }
        }

        public ctrlInternationLicenseApplicationBasicInfo()
        {
            InitializeComponent();

 

        }
    }
}
