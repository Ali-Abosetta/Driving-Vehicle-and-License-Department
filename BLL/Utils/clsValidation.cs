using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace BLL.Utils
{
    public static class clsValidation
    {

        private static readonly Regex EmailRegex = new Regex(@"^[^@\s]+@[^@\s]+\.[^@\s]+$",
                RegexOptions.Compiled | RegexOptions.CultureInvariant);

        public static bool IsValidEmail(string email)
        {
            if (string.IsNullOrWhiteSpace(email))
            {
                return false;
            }

            email = email.Trim();

            if (email.Contains(".."))
            {
                return false;
            }

            int at = email.IndexOf('@');

            if (at <= 0 || at >= email.Length - 1)
            {
                return false;
            }

            if (email[0] == '.' ||
                email[email.Length - 1] == '.' ||
                email[at - 1] == '.' ||
                email[at + 1] == '.')
            {
                return false;
            }

            return EmailRegex.IsMatch(email);
        }


    }
}
