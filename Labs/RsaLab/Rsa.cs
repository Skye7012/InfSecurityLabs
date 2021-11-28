using Labs.GcdLab;
using Labs.MillerRabinLab;
using Labs.PowLab;
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
		public BigInteger N { get; protected set; }
		public BigInteger Phi { get; protected set; }
		public BigInteger E { get; protected set; }
		public BigInteger D { get; protected set; }
		public Rsa(BigInteger p, BigInteger q)
		{
			N = p * q;
			Phi = (p - 1) * (q - 1);

			if (N < 2)
				throw new Exception("Wrong Argruments");

			E = GenerateE();
			D = GenerateD();
		}

		public BigInteger GenerateE()
		{
			int length = N.GetLength()/3;

			if (length < 1)
				throw new Exception("To small N value");

			BigInteger res = BigInteger.Parse
				(new string
				(Enumerable.Repeat('9', length)
					.ToArray()));
			while (Gcd.Calculate(N,res) != 1)
				res -= 1;

			return res;
		}

		public BigInteger GenerateD()
		{
			if (N == default(BigInteger))
				throw new Exception("Not initialized N");

			BigInteger gcd, x, y;
			Gcd.Calculate(E, Phi, out gcd, out x, out y);
			BigInteger d = 1;
			while(x < 0)
			{
				d++;
				Gcd.Calculate(E*d, Phi, out gcd, out x, out y);

				if (d >= N - 1)
					throw new Exception("Cannot Generate D");
			}

			if(x * d >= N - 1)
				throw new Exception("Cannot Generate D");

			return x * d;
		}
	}
}
