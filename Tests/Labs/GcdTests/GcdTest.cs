using Labs.GcdLab;
using Labs.PowLab;
using System;
using System.Collections.Generic;
using System.Numerics;
using Xunit;

namespace Tests
{
	public class GcdTest
	{
		[Fact]
		public void A_Bigger()
		{
			BigInteger gcd, x, y;

			Gcd.Calculate(70, 60, out gcd, out x, out y);

			Assert.Equal(10,gcd);
			Assert.Equal(1,x);
			Assert.Equal(-1,y);
		}

		[Fact]
		public void A_Less()
		{
			BigInteger gcd, x, y;

			Gcd.Calculate(30, 56, out gcd, out x, out y);

			Assert.Equal(2, gcd);
			Assert.Equal(-13, x);
			Assert.Equal(7, y);
		}

		[Fact]
		public void AModBIs0()
		{
			BigInteger gcd, x, y;

			Gcd.Calculate(36, 6, out gcd, out x, out y);

			Assert.Equal(6, gcd);
			Assert.Equal(0, x);
			Assert.Equal(1, y);

			Gcd.Calculate(6, 36, out gcd, out x, out y);

			Assert.Equal(6, gcd);
			Assert.Equal(1, x);
			Assert.Equal(0, y);
		}

		[Fact]
		public void AIsB()
		{
			BigInteger gcd, x, y;

			Gcd.Calculate(77, 77, out gcd, out x, out y);

			Assert.Equal(77, gcd);
			Assert.Equal(0, x);
			Assert.Equal(1, y);
		}

		[Fact]
		public void BigNumber()
		{
			BigInteger a = BigInteger.Parse("11231232312311231232312353453535452352345234112312323123112312323123534535354523523452346654656");
			BigInteger b = BigInteger.Parse("23452341123123231231123123231235345353545235234523466546564234235453453451123123231231123123231235345353545235");

			BigInteger gcd, x, y;

			Gcd.Calculate(a, b, out gcd, out x, out y);

			Assert.Equal(13, gcd);
			Assert.Equal(BigInteger.Parse("662986343628637211856134460192133306446158652092979267507865060829709733184755516447479918579451310837405343"), x);
			Assert.Equal(BigInteger.Parse("-317501506825745719709674277099570782978794148939751650650185136970334532282635995376174782817"), y);
		}
	}
}
