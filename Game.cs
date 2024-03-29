﻿using System;
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

        public void UC_4_RepeatTillWin()
        {
            int ladder = 1;
            int snake = 2;
            //int ladDie;
            //int snkDie;
            int win = 100;
            int number = 0;

            while (number <= win)
            {
                number++;
                if (number >= 0)
                {
                    int randomCheck;
                    Random random = new Random();
                    randomCheck = random.Next(3);

                    switch (randomCheck)
                    {
                        case 1:
                            {
                                Random random1 = new Random();
                                ladder = random1.Next(1, 7);
                                number = number + ladder;
                                Console.WriteLine("You Got A Ladder ");
                                break;
                            }
                        case 2:
                            {
                                Random random2 = new Random();
                                snake = random2.Next(1, 7);
                                number = number - snake;
                                Console.WriteLine("You Got A Snake");
                                break;
                            }
                        default:
                            {
                                Console.WriteLine("You Not Play");
                                break;
                            }
                    }

                }
                else
                {
                    number = 0;
                }

            }
            Console.WriteLine(" Congratulation! you won " + number);
        }

        public void UC_5_EnsureWinPosition()
        {
            int ladder = 1;
            int snake = 2;
            int ladDie = 0;
            int snkDie;
            int win = 100;
            int number = 0;
            int store = 0;

            while (number != win)
            {
                if (number >= 0 && number < 100)
                {
                    int randomCheck;
                    Random random = new Random();
                    randomCheck = random.Next(3);

                    switch (randomCheck)
                    {
                        case 1:
                            {
                                Console.WriteLine("You Got A Ladder ");
                                Random random1 = new Random();
                                ladDie = random1.Next(1, 7);
                                number = number + ladDie;
                                store = number;
                                break;
                            }
                        case 2:
                            {
                                Random random2 = new Random();
                                snkDie = random2.Next(1, 7);
                                number = number - snkDie;
                                Console.WriteLine("You Got A Snake");
                                break;
                            }
                        default:
                            {
                                Console.WriteLine("You Not Play");
                                break;
                            }
                    }

                }
                else if (store > 100)
                {
                    number = store - ladDie;
                }
                else
                {
                    number = 0;
                }

            }
            Console.WriteLine(" Congratulation! you won " + number);
        }

        public void UC_6_ReportTheNumberOfTimes()
        {
            int ladder = 1;
            int snake = 2;
            int ladDie = 0;
            int snkDie;
            int win = 100;
            int number = 0;
            int numOfRoll = 0;
            int store = 0;

            while (number != win)
            {
                if (number >= 0 && number < 100)
                {
                    int randomCheck;
                    Random random = new Random();
                    randomCheck = random.Next(3);
                    numOfRoll++;

                    switch (randomCheck)
                    {
                        case 1:
                            {
                                Console.WriteLine("You Got A Ladder And Position : " + number);
                                Random random1 = new Random();
                                ladDie = random1.Next(1, 7);
                                number = number + ladDie;
                                store = number;
                                break;
                            }
                        case 2:
                            {
                                Random random2 = new Random();
                                snkDie = random2.Next(1, 7);
                                number = number - snkDie;
                                Console.WriteLine("You Got A Snake And Position : " + number);
                                break;
                            }
                        default:
                            {
                                Console.WriteLine("You Not Play And Position : " + number);
                                break;
                            }
                    }

                }
                else if (store > 100)
                {
                    number = store - ladDie;
                }
                else
                {
                    number = 0;
                }

            }
            Console.WriteLine("Total Number Of Roll Dice : " + numOfRoll);
            Console.WriteLine(" Congratulation! you won " + number);
        }
    }
}
