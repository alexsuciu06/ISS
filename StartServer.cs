using FightsReservation.ServicesN;
using System.Runtime.Remoting.Channels;
using System.Runtime.Remoting.Channels.Tcp;
using System;
using System.Collections;
using System.Runtime.Remoting;

namespace FlightsReservation.Server
{
    class StartServer
    {
        static void Main(string[] args)
        {
            //IServices services = new Services();
            //FlightsAppServer server = new FlightsAppServer("127.0.0.1", 4444, services);
            //server.Start();
            //Console.WriteLine("Server started ...");

            BinaryServerFormatterSinkProvider serverProv = new BinaryServerFormatterSinkProvider();
            serverProv.TypeFilterLevel = System.Runtime.Serialization.Formatters.TypeFilterLevel.Full;
            BinaryClientFormatterSinkProvider clientProv = new BinaryClientFormatterSinkProvider();

            IDictionary props = new Hashtable();
            props["port"] = 55555;

            TcpChannel channel = new TcpChannel(props, clientProv, serverProv);
            ChannelServices.RegisterChannel(channel, false);

            
            var server = new Services();
            //var server = new ChatServerImpl();
            RemotingServices.Marshal(server, "Chat");
            //RemotingConfiguration.RegisterWellKnownServiceType(typeof(ChatServerImpl), "Chat",
            //    WellKnownObjectMode.Singleton);

            // the server will keep running until keypress.
            Console.WriteLine("Server started ...");
            Console.WriteLine("Press <enter> to exit...");
            Console.ReadLine();
        }
    }
}
