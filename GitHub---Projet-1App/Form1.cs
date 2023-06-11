namespace GitHub___Projet_1App
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnShowHello_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Good morning!!!", "Hello World", MessageBoxButtons.OK);
        }
    }
}