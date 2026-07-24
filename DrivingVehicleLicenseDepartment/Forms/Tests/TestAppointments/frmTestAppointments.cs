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
        private Users _CurrentUser = new Users();
        private enTestType _TestTypeID;
        private int _LocalApplicationID;
        private LocalDrivingLicenseApplications _LocalApp = new LocalDrivingLicenseApplications();
        private DataTable _AppointmentsTable = new DataTable();
        private bool _HasActiveAppointment = false;

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

        public frmTestAppointments(Users User, int LocalApplicationID, enTestType TestType)
        {
            InitializeComponent();

            _LocalApp = LocalDrivingLicenseApplications.Find(LocalApplicationID);
            ctrlDrivingLicenseApplicationInfo1.LocalApp = _LocalApp;

            ctrlApplicationBasicInfo1.application = _LocalApp.ApplicationInfo;

            _TestTypeID = TestType;
            _LocalApplicationID = LocalApplicationID;

            _AppointmentsTable = BLL.TestAppointments
                .GetTestAppointmentsSummary(_LocalApp.ApplicationInfo.ApplicantPersonID,
                (int)_TestTypeID, _LocalApp.LicenseClassID);

            dgvAppointments.DataSource = _AppointmentsTable;
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

            _HasActiveAppointment = BLL.TestAppointments.HasActiveAppointment
                (_LocalApp.ApplicationInfo.ApplicantPersonID, (int)_TestTypeID,
                _LocalApp.LicenseClassID);
            _CurrentUser = User;

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

        private void ScheduleTest(object sender, EventArgs e)
        {
            if (!_HasActiveAppointment)
            {
                using (frmScheduleTest frm = new frmScheduleTest(_CurrentUser, _LocalApplicationID, _TestTypeID))
                {
                    frm.DataBack += frmScheduleTest_DataBack;
                    frm.ShowDialog();

                }
            }
            else
            {
                KryptonMessageBox.Show("This person already has an active appointment for this test.",
                    "Warning", KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Warning, false);
            }

        }

        private void EditScheduledTest(object sender, EventArgs e)
        {

            BLL.TestAppointments testAppointment = null;
            testAppointment = BLL.TestAppointments.Find(SelectedAppointmentID);

            if (testAppointment != null)
            {
                using (frmScheduleTest frm = new frmScheduleTest(_CurrentUser, testAppointment, _TestTypeID))
                {
                    frm.DataBack += frmScheduleTest_DataBack;
                    frm.ShowDialog();
                }
            }
        }

        private void frmScheduleTest_DataBack(object sender, BLL.TestAppointments testAppointment)
        {
            DataRow row = _AppointmentsTable.NewRow();

            row["Appointment ID"] = testAppointment.TestAppointmentID;
            row["Appointment date"] = testAppointment.AppointmentDate.ToString("dd/MM/yyyy");
            row["Paid Fees"] = testAppointment.PaidFees;
            row["Is Looked"] = testAppointment.IsLocked;
            
            _AppointmentsTable.Rows.Add(row);
        }

        private void takeTestToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (frmTakeTest frm = new frmTakeTest(_CurrentUser, SelectedAppointmentID, _TestTypeID))
            {
                frm.DataBack += frmTakeTest_DataBack;
                frm.ShowDialog();
            }
        }
        private void frmTakeTest_DataBack(object sender, BLL.TestAppointments testAppointment)
        {
            DataRow rowToEdit = _AppointmentsTable.Rows.Find(SelectedAppointmentID);

            if (rowToEdit != null)
            {
                rowToEdit["Appointment ID"] = testAppointment.TestAppointmentID;
                rowToEdit["Appointment date"] = testAppointment.AppointmentDate.ToString("dd/MM/yyyy");
                rowToEdit["Paid Fees"] = testAppointment.PaidFees;
                rowToEdit["Is Looked"] = testAppointment.IsLocked;
            }
        }

    }
}
