using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleGame
{
    internal class Game
    {
        private bool run;

        private Board board;
        private Player player;
        private Enemy ball;

        public Game()
        {
            run = true;
            board = new Board(20, 10);
            player = new Player(0, 0, board.Width, board.Height);
            ball = new Enemy(5, 5, board.Width, board.Height);
        }

        public void Run()
        {
            while(run)
            {
                Console.Clear();
                board.DrawBoard(player, ball);

                if(player.GetX() == ball.GetX() && player.GetY() == ball.GetY())
                    break;

                DrawCommands();

                HandleInputs(GetInput());
                ball.SetX();
                ball.SetY();

                //Console.ReadKey();
            }

            Console.WriteLine("\nYOU WON :)");
            Console.ReadKey();
            Console.Clear();

        }

        private void DrawCommands()
        {
            Console.WriteLine("\n1. Up");
            Console.WriteLine("2. Down");
            Console.WriteLine("3. Right");
            Console.WriteLine("4. Left");
        }

        private int GetInput()
        {
            Console.WriteLine("\nInput: ");

            try
            {
                int input = int.Parse(Console.ReadLine());
                return (input > 9) ? input / 10 : input;
            }
            catch(Exception)
            {
                
            }

            return 0;
        }

        private void HandleInputs(int input)
        {
            switch (input)
            {
                case 1:
                    player.SetY(player.GetY() - 1);
                    break;
                case 2:
                    player.SetY(player.GetY() + 1);
                    break;
                case 3:
                    player.SetX(player.GetX() + 1);
                    break;
                case 4:
                    player.SetX(player.GetX() - 1);
                    break;
                default:
                    break;
            }
        }
    }
}
