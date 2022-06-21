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
    public partial class GameScreen : UserControl
    {

        Player player;
        SolidBrush playerBrush = new SolidBrush(Color.White);
        SolidBrush raccoonBrush = new SolidBrush(Color.Gray);


        Boolean leftArrowDown, rightArrowDown, upArrowDown, downArrowDown;

        private void GameScreen_Load(object sender, EventArgs e)
        {

        }

        public void OnStart()
        {
            int playerWidth = 20;
            int playerHeight = 20;
            int playerX = 100;//((this.Width / 2) - (playerWidth / 2));
            int playerY = 230;//(this.Height - playerHeight) - 60;
            int playerXSpeed = 8;
            int playerYSpeed = 8;
            player = new Player(playerX, playerY, Color.Black, playerXSpeed, playerYSpeed, playerWidth, playerHeight);

            leftArrowDown = rightArrowDown = upArrowDown = downArrowDown = false;

            gameTimer.Enabled = true;

            
        }
        private void timer1_Tick(object sender, EventArgs e)
        {

            if (leftArrowDown && player.x > 48)
            {
                player.Move("left");
            }
            if (rightArrowDown && player.x < (793 - player.width))
            {
                player.Move("right");
            }
            if (downArrowDown && player.y < (356 - player.height))
            {
                player.Move("down");
            }
            if (upArrowDown && player.y > 98)
            {
                player.Move("up");
            }

            Rectangle playerRec = new Rectangle(player.x, player.y, player.width, player.height);
            Rectangle raccoonRec = new Rectangle(700, this.Height / 2, 20, 20);

            if (playerRec.IntersectsWith(raccoonRec))
            {
                gameTimer.Enabled = false;
                Form1.ChangeScreen(this, new FightScreen());
            }



            Refresh();
        }

      

        private void GameScreen_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.FillRectangle(playerBrush, player.x, player.y, player.width, player.height);

            e.Graphics.FillRectangle(raccoonBrush, 700, this.Height/2, 20, 20);
        }

        

        public GameScreen()
        {
            InitializeComponent();
            OnStart();
        }
        private void GameScreen_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Left:
                    leftArrowDown = true;
                    break;
                case Keys.Right:
                    rightArrowDown = true;
                    break;
                case Keys.Up:
                    upArrowDown = true;
                    break;
                case Keys.Down:
                    downArrowDown = true;
                    break;
                default:
                    break;
            }
        }
        private void GameScreen_KeyUp(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Left:
                    leftArrowDown = false;
                    break;
                case Keys.Right:
                    rightArrowDown = false;
                    break;
                case Keys.Up:
                    upArrowDown = false;
                    break;
                case Keys.Down:
                    downArrowDown = false;
                    break;
                default:
                    break;
            }
        }


    }
}
