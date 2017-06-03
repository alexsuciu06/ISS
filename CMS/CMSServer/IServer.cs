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
         bool Login(string username, string password);
         void Register(string name, string affliation, string username, string password, string confirmPassword, string email, string role);
         void SendEmailConfirmation(string username, string passwoerd, string email);
         bool existsUsername(string username);
         void UploadPaper(string title, string keyWords, string topics, string authorsList, string infAboutAuthors);
         string GetHome();
         void AddProposal(string[] keywords, string[] topics, string abstractFileName, string paperFileName);
         List<Edition> getAllEditions();
         List<Conference> getAllConferences();
        int getIdEdition(string edition);
         List<Paper> getAllPapers(int idEdition);
     }
 }