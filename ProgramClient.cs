using FightsReservation;
using FightsReservation.Controller;
using System;
using System.Windows.Forms;
using System.Runtime.Remoting.Channels;
using System.Runtime.Remoting.Channels.Tcp;
using System.Collections;
using FlightsAppClient;
using FightsReservation.ServicesN;

namespace FlightsReservation
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //IServices server = new FligthsAppServerProxy("127.0.0.1", 4444);

            BinaryServerFormatterSinkProvider serverProv = new BinaryServerFormatterSinkProvider();
            serverProv.TypeFilterLevel = System.Runtime.Serialization.Formatters.TypeFilterLevel.Full;
            BinaryClientFormatterSinkProvider clientProv = new BinaryClientFormatterSinkProvider();
            IDictionary props = new System.Collections.Hashtable();

            props["port"] = 0;
            TcpChannel channel = new TcpChannel(props, clientProv, serverProv);
            ChannelServices.RegisterChannel(channel, false);
            IServices server =
                (IServices)Activator.GetObject(typeof(IServices), "tcp://localhost:55555/Chat");

            ClientCtrl ctrl = new ClientCtrl(server);
            LoginWindow loginWin = new LoginWindow(ctrl);
            Application.Run(loginWin);
        }
    }
}
