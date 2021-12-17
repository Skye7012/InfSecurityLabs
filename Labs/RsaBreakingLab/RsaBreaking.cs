using Labs.GcdLab;
using Labs.MillerRabinLab;
using Labs.PowLab;
using Labs.Service;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Numerics;
using System.Text;
using System.Windows.Forms;

namespace Labs.RsaBreakingLab
{
	class RsaBreaking
	{
		BigInteger _n, _e;
		MyTimer _myTimer;
		public BigInteger Iter { get; set; }
		public BigInteger P { get; set; }
		public BigInteger Q { get; set; }
		public BigInteger Phi { get; set; }
		public BigInteger D { get; set; }
		public RsaBreaking( BigInteger n, BigInteger e)
		{
			_myTimer = new MyTimer();
			_n = n;
			_e = e;
			BreakN();
			FindD();
		}

		/// <summary>
		/// Расшифровать Криптограму
		/// </summary>
		/// <param name="cryptogram"></param>
		/// <returns></returns>
		public string Break(BigInteger cryptogram)
		{
			var alphabet = new Win1251Alphabet();

			var plainTextDigits = ModPow.Calculate(cryptogram, D, _n).ToString();

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
		/// Взломать N
		/// </summary>
		void BreakN()
		{
			string state = "";
			BigInteger x = MillerRabin.GenerateRandomNumber(1, _n - 1);
			BigInteger y = 1;
			int i = 0;
			int stage = 2;
			while (Gcd.Calculate(_n, BigInteger.Abs(x - y)) == 1)
			{
				if (i == stage)
				{
					state = $"{stage}\t{_myTimer.GetPast()}";
					Debug.WriteLine(state);
					y = x;
					stage *= 2;
				}
				x = (x * x + 1) % _n;
				i++;
			}
			Iter = i;
			P = Gcd.Calculate(_n, BigInteger.Abs(x - y));
			Q = _n / P;
		}

		/// <summary>
		/// Найти D
		/// </summary>
		public void FindD()
		{
			Phi = (P - 1) * (Q - 1);
			BigInteger gcd, x, y;
			Gcd.Calculate(Phi, _e, out gcd, out x, out y);

			if (y < 0)
				y += Phi;

			D = y;
		}
	}
}
