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
			var actual = Gcd.Calculate(x.a, x.b, x.mod);
				Assert.Equal(x.expected,actual);
		}

		[Fact]
		public void NotProperlyRequest_ShouldSolveIT()
		{
			foreach (var x in _notPropVars)
			{
				var actual = ModPow.Calculate(x.a, x.b, x.mod);
				Assert.NotEqual(x.expected, actual);
			}
		}

		[Fact]
		public void DivideByZeroException()
		{
			Assert.Throws<DivideByZeroException>( () => ModPow.Calculate(1,1,0));
		}

		[Fact]
		public void BigNumbers()
		{
			BigInteger a = BigInteger.Parse("11231232312311231232312353453535452352345234112312323123112312323123534535354523523452346654656");
			BigInteger b = BigInteger.Parse("11231232312311231232312353453535452352345234112312323123112312323123534535354523523452346654656423423545345345");
			BigInteger mod = BigInteger.Parse("112312323123112312323123534545234112312323123112312323123534535354523523452346654656423423545345345");
			var expected = BigInteger.ModPow(a, b, mod);
			var actual = ModPow.Calculate(a, b, mod);

			//"69596851053739570716432202477456780810195556305253437318262107164635743247833817765618322929492606"

			Assert.Equal(expected, actual);
		}
	}
}
