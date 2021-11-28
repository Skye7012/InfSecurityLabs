using System;
using System.Collections.Generic;
using System.Text;

namespace Labs.Servise
{
	using System;
	using System.Numerics;
	using System.Text;
	using System.Windows.Forms;

	public static class StringExtensions
	{
		/// <summary>
		/// Увеличивает индекс каждой буквы в тексте на заданное число n
		/// </summary>
		/// <param name="text">Текст</param>
		/// <returns>Зашифрованный текст</returns>
		public static string Encrypt(this string text, int n)
		{
			StringBuilder res = new StringBuilder();
			foreach (var let in text)
			{
				res.Append(let + n);
			}
			return res.ToString();
		}

		/// <summary>
		/// Уменьшает индекс каждой буквы в тексте на заданное число n
		/// </summary>
		/// <param name="text">Текст</param>
		/// <returns>Расшифрованный текст</returns>
		public static string Decrypt(this string text, int n)
		{
			StringBuilder res = new StringBuilder();
			foreach (var let in text)
			{
				res.Append(let - n);
			}
			return res.ToString();
		}
	}
}


