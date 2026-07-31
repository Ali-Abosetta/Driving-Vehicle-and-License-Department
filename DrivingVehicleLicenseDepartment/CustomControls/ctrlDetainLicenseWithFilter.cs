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
    public partial class ctrlDetainLicenseWithFilter : UserControl
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
                return ctrlDetainInfo1.Detained;
            }
            set
            {
                if (value != null)
                    ctrlDetainInfo1.Detained = value;
            }
        }

        public bool EnableFees
        {
            get
            {
                return ctrlDetainInfo1.txtFineFees.Enabled;
            }
            set
            {
                ctrlDetainInfo1.txtFineFees.Enabled = value;
            }
        }

        public decimal FineFees
        {
            get
            {
                if (!string.IsNullOrWhiteSpace(ctrlDetainInfo1.txtFineFees.Text))
                {
                    return Convert.ToDecimal(ctrlDetainInfo1.txtFineFees.Text);
                }
                else 
                    return 0;
            }
        }
        public ctrlDetainLicenseWithFilter()
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
