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
    public partial class RPSForm : Form
    {
        string PlayerName = NameForm.PlayerName;

        int Time = NameForm.TNum*60;
        public RPSForm()
        {
            InitializeComponent();
            
            dataGridView.Columns[1].HeaderText = PlayerName;
            PlayerLabel1.Text = PlayerName;
            PlayerLabel2.Text = PlayerName;

            timer1.Enabled = true;
            timer1.Start();


            
            

            if (GridCheckBox.Checked)
            {
                dataGridView.CellBorderStyle = DataGridViewCellBorderStyle.Single;
            }
            else
            {
                dataGridView.CellBorderStyle = DataGridViewCellBorderStyle.None;
            }
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        public void Tie(int rn)
        {
            dataGridView.Rows.Add(rn, PlayerChoice, ComputerC, "Tie");
            MessageBox.Show("Its A Tie in Round " + rn);

        }

        public void ComputerWins(int rn)
        {

            dataGridView.Rows.Add(rn, PlayerChoice, ComputerC, "Computer");
            ComputerScore++;
            ComputerBox.Text = Convert.ToString(ComputerScore);
            MessageBox.Show("Computer Wins in Round " + rn);
        }

        public void PlayerWins(int rn)
        {
            dataGridView.Rows.Add(rn, PlayerChoice, ComputerC, PlayerName);
            PlayerScore++;
            PlayerBox.Text = Convert.ToString(PlayerScore);
            MessageBox.Show(PlayerName + " Wins in Round " + rn);
        }

        private void GridCheckBox_CheckStateChanged(object sender, EventArgs e)
        {
            if(GridCheckBox.Checked)
            {
                dataGridView.CellBorderStyle = DataGridViewCellBorderStyle.Single;
            }
            else
            {
                dataGridView.CellBorderStyle = DataGridViewCellBorderStyle.None;
            }
            
        }

        

        private void HelpButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("1. Press The Buttons Rock/Paper/Scissor to Choose your object" + "\n" +
                "2. Press the 'Restart' Button to Restart the Game" + "\n" +
                "3. The Data GridView Shows the Scores in Each Round" + "\n" +
                "4. The TextBoxes show Your or " + PlayerName + "'s Score And Computer's Score in total" + "\n" +
                "5. Check the Checkbox - 'Enable GridLines' to Enable GridLines");
        }


        public void CheckTimer()
        {
            if(TimerDisplay.Text == "0")
            {
                MessageBox.Show("Time Up");
                TimeUpCheckWinner();
            }
        }
        private void TimerDisplay_TextChanged(object sender, EventArgs e)
        {
            CheckTimer();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            TimerDisplay.Text = Convert.ToString(Time--);
        }
    }
}
