using System;
using System.Linq;
using System.Numerics;
using System.Text;

namespace XorManulKey
{
	public class Alphabet
	{
		public string CurrentAlphabet { get; protected set; }
		public int BinaryLength { get; protected set; }

		public Alphabet(string alphabet = "0123456789ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz")
		{
			CurrentAlphabet = alphabet;
			BinaryLength = GetBinaryLength();
		}

		public int IndexOf(char c)
			=> CurrentAlphabet.IndexOf(c);

		public bool IsValid(string text) =>
			!string.IsNullOrEmpty(text)
			&& text.All(x => CurrentAlphabet.Contains(x));

		public int GetBinaryLength()
			=>  (int)Math.Ceiling(Math.Log2(CurrentAlphabet.Length));

		public string ConvertToBinary(string text)
		{
			StringBuilder res = new StringBuilder();

			foreach (var let in text)
			{
				int letIndex = IndexOf(let);

				res.Append(Convert.ToString(letIndex, 2)
					.PadLeft(BinaryLength,'0'));
			}

			return res.ToString();
		}

		public string ConvertFromBinary(string bin)
		{

			return "asd";
		}

		public static Alphabet CreateTestAlphabet()
			=> new Alphabet() { CurrentAlphabet = "01234" };//del
	}
}
