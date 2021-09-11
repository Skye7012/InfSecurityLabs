using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace CaesarCipher.Alphabets
{
	class EnglishAlphabet
	{
		public char[] AlphabetChars { get; } = "0123456789ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz".ToCharArray();
		public List<char> TestAlphabetChars { get; protected set; } = new List<char>();

		public EnglishAlphabet()
		{
			for (char c = '0'; c <= '9'; c++)
			{
				TestAlphabetChars.Add(c);
			}
			for (char c = 'A'; c <= 'Z'; c++)
			{
				TestAlphabetChars.Add(c);
			}
			for (char c = 'a'; c <= 'z'; c++)
			{
				TestAlphabetChars.Add(c);
			}
		}

	}
}
