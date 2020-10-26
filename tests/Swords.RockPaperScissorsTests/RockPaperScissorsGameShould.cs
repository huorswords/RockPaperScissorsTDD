using System;
using Xunit;

namespace Swords.RockPaperScissorsTests
{
    public class RockPaperScissorsGameShould
    {
        internal virtual IRockPaperScissorsGame CreateGame()
        {
            // TODO: Add or remove any initialization here
        }

        [Fact]
        public void ThrowArgumentOutOfRangeException_When_AnyArgumentIsNone()
        {
            IRockPaperScissorsGame game = CreateGame();

            Assert.Throws<ArgumentOutOfRangeException>(() => game.Play(HandType.None, HandType.Paper));
        }

        [Fact]
        public void ReturnScissors_When_PassScissorsAndPaperAsParameters()
        {
            IRockPaperScissorsGame game = CreateGame();

            HandType expectedWinnerHand = HandType.Scissors;
            var winnerHand = game.Play(HandType.Scissors, HandType.Paper);

            Assert.Equal(expectedWinnerHand, winnerHand);
        }

        [Fact]
        public void ReturnScissors_When_PassPaperAndScissorsAsParameters()
        {
            IRockPaperScissorsGame game = CreateGame();

            var expectedWinnerHand = HandType.Scissors;
            HandType winnerHand = game.Play(HandType.Scissors, HandType.Paper);

            Assert.Equal(expectedWinnerHand, winnerHand);
        }

        [Fact]
        public void ReturnPaper_When_PassStoneAndPaperAsParameters()
        {
            IRockPaperScissorsGame game = CreateGame();

            var expectedWinnerHand = HandType.Paper;
            HandType winnerHand = game.Play(HandType.Stone, HandType.Paper);

            Assert.Equal(expectedWinnerHand, winnerHand);
        }

        [Fact]
        public void ReturnStone_When_PassStoneAndScissorsAsParameters()
        {
            IRockPaperScissorsGame game = CreateGame();

            var expectedWinnerHand = HandType.Stone;
            HandType winnerHand = game.Play(HandType.Stone, HandType.Scissors);

            Assert.Equal(expectedWinnerHand, winnerHand);
        }

        // TODO: Add or remove any new test here.
        // a) Return none when deuce.
        // b) Throw exception when both are none.
    }
}
