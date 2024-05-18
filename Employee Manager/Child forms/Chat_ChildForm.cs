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
        public Chat_ChildForm()
        {
            InitializeComponent();
            Control.CheckForIllegalCrossThreadCalls = false;
            Connect();
        }

        private Userdata currentUser;
        private bool email = false;
       // private IFirebaseClient client;
        public Chat_ChildForm(Userdata user)
        {
            InitializeComponent();
            this.currentUser = user;
            username_label.Text = currentUser.username;
            string username = currentUser.name;
            string email = currentUser.email;
        }
        
        



        IPEndPoint ipe;
        Socket client;
        TcpListener tcplisten;
        private void guna2Button1_Click(object sender, EventArgs e)
        {
            Send(client);
        }

        void Connect()
        {
           ipe = new IPEndPoint(IPAddress.Any, 9999);
           tcplisten = new TcpListener(ipe);

           Thread thread = new Thread(() =>
                    {
                        while (true)
                        {
                            tcplisten.Start();

                            client = tcplisten.AcceptSocket();
                            Thread rec = new Thread(Receive);
                            rec.IsBackground = true;
                            rec.Start();
                        }
                    });
                    thread.IsBackground = true;
                    thread.Start(client);

        }
        void Send(Socket client)
        {
            byte[]data = Encoding.UTF8.GetBytes(tboxMess.Text);
            client.Send(data);
            Addmessage(tboxMess.Text);
        }
        void Receive(Object obj)
        {
            while(true)
            {
                Socket clinet = obj as Socket;
                byte[] recv = new byte[1024];
                client.Receive(recv);
                string s = Encoding.UTF8.GetString(recv);
                Addmessage(s);
            }

        }
        void Addmessage (string message)
        {
            lvMess.Items.Add(message);
        }
    }
}
