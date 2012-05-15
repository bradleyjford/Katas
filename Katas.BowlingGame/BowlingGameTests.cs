using System;
using Xunit;

namespace Katas.BowlingGame
{
	public class BowlingGameTests
	{
		private Game _game;

		public BowlingGameTests()
		{
			_game = new Game();
		}

		private void RollMany(int rolls, int pins)
		{
			for (var i = 0; i < rolls; i++)
			{
				_game.Roll(pins);
			}
		}

		[Fact]
		public void TestGutterBallGame()
		{
			RollMany(20, 0);

			Assert.Equal(0, _game.Score);
		}

		[Fact]
		public void TestAllOnePinGame()
		{
			RollMany(20, 1);

			Assert.Equal(20, _game.Score);
		}

		[Fact]
		public void TestSpareGame()
		{
			_game.Roll(5);
			_game.Roll(5);

			_game.Roll(3);

			RollMany(17, 0);

			Assert.Equal(16, _game.Score);
		}

		[Fact]
		public void TestStrikeGame()
		{
			_game.Roll(10);
			_game.Roll(3);
			_game.Roll(4);

			RollMany(16, 0);

			Assert.Equal(24, _game.Score);
		}

		[Fact]
		public void TestPerfectGame()
		{
			RollMany(12, 10);

			Assert.Equal(300, _game.Score);
		}
	}
}
