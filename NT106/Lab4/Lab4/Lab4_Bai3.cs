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

namespace Lab4
{
    public partial class Lab4_Bai3 : Form
    {
        public Lab4_Bai3()
        {
            InitializeComponent();
        }

        private void downBut_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.ShowDialog();

            string url = url_textBox.Text;

            using (WebClient myClient = new WebClient())
            {
                // Tải nội dung web
                string content = myClient.DownloadString(url);
                WebContent.Text = content;

                // Lưu nội dung thành tệp tin HTML
                myClient.DownloadFile(url, sfd.FileName);
            }
        }
    }
}
