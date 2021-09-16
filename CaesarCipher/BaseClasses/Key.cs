using CaesarCipher.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CaesarCipher.BaseClasses
{
	public class Key : IValidable
	{
		public string KeyAlphabet { get; protected set; }

		public bool IsValide(string text)
			=> !string.IsNullOrEmpty(text)
			&& text.All(x => KeyAlphabet.Contains(x));
	}
}
