using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security;
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

        private int _PersonID;
        public int PersonID
        {
            get
            {
                return _PersonID; 
            }
            set
            {
                if (_PersonID != value)
                {
                    _PersonID = value;
                    _PersonInfo = null;
                }
            }
        }

        private int _CreatedByUserID;
        public int CreatedByUserID
        {
            get
            {
                return _CreatedByUserID;
            }
            set
            {
                if (_CreatedByUserID != value)
                {
                    _CreatedByUserID = value;
                    _CreatedByUserInfo = null;
                }
            }
        }

        public DateTime CreatedDate { get; set; }

        private People _PersonInfo;
        public People PersonInfo
        {
            get
            {
                if (_PersonInfo == null && PersonID != -1)
                {
                    _PersonInfo = People.Find(PersonID);
                }
                return _PersonInfo;
            }
            set
            {
                if (value == null)
                {
                    return;
                }

                if (PersonID == -1)
                {
                    _PersonInfo = value;
                    _PersonID = _PersonInfo.PersonID;
                }

                else if (value.PersonID == PersonID)
                {
                    _PersonInfo = value;
                }
            }
        }

        private Users _CreatedByUserInfo;
        public Users CreatedByUserInfo
        {
            get
            {

                if (_CreatedByUserInfo == null && CreatedByUserID != -1)
                {
                    _CreatedByUserInfo = Users.Find(CreatedByUserID);
                }

                return _CreatedByUserInfo;
            }
            set
            {
                if (value == null)
                    return;

                if (CreatedByUserID == -1)
                {
                    _CreatedByUserInfo = value;
                    _CreatedByUserID = _CreatedByUserInfo.UserID;
                    return;
                }

                else if (value.UserID == CreatedByUserID)
                {
                    _CreatedByUserInfo = value;
                }
            }
        }
        private Drivers(int DriverID, int PersonID, int CreatedByUserID, DateTime CreatedDate)
        {
            this.DriverID = DriverID;
            this.PersonID = PersonID;
            this.CreatedByUserID = CreatedByUserID;
            this.CreatedDate = CreatedDate;

            Mode = enMode.Update;
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

        public static DataTable GetDriversSummary()
        {
            return DriversDataAccess.GetDriversSummary();
        }


    }
}
