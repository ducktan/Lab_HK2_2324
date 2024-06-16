using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab2
{
    public partial class Lab2_Bai1 : Form
    {
        public Lab2_Bai1()
        {
            InitializeComponent();
        }


        private void Xoa_Click(object sender, EventArgs e)
        {
            Textshow.Clear();
        }

        private void Thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ReadFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.ShowDialog();

            FileStream fs = new FileStream(ofd.FileName, FileMode.OpenOrCreate);
            StreamReader sr = new StreamReader(fs);

            string text = sr.ReadToEnd();
            Textshow.Text = text;

            fs.Close();
        }

     
        private void WriteFile_Click_1(object sender, EventArgs e)
        {
            string text = Textshow.Text;
            

            // Chọn nơi để ghi file
            SaveFileDialog sfd = new SaveFileDialog();
            if (sfd.ShowDialog() == DialogResult.OK) // Kiem tra vi tri luu co hop le k
            {
                using (FileStream fs = new FileStream(sfd.FileName, FileMode.Create))
                using (StreamWriter sw = new StreamWriter(fs))
                {
                    // Ghi nội dung vào file
                    sw.Write(text.ToUpper());
                }
            }
        }

    }
}
