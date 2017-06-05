using Model;
using CMS.Controlers;
using CMSServer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CMS.Validations;
using System.Windows.Forms;

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
        AssignReviwersController assignedReviwersCtr;
        User current_user = null;

        public MainClientController(IServer server)
        {
            this.server = server;
            this.addProposalCtr = new AddProposalWindowController(server);
            this.chooseEditionController = new ChooseEditionController(server);
            this.registerCtr = new RegisterController(server);
            this.bidController = new BiddingPageController(server);
            this.assignedReviwersCtr = new AssignReviwersController(server);
            this.loginCtr = new LoginController(server);
        }

        public User GetUserByEmail(string text)
        {
            return server.GetUserByEmail(text);
        }

        public void AddSession(Session session)
        {
            server.AddSession(session);
        }

        public List<Session> AllSessions()
        {
            return server.AllSessions();
        }

        public List<Room> AllRooms()
        {
            return server.AllRooms();
        }

        public void AddNewRoom(int seats, string RoomNo)
        {
            server.AddRoom(seats, RoomNo);
        }

        internal object GetReviewsForPaper(Paper p)
        {
            return server.GetReviewsForPaper(p);
        }

        public List<Review> GetAssignedReviews()
        {
            return server.AllAssignedReviews(CurrentUser.Id);
        }

        public void register(string first_name, string last_name, string affilation, string username, string password, string email, string role)
        {
            registerCtr.register(first_name, last_name, affilation, username, password, email, role);
            loginCtr = new LoginController(server);
        }

        public void AddPresentation(Presentation pres)
        {
            server.AddPresentation(pres);
        }

        public void validation(string email, string key)
        {
            current_user = server.validate(email, key);
            if (current_user == null)
            {
                throw new DataException("Key is not valid");
            }
        }

        public List<Presentation> GetPresentationsForSession(int idSession)
        {
            return server.GetPresentationForSession(idSession);
        }

        public List<Paper> getAllPapersForEdition()
        {
            return server.getAllPapers(CurrentEdition.IdEdition);
        }

        public void SubmitProposal(string paper_name, string co_authors, string[] keywords, 
            string[] topics, string path_to_abstract, string path_to_paper)
        {
            addProposalCtr.SubmitProposal(paper_name, co_authors, keywords, topics, path_to_abstract, 
                path_to_paper, currentEdition, current_user);
        }

        public void SubmitReview(Review rev)
        {
            server.UpdateReview(rev);
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

        public User CurrentUser
        {
            get
            {
                return current_user;
            }
            set
            {
                current_user = value;
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


        public void AddBidding(Paper paper, string bidEnum)
        {
            bidController.AddBidding(paper, bidEnum, current_user);
        }

        public List<Bid> getAllReviwers(int id)
        {
            try
            {
                return server.getAllReviewers(id);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            return null;
        }

        public List<Paper> getAllReviwers()
        {
            try
            {
                return server.GetAllPapers();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            return null;
        }

        public List<Paper> GetAllPapers()
        {
            try
            {
                return server.GetAllPapers();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            return null;
        }

        public void addReview(Paper p,Reviewer r)
        {
            server.addReview(p, r);
        }

    }
}
