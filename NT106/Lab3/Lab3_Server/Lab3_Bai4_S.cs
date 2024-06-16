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
using System.Threading;

namespace Lab3_Server
{
    public partial class Lab3_Bai4_S : Form
    {
        private TcpListener tcplistener;
        private List<TcpClient> clients = new List<TcpClient>();


        public Lab3_Bai4_S()
        {
            InitializeComponent();
        }

        private void StartSV()
        {
            try
            {
                // Sử dụng địa chỉ loopback (127.0.0.1) để chỉ định server lắng nghe trên loopback
                IPAddress ipAddress = IPAddress.Parse("127.0.0.1");
                tcplistener = new TcpListener(ipAddress, 8080);
                tcplistener.Start();
                IPEndPoint endPoint = (IPEndPoint)tcplistener.LocalEndpoint;
                AppendLog("Server running on " + endPoint.Address + " and port " + endPoint.Port);


                Thread listenThread = new Thread(ListenForClients);
                listenThread.Start();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ListenForClients()
        {
            while (true)
            {
                try
                {
                    TcpClient tcpClient = tcplistener.AcceptTcpClient();
                    Thread clientThread = new Thread(start: HandleClientComm);
                    clientThread.Start(tcpClient);
                }
                catch (SocketException ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK);
                    break;
                }
            }
        }

        private void HandleClientComm(object client)
        {
            TcpClient tcpClient = (TcpClient)client;
            NetworkStream clientStream = tcpClient.GetStream();
            StreamReader reader = new StreamReader(clientStream);
            StreamWriter writer = new StreamWriter(clientStream);
            string userName = reader.ReadLine();
            AddClient(tcpClient, userName);

            while (tcpClient.Connected)
            {
                try
                {
                    string message = reader.ReadLine();
                    if (message == null)
                        break;

                    BroadcastMessage(userName + ": " + message);
                }
                catch (IOException ex)
                {
                    RemoveClient(tcpClient, userName);
                    break;
                }
            }

            tcpClient.Close();
            RemoveClient(tcpClient, userName);
        }

        private void AddClient(TcpClient tcpClient, string userName)
        {
            clients.Add(tcpClient);
            IPEndPoint endPoint = (IPEndPoint)tcpClient.Client.RemoteEndPoint;
            string clientInfo = $"{userName} đã kết nối từ địa chỉ IP: {endPoint.Address} và cổng: {endPoint.Port}";
            AppendLog(clientInfo);
        }
        private void RemoveClient(TcpClient client, string userName)
        {
            clients.Remove(client);
            AppendLog(userName + " đã ngắt kết nối");

        }

        private void BroadcastMessage(string message, TcpClient excludedClient = null)
        {
            if (!string.IsNullOrEmpty(message))
            {
                if (message.Contains(" đã kết nối") || message.Contains(" đã tham gia"))
                {
                    // Display connection and join messages only on the server's log
                    AppendLog(message);
                }
                else
                {
                    // Broadcast regular messages to all clients
                    foreach (TcpClient client in clients)
                    {
                        if (client != excludedClient)
                        {
                            NetworkStream clientStream = client.GetStream();
                            StreamWriter writer = new StreamWriter(clientStream);
                            writer.WriteLine(message);
                            writer.Flush();
                        }
                    }
                    // Display regular messages on the server's log as well
                    AppendLog(message);
                }
            }
        }


        private void AppendLog(string message)
        {
            if (lv_Message.InvokeRequired)
            {
                lv_Message.Invoke(new MethodInvoker(delegate
                {
                    lv_Message.AppendText(message + Environment.NewLine);
                }));
            }
            else { lv_Message.AppendText(message + Environment.NewLine); }
        }
        

        private void btn_Listen_Click(object sender, EventArgs e)
        {
            StartSV();
        }
    }
}



