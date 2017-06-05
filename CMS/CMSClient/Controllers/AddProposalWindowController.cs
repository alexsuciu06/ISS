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
                PostFileToServerTemp(path_to_abstract, current);
            }
            if ( path_to_paper != null && !(path_to_paper.Equals("")) )
            {
                ValidationData.ValidatePdfFile(path_to_paper);
                PostFileToServerTemp(path_to_paper, current);
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

        private void PostFileToServerTemp(string local_path, Edition current)
        {
            
            try
            {
                string uploads_path = getUploadsPath(current);
                server.CheckOrCreateDir(uploads_path);
                File.Copy(local_path, uploads_path + Path.GetFileName(local_path));
            }
            catch (System.Exception e)
            {
                throw new DataException(e.Message);
            }
        }

        private string getUploadsPath(Edition current)
        {
            string SERVER_HOME_PATH = server.GetHome();
            string UPLOADS_PATH = SERVER_HOME_PATH + "uploads\\"
                + current.Conference.IdConference + "\\"
                + current.IdEdition + "\\";

            return UPLOADS_PATH;
        }
    }
}