using System;
using System.Collections.Generic;

namespace Katas.PrimeFactors
{
	public static class PrimeFactors
	{
		public static int[] Generate(int n)
		{
			var factors = new List<int>();

			for (var candidate = 2; n > 1; candidate++)
			{
				for (; n % candidate == 0; n /= candidate )
				{
					factors.Add(candidate);
				}
			}

			return factors.ToArray();
		} 
	}
}
