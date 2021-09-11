using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace CaesarCipher.Alphabets
{
	class RussianAlphabet
	{
		char[] alphabetChars = "0123456789АБВГДЕЖЗИЙКЛМНОПРСТУФХЦЧШЩЪЫЬЭЮЯабвгдежзийклмнопрстуфхцчшщъыьэюя".ToCharArray();
		public List<char> TestAlphabetChars { get; protected set; } = new List<char>();

		public RussianAlphabet()
		{
			for (char c = '0'; c <= '9'; c++)
			{
				TestAlphabetChars.Add(c);
			}
			for (char c = 'А'; c <= 'Я'; c++)
			{
				TestAlphabetChars.Add(c);
			}
			for (char c = 'а'; c <= 'я'; c++)
			{
				TestAlphabetChars.Add(c);
			}
			var a = new string(TestAlphabetChars.ToArray());
			System.Windows.Forms.MessageBox.Show(new string(TestAlphabetChars.ToArray()));
			Console.WriteLine(new string(TestAlphabetChars.ToArray()));
			
		}

	}
}
