using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace RPSGame
{
    partial class RPSForm
    {
        static int RoundNumber = 0;

        NameForm form1 = new NameForm();
        private void RestartButton_Click(object sender, EventArgs e)
        {
            Reset();
            this.Close();
            Thread form1 = new Thread(new ThreadStart(Form1));

            form1.Start();

            
        }

        public void Form1()
        {
            Application.Run(form1);
        }

        public void Reset()
        {
            PlayerScore = 0; PlayerBox.Text = null;
            ComputerScore = 0; ComputerBox.Text = null;
            RoundNumber = 0;
            dataGridView.Rows.Clear();
            dataGridView.Refresh();
            timer1.Stop();
            TimerDisplay.Text = null;
            Time = NameForm.TNum * 60;
            timer1.Start();
            PlayerPicBox.Image = null;
            ComputerPicBox.Image = null;
        }
    }
}
