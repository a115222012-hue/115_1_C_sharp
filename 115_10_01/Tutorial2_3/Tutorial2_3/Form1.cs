namespace Tutorial2_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            showlabel.Text = "Buen día";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            showlabel.Text = "Buongiorno";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            showlabel.Text = "Guten Morgen";
        }
    }
}
