using System;
using System.Collections.Generic;
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
			var indexes = GetIntsFromBinaries(bin);
			return String.Join("", indexes.Select(x => CurrentAlphabet[x]));
		}

		public List<string> GetSplittedBinaries(string bin)
		{
			var keyLength = BinaryLength;
			var keys = new List<string>();

			for (int i = 0; i < bin.Length; i += keyLength)
			{
				keys.Add(bin.Substring(i, keyLength));
			}

			return keys;
		}

		public int[] GetIntsFromBinaries(string bin)//что-то где-то убрать
			=> GetSplittedBinaries(bin).Select(x => Convert.ToInt32(x, 2)).ToArray();
	}
}
