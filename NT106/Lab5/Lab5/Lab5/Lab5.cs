namespace Lab5
{
    public partial class Lab5 : Form
    {
        public Lab5()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Lab5_Bai1 lab5_Bai1 = new Lab5_Bai1();
            lab5_Bai1.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Lab5_Bai2 lab5 = new Lab5_Bai2();
            lab5.Show();
        }
    }
}
