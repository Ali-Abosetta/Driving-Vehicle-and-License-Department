using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace BLL
{
    public class LocalDrivingLicenseApplications
    {

        enum enMode { AddNew = 0, Update = 1 };
        private enMode Mode = enMode.AddNew;

        public int LocalDrivingLicenseApplicationID { get; set; }
        public int ApplicationID { get; set; }
        public int LicenseClassID { get; set; }

        public static List<string> GetSearchFilters()
        {
            return new List<string>
            {
                "L.D.L Application ID",
                "National No.",
                "Full name",
                "Status"
            };
        }

        private LocalDrivingLicenseApplications(int LocalDrivingLicenseApplicationID, int ApplicationID, int LicenseClassID)
        {
            this.LocalDrivingLicenseApplicationID = LocalDrivingLicenseApplicationID;
            this.ApplicationID = ApplicationID;
            this.LicenseClassID = LicenseClassID;

            this.Mode = enMode.Update;
        }
        public LocalDrivingLicenseApplications()
        {
            LocalDrivingLicenseApplicationID = -1;
            ApplicationID = -1;
            LicenseClassID = -1;

        }
        public static LocalDrivingLicenseApplications Find(int LocalDrivingLicenseApplicationID)
        {

            int ApplicationID = -1;
            int LicenseClassID = -1;

            if (LocalDrivingLicenseApplicationsDataAccess.FindFromLocalDrivingLicenseApplicationsByLocalDrivingLicenseApplicationID(LocalDrivingLicenseApplicationID, ref ApplicationID, ref LicenseClassID))
                return new LocalDrivingLicenseApplications(LocalDrivingLicenseApplicationID, ApplicationID, LicenseClassID);
            else
                return null;

        }

        public static bool IsExists(int LocalDrivingLicenseApplicationID)
        {

            return LocalDrivingLicenseApplicationsDataAccess.IsExistsInLocalDrivingLicenseApplicationsByLocalDrivingLicenseApplicationID(LocalDrivingLicenseApplicationID);

        }

        private bool _AddNewToLocalDrivingLicenseApplications()
        {

            return (this.LocalDrivingLicenseApplicationID = (LocalDrivingLicenseApplicationsDataAccess.AddNewToLocalDrivingLicenseApplications(this.ApplicationID, this.LicenseClassID))) > 0;

        }

        private bool _UpdateLocalDrivingLicenseApplications()
        {

            return LocalDrivingLicenseApplicationsDataAccess.UpdateFromLocalDrivingLicenseApplications(this.LocalDrivingLicenseApplicationID, this.ApplicationID, this.LicenseClassID);

        }

        public static bool DeleteFromLocalDrivingLicenseApplicationsByLocalDrivingLicenseApplicationID(int LocalDrivingLicenseApplicationID)
        {

            return LocalDrivingLicenseApplicationsDataAccess.DeleteFromLocalDrivingLicenseApplications(LocalDrivingLicenseApplicationID);

        }

        public bool Save()
        {
            switch (Mode)
            {
                case enMode.AddNew:

                    if (_AddNewToLocalDrivingLicenseApplications())
                    {
                        Mode = enMode.Update;
                        return true;
                    }
                    else return false;

                case enMode.Update:

                    if (_UpdateLocalDrivingLicenseApplications())
                    {
                        return true;
                    }
                    else return false;

            }
            return false;
        }
        public static DataTable GetAllLocalDrivingLicenseApplications()
        {

            return LocalDrivingLicenseApplicationsDataAccess.GetAllFromLocalDrivingLicenseApplications();

        }

        public static DataTable GetLocalDrivingLicenseApplicationsSummary()
        {
            return LocalDrivingLicenseApplicationsDataAccess
                .GetLocalDrivingLicenseApplicationsSummary();
        }

        public static int HasActiveApplicationForClass(int ApplicantPersonID, int LicenseClassID)
        {
            return LocalDrivingLicenseApplicationsDataAccess
                .HasActiveApplicationForClass(ApplicantPersonID, LicenseClassID);
        }
    }
}
