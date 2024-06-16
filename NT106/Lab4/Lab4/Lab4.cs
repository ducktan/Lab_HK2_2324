namespace Lab4
{
    public partial class Lab4 : Form
    {
        public Lab4()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Lab4_Bai1 b1 = new Lab4_Bai1();
            b1.Show();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Lab4_Bai2 b2 = new Lab4_Bai2();
            b2.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Lab4_Bai3 b3 = new Lab4_Bai3();
            b3.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Lab4_Bai4 b4 = new Lab4_Bai4(); 
            b4.Show();
        }
    }
}
