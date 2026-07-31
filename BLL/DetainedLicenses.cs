using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
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
        public int LicenseID { get; set; }
        public DateTime DetainDate { get; set; }
        public decimal FineFees { get; set; }
        public int CreatedByUserID { get; set; }
        public bool IsReleased { get; set; }
        public DateTime? ReleaseDate { get; set; }
        public int? ReleasedByUserID { get; set; }
        public int? ReleaseApplicationID { get; set; }

        public Licenses LicenseInfo { get; set; }
        public Users CreatedByUserInfo { get; set; }
        public Users ReleasedByUserInfo { get; set; }
        public Applications ReleaseApplicationInfo { get; set; }

        private void _LoadCompositions()
        {
            LicenseInfo = Licenses.Find(LicenseID);
            CreatedByUserInfo = Users.Find(CreatedByUserID);

            if (ReleasedByUserID.HasValue)
            {
                ReleasedByUserInfo = Users.Find(Convert.ToInt32(ReleasedByUserID));
            }

            if (ReleaseApplicationID.HasValue)
            {
                ReleaseApplicationInfo = Applications.Find(Convert.ToInt32(ReleaseApplicationID));
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

            _LoadCompositions();
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
                        _LoadCompositions();
                        Mode = enMode.Update;
                        return true;
                    }
                    else return false;

                case enMode.Update:

                    if (_UpdateDetainedLicenses())
                    {
                        _LoadCompositions();
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
