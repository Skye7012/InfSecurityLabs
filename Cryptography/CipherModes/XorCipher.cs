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
			//_alphabet = alphabet;
			_alphabet = Alphabet.CreateTestAlphabet();
		}

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

				res.Append(Convert.ToString(index,2) + " ");
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


			//var keys = new List<string>();

			//for (int i = 0; i < keyLength; i+=keyLength)
			//{
			//	keys.Add(key.Substring(i, i + keyLength-1));
			//}

			//var intKeys = key.Split(' ', StringSplitOptions.RemoveEmptyEntries)
			//	.Select(x => Convert.ToInt32(x, 2)).ToArray();
			var keys = GetSplittedBinaries(key);
			var intKeys = keys.Select(x => Convert.ToInt32(x, 2));

			//return key.All(x => chars.Contains(x)) 
			//	&& intKeys.All(x => x <= _alphabet.CurrentAlphabet.Length);

			return true;
		}

		List<string> GetSplittedBinaries(string text)
		{
			var keyLength = _alphabet.GetBinaryLength();
			var keys = new List<string>();

			for (int i = 0; i < keyLength; i += keyLength)
			{
				keys.Add(text.Substring(i, i + keyLength - 1));
			}

			return keys;
		}

		int[] GetIntsFromBinaries(string text)
			=> GetSplittedBinaries(text).Select(x => Convert.ToInt32(x, 2)).ToArray();
		

		private string MakeCipherSteps(string text, string key, bool IsEncrypt)
		{
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
				index = index ^ intKey/* % alphabetSize*/;

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
