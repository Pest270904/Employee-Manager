﻿using Employee_Manager.Main_forms;
using Employee_Manager.Others;
using FireSharp.Interfaces;
using FireSharp.Response;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static ServiceStack.Diagnostics.Events;


namespace Employee_Manager.Child_Forms
{
    public partial class AdminChat_ChildForm : Form
    {
        private TcpClient client;
        private NetworkStream stream;

        private readonly string serverIp = "127.0.0.1";
        private readonly int serverPort = 2004;

        private Userdata currentUser;
        private IFirebaseClient clientFB;

        public AdminChat_ChildForm(Userdata user)
        {
            InitializeComponent();
            this.currentUser = user;

            chat_box.ReadOnly = true;

            clientFB = FirebaseSetup.InitializeFirebase();

            ConnectToServer();
            PopulateUserComboBox();

            sendBtn.Enabled = false;
        }

        private void userList_TextChanged(object sender, EventArgs e)
        {
            chat_box.Clear();
            message_box.Clear();
            LoadMessage(userList.Text);
            
            sendBtn.Enabled = true;
        }

        private void PopulateUserComboBox()
        {
            FirebaseResponse resp = clientFB.Get("users/");
            Dictionary<string, Data> result = resp.ResultAs<Dictionary<string, Data>>();

            if (result != null)
            {
                foreach (var user in result)
                {
                    if (user.Value.username != "admin")
                        userList.Items.Add(user.Value.username);
                }
            }
        }

        private void LoadMessage(string receiver)
        {
            FirebaseResponse resp = clientFB.Get("messages/message/");
            Dictionary<string, MessageContent> result;

            if (resp.Body != "null")
            {
                result = resp.ResultAs<Dictionary<string, MessageContent>>();
            }
            else
            {
                result = new Dictionary<string, MessageContent>();
            }

            foreach (var msg in result)
            {
                string sender = msg.Value.sender;
                string receiver_msg = msg.Value.receiver;

                if ((sender == "admin" && receiver_msg == receiver) || sender == receiver)
                {
                    string message = $"{msg.Value.sender}: {msg.Value.content}\r\n";
                    chat_box.AppendText(message);
                }
            }
            chat_box.ScrollToCaret();
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);
            client?.Close();
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

                    string[] splitStr = receivedMessage.Split(':');

                    if (splitStr[1] != userList.Text)
                        continue;

                    string msg = "";
                    for (int i = 1; i < splitStr.Length; i++) 
                    {
                        msg += splitStr[i];
                        if (i == 1)
                            msg += ": ";
                    }

                    Invoke((Action)(() => {
                        chat_box.AppendText(msg);
                        chat_box.ScrollToCaret();
                    }));
                }
            }
            catch (Exception ex) when (ex is ObjectDisposedException || ex is InvalidOperationException)
            {
                //MessageBox.Show("Disconnected from the server.");
            }
        }

        private void ConnectToServer()
        {
            try
            {
                client = new TcpClient();
                client.Connect(serverIp, serverPort);
                stream = client.GetStream();
                //MessageBox.Show("Connected to the server!");

                Task.Run(ReceiveMessages);
            }
            catch (SocketException ex)
            {
                MessageBox.Show("Failed to connect to the server: " + ex.Message);
            }
        }

        private async void sendBtn_Click(object sender, EventArgs e)
        {
            if (client == null || !client.Connected)
            {
                //MessageBox.Show("Not connected to the server!");
                return;
            }

            if (!String.IsNullOrEmpty(message_box.Text))
            {
                string message = $"{currentUser.username}: {message_box.Text}\r\n";
                string send_msg = $"{userList.Text}:{currentUser.username}: {message_box.Text}\r\n";
                chat_box.AppendText(message);

                byte[] data = Encoding.UTF8.GetBytes(send_msg);
                stream.Write(data, 0, data.Length);

                FirebaseResponse respGet = clientFB.Get("messages/");
                Messages result = respGet.ResultAs<Messages>();

                var dataLayer = new MessageContent
                {
                    content = message_box.Text,
                    sender = currentUser.username,
                    receiver = userList.Text
                };

                SetResponse respSetMsg = await clientFB.SetTaskAsync("messages/message/m" + result.count.ToString(), dataLayer);
                SetResponse respSetCount = clientFB.Set("messages/count", result.count + 1);

                message_box.Clear();
                this.ActiveControl = message_box;
            }
        }
    }
}
