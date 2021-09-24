using Cryptography.Interfaces;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Linq;

namespace Cryptography.CipherModes
{
	public class XorCipher : ICryptographer
	{
		private /*readonly*/ Alphabet _alphabet;

		public XorCipher(Alphabet alphabet)
		{
			_alphabet = alphabet;
		}

		public string Encrypt(string text, string key)
		{
			return MakeCipherSteps(text, key, true);
		}

		public string Decrypt(string text, string key)
		{
			return MakeCipherSteps(text, key, false);
		}

		public bool IsKeyValid(string key)
		{
			var chars =  new char[] { '0','1',' '};
			return key.All(x => chars.Contains(x));
		}

		private string MakeCipherSteps(string text, string key, bool IsEncrypt)
		{
			_alphabet = Alphabet.CreateTestAlphabet();
			int alphabetSize = _alphabet.CurrentAlphabet.Length;
			StringBuilder res = new StringBuilder();
			var intKeys = key.Split(' ', StringSplitOptions.RemoveEmptyEntries)
				.Select(x => Convert.ToInt32(x, 2)).ToArray();

			for (int i = 0, j = 0;
				i < text.Length;
				i++, j = (j + 1) % intKeys.Length)
			{
				var index = _alphabet.IndexOf(text[i]);
				var intKey = intKeys[j];

				var test = (index ^ intKey);
				index = (index ^ intKey) % alphabetSize;

				if (index < 0)
					index += alphabetSize;

				res.Append(_alphabet.CurrentAlphabet[index]);
			}

			return res.ToString();
		}

		private string MakeCipherStepsOld(string text, string key, bool IsEncrypt)
		{
			int alphabetSize = _alphabet.CurrentAlphabet.Length;
			StringBuilder res = new StringBuilder();
			var intKey = Convert.ToInt32(key, 2);
			if (!IsEncrypt)
				intKey *= -1;

			foreach (var c in text)
			{
				var index = _alphabet.IndexOf(c);
				index = (int)((index + intKey) % alphabetSize);

				if (index < 0)
					index += alphabetSize;

				res.Append(_alphabet.CurrentAlphabet[index]);
			}

			return res.ToString();
		}
	}
}
