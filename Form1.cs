namespace TikTakToe
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (richTextBox1.Text != "" && richTextBox2.Text != "")
            {
                Form2 game = new Form2();

                this.Hide();
                game.ShowDialog();
            }
            else
            {
                Form3 wrongName = new Form3();
                wrongName.ShowDialog();
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}