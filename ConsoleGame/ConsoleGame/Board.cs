using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleGame
{
    internal class Board
    {
        private char tile;
        public int Width { get; private set; }
        public int Height { get; private set; }

        public char[,] cBoard { get; set; }

        public Board(int w, int h)
        {
            Width = w;
            Height = h;
            cBoard = new char[w, h];
            tile = '-';
            SetupBoard();
        }

        private void SetupBoard()
        {
            for(int i = 0; i < Height; i++)
                for(int j = 0; j < Width; j++)
                    cBoard[j, i] = tile;
        }

        public void DrawBoard(Player player, Enemy enemy)
        {

            for(int i = 0; i < Height; i++)
            {
                for(int j = 0; j < Width; j++)
                {
                    if (i == player.GetY() && j == player.GetX())
                    {
                        cBoard[j, i] = player.GetSkin();
                        Console.ForegroundColor = player.GetColor();
                    }
                    else if(i == enemy.GetY() && j == enemy.GetX())
                    {
                        cBoard[j, i] = enemy.GetSkin();
                        Console.ForegroundColor = enemy.GetColor();
                    }
                    else
                        cBoard[j, i] = tile;

                    Console.Write(cBoard[j, i]);

                    ResetColor();
                }
                Console.WriteLine();
            }
        }

        private void ResetColor()
        {
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}
