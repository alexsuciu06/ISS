using CMSServer;
using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace CMS.Validations
{
    class ValidationData
    {
        public void validateEmail(string email)
        {
            if (!email.Contains("@"))
                throw new DataException("Email invalid");
        }

        public void validatePassword(string password, string confirm_password)
        {
            if (password.Length <= 5)
            {
                throw new DataException("Password is to short ! The password must have at least 6 characters");
            }
            if (!password.Equals(confirm_password))
                throw new DataException("Passwords are not equal");
        }

        public void validateExists(string username, string fist_name, string last_name, string affilation,string role)
        {
            if (username.Length < 3 || fist_name.Length < 3 || last_name.Length <3 || affilation.Length == 0 || role.Length == 0)
            {
                throw new DataException("Invalid data. Check if all text fields are completed");
            } 
        }

        public static void ValidatePdfFile(string filename)
        {
            Regex reg = new Regex(".*\\.pdf", RegexOptions.IgnoreCase);
            if (!reg.IsMatch(filename))
            {
                throw new DataException("Only pdf files are allowed");
            }
        }

        public static void ValidateDeadline(Edition chosen)
        {
            if(DateTime.Now.CompareTo(DateTime.Parse(chosen.Deadline)) > 0)
            {
                throw new DataException(
                    "Deadline for adding proposals was "
                  + chosen.Deadline
                );
            }
        }


    }
}
