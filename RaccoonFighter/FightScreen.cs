using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RaccoonFighter
{
    public partial class FightScreen : UserControl
    {
        //declaring variables
        int playerHP = 30;
        int raccoonHP = 15;

        public FightScreen()
        {
            InitializeComponent();
            OnStart();
        }

        public void OnStart()
        {
            timer1.Enabled = true;
        }

        //minimal timer code
        private void timer1_Tick(object sender, EventArgs e)
        {
            rhpLabel.Text = $"{raccoonHP}";
            phpLabel.Text = $"{playerHP}";

            if (raccoonHP <= 0)
            {
                timer1.Enabled = false;
                Form1.ChangeScreen(this, new VictoryScreen());
            }
        }
      //player fight code
        private void attackButton_Click(object sender, EventArgs e)
        {
            raccoonHP -= 3;
            playerLabel.Text = "Player dealt 3 damage";
            System.Threading.Thread.Sleep(1000);
            RaccoonTurn();

        }
        private void runButton_Click(object sender, EventArgs e)
        {
            playerLabel.Text = "You cannot run from Dave, coward";
            RaccoonTurn();
        }

        private void itemButton_Click(object sender, EventArgs e)
        {
            playerLabel.Text = "No items, you are \nunprepared";
            RaccoonTurn();
        }
        //Raccoon fight code
        public void RaccoonTurn()
        {
            attackButton.Enabled = false;
            
            if (raccoonHP > 10 )
            {
                daveLabel.Text = "Dave's turn";
                System.Threading.Thread.Sleep(1000);
                playerHP -= 4;
                daveLabel.Text = "Dave dealt 4 damage";
                attackButton.Enabled = true;
            }
            if (raccoonHP < 10)
            {
                Random randGen = new Random();
                int move = randGen.Next(1, 3);
                if (move == 1)
                {
                    raccoonHP += 1;
                    daveLabel.Text = "Dave healed 1 hp";
                    System.Threading.Thread.Sleep(1000);
                    attackButton.Enabled = true;
                }
                else if(move == 2)
                {
                    daveLabel.Text = "Dave's turn";
                    System.Threading.Thread.Sleep(2000);
                    playerHP -= 4;
                    daveLabel.Text = "Dave dealt 4 damage";
                    attackButton.Enabled = true;
                }
            }
        }

      
    }
}
