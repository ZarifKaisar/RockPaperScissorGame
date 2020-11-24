using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RPSGame
{
    partial class RPSForm
    {
        string PlayerChoice;

        static int PlayerScore = 0;
        private void RockButton_Click(object sender, EventArgs e)
        {
            RoundNumber++;
            int rn = RoundNumber;

            PlayerChoice = "Rock";

            PlayerPicBox.Image = Properties.Resources.Rock;
            PlayerPicBox.SizeMode = PictureBoxSizeMode.StretchImage;
            ComputerChoice();


            if (PlayerChoice == ComputerC)
            {
                Tie(rn);
            }
            else if (ComputerC == "Paper")
            {
                ComputerWins(rn);
            }
            else if (ComputerC == "Scissor")
            {
                PlayerWins(rn);
            }
            CheckWinner();


        }
        private void PaperButton_Click(object sender, EventArgs e)
        {
            RoundNumber++;
            int rn = RoundNumber;
            PlayerChoice = "Paper";

            PlayerPicBox.Image = Properties.Resources.Paper;
            PlayerPicBox.SizeMode = PictureBoxSizeMode.StretchImage;
            ComputerChoice();

            if (PlayerChoice == ComputerC)
            {
                Tie(rn);

            }
            else if (ComputerC == "Scissor")
            {
                ComputerWins(rn);
            }
            else if (ComputerC == "Rock")
            {
                PlayerWins(rn);
            }
            CheckWinner();



        }

        private void ScissorButton_Click(object sender, EventArgs e)
        {
            RoundNumber++;
            int rn = RoundNumber;
            PlayerChoice = "Scissor";

            PlayerPicBox.Image = Properties.Resources.Scissor;
            PlayerPicBox.SizeMode = PictureBoxSizeMode.StretchImage;
            ComputerChoice();

            if (PlayerChoice == ComputerC)
            {
                Tie(rn);

            }
            else if (ComputerC == "Rock")
            {
                ComputerWins(rn);

            }
            else if (ComputerC == "Paper")
            {
                PlayerWins(rn);
            }
            CheckWinner();



        }
    }
}
