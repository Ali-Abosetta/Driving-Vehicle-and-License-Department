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

namespace DrivingVehicleLicenseDepartment.Forms.Licenses.InternationalDrivingLicense
{
    public partial class frmInternationalLicenseCard : Form
    {

        public InternationalLicenses InternationalLicenses
        {
            get
            {
                return ctrlInternationalLicenseCard1.InternationalLicense;
            }
            set
            {
                ctrlInternationalLicenseCard1.InternationalLicense = value;
            }
        }

        public frmInternationalLicenseCard(int InternationalLicenseID)
        {
            InitializeComponent();

            InternationalLicenses = InternationalLicenses.Find(InternationalLicenseID);
        }

        public frmInternationalLicenseCard(InternationalLicenses internationalLicense)
        {
            InitializeComponent();

            InternationalLicenses = internationalLicense;
        }
    }
}
