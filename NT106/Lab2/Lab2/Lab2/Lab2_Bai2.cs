using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab2
{
    public partial class Lab2_Bai2 : Form
    {
        public Lab2_Bai2()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void ReadFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.ShowDialog();

            FileStream fs = new FileStream(ofd.FileName, FileMode.OpenOrCreate);

            StreamReader sr = new StreamReader(fs);
            string text = sr.ReadToEnd();

            textBox1.Text = text;

            FileName.Text = ofd.SafeFileName.ToString();
            URL.Text = fs.Name.ToString();
            // dem so ky tu
            charNum.Text = text.Length.ToString();
            // dem so dong 

            text = text.Replace("\r\n", "\r");
            lineNum.Text = textBox1.Lines.Count().ToString();
            text = text.Replace('\r', ' ');

            // dem so tu 

            string[] src = text.Split(new char[] {'.', '?', '!', ':', ',', ' ' }, StringSplitOptions.RemoveEmptyEntries); 
            wordNum.Text = src.Count().ToString();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
