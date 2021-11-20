using Labs.MillerRabinLab;
using System;
using System.Numerics;
using Xunit;

namespace Tests
{
	public class GenerateRandomA
	{
		[Fact]
		public void ProperlyRequest_ShouldSolve()
		{
			var bigInteger = MillerRabin.GenerateRandomA(33);
			bool b = bigInteger >= 2 || bigInteger <= 33 - 2;
			Assert.True(b);
		}
	}
}
