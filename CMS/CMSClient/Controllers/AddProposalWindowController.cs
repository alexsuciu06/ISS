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

        public void SubmitProposal(string[] keywords, string[] topics, string path_to_abstract, string path_to_paper, Edition current)
        {
            if ( path_to_abstract != null && !(path_to_abstract.Equals("")) )
            {
                PostFileToServerTemp(path_to_abstract, current);
            }
            if ( path_to_paper != null && !(path_to_paper.Equals("")) )
            {
                PostFileToServerTemp(path_to_paper, current);
            }
            server.AddProposal(
                keywords, 
                topics, 
                Path.GetFileName(path_to_abstract), 
                Path.GetFileName(path_to_paper)
            );
        }

        private void PostFileToServerTemp(string local_path, Edition current)
        {
            string SERVER_HOME_PATH = server.GetHome();
            string UPLOADS_PATH = SERVER_HOME_PATH + "uploads\\" 
                + current.Conference.IdConference + "\\" 
                + current.IdEdition + "\\";
            try
            {
                File.Copy(local_path, UPLOADS_PATH + Path.GetFileName(local_path));
            }
            catch (System.Exception e)
            {
                throw new DataException(e.Message);
            }
        }
    }
}