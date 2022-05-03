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
                if (IsStrike(rollIndex))
                {
                    score += 10 + rolls[rollIndex + 1] + rolls[rollIndex + 2];
                    rollIndex += 1;
                }
                else if (IsSpare(rollIndex))
                {
                    score += 10 + rolls[rollIndex + 2];
                    rollIndex += 2;
                }
                else
                {
                    score += rolls[rollIndex] + rolls[rollIndex + 1];
                    rollIndex += 2;
                }
            }

            return score;
        }

        private bool IsSpare(int rollIndex) => rolls[rollIndex] + rolls[rollIndex + 1] == 10;

        private bool IsStrike(int rollIndex) => rolls[rollIndex] == 10;
    }
}
