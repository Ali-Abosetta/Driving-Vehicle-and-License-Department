using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace BLL
{
    public class Countries
    {

        enum enMode { AddNew = 0, Update = 1 };
        private enMode Mode = enMode.AddNew;

        public int CountryID { get; set; }
        public string CountryName { get; set; }


        private Countries(int CountryID, string CountryName)
        {
            this.CountryID = CountryID;
            this.CountryName = CountryName;


        }
        public Countries()
        {
            CountryID = -1;
            CountryName = string.Empty;


        }
        public static Countries Find(int CountryID)
        {

            string CountryName = string.Empty;

            if (CountriesDataAccess.FindFromCountriesByCountryID(CountryID, ref CountryName))
                return new Countries(CountryID, CountryName);
            else
                return null;

        }

        public static bool IsExists(int CountryID)
        {

            return CountriesDataAccess.IsExistsInCountriesByCountryID(CountryID);

        }

        private bool _AddNewToCountries()
        {

            return (this.CountryID = (CountriesDataAccess.AddNewToCountries(this.CountryName))) > 0;

        }

        private bool _UpdateCountries()
        {

            return CountriesDataAccess.UpdateFromCountries(this.CountryID, this.CountryName);

        }

        public static bool DeleteFromCountriesByCountryID(int CountryID)
        {

            return CountriesDataAccess.DeleteFromCountries(CountryID);

        }

        public bool Save()
        {
            switch (Mode)
            {
                case enMode.AddNew:

                    if (_AddNewToCountries())
                    {
                        Mode = enMode.Update;
                        return true;
                    }
                    else return false;

                case enMode.Update:

                    if (_UpdateCountries())
                    {
                        return true;
                    }
                    else return false;

            }
            return false;
        }
        public static DataTable GetAllCountries()
        {

            return CountriesDataAccess.GetAllFromCountries();

        }

        public static List<string> GetAllCountriesNames()
        {
            return CountriesDataAccess.GetAllCountriesNames();
        }

    }
}
