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
    public partial class NameForm : Form
    {
        public static string PlayerName;
        public static int RNum = 0;
        public static int TNum = 0;
        public NameForm()
        {
            InitializeComponent();
            
            
        }
        
        public void StartForm2()
        {
            Application.Run(new RPSForm());
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            
            

            if(NameBox.Text.Length > 20 || NameBox.Text.Length < 1)
            {
                MessageBox.Show("Please Enter A Name Between 1 - 20 Characters");
            }
            else if(TimeBox.Text != "5" && TimeBox.Text != "3" && TimeBox.Text != "1")
            {
                MessageBox.Show("Please Enter A Timer Between 1/3/5 Minutes");
            }
            else if(RoundBox.Text != "5" && RoundBox.Text != "7" && RoundBox.Text != "10")
            {
                MessageBox.Show("Please Enter Rounds Between 5/7/10 Rounds");
            }
            else
            {
                PlayerName = NameBox.Text;
                TNum = Convert.ToInt32(TimeBox.Text);
                RNum = Convert.ToInt32(RoundBox.Text);
                this.Close();
                Thread frm2 = new Thread(new ThreadStart(StartForm2));
                
                frm2.Start();

            }

        }
    }
}
