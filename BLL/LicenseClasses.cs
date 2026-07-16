using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace BLL
{
    public class LicenseClasses
    {

        enum enMode { AddNew = 0, Update = 1 };
        private enMode Mode = enMode.AddNew;

        public int LicenseClassID { get; set; }
        public string ClassName { get; set; }
        public string ClassDescription { get; set; }
        public int MinimumAllowedAge { get; set; }
        public int DefaultValidityLength { get; set; }
        public decimal ClassFees { get; set; }


        private LicenseClasses(int LicenseClassID, string ClassName, string ClassDescription, int MinimumAllowedAge, int DefaultValidityLength, decimal ClassFees)
        {
            this.LicenseClassID = LicenseClassID;
            this.ClassName = ClassName;
            this.ClassDescription = ClassDescription;
            this.MinimumAllowedAge = MinimumAllowedAge;
            this.DefaultValidityLength = DefaultValidityLength;
            this.ClassFees = ClassFees;


        }
        public LicenseClasses()
        {
            LicenseClassID = -1;
            ClassName = string.Empty;
            ClassDescription = string.Empty;
            MinimumAllowedAge = -1;
            DefaultValidityLength = -1;
            ClassFees = -1;


        }
        public static LicenseClasses Find(int LicenseClassID)
        {

            string ClassName = string.Empty;
            string ClassDescription = string.Empty;
            int MinimumAllowedAge = -1;
            int DefaultValidityLength = -1;
            decimal ClassFees = -1;

            if (LicenseClassesDataAccess.FindFromLicenseClassesByLicenseClassID(LicenseClassID, ref ClassName, ref ClassDescription, ref MinimumAllowedAge, ref DefaultValidityLength, ref ClassFees))
                return new LicenseClasses(LicenseClassID, ClassName, ClassDescription, MinimumAllowedAge, DefaultValidityLength, ClassFees);
            else
                return null;

        }

        public static bool IsExists(int LicenseClassID)
        {

            return LicenseClassesDataAccess.IsExistsInLicenseClassesByLicenseClassID(LicenseClassID);

        }

        private bool _AddNewToLicenseClasses()
        {

            return (this.LicenseClassID = (LicenseClassesDataAccess.AddNewToLicenseClasses(this.ClassName, this.ClassDescription, this.MinimumAllowedAge, this.DefaultValidityLength, this.ClassFees))) > 0;

        }

        private bool _UpdateLicenseClasses()
        {

            return LicenseClassesDataAccess.UpdateFromLicenseClasses(this.LicenseClassID, this.ClassName, this.ClassDescription, this.MinimumAllowedAge, this.DefaultValidityLength, this.ClassFees);

        }

        public static bool DeleteFromLicenseClassesByLicenseClassID(int LicenseClassID)
        {

            return LicenseClassesDataAccess.DeleteFromLicenseClasses(LicenseClassID);

        }

        public bool Save()
        {
            switch (Mode)
            {
                case enMode.AddNew:

                    if (_AddNewToLicenseClasses())
                    {
                        Mode = enMode.Update;
                        return true;
                    }
                    else return false;

                case enMode.Update:

                    if (_UpdateLicenseClasses())
                    {
                        return true;
                    }
                    else return false;

            }
            return false;
        }
        public static DataTable GetAllLicenseClasses()
        {

            return LicenseClassesDataAccess.GetAllFromLicenseClasses();

        }


    }
}
