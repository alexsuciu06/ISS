using CMSServer;
using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CMS
{
    public class BiddingPageController
    {
        private IServer server;

        public BiddingPageController(IServer server)
        {
            this.server = server;
        }

        public void AddBidding(int idPaper, string bidEnum, User currentUser)
        {
            Paper paper = server.findPaperById(idPaper);
            BidEnum bide = (BidEnum)Enum.Parse(typeof(BidEnum), bidEnum);
            server.AddBidding(paper, bide, currentUser);
        }
    }
}
