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
        public int x, y, speed, width, height;
        public Color color;

        public Player(int _x, int _y, Color _color, int _speed, int _width, int _height)
        {
            x = _x;
            y = _y;
            speed = _speed;
            color = _color;
            width = _width;
            height = _height;   
        }

        public void Move(string direction)
        {
            if (direction == "left")
            { 
                x -= speed;
            }
            if (direction == "right")
            {
                x += speed;
            }
            if (direction == "up")
            {
                y -= speed;
            }
            if (direction == "down")
            { 
                y += speed;
            }
        }
    }
}
