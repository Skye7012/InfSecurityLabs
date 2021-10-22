using Cryptography.Interfaces;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Linq;

namespace XorManulKey
{
	public class XorCipher : ICryptographer
	{
		private readonly Alphabet _alphabet;

		public XorCipher(Alphabet alphabet)
			=> _alphabet = alphabet;

		public string Encrypt(string binText, string binKey)
		{
			return MakeSipherSteps(binText, binKey);
		}

		public string Decrypt(string gamma, string binKey)
		{
			return MakeSipherSteps(gamma, binKey);
		}

		public string MakeSipherSteps(string binText, string binKey)
		{
			var intLetters = _alphabet.GetIntsFromBinaries(binText);
			var intKeys = _alphabet.GetIntsFromBinaries(binKey);
			StringBuilder res = new StringBuilder();

			for (int i = 0, j = 0;
				i < intLetters.Length;
				i++, j = (j + 1) % intKeys.Length)
			{
				var newSymbol = intLetters[i] ^ intKeys[j];

				var str = Convert.ToString(newSymbol, 2).
					PadLeft(_alphabet.BinaryLength, '0');

				res.Append(str);
			}

			return res.ToString();
		}

		//List<string> GetSplittedBinaries(string text)
		//{
		//	var keyLength = _alphabet.BinaryLength;
		//	var keys = new List<string>();

		//	for (int i = 0; i < text.Length; i += keyLength)
		//	{
		//		keys.Add(text.Substring(i, keyLength));
		//	}

		//	return keys;
		//}

		//int[] GetIntsFromBinaries(string text)
		//	=> GetSplittedBinaries(text).Select(x => Convert.ToInt32(x, 2)).ToArray();

	}
}
