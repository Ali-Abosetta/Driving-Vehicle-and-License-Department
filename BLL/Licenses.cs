using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace BLL
{
    public class Licenses
    {

        enum enMode { AddNew = 0, Update = 1 };
        private enMode Mode = enMode.AddNew;

        public enum enIssueReason
        {
            FirstTime = 1,
            LostReplacement = 2,
            DamagedReplacement = 3,
            Renewal = 4
        }

        public int LicenseID { get; set; }

        private int _ApplicationID;
        public int ApplicationID
        {
            get
            {
                return _ApplicationID;
            }

            set
            {
                if (value != ApplicationID)
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

        private int _LicenseClass;
        public int LicenseClass
        {
            get
            {
                return _LicenseClass;
            }

            set
            {
                if(value != _LicenseClass)
                {
                    _LicenseClass = value;
                    _LicenseClassInfo = null;
                }
            }
        }

        public DateTime IssueDate { get; set; }
        public DateTime ExpirationDate { get; set; }
        public string Notes { get; set; }
        public decimal PaidFees { get; set; }
        public bool IsActive { get; set; }
        public int IssueReason { get; set; }

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

                if (_ApplicationInfo == null && ApplicationID != -1)
                {
                    _ApplicationInfo = Applications.Find(ApplicationID);
                }

                return _ApplicationInfo;
            }

            set
            {
                if (value == null)
                {
                    return;
                }

                if (ApplicationID == -1)
                {
                    _ApplicationInfo = value;
                    _ApplicationID = _ApplicationInfo.ApplicationID;

                }

                else if (value.ApplicationID == ApplicationID)
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
                if (value == null)
                {
                    return;
                }

                if (_DriverID == -1)
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

        private LicenseClasses _LicenseClassInfo;
        public LicenseClasses LicenseClassInfo
        {
            get
            {
                if(_LicenseClassInfo == null && LicenseClass != -1)
                {
                    _LicenseClassInfo = LicenseClasses.Find(LicenseClass);
                }
                return _LicenseClassInfo;
            }

            set
            {
                if(value == null)
                {
                    return;
                }

                if(LicenseClass == -1)
                {
                    _LicenseClassInfo = value;
                    _LicenseClass = LicenseClassInfo.LicenseClassID;
                }

                else if (value.LicenseClassID == LicenseClass)
                {
                    _LicenseClassInfo = value;
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

        private Licenses(int LicenseID, int ApplicationID, int DriverID, int LicenseClass, DateTime IssueDate, DateTime ExpirationDate, string Notes, decimal PaidFees, bool IsActive, int IssueReason, int CreatedByUserID)
        {
            this.LicenseID = LicenseID;
            this.ApplicationID = ApplicationID;
            this.DriverID = DriverID;
            this.LicenseClass = LicenseClass;
            this.IssueDate = IssueDate;
            this.ExpirationDate = ExpirationDate;
            this.Notes = Notes;
            this.PaidFees = PaidFees;
            this.IsActive = IsActive;
            this.IssueReason = IssueReason;
            this.CreatedByUserID = CreatedByUserID;

            Mode = enMode.Update;
        }
        public Licenses()
        {
            LicenseID = -1;
            ApplicationID = -1;
            DriverID = -1;
            LicenseClass = -1;
            IssueDate = DateTime.Now;
            ExpirationDate = DateTime.Now;
            Notes = string.Empty;
            PaidFees = -1;
            IsActive = false;
            IssueReason = -1;
            CreatedByUserID = -1;

            ApplicationInfo = null;
            DriverInfo = null;
            LicenseClassInfo = null;
            CreatedByUserInfo = null;

        }
        public static Licenses Find(int LicenseID)
        {

            int ApplicationID = -1;
            int DriverID = -1;
            int LicenseClass = -1;
            DateTime IssueDate = DateTime.Now;
            DateTime ExpirationDate = DateTime.Now;
            string Notes = string.Empty;
            decimal PaidFees = -1;
            bool IsActive = false;
            int IssueReason = -1;
            int CreatedByUserID = -1;

            if (LicensesDataAccess.FindFromLicensesByLicenseID(LicenseID, ref ApplicationID, ref DriverID, ref LicenseClass, ref IssueDate, ref ExpirationDate, ref Notes, ref PaidFees, ref IsActive, ref IssueReason, ref CreatedByUserID))
                return new Licenses(LicenseID, ApplicationID, DriverID, LicenseClass, IssueDate, ExpirationDate, Notes, PaidFees, IsActive, IssueReason, CreatedByUserID);
            else
                return null;

        }

        public static Licenses FindByLocalAppID(int LocalAppID)
        {
            int LicenseID = -1;
            int ApplicationID = -1;
            int DriverID = -1;
            int LicenseClass = -1;
            DateTime IssueDate = DateTime.Now;
            DateTime ExpirationDate = DateTime.Now;
            string Notes = string.Empty;
            decimal PaidFees = -1;
            bool IsActive = false;
            int IssueReason = -1;
            int CreatedByUserID = -1;

            if (LicensesDataAccess.FindFromLicensesByLocalAppID(LocalAppID, ref LicenseID, ref ApplicationID, ref DriverID, ref LicenseClass, ref IssueDate, ref ExpirationDate, ref Notes, ref PaidFees, ref IsActive, ref IssueReason, ref CreatedByUserID))
                return new Licenses(LicenseID, ApplicationID, DriverID, LicenseClass, IssueDate, ExpirationDate, Notes, PaidFees, IsActive, IssueReason, CreatedByUserID);
            else
                return null;
        }

        public static bool IsExists(int LicenseID)
        {

            return LicensesDataAccess.IsExistsInLicensesByLicenseID(LicenseID);

        }

        private bool _AddNewToLicenses()
        {

            return (this.LicenseID = (LicensesDataAccess.AddNewToLicenses(this.ApplicationID, this.DriverID, this.LicenseClass, this.IssueDate, this.ExpirationDate, this.Notes, this.PaidFees, this.IsActive, this.IssueReason, this.CreatedByUserID))) > 0;

        }

        private bool _UpdateLicenses()
        {

            return LicensesDataAccess.UpdateFromLicenses(this.LicenseID, this.ApplicationID, this.DriverID, this.LicenseClass, this.IssueDate, this.ExpirationDate, this.Notes, this.PaidFees, this.IsActive, this.IssueReason, this.CreatedByUserID);

        }

        public static bool DeleteFromLicensesByLicenseID(int LicenseID)
        {

            return LicensesDataAccess.DeleteFromLicenses(LicenseID);

        }

        public bool Save()
        {
            switch (Mode)
            {
                case enMode.AddNew:

                    if (_AddNewToLicenses())
                    {
                        Mode = enMode.Update;
                        return true;
                    }
                    else return false;

                case enMode.Update:

                    if (_UpdateLicenses())
                    {
                        return true;
                    }
                    else return false;

            }
            return false;
        }
        public static DataTable GetAllLicenses()
        {
            return LicensesDataAccess.GetAllFromLicenses();
        }

        public static DataTable GetDriverLocalLicensesSummary(int PersonID)
        {
            return LicensesDataAccess.GetDriverLocalLicensesSummary(PersonID);
        }


    }
}
