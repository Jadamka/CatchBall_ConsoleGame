using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleGame
{
    internal class Player : Entity
    {
        public Player(int x, int y, int w, int h) : base(x, y, w, h)
        {
            Skin = 'x';
            color = ConsoleColor.Green;
        }

        public override void SetX(int x)
        {
            X = x;

            if (X < 0)
                X = 0;
            else if (X > bWidth - 1)
                X = bWidth - 1;
        }

        public override void SetY(int y)
        {
            Y = y;

            if (Y < 0)
                Y = 0;
            else if (Y > bHeight - 1)
                Y = bHeight - 1;
        }

        // Overloaded methods
        public override void SetX()
        {
        }

        public override void SetY()
        {
        }
    }
}
