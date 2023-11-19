namespace RunningButton
{
    public partial class Form1 : Form
    {
        Random rnd = new Random();
        public Form1()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            
        }

        private void button4_Enter(object sender, EventArgs e)
        {
            button4.Location = new Point(rnd.Next(0, 800), rnd.Next(0, 450));
        }
    }
}
