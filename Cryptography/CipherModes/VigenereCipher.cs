using Cryptography.Interfaces;
using System.Linq;
using System.Numerics;
using System.Text;

namespace Cryptography.CipherModes
{
	public class VigenereCipher : ICryptographer
	{
		private readonly Alphabet _alphabet;

		public VigenereCipher(Alphabet alphabet) 
			=> _alphabet = alphabet;

		public string Encrypt(string text, string key)
			=> MakeCipherSteps(text, key, true);

		public string Decrypt(string text, string key)
			=> MakeCipherSteps(text, key, false);

		public bool IsKeyValid(string key)
			=> _alphabet.IsValid(key);

		private string MakeCipherSteps(string text, string key, bool IsEncrypt)
		{
			int alphabetSize = _alphabet.CurrentAlphabet.Length;
			StringBuilder res = new StringBuilder();

			for (int i = 0, j = 0;
				i < text.Length;
				i++, j = (j + 1) % key.Length)
			{
				char textChar = text[i];
				char keyChar = key[j];

				var textIndex = _alphabet.IndexOf(textChar);
				var keyIndex = _alphabet.IndexOf(keyChar);

				if (IsEncrypt)
					textIndex = (textIndex + keyIndex) % alphabetSize;
				else
					textIndex = (textIndex - keyIndex) % alphabetSize;

				if (textIndex < 0)
					textIndex += alphabetSize;

				res.Append(_alphabet.CurrentAlphabet[textIndex]);
			}

			return res.ToString();
		}
	}
}
