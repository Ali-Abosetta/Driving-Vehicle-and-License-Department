using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace BLL
{
    public class Users
    {

        enum enMode { AddNew = 0, Update = 1 };
        private enMode Mode = enMode.AddNew;

        public int UserID { get; set; }
        public int PersonID { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public bool IsActive { get; set; }
        public People PersonInfo { get; set; }
        public static List<string> GetSearchFilters()
        {
            return new List<string> { "User ID", "Person ID", 
                "Full name", "Username", "Is active" };
        }

        private void _LoadCompositions()
        {
            this.PersonInfo = People.Find(this.PersonID);
        }

        private Users(int UserID, int PersonID, string UserName, string Password, bool IsActive)
        {
            this.UserID = UserID;
            this.PersonID = PersonID;
            this.UserName = UserName;
            this.Password = Password;
            this.IsActive = IsActive;

            _LoadCompositions();

            this.Mode = enMode.Update;

        }
        public Users()
        {
            UserID = -1;
            PersonID = -1;
            UserName = string.Empty;
            Password = string.Empty;
            IsActive = false;

            PersonInfo = null;
        }
        public static Users Find(int UserID)
        {

            int PersonID = -1;
            string UserName = string.Empty;
            string Password = string.Empty;
            bool IsActive = false;

            if (UsersDataAccess.FindFromUsersByUserID(UserID, ref PersonID, ref UserName, ref Password, ref IsActive)) 
                return new Users(UserID, PersonID, UserName, Password, IsActive);
            else
                return null;

        }

        public static Users FindByUserName(string UserName)
        {

            int PersonID = -1;
            int UserID = -1;
            string Password = string.Empty;
            bool IsActive = false;

            if (UsersDataAccess.FindFromUsersByUserName(UserName, ref UserID, ref PersonID, ref Password, ref IsActive))
                return new Users(UserID, PersonID, UserName, Password, IsActive);
            else
                return null;

        }

        public static bool IsExists(int UserID)
        {

            return UsersDataAccess.IsExistsInUsersByUserID(UserID);

        }

        private bool _AddNewToUsers()
        {

            return (this.UserID = (UsersDataAccess.AddNewToUsers(this.PersonID, this.UserName, this.Password, this.IsActive))) > 0;

        }

        private bool _UpdateUsers()
        {
            return UsersDataAccess.UpdateFromUsers(this.UserID, this.PersonID, this.UserName, this.Password, this.IsActive);
        }

        public bool UpdatePassword(string NewPassword)
        {
            return UsersDataAccess.UpdatePassword(this.UserID, NewPassword);
        }

        public static bool DeleteFromUsersByUserID(int UserID)
        {

            return UsersDataAccess.DeleteFromUsers(UserID);

        }

        public bool Save()
        {
            switch (Mode)
            {
                case enMode.AddNew:

                    if (_AddNewToUsers())
                    {
                        Mode = enMode.Update;
                        _LoadCompositions();
                        return true;
                    }
                    else return false;

                case enMode.Update:

                    if (_UpdateUsers())
                    {
                        _LoadCompositions();
                        return true;
                    }
                    else return false;

            }
            return false;
        }
        public static DataTable GetAllUsers()
        {

            return UsersDataAccess.GetAllFromUsers();

        }

        public static DataTable GetUsersSummary()
        {
            return UsersDataAccess.GetUsersSummary();
        }


    }
}
