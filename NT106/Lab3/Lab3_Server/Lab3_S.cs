namespace Lab3_Server
{
    public partial class Lab3_S : Form
    {
        public Lab3_S()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Lab3_Bai1_S bai1 = new Lab3_Bai1_S();
            bai1.Show();
        }
    }
}
