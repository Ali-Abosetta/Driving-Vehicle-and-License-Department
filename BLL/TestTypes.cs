using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace BLL
{
    public class TestTypes
    {

        enum enMode { AddNew = 0, Update = 1 };
        private enMode Mode = enMode.AddNew;

        public enum enTestType
        {
            VisionTest = 1,
            WrittenTest = 2,
            StreetTest = 3,
            RetakeTest = 4
        }

        public int TestTypeID { get; set; }
        public string TestTypeTitle { get; set; }
        public string TestTypeDescription { get; set; }
        public decimal TestTypeFees { get; set; }


        private TestTypes(int TestTypeID, string TestTypeTitle, string TestTypeDescription, decimal TestTypeFees)
        {
            this.TestTypeID = TestTypeID;
            this.TestTypeTitle = TestTypeTitle;
            this.TestTypeDescription = TestTypeDescription;
            this.TestTypeFees = TestTypeFees;

            this.Mode = enMode.Update;
        }
        public TestTypes()
        {
            TestTypeID = -1;
            TestTypeTitle = string.Empty;
            TestTypeDescription = string.Empty;
            TestTypeFees = -1;


        }
        public static TestTypes Find(int TestTypeID)
        {

            string TestTypeTitle = string.Empty;
            string TestTypeDescription = string.Empty;
            decimal TestTypeFees = -1;

            if (TestTypesDataAccess.FindFromTestTypesByTestTypeID(TestTypeID, ref TestTypeTitle, ref TestTypeDescription, ref TestTypeFees))
                return new TestTypes(TestTypeID, TestTypeTitle, TestTypeDescription, TestTypeFees);
            else
                return null;

        }

        public static bool IsExists(int TestTypeID)
        {

            return TestTypesDataAccess.IsExistsInTestTypesByTestTypeID(TestTypeID);

        }

        private bool _AddNewToTestTypes()
        {

            return (this.TestTypeID = (TestTypesDataAccess.AddNewToTestTypes(this.TestTypeTitle, this.TestTypeDescription, this.TestTypeFees))) > 0;

        }

        private bool _UpdateTestTypes()
        {

            return TestTypesDataAccess.UpdateFromTestTypes(this.TestTypeID, this.TestTypeTitle, this.TestTypeDescription, this.TestTypeFees);

        }

        public static bool DeleteFromTestTypesByTestTypeID(int TestTypeID)
        {

            return TestTypesDataAccess.DeleteFromTestTypes(TestTypeID);

        }

        public bool Save()
        {
            switch (Mode)
            {
                case enMode.AddNew:

                    if (_AddNewToTestTypes())
                    {
                        Mode = enMode.Update;
                        return true;
                    }
                    else return false;

                case enMode.Update:

                    if (_UpdateTestTypes())
                    {
                        return true;
                    }
                    else return false;

            }
            return false;
        }
        public static DataTable GetAllTestTypes()
        {

            return TestTypesDataAccess.GetAllFromTestTypes();

        }


    }
}
