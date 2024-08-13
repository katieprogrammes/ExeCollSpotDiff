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
    public partial class Hard1 : Form
    {
        //Score is how many levels the user has completed
        public static int scoreh = 0;
        public Hard1()
        {
            InitializeComponent();
            //Converts current score to a displayable format
            textBox1.Text = Convert.ToString(scoreh);
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            //Displays current score
            Console.WriteLine(scoreh);
        }

        private void pic1_Click(object sender, EventArgs e)
        {
            //Keeps score the same due to incorrect click
            textBox1.Text = Convert.ToString(scoreh);
            //Opens next level
            this.Hide();
            var Hard2 = new Hard2();
            Hard2.Closed += (s, args) => this.Close();
            Hard2.Show();
        }

        private void pic2_Click(object sender, EventArgs e)
        {
            //Keeps score the same due to incorrect click
            textBox1.Text = Convert.ToString(scoreh);
            //Opens next level
            this.Hide();
            var Hard2 = new Hard2();
            Hard2.Closed += (s, args) => this.Close();
            Hard2.Show();
        }

        private void pic3_Click(object sender, EventArgs e)
        {
            //Keeps score the same due to incorrect click
            textBox1.Text = Convert.ToString(scoreh);
            //Opens next level
            this.Hide();
            var Hard2 = new Hard2();
            Hard2.Closed += (s, args) => this.Close();
            Hard2.Show();
        }

        private void pic4_Click(object sender, EventArgs e)
        {
            //Keeps score the same due to incorrect click
            textBox1.Text = Convert.ToString(scoreh);
            //Opens next level
            this.Hide();
            var Hard2 = new Hard2();
            Hard2.Closed += (s, args) => this.Close();
            Hard2.Show();
        }

        private void pic5_Click(object sender, EventArgs e)
        {
            //Keeps score the same due to incorrect click
            textBox1.Text = Convert.ToString(scoreh);
            //Opens next level
            this.Hide();
            var Hard2 = new Hard2();
            Hard2.Closed += (s, args) => this.Close();
            Hard2.Show();
        }

        private void pic6_Click(object sender, EventArgs e)
        {
            //Keeps score the same due to incorrect click
            textBox1.Text = Convert.ToString(scoreh);
            //Opens next level
            this.Hide();
            var Hard2 = new Hard2();
            Hard2.Closed += (s, args) => this.Close();
            Hard2.Show();
        }

        private void pic7_Click(object sender, EventArgs e)
        {
            //Keeps score the same due to incorrect click
            textBox1.Text = Convert.ToString(scoreh);
            //Opens next level
            this.Hide();
            var Hard2 = new Hard2();
            Hard2.Closed += (s, args) => this.Close();
            Hard2.Show();
        }

        private void pic8_Click(object sender, EventArgs e)
        {
            //Increases score by one due to correct click
            scoreh = +1;
            textBox1.Text = Convert.ToString(scoreh);
            //Opens next level
            this.Hide();
            var Hard2 = new Hard2();
            Hard2.Closed += (s, args) => this.Close();
            Hard2.Show();
        }

        private void pic9_Click(object sender, EventArgs e)
        {
            //Keeps score the same due to incorrect click
            textBox1.Text = Convert.ToString(scoreh);
            //Opens next level
            this.Hide();
            var Hard2 = new Hard2();
            Hard2.Closed += (s, args) => this.Close();
            Hard2.Show();
        }
    }
}
