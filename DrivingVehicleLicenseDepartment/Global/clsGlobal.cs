using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BLL;
using Microsoft.Win32;

namespace DrivingVehicleLicenseDepartment.Global
{
    internal static class clsGlobal
    {
        private static readonly string _KeyPath = @"HKEY_CURRENT_USER\SOFTWARE\DVLD";
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

        public static bool RememberCredentials(string username, string password)
        {

            bool result = false;

            try
            {

                Registry.SetValue(_KeyPath, "Username", username, RegistryValueKind.String);
                Registry.SetValue(_KeyPath, "Password", password, RegistryValueKind.String);

                result = true;
            }
            catch (Exception ex)
            {
                throw;
            }

            return result;
        }

        public static bool GetRememberedCredentials(out string username, out string password)
        {
            username = string.Empty;
            password = string.Empty;

            bool isFound = false;

            try
            {
                username = Registry.GetValue(_KeyPath, "Username", null)?.ToString();
                password = Registry.GetValue(_KeyPath, "Password", null)?.ToString();

                if (!string.IsNullOrWhiteSpace(username))
                {
                    isFound = true;
                }
            }
            catch (Exception ex)
            {
                throw;
            }

            return isFound;
        }

        public static void Logout()
        {
            User = null;
        }
    }
}
