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

        public void validatePassword(string password,string confirm_password)
        {
            if (!password.Equals(confirm_password))
                throw new DataException("Passwords are not equal");
        }

        public void validateUsername(IServer server, string username)
        {
            //if (!server.validateUserName(username))
            //    throw new DataException("This username is already exists");
            //if (!server.validateUserName(username))
            //    throw new DataException("This username is already exists");
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
