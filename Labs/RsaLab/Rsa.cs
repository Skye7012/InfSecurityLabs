using Labs.GcdLab;
using Labs.MillerRabinLab;
using Labs.PowLab;
using Labs.Service;
using Labs.Servise;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;

namespace Labs.RsaLab
{
	public class Rsa
	{
		public BigInteger P { get; protected set; }
		public BigInteger Q { get; protected set; }
		public BigInteger N { get; protected set; }
		public BigInteger Phi { get; protected set; }
		public BigInteger E { get; protected set; }
		public BigInteger D { get; protected set; }

		private Win1251Alphabet _alphabet;

		/// <summary>
		/// Конструтор
		/// </summary>
		/// <param name="p"></param>
		/// <param name="q"></param>
		public Rsa(BigInteger bitSize)
		{
			if (bitSize < 5)
				throw new Exception("Too small bit Size, it must be at least bigger than 4");

			while (true)
			{
				try
				{
					_alphabet = new Win1251Alphabet();

					BigInteger p = MillerRabin.GeneratePrimeNumber(bitSize);
					BigInteger q = MillerRabin.GeneratePrimeNumber(bitSize);
					while (p == q)
						q = MillerRabin.GeneratePrimeNumber(bitSize);

					P = p;
					Q = q;

					N = p * q;
					Phi = (p - 1) * (q - 1);

					E = GenerateE();
					D = GenerateD();

					break;
				}
				catch { }
			}


		}

		/// <summary>
		/// Конструтор
		/// </summary>
		/// <param name="p">Простое число</param>
		/// <param name="q">Простое число</param>
		[Obsolete]
		public Rsa(BigInteger p, BigInteger q)
		{
			N = p * q;
			Phi = (p - 1) * (q - 1);

			if (N < 2)
				throw new Exception("Wrong Argruments");

			E = GenerateE();
			D = GenerateD();
		}

		/// <summary>
		/// Зашифровывает сообщение
		/// </summary>
		/// <param name="text">Исходный текст</param>
		/// <returns>Коллекцию индексов символов</returns>
		public BigInteger Encrypt(string text)
		{
			var num = _alphabet.ConvertTextToIdsNumber(text);
			return ModPow.Calculate(num, E, N);
		}

		/// <summary>
		/// Расшифровывает сообщение
		/// </summary>
		/// <param name="indexes">Коллекция индексов символов</param>
		/// <returns>Расшифровыванное сообщение</returns>
		public string Decrypt(List<BigInteger> indexes)
		{
			StringBuilder res = new StringBuilder();

			foreach (var id in indexes)
			{
				BigInteger bPlainId = ModPow.Calculate(id, D, N);
				//int plainId = (int) (bPlainId%65536);
				int plainId = (int)(bPlainId);
				res.Append((char)plainId);
			}

			return res.ToString();
		}

		/// <summary>
		/// Расшифровывает сообщение
		/// </summary>
		/// <param name="cryptogram">Криптограма</param>
		/// <returns>Расшифровыванное сообщение</returns>
		public string Decrypt(BigInteger cryptogram)
		{
			var plainTextDigits = ModPow.Calculate(cryptogram, D, N).ToString();
			var ids = new List<int>();

			var res = new StringBuilder();
			for(int i = 0; i < plainTextDigits.Length; i+=2)
			{
				string idString = plainTextDigits[i].ToString() + plainTextDigits[i + 1].ToString();
				var id = int.Parse(idString);
				res.Append(_alphabet.GetLetter(id));
			}

			return res.ToString();
		}

		/// <summary>
		/// Геренерирует e
		/// </summary>
		/// <returns></returns>
		public BigInteger GenerateE()
		{
			int length = N.GetLength()/3;

			if (length < 1)
				throw new Exception("Too small N value");

			BigInteger res = BigInteger.Parse
				(new string
				(Enumerable.Repeat('9', length)
					.ToArray()));
			while (Gcd.Calculate(Phi,res) != 1)
				res -= 1;

			if (!(res >= 2 && res < N))
				throw new Exception("Cannot generate E");

			return res;
		}

		/// <summary>
		/// Генерирует d
		/// </summary>
		public BigInteger GenerateD()
		{
			if (E == default(BigInteger))
				throw new Exception("Not initialized E");

			BigInteger gcd, x, y;
			Gcd.Calculate(Phi, E, out gcd, out x, out y);

			if (y < 0)
				y += Phi;

			if (!(y > 1 && y < N))
				throw new Exception("Cannot generate D");

			return y;
		}
	}
}
