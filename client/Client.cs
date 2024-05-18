using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;
using System.Threading;
using System.IO;

namespace client
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Connect();
            Send();
        }
        IPEndPoint ipe;
        TcpClient tcpClient;
        Stream stream;
        void Connect()
        {
            ipe = new IPEndPoint(IPAddress.Parse("127.0.0.1"), 9999);
            tcpClient = new TcpClient();
            tcpClient.Connect(ipe);
            stream = tcpClient.GetStream();
            Thread recv = new Thread(Receive);
            recv.IsBackground = true;
            recv.Start();

        }
        void Send()
        {
            byte[] data = Encoding.UTF8.GetBytes(tboxMess.Text);
            stream.Write(data, 0, data.Length);
            Addmessage(tboxMess.Text);
        }
        void Receive()
        {
            while (true)
            {
                byte[] recv = new byte[1024];
                stream.Read(recv, 0, recv.Length);
                string s = Encoding.UTF8.GetString(recv);
                Addmessage(s);
            }

        }
        void Addmessage(string message)
        {
            lvMess.Items.Add(message);
        }
    }
}
