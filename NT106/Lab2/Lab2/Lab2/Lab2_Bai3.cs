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
    public partial class Lab2_Bai3 : Form
    {
        public Lab2_Bai3()
        {
            InitializeComponent();
        }

        private void Thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Xoa_Click(object sender, EventArgs e)
        {
            richTextBox_result.Clear();
        }
        static double CalculateExpression(string expression)
        {
            // Hàm tính toán biểu thức
            DataTable dt = new DataTable();
            return Convert.ToDouble(dt.Compute(expression, ""));
        }
        private void ReadFile_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog ofd = new OpenFileDialog();
                ofd.ShowDialog();

                FileStream fs = new FileStream(ofd.FileName, FileMode.OpenOrCreate);
                StreamReader sr = new StreamReader(fs);

                richTextBox_result.Text = sr.ReadToEnd();

                fs.Close();
            }
            catch
            {
                MessageBox.Show("Có phép tính nhập vào không đúng!");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofdInput = new OpenFileDialog();
            ofdInput.ShowDialog();

            FileStream fsInput = new FileStream(ofdInput.FileName, FileMode.OpenOrCreate);

            OpenFileDialog ofdOutput = new OpenFileDialog();
            ofdOutput.ShowDialog();

            FileStream fsOutput = new FileStream(ofdOutput.FileName, FileMode.OpenOrCreate);

            try
            {
                StreamReader sr = new StreamReader(fsInput);
                StreamWriter sw = new StreamWriter(fsOutput);

                richTextBox_result.Clear();
                while (true)
                {
                    string expression = sr.ReadLine();
                    if (expression == null)
                    {
                        break;
                    }
                    var result = new DataTable().Compute(expression, null);
                    richTextBox_result.Text += expression + "=" + result.ToString() + "\n";
                }
                sw.Write(richTextBox_result.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("Có phép tính nhập vào không đúng!");
            }

            fsInput.Close();
            fsOutput.Close();


        }

        private void Lab2_Bai3_Load(object sender, EventArgs e)
        {

        }
    }
}
