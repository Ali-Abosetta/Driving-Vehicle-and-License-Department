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
    public partial class ctrlApplicationReplacementLicenseInfo : UserControl
    {
        private ApplicationsTypes _appType;
        private Licenses _OldLicense;
        public Licenses OldLicense
        {
            get
            {
                return _OldLicense;
            }
            set
            {
                if (value != null)
                {
                    lblApplicationDate.Text = value.ApplicationInfo.ApplicationDate.ToString("dd/MM/yyyy");
                    lblOldLicenseID.Text = value.LicenseID.ToString();
                    lblUser.Text = value.CreatedByUserInfo.UserName;
                    lblFees.Text = _appType.ApplicationFees.ToString();

                }
            }
        }

        private Licenses _NewLicense;
        public Licenses NewLicense
        {
            get
            {
                return _NewLicense;
            }

            set
            {
                if (value != null)
                {

                    lblReplacmentApplicationID.Text = value.ApplicationID.ToString();
                    lblReplacementLicenseID.Text = value.LicenseID.ToString();

                    _NewLicense = value;
                }
            }
        }
        public ctrlApplicationReplacementLicenseInfo()
        {
            InitializeComponent();

            _appType = ApplicationsTypes
                .Find((int)ApplicationsTypes.enApplicationType.RenewDrivingLicense);
        }
    }
}
