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
    public partial class ctrlApplicationRenewLicenseInfo : UserControl
    {

        private ApplicationsTypes _appType;
        public decimal NewFees {  get; set; }
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
                    lblIssueDate.Text = value.IssueDate.ToString("dd/MM/yyyy");
                    lblLicenseFees.Text = value.LicenseClassInfo.ClassFees.ToString();
                    lblOldLicenseID.Text = value.LicenseID.ToString();
                    lblExpairationDate.Text = value.ExpirationDate.ToString("dd/MM/yyyy");
                    lblUser.Text = value.CreatedByUserInfo.UserName;

                    NewFees = value.LicenseClassInfo.ClassFees + _appType.ApplicationFees;
                    lblTotalFees.Text = NewFees.ToString();

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

                    lblRenewApplicationID.Text = value.ApplicationID.ToString();
                    lblRenewLicenseID.Text = value.LicenseID.ToString();

                    _NewLicense = value;
                }
            }
        }

        public string Notes
        {
            get
            {
                return rtbNotes.Text;
            }
            set
            {
                rtbNotes.Text = value;
            }
        }
        public ctrlApplicationRenewLicenseInfo()
        {
            InitializeComponent();

            _appType = ApplicationsTypes
                .Find((int)ApplicationsTypes.enApplicationType.RenewDrivingLicense);
            lblApplicationFees.Text = _appType.ApplicationFees.ToString();

        }
    }
}
