using System;
using System.Net;
using System.Net.Sockets;

namespace CMSServer
{
    public class Server
    {
        public static int NumarClienti = 0;                // contor clienti
        public void ExecuteConcurrentServer()
        {
            try
            {
                IPAddress adresaLocala = IPAddress.Parse("127.0.0.1");
                TcpListener server = new TcpListener(adresaLocala, 1995);
                server.Start();
                System.Console.WriteLine("Press Ctrl-C to stop");
                while (true)
                {
                    TcpClient Cl = server.AcceptTcpClient();
                    new ClientWorker(Cl).ExecuteOperation();
                }
                server.Stop();
            }
            catch (Exception e)
            {
                System.Console.WriteLine(e.StackTrace);
            }
        }
    }
}
