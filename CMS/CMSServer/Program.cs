using Model;
using Persistence;
using Persistence.Repository;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Remoting;
using System.Runtime.Remoting.Channels;
using System.Runtime.Remoting.Channels.Tcp;

namespace CMSServer
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            CreateDatabase db = new CreateDatabase();
            UserRepository userRepo = new UserRepository();
            ConferenceRepository conferenceRepo = new ConferenceRepository();
            EditionRepository editionRepo = new EditionRepository();

            BinaryServerFormatterSinkProvider serverProv = new BinaryServerFormatterSinkProvider();
            serverProv.TypeFilterLevel = System.Runtime.Serialization.Formatters.TypeFilterLevel.Full;
            BinaryClientFormatterSinkProvider clientProv = new BinaryClientFormatterSinkProvider();

            IDictionary props = new Hashtable();
            props["port"] = 55555;

            TcpChannel channel = new TcpChannel(props, clientProv, serverProv);
            ChannelServices.RegisterChannel(channel, false);


            var server = new ServerImpl();
            RemotingServices.Marshal(server, "Chat");

            Console.WriteLine("Server started ...");
            Console.WriteLine("Press <enter> to exit...");
            Console.ReadLine();
        }
    }
}
