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
        public int ApplicationID { get; set; }
        public int DriverID { get; set; }
        public int IssuedUsingLocalLicenseID { get; set; }
        public DateTime IssueDate { get; set; }
        public DateTime ExpirationDate { get; set; }
        public bool IsActive { get; set; }
        public int CreatedByUserID { get; set; }

        public Applications ApplicationInfo { get; set; }
        public Drivers DriverInfo { get; set; }
        public LocalDrivingLicenseApplications IssuedUsingLocalLicenseInfo { get; set; }
        public Users CreatedByUserInfo { get; set; }

        private void _LoadCompositions()
        {
            ApplicationInfo = Applications.Find(ApplicationID);
            DriverInfo = Drivers.Find(DriverID);
            IssuedUsingLocalLicenseInfo = LocalDrivingLicenseApplications.Find(IssuedUsingLocalLicenseID);
            CreatedByUserInfo = Users.Find(CreatedByUserID);

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

            _LoadCompositions();
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
                        _LoadCompositions();
                        Mode = enMode.Update;
                        return true;
                    }
                    else return false;

                case enMode.Update:

                    if (_UpdateInternationalLicenses())
                    {
                        _LoadCompositions();
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


    }
}
