using CaesarCipher.BaseClasses;
using System;
using System.Collections.Generic;
using System.Text;

namespace CaesarCipher.Interfaces
{
	public interface ICryptography
	{
		string Encrypt(string text, string key);

		string Decrypt(string text, string key);

		bool IsKeyValid(string key);
	}
}
