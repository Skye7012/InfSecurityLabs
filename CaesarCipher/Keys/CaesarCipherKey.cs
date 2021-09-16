using CaesarCipher.BaseClasses;
using CaesarCipher.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;

namespace CaesarCipher
{
	public class CaesarCipherKey :  IValidable
	{
		//public BigInteger Steps { get; protected set; }

		//public CaesarCipherKey(BigInteger steps)
		//	=> Steps = steps;

		public bool IsValid(string text)
		{
			BigInteger steps;
			return BigInteger.TryParse(text, out steps);
		}
	}
}
