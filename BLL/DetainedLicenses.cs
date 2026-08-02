using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace BLL
{
    public class DetainedLicenses
    {

        enum enMode { AddNew = 0, Update = 1 };
        private enMode Mode = enMode.AddNew;

        public int DetainID { get; set; }

        private int _LicenseID;
        public int LicenseID
        {
            get
            {
                return _LicenseID;
            }
            set
            {
                if (_LicenseID != value)
                {
                    _LicenseID = value;
                    _LicenseInfo = null;
                }
            }
        }

        public DateTime DetainDate { get; set; }
        public decimal FineFees { get; set; }

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

        public bool IsReleased { get; set; }
        public DateTime? ReleaseDate { get; set; }

        private int? _ReleasedByUserID;
        public int? ReleasedByUserID
        {
            get
            {
                return _ReleasedByUserID;
            }
            set
            {
                if(_ReleasedByUserID != value)
                {
                    _ReleasedByUserID = value;
                    _ReleasedByUserInfo = null;
                }
            }
        }

        private int? _ReleaseApplicationID;
        public int? ReleaseApplicationID
        {
            get
            {
                return _ReleaseApplicationID;
            }

            set
            {
                if(value != _ReleaseApplicationID)
                {
                    _ReleaseApplicationID = value;
                    _ReleaseApplicationInfo = null;
                }
            }
        }


        private Licenses _LicenseInfo;
        public Licenses LicenseInfo
        {
            get
            {
                if (_LicenseInfo == null && LicenseID != -1)
                {
                    _LicenseInfo = Licenses.Find(LicenseID);
                }

                return _LicenseInfo;
            }
            set
            {
                if(value == null)
                {
                    return;
                }

                if (LicenseID == -1)
                {
                    _LicenseInfo = value;
                    _LicenseID = _LicenseInfo.LicenseID;

                    return;
                }

                else if (value.LicenseID == LicenseID)
                {
                    _LicenseInfo = value;
                }
                
            }
        }

        private Users _CreatedByUserInfo;
        public Users CreatedByUserInfo
        {
            get
            {

                if(_CreatedByUserInfo == null && CreatedByUserID != -1)
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

                else if(value.UserID == CreatedByUserID)
                {
                    _CreatedByUserInfo = value;
                }
            }
        }

        private Users _ReleasedByUserInfo;
        public Users ReleasedByUserInfo
        {
            get
            {
                if (_ReleasedByUserInfo == null && ReleasedByUserID.HasValue)
                {
                    _ReleasedByUserInfo = Users.Find(ReleasedByUserID.Value);
                }
                return _ReleasedByUserInfo;
            }
            set
            {
                if (value == null)
                    return;

                if (ReleasedByUserID == null)
                {
                    _ReleasedByUserInfo = value;
                    _ReleasedByUserID = _ReleasedByUserInfo.UserID;

                    return;
                }

                else if (value.UserID == ReleasedByUserID)
                {
                    _ReleasedByUserInfo = value;
                }
            }
        }

        private Applications _ReleaseApplicationInfo;
        public Applications ReleaseApplicationInfo
        {
            get
            {
                if(_ReleaseApplicationInfo == null && ReleaseApplicationID.HasValue)
                {
                    _ReleaseApplicationInfo = Applications.Find(ReleaseApplicationID.Value);
                }
                return _ReleaseApplicationInfo;
            }
            set
            {
                if (value == null)
                    return;

                if (ReleaseApplicationID == null)
                {
                    _ReleaseApplicationInfo = value;
                    _ReleaseApplicationID = _ReleaseApplicationInfo.ApplicationID;

                    return;
                }

                else if (value.ApplicationID == ReleaseApplicationID)
                {
                    _ReleaseApplicationInfo = value;
                }
            }
        }


        private DetainedLicenses(int DetainID, int LicenseID, DateTime DetainDate, decimal FineFees, int CreatedByUserID, bool IsReleased, DateTime? ReleaseDate, int? ReleasedByUserID, int? ReleaseApplicationID)
        {
            this.DetainID = DetainID;
            this.LicenseID = LicenseID;
            this.DetainDate = DetainDate;
            this.FineFees = FineFees;
            this.CreatedByUserID = CreatedByUserID;
            this.IsReleased = IsReleased;
            this.ReleaseDate = ReleaseDate;
            this.ReleasedByUserID = ReleasedByUserID;
            this.ReleaseApplicationID = ReleaseApplicationID;

            Mode = enMode.Update;

        }
        public DetainedLicenses()
        {
            DetainID = -1;
            LicenseID = -1;
            DetainDate = DateTime.Now;
            FineFees = -1;
            CreatedByUserID = -1;
            IsReleased = false;
            ReleaseDate = null;
            ReleasedByUserID = null;
            ReleaseApplicationID = null;

            Mode = enMode.AddNew;

        }
        public static DetainedLicenses Find(int DetainID)
        {

            int LicenseID = -1;
            DateTime DetainDate = DateTime.Now;
            decimal FineFees = -1;
            int CreatedByUserID = -1;
            bool IsReleased = false;
            DateTime? ReleaseDate = null;
            int? ReleasedByUserID = null;
            int? ReleaseApplicationID = null;

            if (DetainedLicensesDataAccess.FindFromDetainedLicensesByDetainID(DetainID, ref LicenseID, ref DetainDate, ref FineFees, ref CreatedByUserID, ref IsReleased, ref ReleaseDate, ref ReleasedByUserID, ref ReleaseApplicationID))
                return new DetainedLicenses(DetainID, LicenseID, DetainDate, FineFees, CreatedByUserID, IsReleased, ReleaseDate, ReleasedByUserID, ReleaseApplicationID);
            else
                return null;

        }

        public static DetainedLicenses FindByLicenseID(int LicenseID)
        {
            int DetainID = -1;
            DateTime DetainDate = DateTime.Now;
            decimal FineFees = -1;
            int CreatedByUserID = -1;
            bool IsReleased = false;
            DateTime? ReleaseDate = null;
            int? ReleasedByUserID = null;
            int? ReleaseApplicationID = null;

            if (DetainedLicensesDataAccess.FindByLicenseID(LicenseID, ref DetainID, ref DetainDate, ref FineFees, ref CreatedByUserID, ref IsReleased, ref ReleaseDate, ref ReleasedByUserID, ref ReleaseApplicationID))
                return new DetainedLicenses(DetainID, LicenseID, DetainDate, FineFees, CreatedByUserID, IsReleased, ReleaseDate, ReleasedByUserID, ReleaseApplicationID);
            else
                return null;
        }

        public static bool IsExists(int DetainID)
        {

            return DetainedLicensesDataAccess.IsExistsInDetainedLicensesByDetainID(DetainID);

        }

        private bool _AddNewToDetainedLicenses()
        {

            return (this.DetainID = (DetainedLicensesDataAccess.AddNewToDetainedLicenses(this.LicenseID, this.DetainDate, this.FineFees, this.CreatedByUserID, this.IsReleased, this.ReleaseDate, this.ReleasedByUserID, this.ReleaseApplicationID))) > 0;

        }

        private bool _UpdateDetainedLicenses()
        {

            return DetainedLicensesDataAccess.UpdateFromDetainedLicenses(this.DetainID, this.LicenseID, this.DetainDate, this.FineFees, this.CreatedByUserID, this.IsReleased, this.ReleaseDate, this.ReleasedByUserID, this.ReleaseApplicationID);

        }

        public static bool DeleteFromDetainedLicensesByDetainID(int DetainID)
        {

            return DetainedLicensesDataAccess.DeleteFromDetainedLicenses(DetainID);

        }

        public bool Save()
        {
            switch (Mode)
            {
                case enMode.AddNew:

                    if (_AddNewToDetainedLicenses())
                    {
                        Mode = enMode.Update;
                        return true;
                    }
                    else return false;

                case enMode.Update:

                    if (_UpdateDetainedLicenses())
                    {
                        return true;
                    }
                    else return false;

            }
            return false;
        }
        public static DataTable GetAllDetainedLicenses()
        {

            return DetainedLicensesDataAccess.GetAllFromDetainedLicenses();

        }
        
        public static DataTable GetDetainedLicensesSummary()
        {
            return DetainedLicensesDataAccess.GetDetainedLicensesSummary();
        }

        public static bool IsDetainedByLicenseID(int LicenseID)
        {
            return DetainedLicensesDataAccess.IsDetainedByLicenseID(LicenseID);
        }

    }
}
