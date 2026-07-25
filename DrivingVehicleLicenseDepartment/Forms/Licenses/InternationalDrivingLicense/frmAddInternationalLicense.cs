using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DrivingVehicleLicenseDepartment.Forms.Licenses.InternationalDrivingLicense
{
    public partial class frmAddInternationalLicense : Form
    {
        public frmAddInternationalLicense()
        {
            InitializeComponent();
        }

        private void ctrlLicenseApplicationWithFilter1_OnLicenseSelected(object sender, EventArgs e)
        {
            lblShowLicenseHistory.Enabled = true;
            btnIssue.Enabled = true;
        }

    }
}
