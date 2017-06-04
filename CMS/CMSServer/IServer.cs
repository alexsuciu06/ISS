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
         void AddProposal(string[] keywords, string[] topics, string abstractFileName, string paperFileName);
         List<Edition> getAllEditions();
         List<Conference> getAllConferences();
         int getIdEdition(string edition);
         List<Paper> getAllPapers(int idEdition);
        User validate(string email, string key);
         Paper findPaperById(int id);
         void AddBidding(Paper paper, BidEnum bidenum, User user);
         List<Paper> GetAllPapers();
     }
 }
