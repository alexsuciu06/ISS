using Model;
using CMS.Controlers;
using CMSServer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CMS.Validations;

namespace CMS.Controllers
{
    public class MainClientController
    {
        private IServer server;
        BiddingPageController bidController;
        Edition currentEdition;
        AddProposalWindowController addProposalCtr;
        ChooseEditionController chooseEditionController;
        RegisterController registerCtr;
        LoginController loginCtr;
        User current_user = null;

        public MainClientController(IServer server)
        {
            this.server = server;
            this.addProposalCtr = new AddProposalWindowController(server);
            this.chooseEditionController = new ChooseEditionController(server);
            this.registerCtr = new RegisterController(server);
            this.bidController = new BiddingPageController(server);
            loginCtr = new LoginController(server);
        }

        public List<Review> GetAssignedReviews()
        {
            return server.AllAssignedReviews(1);
        }

        public void register(string first_name, string last_name, string affilation, string username, string password, string email, string role)
        {
            registerCtr.register(first_name, last_name, affilation, username, password, email, role);
            loginCtr = new LoginController(server);
        }

        public void validation(string email, string key)
        {
            current_user = server.validate(email, key);
            if (current_user == null)
            {
                throw new DataException("Key is not valid");
            }
        }

        public void SubmitProposal(string[] keywords, string[] topics, string path_to_abstract, string path_to_paper) {
            addProposalCtr.SubmitProposal(keywords, topics, path_to_abstract, path_to_paper, currentEdition);
        }


        public List<Edition> GetAllEditions()
        {
            return chooseEditionController.GetAll();
        }

        public Edition CurrentEdition
        {
            get
            {
                return currentEdition;
            }

            set
            {
                this.currentEdition = value;
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


        public void AddBidding(int idPaper, string bidEnum)
        {
            bidController.AddBidding(idPaper, bidEnum, current_user);
        }

        public List<Paper> GetAllPapers()
        {
            return bidController.GetAllPapers();
        }
    }
}
