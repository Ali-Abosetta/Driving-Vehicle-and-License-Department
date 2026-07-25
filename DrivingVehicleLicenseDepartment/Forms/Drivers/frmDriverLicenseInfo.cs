using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Krypton.Toolkit;
namespace DrivingVehicleLicenseDepartment.Forms.Drivers
{
    public partial class frmDriverLicenseInfo : KryptonForm
    {
        public frmDriverLicenseInfo(BLL.Licenses License)
        {
            InitializeComponent();

            ctrlDriverLicenseCard1.License = License;
        }

        public frmDriverLicenseInfo(int LicenseID)
        {
            InitializeComponent();

            ctrlDriverLicenseCard1.License = BLL.Licenses.Find(LicenseID);

        }
    }
}
