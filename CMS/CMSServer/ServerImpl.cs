using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using Persistence.Repository;

namespace CMSServer
{
   
    class ServerImpl : MarshalByRefObject, IServer
    {
        private EditionRepository editionRepository;
        private ConferenceRepository conferenceRepository;

        public ServerImpl()
        {
            conferenceRepository = new ConferenceRepository();
            editionRepository = new EditionRepository();
            
        }

        public void AddProposal(string[] keywords, string[] topics, string abstractFileName, string paperFileName)
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

        public bool Login(string username, string password)
        {
            throw new NotImplementedException();
        }

        public void Register(string name, string affliation, string username, string password, string confirmPassword, string email, string role)
        {
            throw new NotImplementedException();
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
