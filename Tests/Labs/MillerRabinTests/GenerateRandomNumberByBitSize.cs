using Labs.MillerRabinLab;
using System;
using System.Numerics;
using Xunit;

namespace Tests
{
	public class GenerateRandomNumberByBitSize
	{
		[Fact]
		public void ProperlyRequest_ShouldSolve()
		{
			var bigInteger =MillerRabin.GenerateRandomNumberByBitSize(512);
			var size = bigInteger.ToString().Length;
			Assert.InRange(size, 150, 155);
		}
	}
}
