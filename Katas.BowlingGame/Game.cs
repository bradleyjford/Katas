using System;

namespace Katas.BowlingGame
{
	public class Game
	{
		private int[] _rolls = new int[21];
		private int _rollIndex;

		public void Roll(int pins)
		{
			_rolls[_rollIndex++] = pins;
		}

		public int Score
		{
			get
			{
				var score = 0;
				var frameIndex = 0;

				for (var frame = 0; frame < 10; frame++)
				{
					if (IsStrike(frameIndex))
					{
						score += 10 + GetStrikeBonus(frameIndex);

						frameIndex++;
					}
					else if (IsSpare(frameIndex))
					{
						score += 10 + GetSpareBonus(frameIndex);
						frameIndex += 2;
					}
					else
					{
						score += GetFrameTotal(frameIndex);
						frameIndex += 2;
					}
				}
					
				return score;
			}
		}

		private bool IsStrike(int frameIndex)
		{
			return _rolls[frameIndex] == 10;
		}

		private bool IsSpare(int frameIndex)
		{
			return GetFrameTotal(frameIndex) == 10;
		}

		private int GetStrikeBonus(int frameIndex)
		{
			return GetFrameTotal(frameIndex + 1);
		}

		private int GetSpareBonus(int frameIndex)
		{
			return _rolls[frameIndex + 2];
		}

		private int GetFrameTotal(int frameIndex)
		{
			return _rolls[frameIndex] + _rolls[frameIndex + 1];
		}
	}
}
