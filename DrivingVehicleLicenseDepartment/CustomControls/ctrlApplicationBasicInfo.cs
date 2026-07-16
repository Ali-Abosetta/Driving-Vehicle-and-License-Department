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
    public partial class ctrlApplicationBasicInfo : UserControl
    {
        private Applications _application;
        public Applications application
        {
            get
            {
                return _application;
            }

            set
            {
                if (value != null)
                {
                    lblApplicant.Text = value.ApplicantPersonInfo.FullName;
                    lblDate.Text = value.ApplicationDate.ToString("dd/MM/yyyy");
                    lblFees.Text = value.PaidFees.ToString();
                    lblID.Text = value.ApplicationID.ToString();

                    lblStatus.Text = value.ApplicationStatus.ToString();

                    lblStatusDate.Text = value.LastStatusDate.ToString("dd/MM/yyyy");
                    lblType.Text = value.ApplicationTypeInfo.ApplicationTypeTitle;
                    lblUser.Text = value.CreatedByUserInfo.UserName;

                    _application = value;
                }
            }
        }
        public ctrlApplicationBasicInfo()
        {
            InitializeComponent();
        }

    }
}
