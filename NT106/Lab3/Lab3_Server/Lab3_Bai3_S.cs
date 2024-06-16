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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Lab3_Server
{
    public partial class Lab3_Bai3_S : Form
    {
        private TcpListener listener;
        public Lab3_Bai3_S()
        {
            InitializeComponent();
        }

        private void DisplayMessage(string message)
        {
            if (richTextBox1.InvokeRequired)
            {
                richTextBox1.Invoke((MethodInvoker)delegate {
                    richTextBox1.Text += message + "\n";
                });
            }
            else
            {
                richTextBox1.Text += message + "\n";
            }
        }

        private void HandleClientComm(object clientObj)
        {
            TcpClient client = (TcpClient)clientObj;
            NetworkStream stream = client.GetStream();
            byte[] data = new byte[1024];

            try
            {
                while (true)
                {
                    int bytesRead = stream.Read(data, 0, data.Length);
                    if (bytesRead == 0)
                    {
                        break; // Kết thúc khi client đóng kết nối
                    }

                    string message = Encoding.UTF8.GetString(data, 0, bytesRead);
                    DisplayMessage(message);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi trong xử lý dữ liệu từ client: " + ex.Message);
            }
            finally
            {
                client.Close();
            }
        }

        private void ListenForClients()
        {
            try
            {
                while (true)
                {
                    TcpClient client = listener.AcceptTcpClient();
                    Thread clientThread = new Thread(HandleClientComm);
                    clientThread.IsBackground = true;
                    clientThread.Start(client);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        private void Listen_Click(object sender, EventArgs e)
        {
            int port = 8080;
            try
            {
                listener = new TcpListener(IPAddress.Any, port);
                listener.Start();

                // Khởi tạo một luồng riêng biệt để lắng nghe kết nối từ client
                Thread listenThread = new Thread(ListenForClients);
                listenThread.IsBackground = true;
                listenThread.Start();

                MessageBox.Show("Đã bắt đầu lắng nghe kết nối từ client.");
                richTextBox1.Text = "Connected!\n";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }
    }
}
