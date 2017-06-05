using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using Persistence.Repository;
using System.IO;
using System.Timers;

namespace CMSServer
{
   
    public class ServerImpl : MarshalByRefObject, IServer
    {
        private EditionRepository editionRepository;
        private ConferenceRepository conferenceRepository;
        private PaperRepository paperRepo;
        private BidRepository bidRepo;
        private UserRepository userRepo;
        private ReviewRepository reviewRepo;
        private ReviewerRepository reviewerRepo;
        private TopicsRepository topicsRepo = new TopicsRepository();
        private MetaInformationTopicsRepository metaTopicsRepo = new MetaInformationTopicsRepository();
        PaperRepository paerRepo = new PaperRepository();
        AbstractRepository abstractRepo = new AbstractRepository();
        PaperMetaInfRepository metaInfoRepo = new PaperMetaInfRepository();
        RoomRepository roomRepo = new RoomRepository();
        SessionRepository sessionRepo = new SessionRepository();
        PresentationRepository presRepo = new PresentationRepository();

        public ServerImpl()
        {
            conferenceRepository = new ConferenceRepository();
            editionRepository = new EditionRepository();
            paperRepo = new PaperRepository();
            bidRepo = new BidRepository();
            userRepo = new UserRepository();
            reviewRepo = new ReviewRepository();
            reviewerRepo = new ReviewerRepository();
        }

        public void AddProposal(string paper_name, string co_authors, 
            string[] keywords, string[] topics, string abstractFileName, string paperFileName, 
            User author, Edition ed)
        { 
            PaperMetaInformation metaInfo = new PaperMetaInformation(paper_name, string.Join(",", keywords), author, co_authors);
            metaInfoRepo.Save(metaInfo);
            foreach (string topic in topics) {
                Topic t = new Topic(topic);
                topicsRepo.Save(t);
                MetaInformationTopics mit = new MetaInformationTopics(t, metaInfo);
                metaTopicsRepo.Save(mit);
            }
            
            Abstract abs = (abstractFileName != "") ? new Abstract(abstractFileName) : null;
            Paper paper = (paperFileName != "") ? new Paper(paperFileName, abs, metaInfo, ed) : null;
            if (abs != null)
                { abstractRepo.Save(abs); }
            if (paper != null)
                { paerRepo.Save(paper); }
        }

        public bool existsUsername(string username)
        {
            throw new NotImplementedException();
        }

        public List<Conference> getAllConferences()
        {
            return conferenceRepository.GetAll();
        }

        public List<Edition> getAllEditions()
        {
            return editionRepository.GetAll();
        }

        public List<Paper> getAllPapers(int idEdition)
        {

            return paperRepo.GetByEdition(idEdition);

        }

        public string GetHome()
        {
            return System.AppDomain.CurrentDomain.BaseDirectory;
        }

        public int getIdEdition(string edition)
        {
            throw new NotImplementedException();
        }

        public User Login(string username, string password, string role)
        {
            return userRepo.GetByUsernameAndRole(username, role);
            
        }

        public void Register(string first_name, string last_name, string affilation, string username, string password, string email, string role)
        {
            Random rnd = new Random();
            int key = 1000 + rnd.Next(5000);

            User new_user = new User(first_name, last_name, affilation, username, password, email, role,key);
            userRepo.Save(new_user);
            
            SendEmail mail = new SendEmail(new System.Net.Mail.MailAddress(email), "Validation", key.ToString());
            mail.send();
        }

        public User validate(string email, string key)
        {
            return userRepo.UpdateValidationState(email, key);
        }

        public void RegisterConference(string edition, string session, string deadlineUploadPaper, string deadlineUploadAbstract, string deadlineUploadInformations, string deadlineLicitationProcess)
        {
            throw new NotImplementedException();
        }

        public void SendEmailConfirmation(string username, string passwoerd, string email)
        {
            throw new NotImplementedException();
        }

        public void UploadPaper(string title, string keyWords, string topics, string authorsList, string infAboutAuthors)
        {
            throw new NotImplementedException();
        }


        public Paper findPaperById(int id)
        {
            return paperRepo.Get(id);
        }

        public void AddBidding(Paper paper, BidEnum bidenum, User user)
        {
            bidRepo.Save(new Bid(user, bidenum, paper));
        }

        public List<Paper> GetAllPapers()
        {
            try
            {
                return paperRepo.GetAll();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            return null;
        }

        public void CheckOrCreateDir(string dir_path)
        {
            try
            {
                if (Directory.Exists(dir_path))
                {
                    return;
                }
                DirectoryInfo di = Directory.CreateDirectory(dir_path);
            }
            catch (Exception e)
            {
                Console.WriteLine("The process failed: {0}", e.ToString());
            }
        }

        public List<Review> AllAssignedReviews(int reviewer_id)
        {
            return reviewRepo.AssignedReviews(reviewer_id);
        }


        public List<Bid> getAllReviewers(int id)
        {
            try
            {
                return bidRepo.GetAllRewersById(id);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            return null;
        }

        public void addReview(Paper p, Reviewer r)
        {
            reviewerRepo.Save(r);
            Review re = new Review( r, null, p, null);
            reviewRepo.Save(re);
        }

        public void UpdateReview(Review rev)
        {
            if (rev.Recomandation != null)
            {
                new RecomandationRepository().Save(rev.Recomandation);
            }
            reviewRepo.Update(rev);
        }

        public object GetReviewsForPaper(Paper p)
        {
            return reviewRepo.GetForPaper(p);
        }

        public void AddRoom(int seats, string room_no)
        {
            roomRepo.Save(new Room(int.Parse(room_no), seats));
        }

        public List<Room> AllRooms()
        {
            return roomRepo.GetAll();
        }

        public User GetUserByEmail(string email)
        {
            return userRepo.GetByEmail(email);
        }

        public void AddSession(Session session)
        {
            sessionRepo.Save(session);    
        }

        public List<Session> AllSessions()
        {
            return sessionRepo.GetAll();
        }

        public void AddPresentation(Presentation pres)
        {
            presRepo.Save(pres);
        }

        public List<Presentation> GetPresentationForSession(int id_session)
        {
            return presRepo.AllForSession(id_session);
        }

    }
}
