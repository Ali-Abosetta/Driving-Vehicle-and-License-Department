using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BLL;

namespace DrivingVehicleLicenseDepartment.Global
{
    internal static class clsGlobal
    {
        public static BLL.Users User { get; private set; }

        private static bool _IsValidPassword(BLL.Users user, string password)
        {
            return user.Password == password;
        }
        public static bool Login(string Username, string Password)
        {

            BLL.Users tempUser = BLL.Users.FindByUserName(Username);

            if (tempUser != null && _IsValidPassword(tempUser, Password))
            {
                User = tempUser;
                return true;
            }

            return false;

        }

        public static void Logout()
        {
            User = null;
        }
    }
}
