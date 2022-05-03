using Bowling.Core;
using System;

namespace Bowling.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var rolls = new[] { 10, 9, 1, 5, 5, 7, 2, 10, 10, 10, 9, 0, 8, 2, 9, 1, 10 };

            var game = new BowlingGame();

            for(int i = 0; i < rolls.Length; i++)
            {
                game.Roll(rolls[i]);
            }

            Console.WriteLine("Score is: {0}", game.GetScore());
        }
    }
}
