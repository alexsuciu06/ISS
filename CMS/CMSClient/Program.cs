using System;
using System.Windows.Forms;
using System.Runtime.Remoting.Channels;
using System.Runtime.Remoting.Channels.Tcp;
using System.Collections;

namespace CMS
{
    public class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>

        static ClientCtrl ctrl=null;
        [STAThread]
        static void Main()
        {
            Application.ApplicationExit += new EventHandler(OnApplicationExit);

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

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            LoginWindow loginWin = new LoginWindow(ctrl);
            Application.Run(loginWin);
        }

        private static void OnApplicationExit(object sender, EventArgs e)
        {
            //MessageBox.Show(ctrl.ToString());
            Console.WriteLine("TEST");
        }
    }
}
