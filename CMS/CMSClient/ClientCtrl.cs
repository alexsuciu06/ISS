namespace CMS
{
    public class ClientCtrl
    {
        private IServices server;

        public ClientCtrl()
        {
        }

        public ClientCtrl(IServices server)
        {
            this.server = server;
        }
    }
}