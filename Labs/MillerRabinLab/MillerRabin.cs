﻿using System;
using System.Collections.Generic;
using System.Numerics;
using System.Text;
using System.Security.Cryptography;
using Labs.PowLab;

namespace Labs.MillerRabinLab
{
	public class MillerRabin
	{
		/// <summary>
		/// Проверяет является ли число вероятно простым
		/// </summary>
		/// <param name="n">число для проверки</param>
		/// <returns>True если число является вероятно простым
		/// , false если является составным</returns>
		public static bool IsPrime(BigInteger n)
		{
			if (n == 2 || n == 3)
				return true;
			else if (n == 1 || n.IsEven)
				return false;
			

			//кол-во раундов
			BigInteger r = (int)Math.Round(BigInteger.Log(n, 2));

			BigInteger s, t;

			To2PowSMultiT(n, out s, out t);

			for (int i = 0; i < r; i++)
			{
				BigInteger a = GenerateRandomA(n);

				BigInteger x = ModPow.Calculate(a, t, n);

				if (x == 1 || x == n - 1)
					continue;

				for (int j = 0; j < s - 1; j++)
				{
					x = ModPow.Calculate(x, 2, n);

					if (x == 1)
						return false;
					else if (x == n - 1)
						break;
				}

				if (x != n - 1)
					return false;
			}

			return true;
		}

		/// <summary>
		/// представить число n-1 в виде 2^s * t
		/// </summary>
		/// <param name="n">Исходное число</param>
		/// <param name="s">s</param>
		/// <param name="t">t</param>
		public static void To2PowSMultiT(BigInteger n,
			out BigInteger s, out BigInteger t)
		{
			s = 0;
			t = n - 1;
			while (t.IsEven)
			{
				t /= 2;
				s++;
			}
		}

		/// <summary>
		/// Сгенироровать случайное число a для алгоритма
		/// </summary>
		/// <param name="n">исходное число</param>
		/// <returns>a</returns>
		public static BigInteger GenerateRandomA(BigInteger n)
		{
			BigInteger a;

			do
			{
				var rng = new RNGCryptoServiceProvider();
				byte[] bytes = new byte[n.ToByteArray().LongLength];
				rng.GetBytes(bytes);

				a = new BigInteger(bytes);
			}
			while (!(a >= 2 && a <= n - 2));

			return a;
		}
	}
}
