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
        public object CreatedDate { get; set; }


        private Drivers(int DriverID, int PersonID, int CreatedByUserID, object CreatedDate)
        {
            this.DriverID = DriverID;
            this.PersonID = PersonID;
            this.CreatedByUserID = CreatedByUserID;
            this.CreatedDate = CreatedDate;


        }
        public Drivers()
        {
            DriverID = -1;
            PersonID = -1;
            CreatedByUserID = -1;
            CreatedDate = null;


        }
        public static Drivers Find(int DriverID)
        {

            int PersonID = -1;
            int CreatedByUserID = -1;
            object CreatedDate = null;

            if (DriversDataAccess.FindFromDriversByDriverID(DriverID, ref PersonID, ref CreatedByUserID, ref CreatedDate))
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
                        Mode = enMode.Update;
                        return true;
                    }
                    else return false;

                case enMode.Update:

                    if (_UpdateDrivers())
                    {
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
