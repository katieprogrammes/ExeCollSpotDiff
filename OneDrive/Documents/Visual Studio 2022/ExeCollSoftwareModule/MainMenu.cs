namespace SpotTheDifference
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void buttonimgEasy_Click(object sender, EventArgs e)
        {
            this.Hide();
            var Easy1 = new Easy1();
            Easy1.Closed += (s, args) => this.Close();
            Easy1.Show();
        }

        private void buttonimgMed_Click(object sender, EventArgs e)
        {
            this.Hide();
            var Medium1 = new Medium1();
            Medium1.Closed += (s, args) => this.Close();
            Medium1.Show();
        }

        private void buttonimgHard_Click(object sender, EventArgs e)
        {
            this.Hide();
            var Hard1 = new Hard1();
            Hard1.Closed += (s, args) => this.Close();
            Hard1.Show();
        }

        private void buttonimgVeryHard_Click(object sender, EventArgs e)
        {

        }
    }
}