using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using Enum;

namespace BLL
{
    public class People
    {

        
        public enMode Mode = enMode.AddNew;

        public int PersonID { get; set; }
        public string NationalNo { get; set; }
        public string FirstName { get; set; }
        public string SecondName { get; set; }
        public string ThirdName { get; set; }
        public string LastName { get; set; }
        public string FullName { 
            get
            {
                string tempFullName = FirstName + " " + SecondName + " ";
                if (!string.IsNullOrWhiteSpace(ThirdName))
                    tempFullName += ThirdName + " ";
                tempFullName += LastName;

                return tempFullName;
            }
        }
        public DateTime DateOfBirth { get; set; }
        public int Gendor { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public int NationalityCountryID { get; set; }
        public string ImagePath { get; set; }
        public Countries CountryInfo { get; set; }
        public static List<string> GetSearchFilters()
        {
            return new List<string> { "Person ID", "National No.",
                "First name", "Second Name", "Third Name", "Last Name", 
                "Nationality", "Gender", "Phone Number", "Email" };
        }


        private People(int PersonID, string NationalNo, string FirstName, string SecondName, string ThirdName, string LastName, DateTime DateOfBirth, int Gendor, string Address, string Phone, string Email, int NationalityCountryID, string ImagePath)
        {
            this.PersonID = PersonID;
            this.NationalNo = NationalNo;
            this.FirstName = FirstName;
            this.SecondName = SecondName;
            this.ThirdName = ThirdName;
            this.LastName = LastName;
            this.DateOfBirth = DateOfBirth;
            this.Gendor = Gendor;
            this.Address = Address;
            this.Phone = Phone;
            this.Email = Email;
            this.NationalityCountryID = NationalityCountryID;
            this.ImagePath = ImagePath;
            CountryInfo = Countries.Find(NationalityCountryID);
        }
        public People()
        {
            PersonID = -1;
            NationalNo = string.Empty;
            FirstName = string.Empty;
            SecondName = string.Empty;
            ThirdName = string.Empty;
            LastName = string.Empty;
            DateOfBirth = DateTime.Now;
            Gendor = -1;
            Address = string.Empty;
            Phone = string.Empty;
            Email = string.Empty;
            NationalityCountryID = -1;
            ImagePath = string.Empty;
            CountryInfo = null;

        }
        public static People Find(int PersonID)
        {

            string NationalNo = string.Empty;
            string FirstName = string.Empty;
            string SecondName = string.Empty;
            string ThirdName = string.Empty;
            string LastName = string.Empty;
            DateTime DateOfBirth = DateTime.Now;
            int Gendor = 0;
            string Address = string.Empty;
            string Phone = string.Empty;
            string Email = string.Empty;
            int NationalityCountryID = -1;
            string ImagePath = string.Empty;

            if (PeopleDataAccess.FindFromPeopleByPersonID(PersonID, ref NationalNo, ref FirstName, ref SecondName, ref ThirdName, ref LastName, ref DateOfBirth, ref Gendor, ref Address, ref Phone, ref Email, ref NationalityCountryID, ref ImagePath))
                return new People(PersonID, NationalNo, FirstName, SecondName, ThirdName, LastName, DateOfBirth, Gendor, Address, Phone, Email, NationalityCountryID, ImagePath);
            else
                return null;

        }

        public static People FindByNationalNo(string NationalNo)
        {

            int PersonID = -1;
            string FirstName = string.Empty;
            string SecondName = string.Empty;
            string ThirdName = string.Empty;
            string LastName = string.Empty;
            DateTime DateOfBirth = DateTime.Now;
            int Gendor = 0;
            string Address = string.Empty;
            string Phone = string.Empty;
            string Email = string.Empty;
            int NationalityCountryID = -1;
            string ImagePath = string.Empty;

            if (PeopleDataAccess.FindFromPeopleByNationalNo(NationalNo, ref PersonID, ref FirstName, ref SecondName, ref ThirdName, ref LastName, ref DateOfBirth, ref Gendor, ref Address, ref Phone, ref Email, ref NationalityCountryID, ref ImagePath))
                return new People(PersonID, NationalNo, FirstName, SecondName, ThirdName, LastName, DateOfBirth, Gendor, Address, Phone, Email, NationalityCountryID, ImagePath);
            else
                return null;

        }

        public static bool IsExists(int PersonID)
        {

            return PeopleDataAccess.IsExistsInPeopleByPersonID(PersonID);

        }

        private bool _AddNewToPeople()
        {

            return (this.PersonID = (PeopleDataAccess.AddNewToPeople(this.NationalNo,
                this.FirstName, this.SecondName, this.ThirdName,
                this.LastName, this.DateOfBirth, this.Gendor, this.Address,
                this.Phone, this.Email, this.NationalityCountryID, this.ImagePath))) > 0;

        }

        private bool _UpdatePeople()
        {

            return PeopleDataAccess.UpdateFromPeople(this.PersonID, this.NationalNo, this.FirstName, this.SecondName, this.ThirdName, this.LastName, this.DateOfBirth, this.Gendor, this.Address, this.Phone, this.Email, this.NationalityCountryID, this.ImagePath);

        }

        public static bool DeleteFromPeopleByPersonID(int PersonID)
        {

            return PeopleDataAccess.DeleteFromPeople(PersonID);

        }

        public bool Save()
        {
            switch (Mode)
            {
                case enMode.AddNew:

                    if (_AddNewToPeople())
                    {
                        Mode = enMode.Update;
                        return true;
                    }
                    else return false;

                case enMode.Update:

                    if (_UpdatePeople())
                    {
                        return true;
                    }
                    else return false;

            }
            return false;
        }
        public static DataTable GetAllPeople()
        {

            return PeopleDataAccess.GetAllFromPeople();

        }

        public static DataTable GetPeopleSummary() 
        {
            return PeopleDataAccess.GetPeopleSummary();
        }




    }
}
