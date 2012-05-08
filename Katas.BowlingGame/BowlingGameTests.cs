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

		[Test]
		public void TestGutterBallGame()
		{
			RollMany(20, 0);

			Assert.AreEqual(0, _game.Score);
		}

		private void RollMany(int rolls, int pins)
		{
			for (var roll = 0; roll < rolls; roll++)
			{
				_game.Roll(pins);
			}
		}

		[Test]
		public void TestOnePinGame()
		{
			RollMany(20, 1);

			Assert.AreEqual(20, _game.Score);
		}

		[Test]
		public void TestSpareGame()
		{
			RollSpare();
			
			_game.Roll(3);

			RollMany(17, 0);

			Assert.AreEqual(16, _game.Score);
		}

		private void RollSpare()
		{
			_game.Roll(5);
			_game.Roll(5);
		}

		[Test]
		public void TestStrikeGame()
		{
			RollStrike();

			_game.Roll(3);
			_game.Roll(4);

			RollMany(16, 0);

			Assert.AreEqual(24, _game.Score);
		}

		private void RollStrike()
		{
			_game.Roll(10);
		}

		[Test]
		public void TestPerfectGame()
		{
			RollMany(12, 10);

			Assert.AreEqual(300, _game.Score);
		}
	}
}
