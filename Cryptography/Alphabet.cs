using Cryptography.Enums;
using System;
using System.Linq;
using System.Numerics;
using System.Text;

namespace Cryptography
{
	public class Alphabet
	{
		readonly string englishAlphabet = "0123456789ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz";
		readonly string russianAlphabet = "0123456789АБВГДЕЖЗИЙКЛМНОПРСТУФХЦЧШЩЪЫЬЭЮЯабвгдежзийклмнопрстуфхцчшщъыьэюя";
		public string CurrentAlphabet { get; protected set; }

		public Alphabet(AlphabetsEnum alphabet)
		{
			ChangeAlphabet(alphabet);
		}

		public Alphabet() { }

		public int IndexOf(char c)
			=> CurrentAlphabet.IndexOf(c);

		public string MakeCipherSteps(string text, BigInteger steps)
		{
			int alphabetSize = CurrentAlphabet.Length;
			StringBuilder res = new StringBuilder();

			foreach (var c in text)
			{
				var index = new string(CurrentAlphabet).IndexOf(c);
				index = (int)((index + steps) % alphabetSize);

				if (index < 0)
					index += alphabetSize;

				res.Append(CurrentAlphabet[index]);
			}

			return res.ToString();
		}

		public bool IsValid(string text) =>
			!string.IsNullOrEmpty(text)
			&& text.All(x => CurrentAlphabet.Contains(x));

		public void ChangeAlphabet(AlphabetsEnum alphabet)
		{
			switch (alphabet)
			{
				case AlphabetsEnum.EnglishAlphabet:
					CurrentAlphabet = englishAlphabet;
					break;
				case AlphabetsEnum.RussianAlphabet:
					CurrentAlphabet = russianAlphabet;
					break;
			}
		}

		public int GetBinaryLength()
		{
			var sqrt =  Math.Ceiling(Math.Log2(CurrentAlphabet.Length));
			return (int)sqrt + 1;
		}

		public static Alphabet CreateTestAlphabet()
		{
			return new Alphabet() { CurrentAlphabet = "01234" };
		}
	}
}
