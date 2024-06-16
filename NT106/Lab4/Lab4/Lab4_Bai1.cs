using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Http;
using System.Threading.Tasks;


namespace Lab4
{
    public partial class Lab4_Bai1 : Form
    {
        public Lab4_Bai1()
        {
            InitializeComponent();
        }

        private async void GET_button_Click(object sender, EventArgs e)
        {
            using (HttpClient client = new HttpClient())
            {
                try
                {
                    string url = url_Textbox.Text;
                    if (!Uri.TryCreate(url, UriKind.Absolute, out Uri validUrl))
                    {
                        MessageBox.Show("URL không hợp lệ");
                        return;
                    }
                    HttpResponseMessage response = await client.GetAsync(url);
                    response.EnsureSuccessStatusCode();
                    string html = await response.Content.ReadAsStringAsync();
                    richTextBox1.Text = html;
                }
                catch (HttpRequestException ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void url_Textbox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
