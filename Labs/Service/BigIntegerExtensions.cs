using System;
using System.Collections.Generic;
using System.Text;

namespace Labs.Servise
{
	using System;
	using System.Numerics;
	using System.Text;
	using System.Windows.Forms;

	public static class BigIntegerExtensions
	{
		public static string ToBinaryString(this BigInteger bigint)
		{
			Stack<char> stack = new Stack<char>();

			BigInteger mod;
			BigInteger div;

			do
			{
				mod = bigint % 2;
				div = bigint / 2;
				if (div == 0)
				{
					stack.Push('1');
					break;
				}
				stack.Push(Convert.ToString(mod)[0]);
				bigint = div;
			}
			while (true);

			return new string(stack.ToArray());
		}
		public static int GetLength(this BigInteger bigint)
		{
			string str = Convert.ToString(bigint);
			return str.Length;
		}
	}
}


