using CMSServer;
using Model;
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

        public MainClientController(IServer server)
        {
            this.server = server;
            addProposalCtr = new AddProposalWindowController(server);
            chooseEditionController = new ChooseEditionController(server);
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
      
    }
}
