using System;
using System.Linq;

namespace Katas.BowlingGame
{
	public class Game
	{
		private int[] _rolls = new int[21];
		private int _currentRoll;

		public void Roll(int pins)
		{
			_rolls[_currentRoll++] = pins;
		}

		public int Score
		{
			get
			{
				var score = 0;
				var frameIndex = 0;

				for (var frame = 0; frame < 10; frame++)
				{
					if (IsStrikeFrame(frameIndex))
					{
						score += 10 + GetStrikeBonus(frameIndex);
						frameIndex++;
					}
					else if (IsSpareFrame(frameIndex))
					{
						score += 10 + GetSpareBonus(frameIndex);
						frameIndex += 2;
					}
					else
					{
						score += _rolls[frameIndex] + _rolls[frameIndex + 1];
						frameIndex += 2;
					}
				}

				return score;
			}
		}

		private bool IsStrikeFrame(int frameIndex)
		{
			return _rolls[frameIndex] == 10;
		}

		private int GetStrikeBonus(int frameIndex)
		{
			return _rolls[frameIndex + 1] + _rolls[frameIndex + 2];
		}

		private bool IsSpareFrame(int frameIndex)
		{
			return _rolls[frameIndex] + _rolls[frameIndex + 1] == 10;
		}

		private int GetSpareBonus(int frameIndex)
		{
			return _rolls[frameIndex + 2];
		}
	}
}