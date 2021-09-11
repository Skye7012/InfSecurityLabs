using CaesarCipher.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;

namespace CaesarCipher
{
	public class Alphabet
	{
		readonly char[] englishAlphabet = "0123456789ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz".ToCharArray();
		readonly char[] russianAlphabet = "0123456789АБВГДЕЖЗИЙКЛМНОПРСТУФХЦЧШЩЪЫЬЭЮЯабвгдежзийклмнопрстуфхцчшщъыьэюя".ToCharArray();
		public char[] CurrentAlphabet { get; set; }

		public Alphabet(AlphabetsEnum alphabet)
		{
			ChangeAlphabet(alphabet);
		}
		public string MakeCipherSteps(string text, BigInteger steps)
		{
			//if (IsValide(text))//liw?
			//{
			int alphabetSize = CurrentAlphabet.Length;
			StringBuilder res = new StringBuilder();
			foreach(var c in text)
			{
				CurrentAlphabet.
			}
			return new string(
				text.Select(x => (char) ((x + steps) % alphabetSize) )
				.ToArray());
			//}
		}

		//public char MakeStep(char c)
		//{
		//	if (IsValide(c))
		//	{
		//		int alphabetSize = CurrentAlphabet.Length;

		//	}
		//}

		public bool IsValide (string text) =>
			text.All(x => CurrentAlphabet.Contains(x));

		private bool IsValide(char c) =>
			CurrentAlphabet.Contains(c);

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
	}
}
