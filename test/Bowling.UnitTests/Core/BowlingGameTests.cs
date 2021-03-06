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

            RollZeros(20, game);

            Assert.Equal(0, game.GetScore());
        }

        [Fact]
        public void Score_should_be_10_when_rolled_one_spare()
        {
            var game = new BowlingGame();

            game.Roll(3);
            game.Roll(7);

            RollZeros(18, game);

            Assert.Equal(10, game.GetScore());
        }

        [Fact]
        public void Score_should_be_17_when_rolled_one_spare_with_bonus()
        {
            var game = new BowlingGame();

            game.Roll(3);
            game.Roll(7);
            game.Roll(7);

            RollZeros(17, game);

            Assert.Equal(24, game.GetScore());
        }

        [Fact]
        public void Score_should_be_30_when_rolled_a_strike_with_a_spare()
        {
            var game = new BowlingGame();

            game.Roll(10);
            game.Roll(3);
            game.Roll(7);

            RollZeros(71, game);

            Assert.Equal(30, game.GetScore());
        }

        [Fact]
        public void Score_should_be_300_when_rolled_12_strikes()
        {
            var game = new BowlingGame();

            RollStrike(12, game);

            Assert.Equal(300, game.GetScore());
        }

        [Fact]
        public void Score_should_be_291_when_rolled_11_strikes_and_1()
        {
            var game = new BowlingGame();

            RollStrike(11, game);
            game.Roll(1);

            Assert.Equal(291, game.GetScore());
        }

        [Fact]
        public void Score_should_be_266_when_rolled_9_strikes_and_8_and_1()
        {
            var game = new BowlingGame();

            RollStrike(9, game);
            game.Roll(8);
            game.Roll(1);

            Assert.Equal(266, game.GetScore());
        }

        [Fact]
        public void Score_should_be_270_when_rolled_9_strikes_a_spare_and_1()
        {
            var game = new BowlingGame();

            RollStrike(9, game);
            game.Roll(9);
            game.Roll(1);
            game.Roll(1);

            Assert.Equal(270, game.GetScore());
        }

        private static void RollZeros(int times, BowlingGame game) => Roll(0, times, game);

        private static void RollStrike(int times, BowlingGame game) => Roll(10, times, game);

        private static void Roll(int pins, int times, BowlingGame game)
        {
            for (int i = 0; i < times; i++)
            {
                game.Roll(pins);
            }
        }
    }
}
