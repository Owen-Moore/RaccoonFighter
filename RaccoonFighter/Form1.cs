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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            MenuScreen ms = new MenuScreen();
            this.Controls.Add(ms);

            ms.Location = new Point((this.Width - ms.Width) / 2, (this.Height - ms.Height) / 2);
        }
        public static void ChangeScreen(object sender, UserControl next)

        {

            Form f; // will either be the sender or parent of sender 



            if (sender is Form)

            {

                f = (Form)sender;

            }

            else

            {

                UserControl current = (UserControl)sender;

                f = current.FindForm();

                f.Controls.Remove(current);

            }



            next.Location = new Point((f.ClientSize.Width - next.Width) / 2,

                (f.ClientSize.Height - next.Height) / 2);



            f.Controls.Add(next);

            next.Focus();

        }
    }
}
