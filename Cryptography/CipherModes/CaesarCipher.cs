using Cryptography.Interfaces;
using System.Numerics;
using System.Text;

namespace Cryptography.CipherModes
{
	public class CaesarCipher : ICryptographer
	{
		private readonly Alphabet _alphabet;

		public CaesarCipher(Alphabet alphabet)
		{
			_alphabet = alphabet;
		}

		public string Encrypt(string text, string key)
		{
			var steps = BigInteger.Parse(key);
			return MakeCipherSteps(text, steps);
		}

		public string Decrypt(string text, string key)
		{
			var steps = BigInteger.Parse(key);
			return MakeCipherSteps(text, steps * -1);
		}

		public bool IsKeyValid(string key)
		{
			BigInteger steps;
			return BigInteger.TryParse(key, out steps);
		}

		private string MakeCipherSteps(string text, BigInteger steps)
		{
			int alphabetSize = _alphabet.CurrentAlphabet.Length;
			StringBuilder res = new StringBuilder();

			foreach (var c in text)
			{
				var index = _alphabet.IndexOf(c);
				index = (int)((index + steps) % alphabetSize);

				if (index < 0)
					index += alphabetSize;

				res.Append(_alphabet.CurrentAlphabet[index]);
			}

			return res.ToString();
		}
	}
}
