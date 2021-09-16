using CaesarCipher.BaseClasses;
using CaesarCipher.Interfaces;
using System;
using System.Collections.Generic;
using System.Numerics;
using System.Text;

namespace CaesarCipher
{
	public class VigenereCipherKey: IValidable
	{
		//public VigenereCipherKey(Alphabet alphabet)
		//	=> KeyAlphabet = alphabet.CurrentAlphabet;
		public bool IsValid(string text)
		{
			BigInteger steps;
			return BigInteger.TryParse(text, out steps);
		}
	}
}
