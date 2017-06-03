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
   
    class ServerImpl : MarshalByRefObject, IServer
    {
        private EditionRepository editionRepository;
        private ConferenceRepository conferenceRepository;
	private UserRepository userRepo = new UserRepository();
			
        public ServerImpl()
        {
            conferenceRepository = new ConferenceRepository();
            editionRepository = new EditionRepository();
            
        }
        
        PaperRepository paerRepo = new PaperRepository();
        AbstractRepository abstractRepo = new AbstractRepository();
        PaperMetaInfRepository metaInfoRepo = new PaperMetaInfRepository();

        public void AddProposal(string[] keywords, string[] topics, string abstractFileName, string paperFileName)
        { 
            PaperMetaInformation metaInfo = new PaperMetaInformation(Path.GetFileName(paperFileName), string.Join(",", keywords));
            Abstract abs = new Abstract(abstractFileName);
            Paper paper = new Paper(paperFileName, abs, metaInfo);
            metaInfoRepo.Save(metaInfo);
            abstractRepo.Save(abs);
            paerRepo.Save(paper);
        }

        public bool existsUsername(string username)
        {
            throw new NotImplementedException();
        }

        public List<Edition> getAllEditions()
        {
            throw new NotImplementedException();
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

        public List<Edition> getAllEditions()
        {
            throw new NotImplementedException();
        }

        public List<Paper> getAllPapers(int idEdition)
        {
            throw new NotImplementedException();
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

        public void Register(string name, string affliation, string username, string password, string confirmPassword, string email, string role)
        {
            throw new NotImplementedException();
        }

        public void Register(string first_name, string last_name, string affilation, string username, string password, string email, string role)
        {
            User new_user = new User(first_name, last_name, affilation, username, password, email, role);
            userRepo.Save(new_user);

            Random rnd = new Random();
            int key = 1000 + rnd.Next(5000);
            
            SendEmail mail = new SendEmail(new System.Net.Mail.MailAddress(email), "Validation", key.ToString());
            mail.send();
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
    }
}
