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
                if (rolls[rollIndex] + rolls[rollIndex + 1] == 10)
                {
                    score += 10 + rolls[rollIndex + 2];
                }
                else
                {
                    score += rolls[rollIndex] + rolls[rollIndex + 1];
                }

                rollIndex += 2;
            }

            return score;
        }
    }
}
