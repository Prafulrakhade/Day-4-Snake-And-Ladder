using System;

namespace SnakeAndLadder
{
    public class Program
    {
        static void Main(string[] args)
        {
            Game check = new Game();
            check.UC_1_Player();
            check.UC_2_RollDice();
            check.UC_3_CheckOptions();
        }
    }
}
