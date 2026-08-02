using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace BLL
{
    public class InternationalLicenses
    {

        enum enMode { AddNew = 0, Update = 1 };
        private enMode Mode = enMode.AddNew;

        public int InternationalLicenseID { get; set; }

        private int _ApplicationID;
        public int ApplicationID
        {
            get
            {
                return _ApplicationID;
            }

            set
            {
                if(value != ApplicationID)
                {
                    _ApplicationID = value;
                    _ApplicationInfo = null;
                }
            }
        }

        private int _DriverID;
        public int DriverID
        {
            get
            {
                return _DriverID;
            }

            set
            {
                if (value != _DriverID)
                {
                    _DriverID = value; 
                    _DriverInfo = null;
                }
            }
        }

        private int _IssuedUsingLocalLicenseID;
        public int IssuedUsingLocalLicenseID
        {
            get
            {
                return _IssuedUsingLocalLicenseID;
            }

            set
            {
                if(value != _IssuedUsingLocalLicenseID)
                {
                    _IssuedUsingLocalLicenseID = value;
                    _IssuedUsingLocalLicenseInfo = null; 
                }
            }
        }

        public DateTime IssueDate { get; set; }
        public DateTime ExpirationDate { get; set; }
        public bool IsActive { get; set; }

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

        private Applications _ApplicationInfo;
        public Applications ApplicationInfo
        {
            get
            {

                if(_ApplicationInfo == null && ApplicationID != -1)
                {
                    _ApplicationInfo = Applications.Find(ApplicationID);
                }

                return _ApplicationInfo;
            }

            set
            {
                if(value == null)
                {
                    return;
                }

                if (ApplicationID == -1)
                {
                    _ApplicationInfo = value;
                    _ApplicationID = _ApplicationInfo.ApplicationID;

                }

                else if(value.ApplicationID == ApplicationID)
                {
                    _ApplicationInfo = value;
                }
            }
        }

        private Drivers _DriverInfo;
        public Drivers DriverInfo
        {
            get
            {
                if (_DriverInfo == null && DriverID != -1)
                {
                    _DriverInfo = Drivers.Find(DriverID);
                }
                return _DriverInfo;
            }

            set
            {
                if(value == null)
                {
                    return;
                }

                if(DriverID == -1)
                {
                    _DriverInfo = value;
                    _DriverID = _DriverInfo.DriverID;
                }

                else if (value.DriverID == DriverID)
                {
                    _DriverInfo = value;
                }
            }
        }

        private LocalDrivingLicenseApplications _IssuedUsingLocalLicenseInfo;
        public LocalDrivingLicenseApplications IssuedUsingLocalLicenseInfo
        {
            get
            {
                if(_IssuedUsingLocalLicenseInfo == null && _IssuedUsingLocalLicenseID != -1)
                {
                    _IssuedUsingLocalLicenseInfo = LocalDrivingLicenseApplications.Find(IssuedUsingLocalLicenseID);
                }

                return _IssuedUsingLocalLicenseInfo;
            }

            set
            {
                if (value == null)
                {
                    return;
                }

                if(IssuedUsingLocalLicenseID == -1)
                {
                    _IssuedUsingLocalLicenseInfo = value;
                    _IssuedUsingLocalLicenseID = IssuedUsingLocalLicenseInfo.LocalDrivingLicenseApplicationID;
                }

                else if (value.LocalDrivingLicenseApplicationID == IssuedUsingLocalLicenseID)
                {
                    _IssuedUsingLocalLicenseInfo = value;
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

        private InternationalLicenses(int InternationalLicenseID, int ApplicationID, int DriverID, int IssuedUsingLocalLicenseID, DateTime IssueDate, DateTime ExpirationDate, bool IsActive, int CreatedByUserID)
        {
            this.InternationalLicenseID = InternationalLicenseID;
            this.ApplicationID = ApplicationID;
            this.DriverID = DriverID;
            this.IssuedUsingLocalLicenseID = IssuedUsingLocalLicenseID;
            this.IssueDate = IssueDate;
            this.ExpirationDate = ExpirationDate;
            this.IsActive = IsActive;
            this.CreatedByUserID = CreatedByUserID;

        }
        public InternationalLicenses()
        {
            InternationalLicenseID = -1;
            ApplicationID = -1;
            DriverID = -1;
            IssuedUsingLocalLicenseID = -1;
            IssueDate = DateTime.Now;
            ExpirationDate = DateTime.Now;
            IsActive = false;
            CreatedByUserID = -1;

            ApplicationInfo = null;
            DriverInfo = null;
            IssuedUsingLocalLicenseInfo = null;
            CreatedByUserInfo = null;

        }
        public static InternationalLicenses Find(int InternationalLicenseID)
        {

            int ApplicationID = -1;
            int DriverID = -1;
            int IssuedUsingLocalLicenseID = -1;
            DateTime IssueDate = DateTime.Now;
            DateTime ExpirationDate = DateTime.Now;
            bool IsActive = false;
            int CreatedByUserID = -1;

            if (InternationalLicensesDataAccess.FindFromInternationalLicensesByInternationalLicenseID(InternationalLicenseID, ref ApplicationID, ref DriverID, ref IssuedUsingLocalLicenseID, ref IssueDate, ref ExpirationDate, ref IsActive, ref CreatedByUserID))
                return new InternationalLicenses(InternationalLicenseID, ApplicationID, DriverID, IssuedUsingLocalLicenseID, IssueDate, ExpirationDate, IsActive, CreatedByUserID);
            else
                return null;

        }

        public static InternationalLicenses FindByDriverID(int DriverID)
        {
            int ApplicationID = -1;
            int InternationalLicenseID = -1;
            int IssuedUsingLocalLicenseID = -1;
            DateTime IssueDate = DateTime.Now;
            DateTime ExpirationDate = DateTime.Now;
            bool IsActive = false;
            int CreatedByUserID = -1;

            if (InternationalLicensesDataAccess.FindFromInternationalLicensesByDriverID(DriverID, ref InternationalLicenseID, ref ApplicationID, ref IssuedUsingLocalLicenseID, ref IssueDate, ref ExpirationDate, ref IsActive, ref CreatedByUserID))
                return new InternationalLicenses(InternationalLicenseID, ApplicationID, DriverID, IssuedUsingLocalLicenseID, IssueDate, ExpirationDate, IsActive, CreatedByUserID);
            else
                return null;
        }

        public static bool IsExists(int InternationalLicenseID)
        {

            return InternationalLicensesDataAccess.IsExistsInInternationalLicensesByInternationalLicenseID(InternationalLicenseID);

        }

        private bool _AddNewToInternationalLicenses()
        {

            return (this.InternationalLicenseID = (InternationalLicensesDataAccess.AddNewToInternationalLicenses(this.ApplicationID, this.DriverID, this.IssuedUsingLocalLicenseID, this.IssueDate, this.ExpirationDate, this.IsActive, this.CreatedByUserID))) > 0;

        }

        private bool _UpdateInternationalLicenses()
        {

            return InternationalLicensesDataAccess.UpdateFromInternationalLicenses(this.InternationalLicenseID, this.ApplicationID, this.DriverID, this.IssuedUsingLocalLicenseID, this.IssueDate, this.ExpirationDate, this.IsActive, this.CreatedByUserID);

        }

        public static bool DeleteFromInternationalLicensesByInternationalLicenseID(int InternationalLicenseID)
        {

            return InternationalLicensesDataAccess.DeleteFromInternationalLicenses(InternationalLicenseID);

        }

        public bool Save()
        {
            switch (Mode)
            {
                case enMode.AddNew:

                    if (_AddNewToInternationalLicenses())
                    {
                        Mode = enMode.Update;
                        return true;
                    }
                    else return false;

                case enMode.Update:

                    if (_UpdateInternationalLicenses())
                    {
                        return true;
                    }
                    else return false;

            }
            return false;
        }
        public static DataTable GetAllInternationalLicenses()
        {

            return InternationalLicensesDataAccess.GetAllFromInternationalLicenses();

        }

        public static int GetActiveInternationalLicenseIDByDriverID(int DriverID)
        {
            return InternationalLicensesDataAccess.GetActiveInternationalLicenseIDByDriverID(DriverID);
        }

        public static DataTable GetInternationalLicensesSummary()
        {
            return InternationalLicensesDataAccess.GetInternationalLicensesSummary();
        }


        public static DataTable GetDriverInternationalLicensesSummary(int PersonID)
        {
            return InternationalLicensesDataAccess.GetDriverInternationalLicensesSummary(PersonID);
        }

    }
}
