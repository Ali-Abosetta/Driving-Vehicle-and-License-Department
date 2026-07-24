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
    public partial class frmScheduleTest : KryptonForm
    {

        public delegate void DataBackEvenHandler(object sender, BLL.TestAppointments testAppointment);
        public event DataBackEvenHandler DataBack;

        private Users _CurrentUser = new Users();
        private int _TestTypeID;
        private int _LocalApplicationID;
        private LocalDrivingLicenseApplications _LocalApp = new LocalDrivingLicenseApplications();
        private int _TestAppointmentID;
        private decimal _Fees;
        private ApplicationsTypes _RetakeAppInfo;
        private bool _isRetake;

        public frmScheduleTest(Users user, int LocalApplicationID, enTestType TestType) //To add new appointmetn
        {
            InitializeComponent();

            _TestTypeID = (int)TestType;
            _LocalApplicationID = LocalApplicationID;
            _CurrentUser = user;

            _LocalApp = LocalDrivingLicenseApplications.Find(LocalApplicationID);

            TestTypes testTypeInfo = TestTypes.Find((int)TestType);
            _Fees = testTypeInfo.TestTypeFees;

            BLL.ApplicationsTypes retakeAppInfo = BLL.ApplicationsTypes.Find((int)BLL.ApplicationsTypes.enApplicationType.RetakeTest);
            _RetakeAppInfo = retakeAppInfo;


            int Trials = BLL.TestAppointments
                .GetTestTrials(LocalApplicationID, _TestTypeID);
            _ApplyRetakeProcedures(Trials);

            lblDLAppID.Text = _LocalApp.LocalDrivingLicenseApplicationID.ToString();
            lblDClass.Text = _LocalApp.LicenseClassInfo.ClassName;
            lblName.Text = _LocalApp.ApplicationInfo.ApplicantPersonInfo.FullName;

            lblTrial.Text = Trials.ToString();
            lblFees.Text = _Fees.ToString();
            dtpDate.Value = DateTime.Now;

            _ApplyThemes(TestType);
        }
        public frmScheduleTest(Users User, BLL.TestAppointments testAppointments, enTestType TestType) //To edit
        {
            InitializeComponent();

            _TestTypeID = (int)TestType;
            _LocalApplicationID = testAppointments.LocalApplicationInfo.LocalDrivingLicenseApplicationID;

            if (testAppointments != null)
            {
                _Fees = testAppointments.TestTypesInfo.TestTypeFees;

                int Trials = BLL.TestAppointments
                    .GetTestTrials(testAppointments.LocalApplicationInfo.LocalDrivingLicenseApplicationID,
                    _TestTypeID);

                _ApplyRetakeProcedures(Trials);

                lblDLAppID.Text = testAppointments.LocalApplicationInfo.LocalDrivingLicenseApplicationID.ToString();
                lblDClass.Text = testAppointments.LocalApplicationInfo.LicenseClassInfo.ClassName;
                lblName.Text = testAppointments.LocalApplicationInfo.ApplicationInfo.ApplicantPersonInfo.FullName.ToString();

                lblTrial.Text = Trials.ToString();

                dtpDate.Value = testAppointments.AppointmentDate;
                lblFees.Text = _Fees.ToString();

                _CurrentUser = User;
            }

            _ApplyThemes(TestType);
        }

        private void _ApplyRetakeProcedures(int Trials)
        {
            if (Trials > 0)
            {
                _isRetake = true;
                gbRetakeTest.Enabled = true;
                gbRetakeTest.Visible = true;
                lblRetakeFees.Text = _RetakeAppInfo.ApplicationFees.ToString();
                lblTotalFees.Text = (_Fees + _RetakeAppInfo.ApplicationFees).ToString();
            }
            else
            {

                _isRetake = false;
                gbRetakeTest.Visible = false;
                gbRetakeTest.Enabled = false;

            }
        }

        private void _ApplyThemes(enTestType TestType)
        {
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
            lblTitle.Text = "Schedule Vision Test";
            pbPicture.Image = Resources.Vision_512;
        }

        private void _ApplyWrittenTestTheme()
        {
            lblTitle.Text = "Schedule Written Test";
            pbPicture.Image = Resources.Written_Test_512;
        }

        private void _ApplyStreetTestTheme()
        {
            lblTitle.Text = "Schedule Street Test";
            pbPicture.Image = Resources.driving_test_512;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            BLL.TestAppointments testAppointment = new BLL.TestAppointments();

            testAppointment.TestTypeID = _TestTypeID;
            testAppointment.LocalDrivingLicenseApplicationID = _LocalApplicationID;
            testAppointment.AppointmentDate = dtpDate.Value;
            testAppointment.PaidFees = _Fees;
            testAppointment.CreatedByUserID = _CurrentUser.UserID;
            testAppointment.IsLocked = false;

            if (_isRetake)
            {
                Applications retakeApp = new Applications();

                retakeApp.ApplicantPersonID = _LocalApp.ApplicationInfo.ApplicantPersonID;
                retakeApp.ApplicationDate = DateTime.Now;
                retakeApp.ApplicationTypeID = (int)BLL.ApplicationsTypes.enApplicationType.RetakeTest; 
                retakeApp.ApplicationStatus = (int)Applications.enStatus.New;
                retakeApp.LastStatusDate = DateTime.Now;
                retakeApp.PaidFees = _RetakeAppInfo.ApplicationFees; 
                retakeApp.CreatedByUserID = _CurrentUser.UserID;

                if (retakeApp.Save())
                {
                    testAppointment.RetakeTestApplicationID = retakeApp.ApplicationID;
                }
            }
            else
            {
                testAppointment.RetakeTestApplicationID = null; 
            }

            if (testAppointment.Save())
            {
                KryptonMessageBox.Show("Appointment scheduled Successfully.",
                "Success schedule", KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Information, false);

                DataBack?.Invoke(this, testAppointment);

                this.Close();
            }
            else
            {
                KryptonMessageBox.Show("Error: Appointment was not schedule Successfully.",
                    "Error", KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Error, false);
            }
        }


    }
}
