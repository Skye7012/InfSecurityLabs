using CaesarCipher.BaseClasses;
using System;
using System.Collections.Generic;
using System.Text;

namespace CaesarCipher
{
	public class VigenereCipherKey: Key
	{
		public VigenereCipherKey(Alphabet alphabet)
			=> KeyAlphabet = alphabet.CurrentAlphabet;
	}
}
