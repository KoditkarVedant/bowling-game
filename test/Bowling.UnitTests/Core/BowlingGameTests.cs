using Bowling.Core;
using Xunit;

namespace Bowling.UnitTests.Core
{
    public class BowlingGameTests
    {
        [Fact]
        public void Score_should_be_0_when_rolled_all_0()
        {
            var game = new BowlingGame();

            for (int i = 0; i < 20; i++)
            {
                game.Roll(0);
            }

            Assert.Equal(0, game.GetScore());
        }

        [Fact]
        public void Score_should_be_10_when_rolled_one_spare()
        {
            var game = new BowlingGame();

            game.Roll(3);
            game.Roll(7);

            for (int i = 2; i < 20; i++)
            {
                game.Roll(0);
            }

            Assert.Equal(10, game.GetScore());
        }
    }
}
