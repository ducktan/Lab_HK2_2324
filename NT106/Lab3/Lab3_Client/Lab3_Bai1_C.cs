using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;


namespace Lab3_Client
{
    public partial class Lab3_Bai1_C : Form
    {
        public Lab3_Bai1_C()
        {
            InitializeComponent();
        }

        private void Send_Click(object sender, EventArgs e)
        {
            try
            {
                UdpClient client = new UdpClient();

                // Lấy IP từ textbox
                if (!IPAddress.TryParse(IP.Text, out IPAddress ipAddress))
                {
                    MessageBox.Show("Địa chỉ IP không hợp lệ");
                    return;
                }

                int port;
                if (!int.TryParse(Port.Text, out port))
                {
                    MessageBox.Show("Cổng không hợp lệ");
                    return;
                }

                IPEndPoint ipEndpoint = new IPEndPoint(ipAddress, port);

                byte[] stringByte = Encoding.UTF8.GetBytes(textBox1.Text);

                client.Send(stringByte, stringByte.Length, ipEndpoint);

                textBox1.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
    }
}
