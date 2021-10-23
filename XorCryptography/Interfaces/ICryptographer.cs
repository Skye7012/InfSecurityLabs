namespace XorCryptography.Interfaces
{
	public interface ICryptographer
	{
		string Encrypt(string text, string key);

		string Decrypt(string text, string key);
	}
}
