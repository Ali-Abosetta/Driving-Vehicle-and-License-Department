using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.InteropServices;
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

        private int _TestTypeID;
        public int TestTypeID
        {
            get
            {
                return _TestTypeID;
            }

            set
            {
                if (value != _TestTypeID)
                {
                    _TestTypeID = value;
                    _TestTypesInfo = null;
                }
            }
        }

        private int _LocalDrivingLicenseApplicationID;
        public int LocalDrivingLicenseApplicationID
        {
            get
            {
                return _LocalDrivingLicenseApplicationID;
            }

            set
            {
                if (value !=  _LocalDrivingLicenseApplicationID)
                {
                    _LocalDrivingLicenseApplicationID = value;
                    _LocalApplicationInfo = null;
                }
            }
        }

        public DateTime AppointmentDate { get; set; }
        public decimal PaidFees { get; set; }

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

        public bool IsLocked { get; set; }
        public int? RetakeTestApplicationID { get; set; }

        private TestTypes _TestTypesInfo;
        public TestTypes TestTypesInfo
        {
            get
            {
                if (_TestTypesInfo == null && TestTypeID != -1)
                {
                    _TestTypesInfo = TestTypes.Find(TestTypeID);
                }
                return _TestTypesInfo;
            }

            set
            {

                if(value == null)
                {
                    return;
                }

                if(TestTypeID == -1)
                {
                    _TestTypesInfo = value;
                    _TestTypeID = _TestTypesInfo.TestTypeID;
                }

                else if (value.TestTypeID == TestTypeID)
                {
                    _TestTypesInfo = value;
                }

            }
        }


        private LocalDrivingLicenseApplications _LocalApplicationInfo;
        public LocalDrivingLicenseApplications LocalApplicationInfo
        {
            get
            {
                if (_LocalApplicationInfo == null && LocalDrivingLicenseApplicationID != -1)
                {
                    _LocalApplicationInfo = LocalDrivingLicenseApplications.Find(LocalDrivingLicenseApplicationID);
                }

                return _LocalApplicationInfo;
            }

            set
            {
                if (value == null)
                {
                    return;
                }

                if (LocalDrivingLicenseApplicationID == -1)
                {
                    _LocalApplicationInfo = value;
                    _LocalDrivingLicenseApplicationID = LocalApplicationInfo.LocalDrivingLicenseApplicationID;
                }

                else if (value.LocalDrivingLicenseApplicationID == LocalDrivingLicenseApplicationID)
                {
                    _LocalApplicationInfo = value;
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

                else if (value.UserID == CreatedByUserID)
                {
                    _CreatedByUserInfo = value;
                }
            }
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
