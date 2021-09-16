using System;
using System.Collections.Generic;
using System.Text;

namespace CaesarCipher.Interfaces
{
	public interface IValidable
	{
		bool IsValid(string text);
	}
}
