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
		{
			_alphabet = alphabet;
		}

		public string Encrypt(string text, string key)
		{
			return MakeCipherSteps(text, key);
		}

		public string Decrypt(string text, string key)
		{
			//var steps = BigInteger.Parse(key);
			//return MakeCipherSteps(text, key);
			return text;
		}

		public bool IsKeyValid(string key)
			=> _alphabet.IsValid(key);

		private string MakeCipherSteps(string text, string key)
		{
			int alphabetSize = _alphabet.CurrentAlphabet.Length;
			int keyIndex = 0;
			StringBuilder res = new StringBuilder();

			foreach (var c in text)
			{
				var index = _alphabet.IndexOf(c);
				var keyIndexInAlphabet = _alphabet.IndexOf(key[keyIndex]);
				index = (int)((index + keyIndexInAlphabet) % alphabetSize);

				if (index < 0)
					index += alphabetSize;

				res.Append(_alphabet.CurrentAlphabet[index]);

				keyIndex = (keyIndex + 1) % key.Length;
			}

			return res.ToString();
		}
	}
}
