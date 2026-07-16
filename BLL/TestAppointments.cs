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
        public object AppointmentDate { get; set; }
        public decimal PaidFees { get; set; }
        public int CreatedByUserID { get; set; }
        public bool IsLocked { get; set; }
        public int RetakeTestApplicationID { get; set; }
        public TestTypes TestTypsInfo { get; set; }


        private TestAppointments(int TestAppointmentID, int TestTypeID, int LocalDrivingLicenseApplicationID, object AppointmentDate, decimal PaidFees, int CreatedByUserID, bool IsLocked, int RetakeTestApplicationID)
        {
            this.TestAppointmentID = TestAppointmentID;
            this.TestTypeID = TestTypeID;
            this.LocalDrivingLicenseApplicationID = LocalDrivingLicenseApplicationID;
            this.AppointmentDate = AppointmentDate;
            this.PaidFees = PaidFees;
            this.CreatedByUserID = CreatedByUserID;
            this.IsLocked = IsLocked;
            this.RetakeTestApplicationID = RetakeTestApplicationID;

            TestTypsInfo = TestTypes.Find(TestTypeID);

            Mode = enMode.Update;
        }
        public TestAppointments()
        {
            TestAppointmentID = -1;
            TestTypeID = -1;
            LocalDrivingLicenseApplicationID = -1;
            AppointmentDate = null;
            PaidFees = -1;
            CreatedByUserID = -1;
            IsLocked = false;
            RetakeTestApplicationID = -1;


        }
        public static TestAppointments Find(int TestAppointmentID)
        {

            int TestTypeID = -1;
            int LocalDrivingLicenseApplicationID = -1;
            object AppointmentDate = null;
            decimal PaidFees = -1;
            int CreatedByUserID = -1;
            bool IsLocked = false;
            int RetakeTestApplicationID = -1;

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

            return (this.TestAppointmentID = (TestAppointmentsDataAccess.AddNewToTestAppointments(this.TestTypeID, this.LocalDrivingLicenseApplicationID, this.AppointmentDate, this.PaidFees, this.CreatedByUserID, this.IsLocked, this.RetakeTestApplicationID))) > 0;

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
                        Mode = enMode.Update;
                        return true;
                    }
                    else return false;

                case enMode.Update:

                    if (_UpdateTestAppointments())
                    {
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


    }
}
