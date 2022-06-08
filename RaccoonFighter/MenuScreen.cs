﻿using System;
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
    public partial class MenuScreen : UserControl
    {
        public MenuScreen()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            GameScreen gs = new GameScreen();
            this.Controls.Add(gs);
            Form form = this.FindForm();
           
            form.Controls.Remove(this);

            gs.Location = new Point((this.Width - gs.Width) / 2, (this.Height - gs.Height) / 2);
        }
    }
}
