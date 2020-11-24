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
        
        public void CheckWinner()
        {

            if (RoundNumber == NameForm.RNum && ComputerScore == PlayerScore)
            {
                MessageBox.Show("Its A Tie" +"\n"+ "After Playing " + RoundNumber + " Rounds" +"\n"+ "NOBODY WINS");
                Reset();


            }
            else if (RoundNumber == NameForm.RNum && ComputerScore > PlayerScore)
            {
                MessageBox.Show("Computer Wins !!" +"\n"+ "After Playing " + RoundNumber + " Rounds");
                Reset();

            }
            else if (RoundNumber == NameForm.RNum && ComputerScore < PlayerScore)
            {
                MessageBox.Show(PlayerName + " Wins !!" + "\n" + "After Playing " + RoundNumber + " Rounds");
                Reset();

            }

        }

        public void TimeUpCheckWinner()
        {
            if (ComputerScore == PlayerScore)
            {
                MessageBox.Show("Its A Tie" + "\n" + "After Playing " + RoundNumber + " Rounds" + "\n" + "NOBODY WINS");
                Reset();


            }
            else if (ComputerScore > PlayerScore)
            {
                MessageBox.Show("Computer Wins !!" + "\n" + "After Playing " + RoundNumber + " Rounds");
                Reset();

            }
            else if (ComputerScore < PlayerScore)
            {
                MessageBox.Show(PlayerName + " Wins !!" + "\n" + "After Playing " + RoundNumber + " Rounds");
                Reset();

            }
        }
    }
}
