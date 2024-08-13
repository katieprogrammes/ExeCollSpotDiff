using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SpotTheDifference
{
    public partial class VeryHard4 : Form
    {
        //variable for the users current score
        public static int scorevh4 = 0;
        public VeryHard4()
        {
            InitializeComponent();
            //parses the score to this level
            scorevh4 = VeryHard3.scorevh3;
            //converts the score to a displayable format
            textBox1.Text = Convert.ToString(scorevh4);
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            //displays current score
            Console.WriteLine(scorevh4);
        }

        private void pic1_Click(object sender, EventArgs e)
        {
            //keeps the score the same due to incorrect click
            textBox1.Text = Convert.ToString(scorevh4);
            //Opens the next level
            this.Hide();
            var VeryHard5 = new VeryHard5();
            VeryHard5.Closed += (s, args) => this.Close();
            VeryHard5.Show();
        }

        private void pic2_Click(object sender, EventArgs e)
        {
            //keeps the score the same due to incorrect click
            textBox1.Text = Convert.ToString(scorevh4);
            //Opens the next level
            this.Hide();
            var VeryHard5 = new VeryHard5();
            VeryHard5.Closed += (s, args) => this.Close();
            VeryHard5.Show();
        }

        private void pic3_Click(object sender, EventArgs e)
        {
            //keeps the score the same due to incorrect click
            textBox1.Text = Convert.ToString(scorevh4);
            //Opens the next level
            this.Hide();
            var VeryHard5 = new VeryHard5();
            VeryHard5.Closed += (s, args) => this.Close();
            VeryHard5.Show();
        }

        private void pic4_Click(object sender, EventArgs e)
        {
            //keeps the score the same due to incorrect click
            textBox1.Text = Convert.ToString(scorevh4);
            //Opens the next level
            this.Hide();
            var VeryHard5 = new VeryHard5();
            VeryHard5.Closed += (s, args) => this.Close();
            VeryHard5.Show();
        }

        private void pic5_Click(object sender, EventArgs e)
        {
            //keeps the score the same due to incorrect click
            textBox1.Text = Convert.ToString(scorevh4);
            //Opens the next level
            this.Hide();
            var VeryHard5 = new VeryHard5();
            VeryHard5.Closed += (s, args) => this.Close();
            VeryHard5.Show();
        }

        private void pic6_Click(object sender, EventArgs e)
        {
            //keeps the score the same due to incorrect click
            textBox1.Text = Convert.ToString(scorevh4);
            //Opens the next level
            this.Hide();
            var VeryHard5 = new VeryHard5();
            VeryHard5.Closed += (s, args) => this.Close();
            VeryHard5.Show();
        }

        private void pic7_Click(object sender, EventArgs e)
        {
            //keeps the score the same due to incorrect click
            textBox1.Text = Convert.ToString(scorevh4);
            //Opens the next level
            this.Hide();
            var VeryHard5 = new VeryHard5();
            VeryHard5.Closed += (s, args) => this.Close();
            VeryHard5.Show();
        }

        private void pic8_Click(object sender, EventArgs e)
        {
            //keeps the score the same due to incorrect click
            textBox1.Text = Convert.ToString(scorevh4);
            //Opens the next level
            this.Hide();
            var VeryHard5 = new VeryHard5();
            VeryHard5.Closed += (s, args) => this.Close();
            VeryHard5.Show();
        }

        private void pic9_Click(object sender, EventArgs e)
        {
            //keeps the score the same due to incorrect click
            textBox1.Text = Convert.ToString(scorevh4);
            //Opens the next level
            this.Hide();
            var VeryHard5 = new VeryHard5();
            VeryHard5.Closed += (s, args) => this.Close();
            VeryHard5.Show();
        }

        private void pic10_Click(object sender, EventArgs e)
        {
            //keeps the score the same due to incorrect click
            textBox1.Text = Convert.ToString(scorevh4);
            //Opens the next level
            this.Hide();
            var VeryHard5 = new VeryHard5();
            VeryHard5.Closed += (s, args) => this.Close();
            VeryHard5.Show();
        }

        private void pic11_Click(object sender, EventArgs e)
        {
            //increases the users score by one as they have clicked the correct box
            scorevh4 = +1;
            textBox1.Text = Convert.ToString(scorevh4);
            //Opens the next level
            this.Hide();
            var VeryHard5 = new VeryHard5();
            VeryHard5.Closed += (s, args) => this.Close();
            VeryHard5.Show();
        }

        private void pic12_Click(object sender, EventArgs e)
        {
            //keeps the score the same due to incorrect click
            textBox1.Text = Convert.ToString(scorevh4);
            //Opens the next level
            this.Hide();
            var VeryHard5 = new VeryHard5();
            VeryHard5.Closed += (s, args) => this.Close();
            VeryHard5.Show();
        }

        private void pic13_Click(object sender, EventArgs e)
        {
            //keeps the score the same due to incorrect click
            textBox1.Text = Convert.ToString(scorevh4);
            //Opens the next level
            this.Hide();
            var VeryHard5 = new VeryHard5();
            VeryHard5.Closed += (s, args) => this.Close();
            VeryHard5.Show();
        }

        private void pic14_Click(object sender, EventArgs e)
        {
            //keeps the score the same due to incorrect click
            textBox1.Text = Convert.ToString(scorevh4);
            //Opens the next level
            this.Hide();
            var VeryHard5 = new VeryHard5();
            VeryHard5.Closed += (s, args) => this.Close();
            VeryHard5.Show();
        }

        private void pic15_Click(object sender, EventArgs e)
        {
            //keeps the score the same due to incorrect click
            textBox1.Text = Convert.ToString(scorevh4);
            //Opens the next level
            this.Hide();
            var VeryHard5 = new VeryHard5();
            VeryHard5.Closed += (s, args) => this.Close();
            VeryHard5.Show();
        }

        private void pic16_Click(object sender, EventArgs e)
        {
            //keeps the score the same due to incorrect click
            textBox1.Text = Convert.ToString(scorevh4);
            //Opens the next level
            this.Hide();
            var VeryHard5 = new VeryHard5();
            VeryHard5.Closed += (s, args) => this.Close();
            VeryHard5.Show();
        }
    }
}
