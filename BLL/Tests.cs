using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace BLL
{
    public class Tests
    {

        enum enMode { AddNew = 0, Update = 1 };
        private enMode Mode = enMode.AddNew;

        public int TestID { get; set; }

        private int _TestAppointmentID;
        public int TestAppointmentID
        {
            get
            {
                return _TestAppointmentID;
            }

            set
            {
                if(value !=  _TestAppointmentID)
                {
                    _TestAppointmentID = value;
                    _TestAppointmentInfo = null;
                }
            }
        }


        public bool TestResult { get; set; }
        public string Notes { get; set; }

        private int _CreatedByUserID;
        public int CreatedByUserID
        {
            get
            {
                return _CreatedByUserID;
            }
            set
            {
                if (_CreatedByUserID != value)
                {
                    _CreatedByUserID = value;
                    _CreatedByUserInfo = null;
                }
            }
        }

        private TestAppointments _TestAppointmentInfo;
        public TestAppointments TestAppointmentInfo
        {
            get
            {
                if (_TestAppointmentInfo == null && TestAppointmentID != -1)
                {
                    _TestAppointmentInfo = TestAppointments.Find(TestAppointmentID);
                }
                return _TestAppointmentInfo;
            }

            set
            {
                if (value == null)
                {
                    return;
                }

                if (TestAppointmentID == -1)
                {
                    _TestAppointmentInfo = value;
                    _TestAppointmentID = _TestAppointmentInfo.TestAppointmentID;
                }

                else if (_TestAppointmentID == value.TestAppointmentID)
                {
                    _TestAppointmentInfo = value;
                }
            }
        }

        private Users _CreatedByUserInfo;
        public Users CreatedByUserInfo
        {
            get
            {

                if (_CreatedByUserInfo == null && CreatedByUserID != -1)
                {
                    _CreatedByUserInfo = Users.Find(CreatedByUserID);
                }

                return _CreatedByUserInfo;
            }
            set
            {
                if (value == null)
                    return;

                if (CreatedByUserID == -1)
                {
                    _CreatedByUserInfo = value;
                    _CreatedByUserID = _CreatedByUserInfo.UserID;
                    return;
                }

                else if (value.UserID == _CreatedByUserID)
                {
                    _CreatedByUserInfo = value;
                }
            }
        }

        private Tests(int TestID, int TestAppointmentID, bool TestResult, string Notes, int CreatedByUserID)
        {
            this.TestID = TestID;
            this.TestAppointmentID = TestAppointmentID;
            this.TestResult = TestResult;
            this.Notes = Notes;
            this.CreatedByUserID = CreatedByUserID;

        }
        public Tests()
        {
            TestID = -1;
            TestAppointmentID = -1;
            TestResult = false;
            Notes = null;
            CreatedByUserID = -1;

            TestAppointmentInfo = null;
            CreatedByUserInfo = null;
        }
        public static Tests Find(int TestID)
        {

            int TestAppointmentID = -1;
            bool TestResult = false;
            string Notes = null;
            int CreatedByUserID = -1;

            if (TestsDataAccess.FindFromTestsByTestID(TestID, ref TestAppointmentID, ref TestResult, ref Notes, ref CreatedByUserID))
                return new Tests(TestID, TestAppointmentID, TestResult, Notes, CreatedByUserID);
            else
                return null;

        }

        public static bool IsExists(int TestID)
        {

            return TestsDataAccess.IsExistsInTestsByTestID(TestID);

        }

        private bool _AddNewToTests()
        {

            return (this.TestID = (TestsDataAccess.AddNewToTests(this.TestAppointmentID, this.TestResult, this.Notes, this.CreatedByUserID))) > 0;

        }

        private bool _UpdateTests()
        {

            return TestsDataAccess.UpdateFromTests(this.TestID, this.TestAppointmentID, this.TestResult, this.Notes, this.CreatedByUserID);

        }

        public static bool DeleteFromTestsByTestID(int TestID)
        {

            return TestsDataAccess.DeleteFromTests(TestID);

        }

        public bool Save()
        {
            switch (Mode)
            {
                case enMode.AddNew:

                    if (_AddNewToTests())
                    {
                        Mode = enMode.Update;
                        return true;
                    }
                    else return false;

                case enMode.Update:

                    if (_UpdateTests())
                    {
                        return true;
                    }
                    else return false;

            }
            return false;
        }
        public static DataTable GetAllTests()
        {

            return TestsDataAccess.GetAllFromTests();

        }


    }
}
