using System;
using System.IO;
using System.Net.Sockets;
using System.Windows.Forms;

namespace CMS
{
    public class ConnectServer
    {
        TcpClient client;
        string NumeCli = Environment.MachineName;

        public ConnectServer()
        {
            try
            {
                Conectare();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }
        }

        public void Conectare()
        {
            //conectare la server
            try
            {
                client = new TcpClient("127.0.0.1", 1995);
                StreamReader reader = new StreamReader(client.GetStream());
                StreamWriter writer = new StreamWriter(client.GetStream());
                writer.AutoFlush = true;
                writer.WriteLine("Contabil : " + NumeCli);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void Deconectare()
        {
            //deconectare de la server
            try
            {
                StreamWriter writer = new StreamWriter(client.GetStream());
                writer.AutoFlush = true;
                writer.WriteLine("Final");
                client.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Disconect fail.\n" + ex.Message);
            }
        }
    }
}
