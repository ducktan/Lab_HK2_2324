using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
#pragma warning disable SYSLIB0011

namespace Lab2
{
    public partial class Lab2_Bai4 : Form
    {
        public Lab2_Bai4()
        {
            InitializeComponent();
        }

        [Serializable]
        public class Student
        {
            private string MSSV;
            private string HoTen;
            private string DienThoai;
            private float DiemToan;
            private float DiemVan;
            private float DiemTB;
            public Student(string MSSV, string HoTen, string DienThoai, float DiemToan, float DiemVan)
            {
                this.MSSV = MSSV;
                this.HoTen = HoTen;
                this.DienThoai = DienThoai;
                this.DiemToan = DiemToan;
                this.DiemVan = DiemVan;
                DiemTB = 0;
            }

            public string Show(bool check)
            {
                if (!check)
                    return $"{MSSV}\n{HoTen}\n{DienThoai}\n{DiemToan.ToString(".0###########")}\n{DiemVan.ToString(".0###########")}\n\n\n";
                return $"{MSSV}\n{HoTen}\n{DienThoai}\n{DiemToan.ToString(".0###########")}\n{DiemVan.ToString(".0###########")}\n{DiemTB.ToString(".0###########")}\n\n";
            }

            public void CalAvg()
            {
                DiemTB = (DiemToan + DiemVan) / 2;
            }
        }

        // Danh sách các học viên
        List<Student> students = new List<Student>();

        private void Thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Xoa_Click(object sender, EventArgs e)
        {

        }

        private void button_add_Click(object sender, EventArgs e)
        {
            try
            {
                if (
                    // Check MSSV
                    string.IsNullOrEmpty(textBox_MSSV.Text) || textBox_MSSV.TextLength != 8 || !Regex.IsMatch(textBox_MSSV.Text, "^[0-9]+$") ||
                    // Check HoTen
                    string.IsNullOrEmpty(textBox_hoTen.Text) || !Regex.IsMatch(textBox_hoTen.Text, "^[a-zA-Z]+$") ||
                    // Check DienThoai
                    string.IsNullOrEmpty(textBox_sdt.Text) || textBox_sdt.TextLength != 10 || !Regex.IsMatch(textBox_sdt.Text, "^[0-9]+$") ||
                    // Check DiemToan
                    (float.Parse(textBox_dToan.Text, CultureInfo.CurrentCulture) > 10 || float.Parse(textBox_dToan.Text, CultureInfo.CurrentCulture) < 0) ||
                    // Check DiemVan
                    (float.Parse(textBox_dVan.Text, CultureInfo.CurrentCulture) > 10 || float.Parse(textBox_dVan.Text, CultureInfo.CurrentCulture) < 0))
                {
                    throw new ArgumentException("Invalid input");
                }

                students.Add(new Student(textBox_MSSV.Text, textBox_hoTen.Text, textBox_sdt.Text, float.Parse(textBox_dToan.Text, NumberStyles.Any, CultureInfo.CurrentCulture), float.Parse(textBox_dVan.Text, NumberStyles.Any, CultureInfo.CurrentCulture)));
                richTextBox_result.Text = "Added information's student:\n";
                richTextBox_result.Text += students[students.Count - 1].Show(false);
                textBox_MSSV.Clear();
                textBox_hoTen.Clear();
                textBox_sdt.Clear();
                textBox_dToan.Clear();
                textBox_dVan.Clear();
            }
            catch
            {
                MessageBox.Show("Thông tin vừa nhập chưa đúng!");
            }

        }

        private void button_save_Click(object sender, EventArgs e)
        {
            if (students.Count != 0)
            {

                OpenFileDialog ofd = new OpenFileDialog();
                ofd.ShowDialog();

                FileStream fs = new FileStream(ofd.FileName, FileMode.OpenOrCreate);

                BinaryFormatter bf = new BinaryFormatter();

                MessageBox.Show("Đã lưu thông tin các sinh viên vào file input.txt");
                bf.Serialize(fs, students);
                fs.Close();
            }
            else
            {
                MessageBox.Show("Bạn chưa nhập thông tin sinh viên!");
            }
        }

        private void button_cal_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofdInput = new OpenFileDialog();
            ofdInput.ShowDialog();

            FileStream fsInput = new FileStream(ofdInput.FileName, FileMode.OpenOrCreate);

            OpenFileDialog ofdOutput = new OpenFileDialog();
            ofdOutput.ShowDialog();

            FileStream fsOutput = new FileStream(ofdOutput.FileName, FileMode.OpenOrCreate);

            try
            {
                BinaryFormatter bf = new BinaryFormatter();

                students.Clear();
                students = (List<Student>)bf.Deserialize(fsInput);
                richTextBox_result.Clear();
                students.ForEach(s =>richTextBox_result.Text += s.Show(false));

                MessageBox.Show("Đã tính điểm trung bình cho các sinh viên và lưu thông tin vào file output.txt");
                students.ForEach(s => s.CalAvg());
                bf.Serialize(fsOutput, students);
            }
            catch
            {
                MessageBox.Show("Không có thông tin để tính");
            }
            fsInput.Close();
            fsOutput.Close();
        }

        private void button_output_Click(object sender, EventArgs e)
        {

            OpenFileDialog ofd = new OpenFileDialog();
            ofd.ShowDialog();

            FileStream fs = new FileStream(ofd.FileName, FileMode.OpenOrCreate);

            try
            {
                BinaryFormatter bf = new BinaryFormatter();

                students.Clear();
                students = (List<Student>)bf.Deserialize(fs);
                richTextBox_result.Clear();
                students.ForEach(s =>richTextBox_result.Text += s.Show(true));
            }
            catch
            {
                MessageBox.Show("Không có thông tin!");
            }
            fs.Close();
        }
    }
}

#pragma warning restore SYSLIB0011
