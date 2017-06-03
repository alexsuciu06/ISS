<<<<<<< Updated upstream
﻿using CMSServer;
using Model;
<<<<<<< Updated upstream
=======
﻿using CMS.Controlers;
using CMSServer;
>>>>>>> Stashed changes
=======
>>>>>>> Stashed changes
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMS.Controllers
{
    public class MainClientController
    {
        private IServer server;
        private int idCurrentEdition;

        AddProposalWindowController addProposalCtr;
        ChooseEditionController chooseEditionController;
        RegisterController registerCtr;
        LoginController loginCtr;
        User current_user = null;

        public MainClientController(IServer server)
        {
            this.server = server;
            addProposalCtr = new AddProposalWindowController(server);
            chooseEditionController = new ChooseEditionController(server);
            this.registerCtr = new RegisterController(server);
        }

        public void register(string first_name, string last_name, string affilation, string username, string password, string email, string role)
        {
            registerCtr.register(first_name, last_name, affilation, username, password, email, role);
            loginCtr = new LoginController(server);
        }

        public void SubmitProposal(string[] keywords, string[] topics, string path_to_abstract, string path_to_paper) {
            addProposalCtr.SubmitProposal(keywords, topics, path_to_abstract, path_to_paper);
        }


        public List<Edition> GetAllEditions()
        {
            return chooseEditionController.GetAll();
        }

        public int IdCurrentEdition
        {
            get
            {
                return idCurrentEdition;
            }

            set
            {
                this.idCurrentEdition = value;
            }
        } 

        public List<Conference> GetAllConferences()
        {
            return chooseEditionController.GetAllConferences();
        }
      

        public void Login(string username, string password, string role)
        {
            current_user = loginCtr.Login(username, password, role);
        }
    }
}
