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
        string ComputerC;

        static int ComputerScore = 0;
        public void ComputerChoice()
        {
            

            int CC = 0;
            Random rnd = new Random();
            CC = rnd.Next(1, 4);

            if (CC == 1)
            {
                ComputerC = "Rock";
                ComputerPicBox.Image = Properties.Resources.Rock;
                ComputerPicBox.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            else if (CC == 2)
            {
                ComputerC = "Paper";
                ComputerPicBox.Image = Properties.Resources.Paper;
                ComputerPicBox.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            else if (CC == 3)
            {
                ComputerC = "Scissor";
                ComputerPicBox.Image = Properties.Resources.Scissor;
                ComputerPicBox.SizeMode = PictureBoxSizeMode.StretchImage;
            }


        }

    }
}
