using Labs.GcdLab;
using Labs.MillerRabinLab;
using Labs.PowLab;
using Labs.Service;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Numerics;
using System.Text;

namespace Labs.RsaBreakingLab
{
	class RsaBreaking
	{
		public static BigInteger BreakN(BigInteger N)
		{
			BigInteger x = MillerRabin.GenerateRandomNumber(1, N - 1);
			BigInteger y = 1;
			int i = 0;
			int stage = 2;
			while (Gcd.Calculate(N, BigInteger.Abs(x - y)) == 1)
			{
				if (i == stage)
				{
					y = x;
					stage *= 2;
				}
				x = (x * x + 1) % N;
				i++;
			}

			return Gcd.Calculate(N, BigInteger.Abs(x - y));
		}

		public static void BreakN(BigInteger N, out BigInteger p, out BigInteger q)
		{
			BigInteger x = MillerRabin.GenerateRandomNumber(1, N - 1);
			BigInteger y = 1;
			int i = 0;
			int stage = 2;
			while (Gcd.Calculate(N, BigInteger.Abs(x - y)) == 1)
			{
				if (i == stage)
				{
					y = x;
					stage *= 2;
					Debug.WriteLine(stage);
				}
				x = (x * x + 1) % N;
				i++;
			}

			p = Gcd.Calculate(N, BigInteger.Abs(x - y));
			q = N / p;
		}

		/// <summary>
		/// Расшифровывает сообщение
		/// </summary>
		/// <param name="cryptogram">Криптограма</param>
		/// <returns>Расшифровыванное сообщение</returns>
		public static string Decrypt(BigInteger cryptogram, BigInteger d, BigInteger n)
		{
			var alphabet = new Win1251Alphabet();

			var plainTextDigits = ModPow.Calculate(cryptogram, d, n).ToString();
			var ids = new List<int>();

			var res = new StringBuilder();
			for (int i = 0; i < plainTextDigits.Length; i += 2)
			{
				string idString = plainTextDigits[i].ToString() + plainTextDigits[i + 1].ToString();
				var id = int.Parse(idString);
				res.Append(alphabet.GetLetter(id));
			}

			return res.ToString();
		}

		/// <summary>
		/// Генерирует d
		/// </summary>
		public static BigInteger FindD(BigInteger phi, BigInteger e, BigInteger n)
		{
			if (e == default(BigInteger))
				throw new Exception("Not initialized E");

			BigInteger gcd, x, y;
			Gcd.Calculate(phi, e, out gcd, out x, out y);

			if (y < 0)
				y += phi;

			if (!(y > 1 && y < n))
				throw new Exception("Cannot generate D");

			return y;
		}
	}
}
