using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DrivingVehicleLicenseDepartment.CustomControls
{
    public partial class ctrlDriverLicenseCard : UserControl
    {
        private BLL.Licenses _License;
        public BLL.Licenses License
        {
            get
            {
                return _License;
            }
            set
            {
                if(value != null)
                {
                    lblClass.Text = value.LicenseClassInfo.ClassName;
                    lblName.Text = value.DriverInfo.PersonInfo.FullName;
                    lblLicenseID.Text = value.LicenseID.ToString();
                    lblNational.Text = value.DriverInfo.PersonInfo.CountryInfo.CountryName;
                    lblGender.Text = value.DriverInfo.PersonInfo.Gendor == 0? "Male" : "Female";
                    lblIsseuDate.Text = value.IssueDate.ToString("dd/MM/yyyy");

                    switch ((BLL.Licenses.enIssueReason)value.IssueReason)
                    {
                        case BLL.Licenses.enIssueReason.FirstTime:
                            lblIssueReasone.Text = "First Time";
                            break;

                        case BLL.Licenses.enIssueReason.LostReplacement:
                            lblIssueReasone.Text = "Lost replacement";
                            break;

                        case BLL.Licenses.enIssueReason.DamagedReplacement:
                            lblIssueReasone.Text = "Damaged replacement";
                            break;

                        case BLL.Licenses.enIssueReason.Renewal:
                            lblIssueReasone.Text = "Renewal";
                            break;
                    }


                    lblNotes.Text = value.Notes;

                    lblActive.Text = value.IsActive ? "Yes" : "No";
                    lblDateOfBirth.Text = value.DriverInfo.PersonInfo.DateOfBirth.ToString("dd/MM/yyyy");
                    lblDriverID.Text = value.DriverID.ToString();
                    lblExpirationDate.Text = value.ExpirationDate.ToString("dd/MM/yyyy");
                    bool isDetained = BLL.DetainedLicenses.IsDetainedByLicenseID(value.LicenseID);
                    lblIsDetained.Text = isDetained ? "Yes" : "No";
                    pbPicture.ImageLocation = value.DriverInfo.PersonInfo.ImagePath;
                }
                _License = value;
            }
        }
        public ctrlDriverLicenseCard()
        {
            InitializeComponent();
        }
    }
}
