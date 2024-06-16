using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Lab3_Server
{
    public partial class Lab3_Bai1_S : Form
    {
        public Lab3_Bai1_S()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
        UdpClient udpServer;



        private void Listen_Click(object sender, EventArgs e)
        {
            try
            {
                int port;
                if (!int.TryParse(Port.Text, out port))
                {
                    MessageBox.Show("Port không hợp lệ");
                    return;
                }
                port = Convert.ToInt32(Port.Text);
                udpServer = new UdpClient(port);
                Thread listenThread = new Thread(new ThreadStart(ListenForMessages));
                listenThread.IsBackground = true;
                // Đặt luồng là background để nó không ngăn cản ứng dụng kết thúc khi đóng form
                listenThread.Start();
            }

            catch (Exception ex){
                MessageBox.Show("Error: " + ex.Message);
            }
            
        }

        private void ListenForMessages()
        {
            try
            {
                while (true)
                {
                    IPEndPoint clientEndPoint = new IPEndPoint(IPAddress.Any, 0);
                    byte[] receiveBytes = udpServer.Receive(ref clientEndPoint);
                    string receivedData = Encoding.UTF8.GetString(receiveBytes);
                    string clientAddress = clientEndPoint.Address.ToString();
                    string messageWithAddress = clientAddress + ": " + receivedData;

                    textBox1.Invoke(new Action(() =>
                    {
                        textBox1.AppendText(messageWithAddress + Environment.NewLine);
                    }));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void Lab3_Bai1_S_Load(object sender, EventArgs e)
        {

        }
    }
}
