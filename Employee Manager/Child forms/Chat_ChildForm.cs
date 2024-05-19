using FireSharp.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.ComponentModel;
using System.Data;
using System.Net;
using System.Threading;
using System.Net.Sockets;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Employee_Manager.Child_Forms
{
    public partial class Chat_ChildForm : Form
    {
        private TcpClient client;
        private NetworkStream stream;

        private readonly string serverIp = "127.0.0.1";
        private readonly int serverPort = 2004;
        string name = string.Empty;
        private Userdata currentUser;
        public Chat_ChildForm(Userdata user)
        {
            InitializeComponent();
            chat_box.ReadOnly = true;

        //this.ActiveControl = name_box;
            ConnectToServer();
            this.currentUser = user;
            name = currentUser.username;
        }

        private void ConnectToServer()
        {
            try
            {
                client = new TcpClient();
                client.Connect(serverIp, serverPort);
                stream = client.GetStream();
                MessageBox.Show("Connected to the server!");

                Task.Run(ReceiveMessages);
            }
            catch (SocketException ex)
            {
                MessageBox.Show("Failed to connect to the server: " + ex.Message);
            }
        }

        private async Task ReceiveMessages()
        {
            try
            {
                while (true)
                {
                    byte[] buffer = new byte[1024];
                    int bytesRead = await stream.ReadAsync(buffer, 0, buffer.Length);
                    string receivedMessage = Encoding.UTF8.GetString(buffer, 0, bytesRead);

                    Invoke((Action)(() =>
                    {
                        chat_box.AppendText(receivedMessage);
                        chat_box.ScrollToCaret();
                    }));
                }
            }
            catch (Exception ex) when (ex is ObjectDisposedException || ex is InvalidOperationException)
            {
                MessageBox.Show("Disconnected from the server.");
            }
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);
            client?.Close();
        }


        private void send_btn_Click(object sender, EventArgs e)
        {
            if (client == null || !client.Connected)
            {
                MessageBox.Show("Not connected to the server!");
                return;
            }

            string message = $"{name}: {message_box.Text}\r\n";
            chat_box.AppendText(message);

            byte[] data = Encoding.UTF8.GetBytes(message);
            stream.Write(data, 0, data.Length);

            message_box.Text = "";
            this.ActiveControl = message_box;
        }
    }
}
