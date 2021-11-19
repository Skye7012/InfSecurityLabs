using Labs.MillerRabinLab;
using System;
using System.Numerics;
using Xunit;

namespace Tests
{
	public class MillerRabinTest
	{
		private readonly BigInteger m127;
		private readonly BigInteger m521;

		public MillerRabinTest()
		{
			m127 = GetMNubmer(127);
			m521 = GetMNubmer(521);
		}

		[Fact]
		public void SendN_ShouldReturnTrue()
		{
			Assert.True(MillerRabin.IsPrime(2));
			Assert.True(MillerRabin.IsPrime(3));
			Assert.True(MillerRabin.IsPrime(3571));
			Assert.True(MillerRabin.IsPrime(m127));
			Assert.True(MillerRabin.IsPrime(m521));
			Assert.True(MillerRabin.IsPrime(GetMNubmer(607)));
			//Assert.True(MillerRabin.IsPrime(GetMNubmer(1279)));
		}

		[Fact]
		public void SendN_ShouldReturnFalse()
		{
			Assert.False(MillerRabin.IsPrime(1));
			Assert.False(MillerRabin.IsPrime(3570));
			Assert.False(MillerRabin.IsPrime(3572));
			Assert.False(MillerRabin.IsPrime(8000000000));
		}

		BigInteger GetMNubmer(int n)
		{
			return BigInteger.Pow(2, n) - 1;
		}
	}
}
