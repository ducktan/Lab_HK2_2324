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
    public partial class Lab2_Bai5 : Form
    {
        public Lab2_Bai5()
        {
            InitializeComponent();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listView1.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Thiết lập chế độ xem cho ListView
            listView1.View = View.Details;

            // Xóa các cột cũ (nếu có)
            listView1.Columns.Clear();

            // Thêm các cột mới
            listView1.Columns.Add("Tên tệp", 200);
            listView1.Columns.Add("Kích thước (bytes)", 100);
            listView1.Columns.Add("Đuôi mở rộng", 150);
            listView1.Columns.Add("Ngày tạo", 150);

            // Mở hộp thoại chọn thư mục
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            if (fbd.ShowDialog() == DialogResult.OK)
            {
                DisplayFiles(fbd.SelectedPath);
            }
        }

        private void DisplayFiles(string path)
        {
            try
            {
                // Kiểm tra xem thư mục tồn tại không
                if (!Directory.Exists(path))
                {
                    MessageBox.Show("Thư mục không tồn tại!");
                    return;
                }

                // Xóa các mục cũ trong ListView
                listView1.Items.Clear();

                // Lấy danh sách tất cả các tệp trong thư mục
                string[] files = Directory.GetFiles(path);

                // Hiển thị thông tin của từng tệp trong ListView
                foreach (string filePath in files)
                {
                    FileInfo fileInfo = new FileInfo(filePath);
                    ListViewItem item = new ListViewItem(fileInfo.Name);

                    // Thêm các thông tin của tệp vào các cột tương ứng
                    item.SubItems.Add(fileInfo.Length.ToString());
                    item.SubItems.Add(fileInfo.Extension);
                    item.SubItems.Add(fileInfo.CreationTime.ToString());

                    // Thêm ListViewItem vào ListView
                    listView1.Items.Add(item);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi hiển thị danh sách tệp: " + ex.Message);
            }
        }

    }
}
