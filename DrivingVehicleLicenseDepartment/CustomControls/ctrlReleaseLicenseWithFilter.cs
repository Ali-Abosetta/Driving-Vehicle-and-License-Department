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
    public partial class ctrlReleaseLicenseWithFilter : UserControl
    {
        public event EventHandler OnLicenseSelected;
        public event EventHandler OnLicenseNotFound;

        public BLL.Licenses License
        {
            get
            {
                return ctrlDriverLicenseCard1.License;
            }
            set
            {
                ctrlDriverLicenseCard1.License = value;
            }
        }

        public BLL.DetainedLicenses detainedLicenses
        {
            get
            {
                return ctrlDetainInfoForRelease1.DetainedLicense;
            }
            set
            {
                if (value != null)
                    ctrlDetainInfoForRelease1.DetainedLicense = value;
            }
        }

        public ctrlReleaseLicenseWithFilter()
        {
            InitializeComponent();
        }

        private void Search(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtSearch.Text))
            {
                Licenses license = Licenses.Find(Convert.ToInt32(txtSearch.Text));


                if (license != null)
                {
                    License = license;
                    OnLicenseSelected?.Invoke(this, new EventArgs());
                }

                else
                {
                    OnLicenseNotFound?.Invoke(this, new EventArgs());
                }

            }
        }
    }
}
