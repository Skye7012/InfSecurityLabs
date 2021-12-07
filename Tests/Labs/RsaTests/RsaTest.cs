using Labs.GcdLab;
using Labs.MillerRabinLab;
using Labs.PowLab;
using Labs.RsaLab;
using Labs.Servise;
using System;
using System.Collections.Generic;
using System.Numerics;
using Xunit;

namespace Tests
{
	public class RsaTest
	{
		private readonly string text;

		public RsaTest()
		{
			text = "HelloKitty";
		}

		[Fact]
		public void ProperlyRequest_ShouldSolve()
		{
			BigInteger p = 977;
			BigInteger q = 149;

			Rsa rsa = new Rsa(p, q);

			Assert.Equal(p * q, rsa.N);
			Assert.Equal((p - 1) * (q - 1), rsa.Phi);

			Assert.True(Is_e_Correct(rsa));
			Assert.True(Is_d_Correct(rsa));

			var encrypted = rsa.Encrypt(text);
			var expectedEnc = StringToIdslist("113268 5453 52276 15760 52276 46311 15760 52276");
			Assert.Equal(expectedEnc, encrypted);

			var decrypted = rsa.Decrypt(encrypted);
			var expectedDec = text;
			Assert.Equal(expectedDec, decrypted);
		}

		[Fact]
		public void RandomRequest_ShouldSolve()
		{
			for (int i = 0; i < 100; i++)
			{
				int bitSize = new Random().Next(5, 40);

				Rsa rsa = new Rsa(bitSize);

				var p = rsa.P;
				var q = rsa.Q;

				Assert.True(MillerRabin.IsPrime(p));
				Assert.True(MillerRabin.IsPrime(q));

				Assert.Equal(p * q, rsa.N);
				Assert.Equal((p - 1) * (q - 1), rsa.Phi);

				//Is E correct
				Assert.True(rsa.E >= 2 && rsa.E < rsa.N);
				Assert.True(Gcd.Calculate(rsa.Phi, rsa.E) == 1);
				Assert.True(rsa.E.GetLength() == rsa.N.GetLength() / 3);

				//Is d correct
				Assert.True(rsa.D > 1 && rsa.D < rsa.N);
				Assert.True((rsa.E * rsa.D) % rsa.Phi == 1);

				var encrypted = rsa.Encrypt(text);
				var decrypted = rsa.Decrypt(encrypted);
				var expectedDec = text;
				Assert.Equal(expectedDec, decrypted);
			}
		}

		[Fact]
		public void SmallBitSize_Exception()
		{
			Assert.Throws<Exception>(() => new Rsa(4));
			Assert.Throws<Exception>(() => new Rsa(3));
			Assert.Throws<Exception>(() => new Rsa(2));
			Assert.Throws<Exception>(() => new Rsa(1));
		}

		bool Is_e_Correct(Rsa rsa)
	=> (rsa.E >= 2 && rsa.E < rsa.N)
		&& Gcd.Calculate(rsa.Phi, rsa.E) == 1
		&& rsa.E.GetLength() == rsa.N.GetLength() / 3;

		bool Is_d_Correct(Rsa rsa)
			=> (rsa.D > 1 && rsa.D < rsa.N)
				&& (rsa.E * rsa.D) % rsa.Phi == 1;

		List<BigInteger> StringToIdslist(string text)
		{
			var stringIds = text.Split(' ');
			var ids = new List<BigInteger>();

			foreach (var index in stringIds)
			{
				ids.Add(BigInteger.Parse(index));
			}

			return ids;
		}
	}
}
