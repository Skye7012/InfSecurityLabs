using System;
using System.Collections.Generic;
using System.Text;

namespace CaesarCipher.Interfaces
{
	public interface ICryptography
	{
		string Encrypt(string text);

		string Decrypt(string text);

		bool IsKeyValid(string key);
	}
}
