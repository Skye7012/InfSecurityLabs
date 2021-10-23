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

		public string GenerateKey(string binText)
		{
			int length = binText.Length;

			string res = "";

			res += new string('0', length / 2);
			res += new string('1', length / 2);

			var rnd = new Random();
			res = String.Concat(res.OrderBy(x => rnd.Next()));

			return res;
		}
	}
}
