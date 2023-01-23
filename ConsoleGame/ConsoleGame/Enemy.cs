using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleGame
{
    internal class Enemy : Entity
    {
        private bool left = true;
        private bool up = true;

        public Enemy(int x, int y, int w, int h) : base(x, y, w, h)
        {
            Skin = 'o';
            color = ConsoleColor.Cyan;
        }

        public override void SetX()
        {
            if (X == 0)
                left = false;
            if (X == bWidth - 1)
                left = true;

            if (left)
                X--;
            else
                X++;
        }

        public override void SetY()
        {
            if (Y == 0)
                up = false;
            if (Y == bHeight - 1)
                up = true;

            if (up)
                Y--;
            else
                Y++;
        }

        // Overloaded methods
        public override void SetX(int x)
        {
        }

        public override void SetY(int y)
        {
        }
    }
}
