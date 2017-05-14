using CMSServer.DB_Repository;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CMSServer
{
    class ClientWorker : Server
    {
        Repository rep = new Repository();
        private TcpClient Cl;

        public ClientWorker(TcpClient Cl)
        {
            this.Cl = Cl;
        }

        private void ReadExecuteWrite()
        {
            try
            {
                StreamReader reader = new StreamReader(Cl.GetStream());
                StreamWriter writter = new StreamWriter(Cl.GetStream());
                NumarClienti++;
                Console.WriteLine("Conexiune acceptata: " + Cl + " " + NumarClienti);
                String cePrimesc = reader.ReadLine();
                String NumeClient = cePrimesc;
                Console.WriteLine("Clientul: " + NumeClient + "  " + Cl.Client.RemoteEndPoint + " s-a logat");

                while (true)
                {
                    cePrimesc = reader.ReadLine();
                    if (cePrimesc == "Final")
                        break;

                    Console.WriteLine("Request:  " + NumeClient + "  " + Cl.Client.RemoteEndPoint + " " + cePrimesc);

                    string path = @"D:\Facultate\GitHub\ISS\CMS\log.txt";
                    // This text is added only once to the file.

                    using (StreamWriter sw = File.AppendText(path))
                    {
                        sw.WriteLine("Request:  " + NumeClient + "  " + Cl.Client.RemoteEndPoint + " " + cePrimesc);
                    }

                    String Null = "null";
                    string[] temp = cePrimesc.Split(' ');
                    //if (temp[0] == "getAll")
                    //{
                    //    List<OBJ> listOBJ = new List<OBJ>();
                    //    listOBJ = this.rep.getAll();
                    //    if (listOBJ != null)
                    //        foreach (OBJ obj in listOBJ)
                    //            writter.WriteLine(obj);
                    //    writter.WriteLine(Null);
                    //}

                    writter.Flush();
                }
                Console.WriteLine("Clientul: " + NumeClient + "  " + Cl.Client.RemoteEndPoint + " sign out");
                NumarClienti--;
                Console.WriteLine("Mai sunt legati " + NumarClienti + " clienti");
                Cl.Close();
            }
            catch (Exception e)
            {
                System.Console.WriteLine(e.StackTrace);
            }
        }

        public void ExecuteOperation()
        {
            Thread t = new Thread(new ThreadStart(ReadExecuteWrite));
            t.Start();
        }
    }
}
