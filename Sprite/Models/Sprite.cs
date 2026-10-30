using System;
using System.Collections.Generic;
using System.Text;

namespace Sprite.Models
{
    public class Sprite
    {
        public int x;
        public int y;
        public int maxX;
        public int maxY;
        public string name;
        public void Move(int dx, int dy)
        {
            x += dx;
            if (x > maxX) x -= maxX;
            if (x < 0) x += maxX;
            y += dy;
            if (y > maxX) y -= maxY;
            if (y < 0) y += maxY;
        }
        public bool IsAt(int x, int y)
        {
            return this.x == x && this.y == y;
        }
        public void ShowPosition()
        {
            Console.WriteLine($"{name}: ({x}, {y})");
        }
        public Sprite(string name, int x, int y, int maxX = 10, int maxY = 10)
        {
            this.name = name;
            this.x = x;
            this.y = y;
            this.maxX = maxX;
            this.maxY = maxY;

        }
    }
}
