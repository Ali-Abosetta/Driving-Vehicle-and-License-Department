using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Resources;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;

namespace DrivingVehicleLicenseDepartment.CustomControls
{
    public partial class ctrlInternationalLicenseCard : UserControl
    {
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
                    lblName.Text = value.DriverInfo.PersonInfo.FullName;
                    lblInternationalLicenseID.Text = value.InternationalLicenseID.ToString();
                    lblLicenseID.Text = value.IssuedUsingLocalLicenseID.ToString();
                    lblNationalNo.Text = value.DriverInfo.PersonInfo.NationalNo;
                    lblGender.Text = value.DriverInfo.PersonInfo.Gendor != 1 ? "Male" : "Female";
                    lblIssueDate.Text = value.IssueDate.ToString("dd/MM/yyyy");
                    lblApplicationID.Text = value.ApplicationID.ToString();
                    lblActive.Text = value.IsActive ? "Yes" : "No";
                    lblDateOfBirth.Text = value.DriverInfo.PersonInfo.DateOfBirth.ToString("dd/MM/yyyy");
                    lblDriverID.Text = value.DriverID.ToString();
                    lblExpairationDate.Text = value.ExpirationDate.ToString("dd/MM/yyyy");
                   
                    pbPicture.ImageLocation =
                        value.DriverInfo.PersonInfo.ImagePath == string.Empty ?
                            null : value.DriverInfo.PersonInfo.ImagePath;

                    _InternationalLicense = value;
                }
            }
        }
        public ctrlInternationalLicenseCard()
        {
            InitializeComponent();
        }
    }
}
