using CMSServer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CMS.Controlers
{
    class RegisterController
    {
        private IServer server;
        public RegisterController(IServer server)
        {
            this.server = server;
        }

        public IServer getServer()
        {
            return server;
        }

        public void register(string first_name, string last_name,string affilation, string username,string password, string email, string role)
        {
            try
            {
                server.Register(first_name, last_name, affilation, username, password, email, role);
                MessageBox.Show("You will receive a confirmation mail");
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

    }
}
