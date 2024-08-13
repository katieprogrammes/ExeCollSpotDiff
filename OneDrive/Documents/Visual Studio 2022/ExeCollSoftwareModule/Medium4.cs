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
    public partial class Medium4 : Form
    {
        //variable for the users current score
        public static int scorem4;
        public Medium4()
        {
            InitializeComponent();
            //parses the score to this level
            scorem4 = Medium3.scorem3;
            //converts the score to a displayable format
            labelScore.Text = Convert.ToString(scorem4);
        }
        private void labelScore_TextChanged(object sender, EventArgs e)
        {   //displays current score
            Console.WriteLine(scorem4);
        }
        private void pic1_Click(object sender, EventArgs e)
        {
            //keeps the score the same due to incorrect click
            labelScore.Text = Convert.ToString(scorem4);
            //opens up the next level upon succesfully completing the current level
            this.Hide();
            var Medium5 = new Medium5();
            Medium5.Closed += (s, args) => this.Close();
            Medium5.Show();
        }

        private void pic2_Click(object sender, EventArgs e)
        {
            //keeps the score the same due to incorrect click
            labelScore.Text = Convert.ToString(scorem4);
            //opens up the next level upon succesfully completing the current level
            this.Hide();
            var Medium5 = new Medium5();
            Medium5.Closed += (s, args) => this.Close();
            Medium5.Show();
        }

        private void pic3_Click(object sender, EventArgs e)
        {
            //keeps the score the same due to incorrect click
            labelScore.Text = Convert.ToString(scorem4);
            //opens up the next level upon succesfully completing the current level
            this.Hide();
            var Medium5 = new Medium5();
            Medium5.Closed += (s, args) => this.Close();
            Medium5.Show();
        }

        private void pic4_Click(object sender, EventArgs e)
        {
            //keeps the score the same due to incorrect click
            labelScore.Text = Convert.ToString(scorem4);
            //opens up the next level upon succesfully completing the current level
            this.Hide();
            var Medium5 = new Medium5();
            Medium5.Closed += (s, args) => this.Close();
            Medium5.Show();
        }

        private void pic5_Click(object sender, EventArgs e)
        {
            //keeps the score the same due to incorrect click
            labelScore.Text = Convert.ToString(scorem4);
            //opens up the next level upon succesfully completing the current level
            this.Hide();
            var Medium5 = new Medium5();
            Medium5.Closed += (s, args) => this.Close();
            Medium5.Show();
        }

        private void pic6_Click(object sender, EventArgs e)
        {
            //increases the users score by one as they have clicked the correct box
            scorem4 = scorem4 + 1;
            labelScore.Text = Convert.ToString(scorem4);
            //opens up the next level upon succesfully completing the current level
            this.Hide();
            var Medium5 = new Medium5();
            Medium5.Closed += (s, args) => this.Close();
            Medium5.Show();
        }
    }
}
