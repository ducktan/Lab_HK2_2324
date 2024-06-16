using System;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace Lab3_Server
{
    public partial class Lab3_Bai2_S : Form
    {
        public Lab3_Bai2_S()
        {
            InitializeComponent();
        }

        bool isListening = false;
        IPEndPoint ipepServer = new IPEndPoint(IPAddress.Parse("127.0.0.1"), 8080);

        void StartUnsafeThread()
        {
            int bytesReceived = 0;
            byte[] recv = new byte[256];

            Socket listenerSocket = new Socket(
                AddressFamily.InterNetwork,
                SocketType.Stream,
                ProtocolType.Tcp
            );

            listenerSocket.Bind(ipepServer);
            listenerSocket.Listen(-1);

            Socket clientSocket = listenerSocket.Accept();
            richTextBox1.Text = "New client connected\n";

            while (clientSocket.Connected)
            {
                string text = "";
                do
                {
                    bytesReceived = clientSocket.Receive(recv);
                    text += Encoding.UTF8.GetString(recv, 0, bytesReceived);
                }
                while (bytesReceived > 0 && text[text.Length - 1] != '\n');

                if (!string.IsNullOrWhiteSpace(text))
                    richTextBox1.Text += text;
            }

            listenerSocket.Close();
        }

        private void Listen_Click(object sender, EventArgs e)
        {
            CheckForIllegalCrossThreadCalls = false;
            Thread serverThread = new Thread(new ThreadStart(StartUnsafeThread));
            serverThread.Start();
        }
    }
}