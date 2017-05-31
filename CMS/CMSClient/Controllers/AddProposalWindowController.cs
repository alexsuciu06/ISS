using CMSServer;
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

        public void SubmitProposal(string[] keywords, string[] topics, string path_to_abstract, string path_to_paper)
        {
            if ( path_to_abstract != null && !(path_to_abstract.Equals("")) )
            {
                PostFileToServerTemp(path_to_abstract);
            }
            if ( path_to_paper != null && !(path_to_paper.Equals("")) )
            {
                PostFileToServerTemp(path_to_paper);
            }
            server.AddProposal(
                keywords, 
                topics, 
                Path.GetFileName(path_to_abstract), 
                Path.GetFileName(path_to_paper)
            );
        }

        private void PostFileToServerTemp(string local_path)
        {
            string SERVER_HOME_PATH = server.GetHome();
            string TEMP_UPLOADS_PATH = SERVER_HOME_PATH + "uploads\\";
            try
            {
                File.Copy(local_path, TEMP_UPLOADS_PATH + Path.GetFileName(local_path));
            }
            catch (System.Exception e)
            {
                throw new InvalidDataException(e.Message);
            }
        }
    }
}