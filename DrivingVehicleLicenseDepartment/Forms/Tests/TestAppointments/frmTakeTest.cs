using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DrivingVehicleLicenseDepartment.Properties;
using static BLL.TestTypes;

namespace DrivingVehicleLicenseDepartment.Forms.Tests.TestAppointments
{
    public partial class frmTakeTest : Form
    {
        private int _TestTypeID;
        private int _AppointmentID;
        public frmTakeTest(int AppointmentID, enTestType TestType)
        {
            InitializeComponent();

            _TestTypeID = (int)TestType;
            _AppointmentID = AppointmentID;


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
    }
}
