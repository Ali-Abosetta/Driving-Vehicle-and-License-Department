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
        public int TestAppointmentID { get; set; }
        public bool TestResult { get; set; }
        public string Notes { get; set; }
        public int CreatedByUserID { get; set; }
        public TestAppointments TestAppointmentInfo { get; set; }
        public Users CreatedByUserInfo { get; set; }

        private void _LoadCompositions()
        {
            this.TestAppointmentInfo = TestAppointments.Find(this.TestAppointmentID);
            this.CreatedByUserInfo = Users.Find(this.CreatedByUserID);
        }

        private Tests(int TestID, int TestAppointmentID, bool TestResult, string Notes, int CreatedByUserID)
        {
            this.TestID = TestID;
            this.TestAppointmentID = TestAppointmentID;
            this.TestResult = TestResult;
            this.Notes = Notes;
            this.CreatedByUserID = CreatedByUserID;

            _LoadCompositions();

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
                        _LoadCompositions();
                        Mode = enMode.Update;
                        return true;
                    }
                    else return false;

                case enMode.Update:

                    if (_UpdateTests())
                    {
                        _LoadCompositions();
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
