using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeAndLadder
{
    public class Game
    {

        public void UC_1_Player()
        {
            Console.WriteLine("++++++++++++++++++++ WELCOME TO SNAKE AND LADDER GAME ++++++++++++++++++++++++");
            Console.WriteLine("                                                                              ");
            Console.WriteLine("__________________________ Now Game Is Start _________________________________");
            Console.WriteLine("                                                                              ");
            Console.WriteLine("You Are In Base Position 0");
            Console.WriteLine("                                                                              ");
        }

        public void UC_2_RollDice()
        {
            int randomCheck;
            Random random = new Random();
            randomCheck = random.Next(1, 7);
            Console.WriteLine("You Rolls The Die To get a Number Between 1 to 6");
            Console.WriteLine("                                                                     ");
            Console.WriteLine("You Get a Die Number is = " + randomCheck);
            Console.WriteLine("                                                                     ");
        }

        public void UC_3_CheckOptions()
        {
            int ladder = 1;
            int snake = 2;
            int randomCheck;
            Random random = new Random();
            randomCheck = random.Next(3);
            switch (randomCheck)
            {
                case 1:
                    {
                        Random random1 = new Random();
                        ladder = random1.Next(1, 7);
                        Console.WriteLine(" Great! You Got A Ladder");
                        Console.WriteLine("                                                            ");
                        break;
                    }
                case 2:
                    {
                        Random random2 = new Random();
                        snake = random2.Next(1, 7);
                        Console.WriteLine(" Ohh! You Got A Snake");
                        Console.WriteLine("                                                            ");
                        break;
                    }
                default:
                    {
                        Console.WriteLine("You Not Play");
                        Console.WriteLine("                                                            ");
                        break;
                    }
            }

        }
    }
}
