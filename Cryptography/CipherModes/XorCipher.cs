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
		private readonly Alphabet _alphabet;

		public XorCipher(Alphabet alphabet)
			=> _alphabet = alphabet;

		public string Encrypt(string text, string key)
		{
			int alphabetSize = _alphabet.CurrentAlphabet.Length;
			StringBuilder res = new StringBuilder();
			var intKeys = GetIntsFromBinaries(key);

			for (int i = 0, j = 0;
				i < text.Length;
				i++, j = (j + 1) % intKeys.Length)
			{
				var index = _alphabet.IndexOf(text[i]);
				var intKey = intKeys[j];

				index = index ^ intKey;

				if (index < 0)
					index += alphabetSize;

				var str = Convert.ToString(index, 2).
					PadLeft(_alphabet.GetBinaryLength(), '0');
				
				res.Append(str);
			}

			return res.ToString();
		}

		public string Decrypt(string text, string key)
		{
			if (!IsKeyValid(text))
				throw new Exception("Incorect text");

			int alphabetSize = _alphabet.CurrentAlphabet.Length;
			StringBuilder res = new StringBuilder();
			var intKeys = GetIntsFromBinaries(key);
			var intChars = GetIntsFromBinaries(text);

			for (int i = 0, j = 0;
				i < intChars.Length;
				i++, j = (j + 1) % intKeys.Length)
			{
				var index = intChars[i];
				var intKey = intKeys[j];

				index = index ^ intKey;

				if (index < 0)
					index += alphabetSize;

				res.Append(_alphabet.CurrentAlphabet[index]);
			}

			return res.ToString();
		}

		public bool IsKeyValid(string key)
		{
			var chars = new char[] { '0', '1' };
			var keyLength = _alphabet.GetBinaryLength();

			if (key.Length % keyLength!= 0
				|| !key.All(x => chars.Contains(x)))
				return false;

			return true;
		}

		List<string> GetSplittedBinaries(string text)
		{
			var keyLength = _alphabet.GetBinaryLength();
			var keys = new List<string>();

			for (int i = 0; i < text.Length; i += keyLength)
			{
				keys.Add(text.Substring(i, keyLength));
			}

			return keys;
		}

		int[] GetIntsFromBinaries(string text)
			=> GetSplittedBinaries(text).Select(x => Convert.ToInt32(x, 2)).ToArray();

	}
}
