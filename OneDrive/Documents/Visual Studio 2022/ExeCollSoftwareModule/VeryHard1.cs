using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Formats.Asn1.AsnWriter;

namespace SpotTheDifference
{
    public partial class VeryHard1 : Form
    {
        //variable for the users current score
        public static int scorevh = 0;
        public VeryHard1()
        {
            InitializeComponent();
            //converts the score to a displayable format
            textBox1.Text = Convert.ToString(scorevh);
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            //displays current score
            Console.WriteLine(scorevh);
        }

        private void pic1_Click(object sender, EventArgs e)
        {
            //keeps the score the same due to incorrect click
            textBox1.Text = Convert.ToString(scorevh);
            //Opens the next level
            this.Hide();
            var VeryHard2 = new VeryHard2();
            VeryHard2.Closed += (s, args) => this.Close();
            VeryHard2.Show();
        }

        private void pic2_Click(object sender, EventArgs e)
        {
            //keeps the score the same due to incorrect click
            textBox1.Text = Convert.ToString(scorevh);
            //Opens the next level
            this.Hide();
            var VeryHard2 = new VeryHard2();
            VeryHard2.Closed += (s, args) => this.Close();
            VeryHard2.Show();
        }

        private void pic3_Click(object sender, EventArgs e)
        {
            //keeps the score the same due to incorrect click
            textBox1.Text = Convert.ToString(scorevh);
            //Opens the next level
            this.Hide();
            var VeryHard2 = new VeryHard2();
            VeryHard2.Closed += (s, args) => this.Close();
            VeryHard2.Show();
        }

        private void pic4_Click(object sender, EventArgs e)
        {
            //keeps the score the same due to incorrect click
            textBox1.Text = Convert.ToString(scorevh);
            //Opens the next level
            this.Hide();
            var VeryHard2 = new VeryHard2();
            VeryHard2.Closed += (s, args) => this.Close();
            VeryHard2.Show();
        }

        private void pic5_Click(object sender, EventArgs e)
        {
            //keeps the score the same due to incorrect click
            textBox1.Text = Convert.ToString(scorevh);
            //Opens the next level
            this.Hide();
            var VeryHard2 = new VeryHard2();
            VeryHard2.Closed += (s, args) => this.Close();
            VeryHard2.Show();
        }

        private void pic6_Click(object sender, EventArgs e)
        {
            //keeps the score the same due to incorrect click
            textBox1.Text = Convert.ToString(scorevh);
            //Opens the next level
            this.Hide();
            var VeryHard2 = new VeryHard2();
            VeryHard2.Closed += (s, args) => this.Close();
            VeryHard2.Show();
        }

        private void pic7_Click(object sender, EventArgs e)
        {
            //keeps the score the same due to incorrect click
            textBox1.Text = Convert.ToString(scorevh);
            //Opens the next level
            this.Hide();
            var VeryHard2 = new VeryHard2();
            VeryHard2.Closed += (s, args) => this.Close();
            VeryHard2.Show();
        }

        private void pic8_Click(object sender, EventArgs e)
        {
            //keeps the score the same due to incorrect click
            textBox1.Text = Convert.ToString(scorevh);
            //Opens the next level
            this.Hide();
            var VeryHard2 = new VeryHard2();
            VeryHard2.Closed += (s, args) => this.Close();
            VeryHard2.Show();
        }

        private void pic9_Click(object sender, EventArgs e)
        {
            //keeps the score the same due to incorrect click
            textBox1.Text = Convert.ToString(scorevh);
            //Opens the next level
            this.Hide();
            var VeryHard2 = new VeryHard2();
            VeryHard2.Closed += (s, args) => this.Close();
            VeryHard2.Show();
        }

        private void pic10_Click(object sender, EventArgs e)
        {
            //keeps the score the same due to incorrect click
            textBox1.Text = Convert.ToString(scorevh);
            //Opens the next level
            this.Hide();
            var VeryHard2 = new VeryHard2();
            VeryHard2.Closed += (s, args) => this.Close();
            VeryHard2.Show();
        }

        private void pic11_Click(object sender, EventArgs e)
        {
            //keeps the score the same due to incorrect click
            textBox1.Text = Convert.ToString(scorevh);
            //Opens the next level
            this.Hide();
            var VeryHard2 = new VeryHard2();
            VeryHard2.Closed += (s, args) => this.Close();
            VeryHard2.Show();
        }

        private void pic12_Click(object sender, EventArgs e)
        {
            //keeps the score the same due to incorrect click
            textBox1.Text = Convert.ToString(scorevh);
            //Opens the next level
            this.Hide();
            var VeryHard2 = new VeryHard2();
            VeryHard2.Closed += (s, args) => this.Close();
            VeryHard2.Show();
        }

        private void pic13_Click(object sender, EventArgs e)
        {
            //keeps the score the same due to incorrect click
            textBox1.Text = Convert.ToString(scorevh);
            //Opens the next level
            this.Hide();
            var VeryHard2 = new VeryHard2();
            VeryHard2.Closed += (s, args) => this.Close();
            VeryHard2.Show();
        }

        private void pic14_Click(object sender, EventArgs e)
        {
            //increases the users score by one as they have clicked the correct box
            scorevh = +1;
            textBox1.Text = Convert.ToString(scorevh);
            //Opens the next level
            this.Hide();
            var VeryHard2 = new VeryHard2();
            VeryHard2.Closed += (s, args) => this.Close();
            VeryHard2.Show();
        }

        private void pic15_Click(object sender, EventArgs e)
        {
            //keeps the score the same due to incorrect click
            textBox1.Text = Convert.ToString(scorevh);
            //Opens the next level
            this.Hide();
            var VeryHard2 = new VeryHard2();
            VeryHard2.Closed += (s, args) => this.Close();
            VeryHard2.Show();
        }

        private void pic16_Click(object sender, EventArgs e)
        {
            //keeps the score the same due to incorrect click
            textBox1.Text = Convert.ToString(scorevh);
            //Opens the next level
            this.Hide();
            var VeryHard2 = new VeryHard2();
            VeryHard2.Closed += (s, args) => this.Close();
            VeryHard2.Show();
        }
    }
}
