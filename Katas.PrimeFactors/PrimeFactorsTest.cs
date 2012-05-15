using System;
using Xunit;

namespace Katas.PrimeFactors
{
	public class PrimeFactorsTest
	{
		[Fact]
		public void Test1()
		{
			var factors = PrimeFactors.Generate(1);

			Assert.Equal(0, factors.Length);
		}

		[Fact]
		public void Test2()
		{
			var factors = PrimeFactors.Generate(2);

			Assert.Equal(new [] { 2 }, factors);
		}

		[Fact]
		public void Test3()
		{
			var factors = PrimeFactors.Generate(3);

			Assert.Equal(new [] { 3 }, factors);
		}

		[Fact]
		public void Test4()
		{
			var factors = PrimeFactors.Generate(4);

			Assert.Equal(new [] { 2, 2 }, factors);
		}

		[Fact]
		public void Test6()
		{
			var factors = PrimeFactors.Generate(6);

			Assert.Equal(new [] { 2, 3 }, factors);
		}

		[Fact]
		public void Test8()
		{
			var factors = PrimeFactors.Generate(8);

			Assert.Equal(new [] { 2, 2, 2 }, factors);
		}

		[Fact]
		public void Test9()
		{
			var factors = PrimeFactors.Generate(9);

			Assert.Equal(new [] { 3, 3 }, factors);
		}

		[Fact]
		public void Test12()
		{
			var factors = PrimeFactors.Generate(12);

			Assert.Equal(new [] { 2, 2, 3 }, factors);
		}
	}
}
