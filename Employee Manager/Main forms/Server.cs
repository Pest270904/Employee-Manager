using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Employee_Manager.Main_forms
{
    public partial class Server : Form
    {
        public Server()
        {
            InitializeComponent();
            message_box.ReadOnly = true;

        }
        private readonly string serverIp = "127.0.0.1";
        private readonly int serverPort = 2004;
        private List<Socket> clientSockets = new List<Socket>();
        private readonly object clientSocketsLock = new object();

        private async void StartListen(object sender, EventArgs e)
        {
            try
            {
                IPAddress ipAddress = IPAddress.Parse(serverIp);
                IPEndPoint localEndPoint = new IPEndPoint(ipAddress, serverPort);

                using (Socket listenerSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp))
                {
                    listenerSocket.Bind(localEndPoint);
                    listenerSocket.Listen(10);

                    message_box.AppendText($"Server running on {serverIp}:{serverPort}.\r\n");
                    // MessageBox.Show($"Server listening on port {serverPort}.");

                    while (true)
                    {
                        Socket clientSocket = await listenerSocket.AcceptAsync();
                        lock (clientSocketsLock)
                        {
                            clientSockets.Add(clientSocket);
                            message_box.AppendText($"New connection from {clientSocket.RemoteEndPoint}\r\n");
                        }

                        _ = Task.Run(() => ReceiveMessages(clientSocket));
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error occurred: " + ex.Message);
            }
        }

        private async Task ReceiveMessages(Socket clientSocket)
        {
            try
            {
                byte[] recv = new byte[1024];
                StringBuilder receivedData = new StringBuilder();

                while (clientSocket.Connected)
                {
                    int bytesReceived = await clientSocket.ReceiveAsync(new ArraySegment<byte>(recv), SocketFlags.None);
                    if (bytesReceived > 0)
                    {
                        string text = Encoding.UTF8.GetString(recv, 0, bytesReceived);
                        receivedData.Append(text);
                        if (text.EndsWith("\r\n"))
                        {
                            Invoke((Action)(() => message_box.AppendText(receivedData.ToString())));
                            await BroadcastMessageAsync(receivedData.ToString(), clientSocket);
                            receivedData.Clear();
                        }
                    }
                    else
                    {
                        break;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error occurred: " + ex.Message);
            }
            finally
            {
                clientSocket.Close();
                lock (clientSocketsLock)
                {
                    clientSockets.Remove(clientSocket);
                }
            }
        }

        private async Task BroadcastMessageAsync(string message, Socket senderSocket)
        {
            byte[] dataToSend = Encoding.UTF8.GetBytes(message);
            List<Socket> socketsCopy;
            lock (clientSocketsLock)
            {
                socketsCopy = new List<Socket>(clientSockets);
            }
            foreach (Socket socket in socketsCopy)
            {
                if (socket != senderSocket && socket.Connected)
                {
                    await socket.SendAsync(new ArraySegment<byte>(dataToSend), SocketFlags.None);
                }
            }
        }

        public void listen_btn_Click_1(object sender, EventArgs e)
        {
            StartListen(sender, e);
        }
    }
}
