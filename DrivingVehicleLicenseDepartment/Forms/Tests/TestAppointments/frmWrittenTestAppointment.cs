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
using Krypton.Toolkit;

namespace DrivingVehicleLicenseDepartment.Forms.Tests.TestAppointments
{
    public partial class frmWrittenTestAppointment : KryptonForm
    {
        public frmWrittenTestAppointment(int LocalApplicationID)
        {
            InitializeComponent();

            LocalDrivingLicenseApplications LocalApp = LocalDrivingLicenseApplications.Find(LocalApplicationID);
            ctrlDrivingLicenseApplicationInfo1.LocalApp = LocalApp;

            ctrlApplicationBasicInfo1.application = Applications.Find(LocalApp.ApplicationID);
        }

        private void btnSchedule_Click(object sender, EventArgs e)
        {
            using (frmScheduleVisionTest frm = new frmScheduleVisionTest())
            {
                frm.ShowDialog();
            }
        }
    }
}
