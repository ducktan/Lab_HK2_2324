namespace Lab2
{
    public partial class Lab2 : Form
    {
        public Lab2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Lab2_Bai1 bai1 = new Lab2_Bai1();
            bai1.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Lab2_Bai2 bai2 = new Lab2_Bai2();
            bai2.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Lab2_Bai3 bai3 = new Lab2_Bai3();
            bai3.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Lab2_Bai4 bai4 = new Lab2_Bai4();
            bai4.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Lab2_Bai5 bai5 = new Lab2_Bai5();   
            bai5.Show();
        }
    }
}
