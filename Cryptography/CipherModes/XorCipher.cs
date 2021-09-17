using Cryptography.Interfaces;
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
			BitArray b = 2; 

			for (int i = 0, j = 0;
				i < text.Length;
				i++, j = (j + 1) % key.Length)
			{
				char textChar = text[i];
				char keyChar = key[j];

				var textIndex = _alphabet.IndexOf(textChar);
				var keyIndex = _alphabet.IndexOf(keyChar);

				if (IsEncrypt)
					textIndex = (int)((textIndex + keyIndex) % alphabetSize);
				else
					textIndex = (int)((textIndex - keyIndex) % alphabetSize);

				if (textIndex < 0)
					textIndex += alphabetSize;

				res.Append(_alphabet.CurrentAlphabet[textIndex]);
			}

			return res.ToString();
		}
	}
}
