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

        public int LicenseID { get; set; }
        public int ApplicationID { get; set; }
        public int DriverID { get; set; }
        public int LicenseClass { get; set; }
        public DateTime IssueDate { get; set; }
        public DateTime ExpirationDate { get; set; }
        public string Notes { get; set; }
        public decimal PaidFees { get; set; }
        public bool IsActive { get; set; }
        public int IssueReason { get; set; }
        public int CreatedByUserID { get; set; }


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


    }
}
