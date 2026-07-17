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
using DrivingVehicleLicenseDepartment.CustomControls;
using DrivingVehicleLicenseDepartment.Properties;
using Krypton.Toolkit;
using static BLL.TestTypes;

namespace DrivingVehicleLicenseDepartment.Forms.Tests.TestAppointments
{
    public partial class frmTestAppointments : KryptonForm
    {
        private enTestType _TestTypeID;
        private int _LocalApplicationID;

        private int SelectedAppointmentID
        {
            get
            {
                return Convert.ToInt32(
                    dgvAppointments.CurrentRow.Cells["Appointment ID"].Value
                    );
            }
        }

        public frmTestAppointments()
        {
            InitializeComponent();
        }

        public frmTestAppointments(int LocalApplicationID, enTestType TestType)
        {
            InitializeComponent();

            LocalDrivingLicenseApplications LocalApp = LocalDrivingLicenseApplications.Find(LocalApplicationID);
            ctrlDrivingLicenseApplicationInfo1.LocalApp = LocalApp;

            ctrlApplicationBasicInfo1.application = LocalApp.ApplicationInfo;

            _TestTypeID = TestType;
            _LocalApplicationID = LocalApplicationID;


            switch (TestType)
            {
                case enTestType.VisionTest:
                    _ApplyVisionTestTheme();                    
                    break;

                case enTestType.WrittenTest:
                    _ApplyWrittenTestTheme();                    
                    break;

                case enTestType.StreetTest:
                    _ApplyStreetTestTheme();                    
                    break;

            }
        }

        private void _ApplyVisionTestTheme()
        {
            lblTitle.Text = "Vision Test Appointment";
            pbPicture.Image = Resources.Vision_512;
        }

        private void _ApplyWrittenTestTheme()
        {
            lblTitle.Text = "Written Test Appointment";
            pbPicture.Image = Resources.Written_Test_512;
        }

        private void _ApplyStreetTestTheme()
        {
            lblTitle.Text = "Street Test Appointment";
            pbPicture.Image = Resources.driving_test_512;
        }

        private void btnSchedule_Click(object sender, EventArgs e)
        {
            using (frmScheduleTest frm = new frmScheduleTest(_LocalApplicationID, _TestTypeID))
            {
                frm.ShowDialog();
            }
        }

        private void takeTestToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (frmTakeTest frm = new frmTakeTest(SelectedAppointmentID, _TestTypeID))
            {
                frm.ShowDialog();
            }
        }
    }
}
