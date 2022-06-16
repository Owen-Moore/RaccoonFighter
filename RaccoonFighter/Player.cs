using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace RaccoonFighter
{
    public class Player
    {
        public int x, y, xspeed, yspeed, width, height;
        public Color color;

        public Player(int _x, int _y, Color _color, int _xspeed, int _yspeed, int _width, int _height)
        {
            x = _x;
            y = _y;
            xspeed = _xspeed;
            yspeed = _yspeed;
            color = _color;
            width = _width;
            height = _height;   
        }

        public void Move(string direction)
        {
            if (direction == "left")
            { 
                x -= xspeed;
            }
            if (direction == "right")
            {
                x += xspeed;
            }
            if (direction == "up")
            {
                y -= yspeed;
            }
            if (direction == "down")
            { 
                y += yspeed;
            }
        }

        public void RaccoonCollison(GameScreen gs)
        {
            Rectangle playerRec = new Rectangle(x, y, width, height);
            Rectangle raccoonRec = new Rectangle(700, gs.Height / 2, 20, 20);

            if(playerRec.IntersectsWith(raccoonRec))
            {
                FightScreen fs = new FightScreen();
                gs.Controls.Add(fs);

                fs.Location = new Point((gs.Width - fs.Width) / 2, (gs.Height - fs.Height) / 2);
            }
        }
    }
}
