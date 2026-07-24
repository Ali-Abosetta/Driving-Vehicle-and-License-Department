using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace BLL
{
    public class ApplicationsTypes
    {

        enum enMode { AddNew = 0, Update = 1 };
        private enMode Mode = enMode.AddNew;

        public enum enApplicationType
        {
            NewLocalDrivingLicense = 1,
            RenewDrivingLicense = 2,
            ReplaceLostDrivingLicense = 3,
            ReplaceDamagedDrivingLicense = 4,
            ReleaseDetainedDrivingLicsense = 5,
            NewInternationalLicense = 6,
            RetakeTest = 7 
        }

        public int ApplicationTypeID { get; set; }
        public string ApplicationTypeTitle { get; set; }
        public decimal ApplicationFees { get; set; }


        private ApplicationsTypes(int ApplicationTypeID, string ApplicationTypeTitle, decimal ApplicationFees)
        {
            this.ApplicationTypeID = ApplicationTypeID;
            this.ApplicationTypeTitle = ApplicationTypeTitle;
            this.ApplicationFees = ApplicationFees;

            this.Mode = enMode.Update;
        }
        public ApplicationsTypes()
        {
            ApplicationTypeID = -1;
            ApplicationTypeTitle = string.Empty;
            ApplicationFees = -1;


        }
        public static ApplicationsTypes Find(int ApplicationTypeID)
        {

            string ApplicationTypeTitle = string.Empty;
            decimal ApplicationFees = -1;

            if (ApplicationTypesDataAccess.FindFromApplicationTypesByApplicationTypeID(ApplicationTypeID, ref ApplicationTypeTitle, ref ApplicationFees))
                return new ApplicationsTypes(ApplicationTypeID, ApplicationTypeTitle, ApplicationFees);
            else
                return null;

        }

        public static bool IsExists(int ApplicationTypeID)
        {

            return ApplicationTypesDataAccess.IsExistsInApplicationTypesByApplicationTypeID(ApplicationTypeID);

        }

        private bool _AddNewToApplicationTypes()
        {

            return (this.ApplicationTypeID = (ApplicationTypesDataAccess.AddNewToApplicationTypes(this.ApplicationTypeTitle, this.ApplicationFees))) > 0;

        }

        private bool _UpdateApplicationTypes()
        {

            return ApplicationTypesDataAccess.UpdateFromApplicationTypes(this.ApplicationTypeID, this.ApplicationTypeTitle, this.ApplicationFees);

        }

        public static bool DeleteFromApplicationTypesByApplicationTypeID(int ApplicationTypeID)
        {

            return ApplicationTypesDataAccess.DeleteFromApplicationTypes(ApplicationTypeID);

        }

        public bool Save()
        {
            switch (Mode)
            {
                case enMode.AddNew:

                    if (_AddNewToApplicationTypes())
                    {
                        Mode = enMode.Update;
                        return true;
                    }
                    else return false;

                case enMode.Update:

                    if (_UpdateApplicationTypes())
                    {
                        return true;
                    }
                    else return false;

            }
            return false;
        }
        public static DataTable GetAllApplicationTypes()
        {

            return ApplicationTypesDataAccess.GetAllFromApplicationTypes();

        }


    }
}
