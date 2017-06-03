using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CMSServer;
using CMS.Validations;
using Model;

namespace CMS.Controllers
{
    class LoginController
    {
        IServer server;

        public LoginController(IServer server)
        {
            this.server = server;
        }

        public User Login(string username, string password, string role)
        {
            if (username.Equals(""))
            {
                throw new DataException("Username can't be empty");
            }
            if (password.Equals(""))
            {
                throw new DataException("Password can't be empty");
            }
            if (role.Equals(""))
            {
                throw new DataException("You must select a role");
            }
            User user = server.Login(username, password, role);
            if (user == null)
            {
                throw new DataException("This username does not exist with this role");
            }
            else if (!user.Password.Equals(password))
            {
                throw new DataException("Password is not valid");
            } else
            {
                return user;    
            }
        }
    }
}
