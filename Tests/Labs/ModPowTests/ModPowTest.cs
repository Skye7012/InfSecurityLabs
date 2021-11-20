using Labs.PowLab;
using System;
using System.Collections.Generic;
using System.Numerics;
using Xunit;

namespace Tests
{
	public class ModPowTest
	{
		private readonly List<(BigInteger a, BigInteger b, BigInteger mod, BigInteger expected)> _propVars;
		private readonly List<(BigInteger a, BigInteger b, BigInteger mod, BigInteger expected)> _notPropVars;

		public ModPowTest()
		{
			_propVars = new List<(BigInteger a, BigInteger b, BigInteger mod, BigInteger expected)>()
				{
					(9,40,3,0),
					(7,35,5,3),
					//(0,22,6,1),
					//(0,22,1,0),
					(1,22,1,0),
					(1,22,8,1),

					(12,54,7,1),
				};

			_notPropVars = new List<(BigInteger a, BigInteger b, BigInteger mod, BigInteger expected)>()
				{
					(12,54,7,5),
				};
		}

		[Fact]
		public void ProperlyRequest_ShouldSolveIT()
		{
			foreach (var x in _propVars)
			{
				var actual = ModPow.Calculate(x.a, x.b, x.mod);
				Assert.Equal(x.expected,actual);
			}
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
			Assert.Throws<DivideByZeroException>( () => ModPow.Calculate(0,1,1));
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
