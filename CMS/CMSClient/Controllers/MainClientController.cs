using CMSServer;
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
        AddProposalWindowController addProposalCtr;

        public MainClientController(IServer server)
        {
            this.server = server;
            addProposalCtr = new AddProposalWindowController(server);
        }

        public void SubmitProposal(string[] keywords, string[] topics, string path_to_abstract, string path_to_paper) {
            addProposalCtr.SubmitProposal(keywords, topics, path_to_abstract, path_to_paper);
        }
    }
}
