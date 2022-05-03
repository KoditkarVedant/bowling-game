using System.Collections.Generic;

namespace Bowling.Core
{
    public class BowlingGame
    {
        private List<int> rolls = new List<int>();

        public void Roll(int pins)
        {
            rolls.Add(pins);
        }

        public int GetScore()
        {
            int score = 0;
            int rollIndex = 0;

            for (int frame = 0; frame < 10; frame++)
            {
                score += rolls[rollIndex] + rolls[rollIndex + 1];

                rollIndex += 2;
            }

            return score;
        }
    }
}
