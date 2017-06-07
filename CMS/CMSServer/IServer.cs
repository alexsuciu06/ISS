using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
 
 namespace CMSServer
 {
     public interface IServer
     {
         void RegisterConference(string edition, string session, string deadlineUploadPaper, string deadlineUploadAbstract, string deadlineUploadInformations
             , string deadlineLicitationProcess);
         void Register(string first_name, string last_name, string affilation, string username, string password, string email, string role);
         User Login(string username, string password, string role);
         void SendEmailConfirmation(string username, string passwoerd, string email);
         bool existsUsername(string username);
         void UploadPaper(string title, string keyWords, string topics, string authorsList, string infAboutAuthors);
         string GetHome();
         List<Review> AllAssignedReviews(int v);
         List<Edition> getAllEditions();
         List<Conference> getAllConferences();
        void AddProposal(string paper_name, string co_authors, string[] keywords, string[] topics, string path_to_abstract, string path_to_paper, User author, Edition ed);
        User GetUserByEmail(string text);
        List<Room> AllRooms();
        void AddRoom(int seats, string roomNo);
        void AddSession(Session session);
        object GetReviewsForPaper(Paper p);
        List<Session> AllSessions();
         int getIdEdition(string edition);
         List<Paper> getAllPapers(int idEdition);
         User validate(string email, string key);
         Paper findPaperById(int id);
         void AddBidding(Paper paper, BidEnum bidenum, User user);
         List<Paper> GetAllPapers();
         void CheckOrCreateDir(string uPLOADS_PATH);
         List<Bid> getAllReviewers(int id);
        void addReview(Paper p, Reviewer r);
        void UpdateReview(Review rev);
        void AddPresentation(Presentation pres);
        List<Presentation> GetPresentationForSession(int id_session);
        List<Review> AllAssignedReviews(string first_name);
        void AddEdition(Edition edition);
        void AddConference(Conference conference);
    }
 }
