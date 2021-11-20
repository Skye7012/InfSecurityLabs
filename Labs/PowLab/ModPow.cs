using Labs.Servise;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;

namespace Labs.PowLab
{
	public class ModPow
	{
		/// <summary>
		/// Вычислить возведение в степень по модулю
		/// </summary>
		/// <param name="a">Возводимое число</param>
		/// <param name="b">Степень</param>
		/// <param name="mod">Модуль</param>
		/// <returns>Ответ</returns>
		public static BigInteger Calculate(BigInteger a, BigInteger b, BigInteger mod)
		{
			var binDegree = b.ToBinaryString();

			if (binDegree.Length == 1)
				return a % mod;
			else if (a == 0)
				return 1 % mod;
			else if (mod == 0)
				throw new Exception("Модуль не может быть равен нулю");

			var aS = new List<BigInteger>() { a };


			for (int i = 1; i < binDegree.Length; i++)
			{
				int bin = Convert.ToInt32(binDegree[i].ToString());

				if (bin == 0)
					aS.Add((aS[i - 1] * aS[i - 1]) % mod);
				else if (bin == 1)
					aS.Add((aS[i - 1] * aS[i - 1] * a) % mod);
			}

			return aS.Last();
		}
	}
}
