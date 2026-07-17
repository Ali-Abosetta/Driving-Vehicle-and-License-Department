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
        private int _TestTypeID;
        private int _LocalApplicationID;
        public frmScheduleTest(int LocalApplicationID, enTestType TestType)
        {
            InitializeComponent();

            _TestTypeID = (int)TestType;
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
    }
}
