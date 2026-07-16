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
    public partial class ctrlDrivingLicenseApplicationInfo : UserControl
    {
        private LocalDrivingLicenseApplications _LocalApp;
        public LocalDrivingLicenseApplications LocalApp
        {
            get
            {
                return _LocalApp;
            }

            set
            {
                if(value != null)
                {
                    lblID.Text = value.LocalDrivingLicenseApplicationID.ToString();
                    lblClass.Text = value.LicenseClassInfo.ClassName;
                    int passedTest = LocalDrivingLicenseApplications
                        .GetPassedTestsCount(value.LocalDrivingLicenseApplicationID);
                    lblPassedTests.Text = $"{passedTest}/3"; 
                }

                _LocalApp = value;
            }
        }

        public ctrlDrivingLicenseApplicationInfo()
        {
            InitializeComponent();
        }
    }
}
