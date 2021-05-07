using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace OneArmedBandit
{
    public partial class Form1 : Form
    {
        // random number generator
        Random randGen = new Random();

        // int value for score initialized to 10
        int score = 10;
        int firstReel;
        int secondReel;
        int thirdReel;

        public Form1()
        {
            InitializeComponent();
        }

        private void spinButton_Click(object sender, EventArgs e) 
        {
            // get random values for each reel (store each in separate int variable)
            firstReel = randGen.Next(1, 4);
            secondReel = randGen.Next(1, 4);
            thirdReel = randGen.Next(1, 4);
            //score = Convert.ToInt32(scoreDisplay.Text);

            // check value of reel 1 with a switch statement to set appropriate image to
            // BackgroundImage property of pictureBox. Get images from Properties.Resources
            switch (firstReel)
            {
                case 1:
                    pictureBox1.BackgroundImage = Properties.Resources.cherry_100x125;
                    break;
                case 2:
                    pictureBox1.BackgroundImage = Properties.Resources.diamond_100x125;
                    break;
                case 3:
                    pictureBox1.BackgroundImage = Properties.Resources._7_100x125;
                    break;
            }

            // check value of reel 2 with a switch statement to set appropriate image to
            // BackgroundImage property of pictureBox. Get images from Properties.Resources
            switch (secondReel)
            {
                case 1:
                    pictureBox2.BackgroundImage = Properties.Resources.cherry_100x125;
                    break;
                case 2:
                    pictureBox2.BackgroundImage = Properties.Resources.diamond_100x125;
                    break;
                case 3:
                    pictureBox2.BackgroundImage = Properties.Resources._7_100x125;
                    break;
            }

            // check value of reel 3 with a switch statement to set appropriate image to
            // BackgroundImage property of pictureBox. Get images from Properties.Resources
            switch (thirdReel)
            {
                case 1:
                    pictureBox3.BackgroundImage = Properties.Resources.cherry_100x125;
                    break;
                case 2:
                    pictureBox3.BackgroundImage = Properties.Resources.diamond_100x125;
                    break;
                case 3:
                    pictureBox3.BackgroundImage = Properties.Resources._7_100x125;
                    break;
            }

            /// STOP HERE ----------------------------------------------------------
            /// Test to make sure that your program will display random
            /// images to each reel. Only continue on after you know this works
            /// --------------------------------------------------------------------


            // Use compound if statement to check if all reels are equal. 
            // If yes show "winner" statement and add 3 to score.
            // If no show "play again" statement and subtract 1 from score.         
            if (firstReel == secondReel && thirdReel == firstReel)
            {
                outputLabel.Text = "Winner!";
                score = score + 3;
            }
            else
            {
                outputLabel.Text = "Play again";
                score--;
            }

            // if score has reached 0 display "lose" message and set button enabled property to false
            if (score == 0)
            {
                spinButton.Enabled = false;
                outputLabel.Text = "You Lose!";
            }

            // display updated score
            scoreDisplay.Text = $"{score.ToString()}";
        }
    }
}
