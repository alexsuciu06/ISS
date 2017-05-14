using System;

namespace CMSServer
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Server sv = new Server();
            sv.ExecuteConcurrentServer();
        }
    }
}
