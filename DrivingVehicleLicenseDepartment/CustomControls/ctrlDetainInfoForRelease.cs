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
    public partial class ctrlDetainInfoForRelease : UserControl
    {

        private BLL.ApplicationsTypes _appType;

        private DetainedLicenses _DetainedLicense;
        public DetainedLicenses DetainedLicense
        {
            get
            {
                return _DetainedLicense;
            }
            set
            {
                if (value != null)
                {

                    if (value.DetainID > 0)
                    {
                        lblDetainID.Text = value.DetainID.ToString();
                    }

                    lblDetainDate.Text = value.DetainDate.ToString("dd/MM/yyyy");
                    lblLicenseID.Text = value.LicenseID.ToString();
                    lblUser.Text = value.CreatedByUserInfo.UserName;
                    lblApplicationFees.Text = _appType.ApplicationFees.ToString();
                    lblFineFees.Text = value.FineFees.ToString();
                    lblTotalFees.Text = (_appType.ApplicationFees + value.FineFees).ToString();

                    if (value.ReleaseApplicationID.HasValue)
                    {
                        lblApplicationID.Text = value.ReleaseApplicationID.ToString();
                    }

                    _DetainedLicense = value;
                }
            }
        }
        public ctrlDetainInfoForRelease()
        {
            InitializeComponent();

            _appType = BLL.ApplicationsTypes
                .Find((int)BLL.ApplicationsTypes.enApplicationType.ReleaseDetainedDrivingLicsense);

        }
    }
}
