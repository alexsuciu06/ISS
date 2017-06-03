<<<<<<< Updated upstream
﻿using CMSServer;
=======
﻿using CMSServer;
>>>>>>> Stashed changes
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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
            /*if (!server.validateUserName(username))
                throw new DataException("This username is already exists");*/
        }

        //public bool validate
    }
}
