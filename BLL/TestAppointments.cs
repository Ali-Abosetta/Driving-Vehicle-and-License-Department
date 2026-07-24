using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace BLL
{
    public class TestAppointments
    {

        enum enMode { AddNew = 0, Update = 1 };
        private enMode Mode = enMode.AddNew;

        public int TestAppointmentID { get; set; }
        public int TestTypeID { get; set; }
        public int LocalDrivingLicenseApplicationID { get; set; }
        public DateTime AppointmentDate { get; set; }
        public decimal PaidFees { get; set; }
        public int CreatedByUserID { get; set; }
        public bool IsLocked { get; set; }
        public int? RetakeTestApplicationID { get; set; }
        public TestTypes TestTypesInfo { get; set; }
        public LocalDrivingLicenseApplications LocalApplicationInfo { get; set; }
        public Users CreatedByUserInfo { get; set; }

        private void _LoadCompositions()
        {
            this.TestTypesInfo = TestTypes.Find(this.TestTypeID);
            this.LocalApplicationInfo = LocalDrivingLicenseApplications.Find(this.LocalDrivingLicenseApplicationID);
            this.CreatedByUserInfo = Users.Find(this.CreatedByUserID);
        }

        private TestAppointments(int TestAppointmentID, int TestTypeID, int LocalDrivingLicenseApplicationID, DateTime AppointmentDate, decimal PaidFees, int CreatedByUserID, bool IsLocked, int? RetakeTestApplicationID)
        {
            this.TestAppointmentID = TestAppointmentID;
            this.TestTypeID = TestTypeID;
            this.LocalDrivingLicenseApplicationID = LocalDrivingLicenseApplicationID;
            this.AppointmentDate = AppointmentDate;
            this.PaidFees = PaidFees;
            this.CreatedByUserID = CreatedByUserID;
            this.IsLocked = IsLocked;
            this.RetakeTestApplicationID = RetakeTestApplicationID;

            _LoadCompositions();

            Mode = enMode.Update;
        }
        public TestAppointments()
        {
            TestAppointmentID = -1;
            TestTypeID = -1;
            LocalDrivingLicenseApplicationID = -1;
            AppointmentDate = DateTime.Now;
            PaidFees = -1;
            CreatedByUserID = -1;
            IsLocked = false;
            RetakeTestApplicationID = null;


            TestTypesInfo = null;
            LocalApplicationInfo = null;
            CreatedByUserInfo = null;
        }
        public static TestAppointments Find(int TestAppointmentID)
        {

            int TestTypeID = -1;
            int LocalDrivingLicenseApplicationID = -1;
            DateTime AppointmentDate = DateTime.Now;
            decimal PaidFees = -1;
            int CreatedByUserID = -1;
            bool IsLocked = false;
            int? RetakeTestApplicationID = null;

            if (TestAppointmentsDataAccess.FindFromTestAppointmentsByTestAppointmentID(TestAppointmentID, ref TestTypeID, ref LocalDrivingLicenseApplicationID, ref AppointmentDate, ref PaidFees, ref CreatedByUserID, ref IsLocked, ref RetakeTestApplicationID))
                return new TestAppointments(TestAppointmentID, TestTypeID, LocalDrivingLicenseApplicationID, AppointmentDate, PaidFees, CreatedByUserID, IsLocked, RetakeTestApplicationID);
            else
                return null;

        }

        public static bool IsExists(int TestAppointmentID)
        {

            return TestAppointmentsDataAccess.IsExistsInTestAppointmentsByTestAppointmentID(TestAppointmentID);

        }

        private bool _AddNewToTestAppointments()
        {

            return (this.TestAppointmentID = TestAppointmentsDataAccess.AddNewToTestAppointments(this.TestTypeID, this.LocalDrivingLicenseApplicationID, this.AppointmentDate, this.PaidFees, this.CreatedByUserID, this.IsLocked, this.RetakeTestApplicationID)) > 0;

        }

        private bool _UpdateTestAppointments()
        {

            return TestAppointmentsDataAccess.UpdateFromTestAppointments(this.TestAppointmentID, this.TestTypeID, this.LocalDrivingLicenseApplicationID, this.AppointmentDate, this.PaidFees, this.CreatedByUserID, this.IsLocked, this.RetakeTestApplicationID);

        }

        public static bool DeleteFromTestAppointmentsByTestAppointmentID(int TestAppointmentID)
        {

            return TestAppointmentsDataAccess.DeleteFromTestAppointments(TestAppointmentID);

        }

        public bool Save()
        {
            switch (Mode)
            {
                case enMode.AddNew:

                    if (_AddNewToTestAppointments())
                    {
                        _LoadCompositions();
                        Mode = enMode.Update;
                        return true;
                    }
                    else return false;

                case enMode.Update:

                    if (_UpdateTestAppointments())
                    {
                        _LoadCompositions();
                        return true;
                    }
                    else return false;

            }
            return false;
        }
        public static DataTable GetAllTestAppointments()
        {

            return TestAppointmentsDataAccess.GetAllFromTestAppointments();

        }

        public static DataTable GetTestAppointmentsSummary(int ApplicantID, int TestTypeID, int LicenseClassID)
        {
            return TestAppointmentsDataAccess.GetTestAppointmentSummary(ApplicantID, TestTypeID, LicenseClassID);
        }

        public static int GetTestTrials(int LocalDrivingLicenseApplicationID, int TestTypeID)
        {
            return TestAppointmentsDataAccess.GetTestTrials(LocalDrivingLicenseApplicationID, TestTypeID);
        }

        public int GetTestTrials()
        {
            return TestAppointmentsDataAccess.GetTestTrials(this.LocalDrivingLicenseApplicationID, this.TestTypeID);
        }

        public static bool HasActiveAppointment(int PersonID, int TestTypeID, int LicenseClassID)
        {
            return TestAppointmentsDataAccess.HasActiveAppointment(PersonID, TestTypeID, LicenseClassID);
        }

    }
}
