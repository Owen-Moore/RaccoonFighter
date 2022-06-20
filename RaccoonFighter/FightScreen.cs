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


        private void timer1_Tick(object sender, EventArgs e)
        {
            rhpLabel.Text = $"{raccoonHP}";
            phpLabel.Text = $"{playerHP}";

        }
        //public void PlayerTurn()
        //{
        //    attackButton.Enabled = true;
        //    if ()
        //    {
               

        //    }
        //}
        private void attackButton_Click(object sender, EventArgs e)
        {
            raccoonHP -= 3;
            battleLabel.Text = "Player dealt 3 damage";
            RaccoonTurn();

        }
        public void RaccoonTurn()
        {
            attackButton.Enabled = false;
            
            if (raccoonHP > 10 && battleLabel.Text = "Player dealt 3 damage")
            {
                battleLabel.Text = "Dave's turn";
                System.Threading.Thread.Sleep(10000);
                playerHP -= 4;
                battleLabel.Text = "Dave dealt 3 damage";
                attackButton.Enabled = true;
            }
        }

    }
}
