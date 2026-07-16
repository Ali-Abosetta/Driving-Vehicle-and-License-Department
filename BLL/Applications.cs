using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace BLL
{
    public class Applications
    {

        enum enMode { AddNew = 0, Update = 1 };
        public enum enStatus { New = 1, Canceled  = 2, Completed = 3 };
        private enMode Mode = enMode.AddNew;

        public int ApplicationID { get; set; }
        public int ApplicantPersonID { get; set; }
        public DateTime ApplicationDate { get; set; }
        public int ApplicationTypeID { get; set; }
        public int ApplicationStatus { get; set; }
        public DateTime LastStatusDate { get; set; }
        public decimal PaidFees { get; set; }
        public int CreatedByUserID { get; set; }


        private Applications(int ApplicationID, int ApplicantPersonID, DateTime ApplicationDate, int ApplicationTypeID, int ApplicationStatus, DateTime LastStatusDate, decimal PaidFees, int CreatedByUserID)
        {
            this.ApplicationID = ApplicationID;
            this.ApplicantPersonID = ApplicantPersonID;
            this.ApplicationDate = ApplicationDate;
            this.ApplicationTypeID = ApplicationTypeID;
            this.ApplicationStatus = ApplicationStatus;
            this.LastStatusDate = LastStatusDate;
            this.PaidFees = PaidFees;
            this.CreatedByUserID = CreatedByUserID;

            this.Mode = enMode.Update;
        }
        public Applications()
        {
            ApplicationID = -1;
            ApplicantPersonID = -1;
            ApplicationDate = DateTime.Now;
            ApplicationTypeID = -1;
            ApplicationStatus = (int)enStatus.New;
            LastStatusDate = DateTime.Now;
            PaidFees = -1;
            CreatedByUserID = -1;

        }
        public static Applications Find(int ApplicationID)
        {

            int ApplicantPersonID = -1;
            DateTime ApplicationDate = DateTime.Now;
            int ApplicationTypeID = -1;
            int ApplicationStatus = (int)enStatus.New;
            DateTime LastStatusDate = DateTime.Now;
            decimal PaidFees = -1;
            int CreatedByUserID = -1;

            if (ApplicationsDataAccess.FindFromApplicationsByApplicationID(ApplicationID, ref ApplicantPersonID, ref ApplicationDate, ref ApplicationTypeID, ref ApplicationStatus, ref LastStatusDate, ref PaidFees, ref CreatedByUserID))
                return new Applications(ApplicationID, ApplicantPersonID, ApplicationDate, ApplicationTypeID, ApplicationStatus, LastStatusDate, PaidFees, CreatedByUserID);
            else
                return null;

        }

        public static bool IsExists(int ApplicationID)
        {

            return ApplicationsDataAccess.IsExistsInApplicationsByApplicationID(ApplicationID);

        }

        private bool _AddNewToApplications()
        {

            return (this.ApplicationID = (ApplicationsDataAccess.AddNewToApplications(this.ApplicantPersonID, this.ApplicationDate, this.ApplicationTypeID, this.ApplicationStatus, this.LastStatusDate, this.PaidFees, this.CreatedByUserID))) > 0;

        }

        private bool _UpdateApplications()
        {

            return ApplicationsDataAccess.UpdateFromApplications(this.ApplicationID, this.ApplicantPersonID, this.ApplicationDate, this.ApplicationTypeID, this.ApplicationStatus, this.LastStatusDate, this.PaidFees, this.CreatedByUserID);

        }

        public static bool DeleteFromApplicationsByApplicationID(int ApplicationID)
        {

            return ApplicationsDataAccess.DeleteFromApplications(ApplicationID);

        }

        public bool Save()
        {
            switch (Mode)
            {
                case enMode.AddNew:

                    if (_AddNewToApplications())
                    {
                        Mode = enMode.Update;
                        return true;
                    }
                    else return false;

                case enMode.Update:

                    if (_UpdateApplications())
                    {
                        return true;
                    }
                    else return false;

            }
            return false;
        }
        public static DataTable GetAllApplications()
        {

            return ApplicationsDataAccess.GetAllFromApplications();

        }


    }
}
