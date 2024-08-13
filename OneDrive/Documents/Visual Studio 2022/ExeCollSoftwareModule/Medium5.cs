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
    public partial class Medium5 : Form
    {
        //variable for the users current score
        public static int scorem5;
        public Medium5()
        {
            InitializeComponent();
            //parses the score to this level
            scorem5 = Medium4.scorem4;
            //converts the score to a displayable format
            labelScore.Text = Convert.ToString(scorem5);
        }
        private void labelScore_TextChanged(object sender, EventArgs e)
        {   //displays current score
            Console.WriteLine(scorem5);
        }

        private void pic1_Click(object sender, EventArgs e)
        {
            //keeps the score the same due to incorrect click
            labelScore.Text = Convert.ToString(scorem5);
            //opens up the next level upon succesfully completing the current level
            this.Hide();
            var MediumEnd = new MediumEnd();
            MediumEnd.Closed += (s, args) => this.Close();
            MediumEnd.Show();
        }

        private void pic2_Click(object sender, EventArgs e)
        {
            //increases the users score by one as they have clicked the correct box
            scorem5 = scorem5 + 1;
            labelScore.Text = Convert.ToString(scorem5);
            //opens up the next level upon succesfully completing the current level
            this.Hide();
            var MediumEnd = new MediumEnd();
            MediumEnd.Closed += (s, args) => this.Close();
            MediumEnd.Show();
        }

        private void pic3_Click(object sender, EventArgs e)
        {
            //keeps the score the same due to incorrect click
            labelScore.Text = Convert.ToString(scorem5);
            //opens up the next level upon succesfully completing the current level
            this.Hide();
            var MediumEnd = new MediumEnd();
            MediumEnd.Closed += (s, args) => this.Close();
            MediumEnd.Show();
        }

        private void pic4_Click(object sender, EventArgs e)
        {
            //keeps the score the same due to incorrect click
            labelScore.Text = Convert.ToString(scorem5);
            //opens up the next level upon succesfully completing the current level
            this.Hide();
            var MediumEnd = new MediumEnd();
            MediumEnd.Closed += (s, args) => this.Close();
            MediumEnd.Show();
        }

        private void pic5_Click(object sender, EventArgs e)
        {
            //keeps the score the same due to incorrect click
            labelScore.Text = Convert.ToString(scorem5);
            //opens up the next level upon succesfully completing the current level
            this.Hide();
            var MediumEnd = new MediumEnd();
            MediumEnd.Closed += (s, args) => this.Close();
            MediumEnd.Show();
        }

        private void pic6_Click(object sender, EventArgs e)
        {
            //keeps the score the same due to incorrect click
            labelScore.Text = Convert.ToString(scorem5);
            //opens up the next level upon succesfully completing the current level
            this.Hide();
            var MediumEnd = new MediumEnd();
            MediumEnd.Closed += (s, args) => this.Close();
            MediumEnd.Show();
        }
    }
}
