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
    }
}
