using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleGame
{
    abstract class Entity
    {
        protected int X;
        protected int Y;
        protected char Skin;
        protected ConsoleColor color;
        protected int bWidth;
        protected int bHeight;

        public Entity(int x, int y, int w, int h)
        {
            X = x;
            Y = y;
            bWidth = w;
            bHeight = h;
        }

        public int GetX()
        {
            return X;
        }

        public int GetY()
        {
            return Y;
        }

        public abstract void SetX();
        public abstract void SetY();

        public abstract void SetX(int x);
        public abstract void SetY(int y);

        public char GetSkin()
        {
            return Skin;
        }

        public ConsoleColor GetColor()
        {
            return color;
        }
    }
}
