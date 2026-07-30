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
    public partial class ctrlRenewLicenseWithFilter : UserControl
    {
        public event EventHandler OnLicenseSelected;
        public event EventHandler OnLicenseNotFound;

        public ctrlRenewLicenseWithFilter()
        {
            InitializeComponent();
        }

        private Licenses _OldLicense;
        public Licenses OldLicense
        {
            get
            {
                return ctrlDriverLicenseCard1.License;
            }
            set
            {
                if (value != null)
                {
                    ctrlDriverLicenseCard1.License = value;
                    ctrlApplicationRenewLicenseInfo1.OldLicense = value;
                }
            }
        }

        public string Notes
        {
            get
            {
                return ctrlApplicationRenewLicenseInfo1.Notes;
            }
            set
            {
                ctrlApplicationRenewLicenseInfo1.Notes = value;
            }
        }

        public decimal NewFees
        {
            get
            {
                return ctrlApplicationRenewLicenseInfo1.NewFees;
            }
            set
            {
                ctrlApplicationRenewLicenseInfo1.NewFees = value;
            }
        }

        public BLL.Applications Application { get; set; }

        private void Search(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtSearch.Text))
            {
                Licenses license = Licenses.Find(Convert.ToInt32(txtSearch.Text));

                if (license != null)
                {
                    OldLicense = license;
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
