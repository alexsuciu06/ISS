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

        public List<Paper> GetAllPapers()
        {
            try
            {
                return server.GetAllPapers();
            }
            catch(Exception e)
            {
                MessageBox.Show(e.Message);
            }
            return null;
        }

        public void AddBidding(Paper paper, string bidEnum, User currentUser)
        {
            BidEnum bide = (BidEnum)Enum.Parse(typeof(BidEnum), bidEnum);
            server.AddBidding(paper, bide, currentUser);
        }
    }
}
