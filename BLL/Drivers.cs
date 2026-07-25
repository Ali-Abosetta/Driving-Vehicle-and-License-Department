using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace BLL
{
    public class Drivers
    {

        enum enMode { AddNew = 0, Update = 1 };
        private enMode Mode = enMode.AddNew;

        public int DriverID { get; set; }
        public int PersonID { get; set; }
        public int CreatedByUserID { get; set; }
        public DateTime CreatedDate { get; set; }

        public People PersonInfo;
        public Users CreatedByUserInfo;

        private void _LoadCompositions()
        {
            PersonInfo = People.Find(PersonID);
            CreatedByUserInfo = Users.Find(CreatedByUserID);
        }

        private Drivers(int DriverID, int PersonID, int CreatedByUserID, DateTime CreatedDate)
        {
            this.DriverID = DriverID;
            this.PersonID = PersonID;
            this.CreatedByUserID = CreatedByUserID;
            this.CreatedDate = CreatedDate;

            _LoadCompositions();
        }
        public Drivers()
        {
            DriverID = -1;
            PersonID = -1;
            CreatedByUserID = -1;
            CreatedDate = DateTime.Now;

            PersonInfo = null;
            CreatedByUserInfo = null;


        }
        public static Drivers Find(int DriverID)
        {

            int PersonID = -1;
            int CreatedByUserID = -1;
            DateTime CreatedDate = DateTime.Now;

            if (DriversDataAccess.FindFromDriversByDriverID(DriverID, ref PersonID, ref CreatedByUserID, ref CreatedDate))
                return new Drivers(DriverID, PersonID, CreatedByUserID, CreatedDate);
            else
                return null;

        }

        public static Drivers FindDriverByPersonID(int PersonID)
        {
            int DriverID = -1;
            int CreatedByUserID = -1;
            DateTime CreatedDate = DateTime.Now;

            if(DriversDataAccess.FindDriverByPersonID(PersonID, ref DriverID, ref CreatedByUserID, ref CreatedDate))
                return new Drivers(DriverID, PersonID, CreatedByUserID, CreatedDate);
            else
                return null;
        }


        public static bool IsExists(int DriverID)
        {

            return DriversDataAccess.IsExistsInDriversByDriverID(DriverID);

        }

        private bool _AddNewToDrivers()
        {

            return (this.DriverID = (DriversDataAccess.AddNewToDrivers(this.PersonID, this.CreatedByUserID, this.CreatedDate))) > 0;

        }

        private bool _UpdateDrivers()
        {

            return DriversDataAccess.UpdateFromDrivers(this.DriverID, this.PersonID, this.CreatedByUserID, this.CreatedDate);

        }

        public static bool DeleteFromDriversByDriverID(int DriverID)
        {

            return DriversDataAccess.DeleteFromDrivers(DriverID);

        }

        public bool Save()
        {
            switch (Mode)
            {
                case enMode.AddNew:

                    if (_AddNewToDrivers())
                    {
                        _LoadCompositions();
                        Mode = enMode.Update;
                        return true;
                    }
                    else return false;

                case enMode.Update:

                    if (_UpdateDrivers())
                    {
                        _LoadCompositions();
                        return true;
                    }
                    else return false;

            }
            return false;
        }
        public static DataTable GetAllDrivers()
        {

            return DriversDataAccess.GetAllFromDrivers();

        }


    }
}
