using System;
using System.Collections.Generic;
using System.Linq;
using NUnit.Framework;

namespace Katas.PrimeFactors
{
	[TestFixture]
	public class PrimeFactorsTest
	{
		[Test]
		public void Test1()
		{
			var factors = PrimeFactors.Generate(1);

			Assert.AreEqual(0, factors.Length);
		}

		[Test]
		public void Test2()
		{
			var factors = PrimeFactors.Generate(2);

			Assert.AreEqual(new [] { 2 }, factors);
		}

		[Test]
		public void Test3()
		{
			var factors = PrimeFactors.Generate(3);

			Assert.AreEqual(new [] { 3 }, factors);
		}

		[Test]
		public void Test4()
		{
			var factors = PrimeFactors.Generate(4);

			Assert.AreEqual(new [] { 2, 2 }, factors);
		}

		[Test]
		public void Test6()
		{
			var factors = PrimeFactors.Generate(6);

			Assert.AreEqual(new [] { 2, 3 }, factors);
		}

		[Test]
		public void Test8()
		{
			var factors = PrimeFactors.Generate(8);

			Assert.AreEqual(new [] { 2, 2, 2 }, factors);
		}

		[Test]
		public void Test9()
		{
			var factors = PrimeFactors.Generate(9);

			Assert.AreEqual(new [] { 3, 3 }, factors);
		}

		[Test]
		public void Test12()
		{
			var factors = PrimeFactors.Generate(12);

			Assert.AreEqual(new [] { 2, 2, 3 }, factors);
		}
	}
}
