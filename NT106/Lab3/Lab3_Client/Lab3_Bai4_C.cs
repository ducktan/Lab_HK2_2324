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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using System.IO;
using System.Net.Http;

namespace Lab3_Client
{
    public partial class Lab3_Bai4_C : Form
    {

        private TcpClient client;
        private StreamReader reader;
        private StreamWriter writer;
        private Thread receiveThread;
        private string username;

        public Lab3_Bai4_C()
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;
            button1.Enabled = false;
        }
        private void ConnectToServer()
        {
            client = new TcpClient();
            client.Connect("127.0.0.1", 8080);

            NetworkStream stream = client.GetStream();
            reader = new StreamReader(stream);
            writer = new StreamWriter(stream);

            username = textBox1.Text;

            if (string.IsNullOrEmpty(username))
            {
                MessageBox.Show("Bạn cần nhập username để Chat!");
            }
            else
            {
                writer.WriteLine(username);
                writer.Flush();

                Thread receiveThread = new Thread(receiveMessage);
                receiveThread.Start();

            }

        }

        private void receiveMessage()
        {
            try
            {
                while (true)
                {
                    string message = reader.ReadLine();

                    AddLog(message);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(username))
            {
                MessageBox.Show("Nhập username trước khi gửi tin nhắn");
                return;
            }

            writer.WriteLine(textBox2.Text);
            writer.Flush();
            textBox2.Clear();
        }

        private void AddLog(string log)
        {
            if (richTextBox1.InvokeRequired)
            {
                richTextBox1.Invoke(new Action<string>(AddLog), log);
            }
            else
            {
                richTextBox1.AppendText(log + Environment.NewLine);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            button1.Enabled = true;
            ConnectToServer();
        }

        private void CBut_Click(object sender, EventArgs e)
        {

        }
    }




}
