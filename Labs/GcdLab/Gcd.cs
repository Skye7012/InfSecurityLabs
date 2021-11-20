using Labs.Servise;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;

namespace Labs.GcdLab
{
	public class Gcd
	{
		/// <summary>
		/// Вычислить Нод и х, y
		/// </summary>
		/// <param name="_a"></param>
		/// <param name="_b"></param>
		/// <param name="gcd">НОД</param>
		/// <param name="_x"></param>
		/// <param name="_y"></param>
		public static void Calculate(BigInteger _a, BigInteger _b,
			out BigInteger gcd, out BigInteger _x, out BigInteger _y)
		{
			var vars = new List<(BigInteger A, BigInteger B)>() { (_a, _b) };
			var operations = new List<(BigInteger mod, BigInteger div)>() { (_a % _b, _a / _b) };

			if (_a % _b == 0)
				gcd = _b;
			else
			{
				for (int i = 1; ; i++)
				{
					vars.Add((vars[i - 1].B, operations[i - 1].mod));
					var a = vars[i].A;
					var b = vars[i].B;
					operations.Add((a % b, a / b));

					if (a % b == 0)
					{
						gcd = vars.Last().B;
						break;
					}
				}
			}

			var res = InitializeRes(vars.Count);

			for (int i = vars.Count - 1 - 1; i >= 0; i--)
			{
				var x = res[i + 1].x;
				var y = res[i + 1].y;
				var newY = x - y * operations[i].div;
				res[i] = (y, newY);
			}

			_x = res.First().x;
			_y = res.First().y;
		}

		static List<(BigInteger x, BigInteger y)> InitializeRes(int num)
		{
			List<(BigInteger x, BigInteger y)> res = new List<(BigInteger x, BigInteger y)>() { (0, 1) };

			for (int i = 1; i < num; i++)
			{
				res.Add((0, 0));
			}

			res.Reverse();

			return res;
		}
	}
}
