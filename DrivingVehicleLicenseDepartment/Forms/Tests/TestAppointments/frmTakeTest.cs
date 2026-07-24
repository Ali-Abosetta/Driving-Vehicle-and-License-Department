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
using DrivingVehicleLicenseDepartment.Properties;
using Krypton.Toolkit;
using static BLL.TestTypes;

namespace DrivingVehicleLicenseDepartment.Forms.Tests.TestAppointments
{
    public partial class frmTakeTest : Form
    {

        public delegate void DataBackEventHandler(object sender, BLL.TestAppointments testAppointment);
        public event DataBackEventHandler DataBack;

        private int _TestTypeID;
        private int _AppointmentID;
        private BLL.TestAppointments _testAppointment;
        private bool _isRetake;
        private Users _CurrentUser;
        public frmTakeTest(Users user, int testAppointmentID, enTestType TestType)
        {
            InitializeComponent();

            BLL.TestAppointments testAppointment = BLL.TestAppointments.Find(testAppointmentID);

            _TestTypeID = (int)TestType;
            _AppointmentID = testAppointment.TestAppointmentID;
            _testAppointment = testAppointment;
            _CurrentUser = user;

            if (_testAppointment != null)
            {
                int Trials = BLL.TestAppointments
                    .GetTestTrials(_testAppointment.LocalApplicationInfo.LocalDrivingLicenseApplicationID,
                    _TestTypeID);

                _isRetake = Trials > 0 ? true : false;

                lblDLAppID.Text = _testAppointment.LocalApplicationInfo.ApplicationID.ToString();
                lblDClass.Text = _testAppointment.LocalApplicationInfo.LicenseClassInfo.ClassName;
                lblName.Text = _testAppointment.LocalApplicationInfo.ApplicationInfo.ApplicantPersonInfo.FullName;
                lblTrial.Text = Trials.ToString();
                lblDate.Text = _testAppointment.AppointmentDate.ToString("dd/MM/yyyy");
                lblFees.Text = _testAppointment.PaidFees.ToString();
            }


            _ApplyThemes(TestType);
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
            lblTitle.Text = "Take Vision Test";
            pbPicture.Image = Resources.Vision_512;
        }

        private void _ApplyWrittenTestTheme()
        {
            lblTitle.Text = "Take Written Test";
            pbPicture.Image = Resources.Written_Test_512;
        }

        private void _ApplyStreetTestTheme()
        {
            lblTitle.Text = "Take Street Test";
            pbPicture.Image = Resources.driving_test_512;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            BLL.Tests test = new BLL.Tests();

            test.TestAppointmentID = _testAppointment.TestAppointmentID;
            test.TestResult = rbPass.Checked ? true : false;
            test.Notes = rtbNotes.Text;
            test.CreatedByUserID = _CurrentUser.UserID;

            if (test.Save()) 
            {
                test.TestAppointmentInfo.IsLocked = true;
                if (test.TestAppointmentInfo.Save())
                {
                    KryptonMessageBox.Show("Test has been taken Successfully.",
                    "Saved Successfully", KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Information, false);

                    DataBack?.Invoke(this, test.TestAppointmentInfo);

                    this.Close();
                }

                else
                {
                    KryptonMessageBox.Show("Error: Data Is not Saved Successfully.",
                        "Error", KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Error, false);
                }
            }
        }

        private void frmTakeTest_Load(object sender, EventArgs e)
        {
            btnSave.Enabled = false;
        }

        private void rbPassRbFail_CheckedChanged(object sender, EventArgs e)
        {
            btnSave.Enabled = true;
        }
    }
}
