﻿using System;
using NUnit.Framework;

namespace Katas.BowlingGame
{
	[TestFixture]
	public class BowlingGameTests
	{
		private Game _game;

		[SetUp]
		public void SetUp()
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

		[Test]
		public void TestAllOnePinGame()
		{
			RollMany(20, 1);

			Assert.AreEqual(20, _game.Score);
		}

		[Test]
		public void TestGutterBallGame()
		{
			RollMany(20, 0);

			Assert.AreEqual(0, _game.Score);
		}

		[Test]
		public void TestSpareGame()
		{
			_game.Roll(5);
			_game.Roll(5);
			_game.Roll(3);

			RollMany(17, 0);

			Assert.AreEqual(16, _game.Score);
		}

		[Test]
		public void TestStrikeGame()
		{
			_game.Roll(10);
			_game.Roll(4);
			_game.Roll(3);

			RollMany(16, 0);

			Assert.AreEqual(24, _game.Score);
		}

		[Test]
		public void TestPerfectGame()
		{
			RollMany(12, 10);

			Assert.AreEqual(300, _game.Score);
		}
	}
}
