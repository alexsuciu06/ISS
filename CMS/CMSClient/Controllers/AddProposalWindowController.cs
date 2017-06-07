using CMS.Validations;
using CMSServer;
using Model;
using System.IO;

namespace CMS
{
    public class AddProposalWindowController
    {
        private IServer server;

        public AddProposalWindowController(IServer server)
        {
            this.server = server;
        }

        public void SubmitProposal(string paper_name, string co_authors, string[] keywords, 
            string[] topics, string path_to_abstract, string path_to_paper, Edition current, User author)
        {
            if ( path_to_abstract != null && !(path_to_abstract.Equals("")) )
            {
                ValidationData.ValidatePdfFile(path_to_abstract);
                PostPaperToServerTemp(path_to_abstract, current, author, "Abstract");
            }
            if ( path_to_paper != null && !(path_to_paper.Equals("")) )
            {
                ValidationData.ValidatePdfFile(path_to_paper);
                PostPaperToServerTemp(path_to_paper, current, author, "Paper");
            }
            ValidationData.ValidateDeadline(current);
            server.AddProposal(
                paper_name,
                co_authors,
                keywords, 
                topics, 
                path_to_abstract, 
                path_to_paper,
                author, 
                current
            );
        }

        private void PostPaperToServerTemp(string local_path, Edition current, User author, string final_dir)
        {
            try
            {
                string uploads_path = getPaperUploadsPath(current, author, final_dir);
                server.CheckOrCreateDir(uploads_path);
                File.Copy(local_path, uploads_path + Path.GetFileName(local_path), true);
            }
            catch (System.Exception e)
            {
                throw new DataException(e.Message);
            }
        }

        private string getPaperUploadsPath(Edition current, User author, string final_dir)
        {
            string SERVER_HOME_PATH = server.GetHome();
            string UPLOADS_PATH = SERVER_HOME_PATH + "uploads\\"
                + current.Conference.IdConference + "\\"
                + current.IdEdition + "\\" 
                + author.Id + "\\"
                +final_dir + "\\";

            return UPLOADS_PATH;
        }
    }
}