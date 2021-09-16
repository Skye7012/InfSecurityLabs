using CaesarCipher.BaseClasses;
using CaesarCipher.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;

namespace CaesarCipher
{
	public class CaesarCipherKey: Key
	{
		public BigInteger Steps { get; protected set; }

		public CaesarCipherKey()
			=> KeyAlphabet = "0123456789";
	}
}
