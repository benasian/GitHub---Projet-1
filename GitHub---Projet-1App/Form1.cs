namespace GitHub___Projet_1App
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void lblButton1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Please, press the button, not the label", "Recommandation", MessageBoxButtons.OK);
        }
    }
}