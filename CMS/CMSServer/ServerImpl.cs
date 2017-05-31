using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;

namespace CMSServer
{
    class ServerImpl : MarshalByRefObject, IServer
    {
        public void AddProposal(string[] keywords, string[] topics, string abstractFileName, string paperFileName)
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
