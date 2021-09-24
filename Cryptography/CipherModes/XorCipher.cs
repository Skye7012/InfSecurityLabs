using Cryptography.Interfaces;
using System;
using System.Collections;
using System.Linq;
using System.Numerics;
using System.Text;

namespace Cryptography.CipherModes
{
	public class XorCipher : ICryptographer
	{
		private readonly Alphabet _alphabet;

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
			=> _alphabet.IsValid(key);//redo

		private string MakeCipherSteps(string text, string key, bool IsEncrypt)
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
