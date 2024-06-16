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

namespace Lab3_Client
{
    public partial class Lab3_Bai3_C : Form
    {
        public Lab3_Bai3_C()
        {
            InitializeComponent();
        }

        private void Send_Click(object sender, EventArgs e)
        {
            int port = 8080;
            IPAddress ipadd = IPAddress.Parse("127.0.0.1");

            try
            {
                // connect to server
                TcpClient tcpClient = new TcpClient("127.0.0.1", port);

                //get data from network stream
                NetworkStream stream = tcpClient.GetStream();

                byte[] stringBytes = Encoding.UTF8.GetBytes(textBox1.Text);
                stream.Write(stringBytes, 0, stringBytes.Length);

                stream.Close();
                textBox1.Clear();

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
    }
}
