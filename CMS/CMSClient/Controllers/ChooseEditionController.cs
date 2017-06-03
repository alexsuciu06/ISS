using CMSServer;
using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMS.Controllers
{
    public class ChooseEditionController
    {
        private IServer server;

        public ChooseEditionController(IServer server)
        {
            this.server = server;
        }

        public List<Edition> GetAll()
        {
            return server.getAllEditions();
        }

        public List<Conference> GetAllConferences()
        {
            return server.getAllConferences();
        }
    }
}
