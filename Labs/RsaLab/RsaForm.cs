using Labs.MillerRabinLab;
using Labs.Service;
using Labs.Servise;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Windows.Forms;

namespace Labs.RsaLab
{
	public partial class RsaForm : Form
	{
		Rsa _rsa;
		Win1251Alphabet _alphabet = new Win1251Alphabet();
		public RsaForm()
		{
			InitializeComponent();
		}

		private void sizeTbx_TextChanged(object sender, EventArgs e)
		{
			argsGroupBox.Enabled = false;
			cryptGroupBox.Enabled = false;
			encryptBtn.Enabled = false;
			cryptTbx.Enabled = false;
			decryptBtn.Enabled = false;

			BigInteger bitSize;
			bool isValid = BigInteger.TryParse(sizeTbx.Text, out bitSize)
				&& !string.IsNullOrWhiteSpace(sizeTbx.Text)
				&& bitSize > 4;

			//>4 потому что только с 5 битами и более
			//можно сгенерировать правильные p,q,n,phi,e,d

			generateBtn.Enabled = isValid;
		}

		private void generateBtn_Click(object sender, EventArgs ev)
		{
			try
			{
				GenerateBtn();
			}
			catch 
			{ 
				MessageBox.Show("Wrong bitSize"); 
			}

		}

		private void GenerateBtn()
		{
			BigInteger bitSize = BigInteger.Parse(sizeTbx.Text);

			BigInteger p, q, n, phi, e, d;

			GenerateVars(bitSize, out p, out q, out n, out phi, out e, out d);

			pTbx.Text = Convert.ToString(p);
			qTbx.Text = Convert.ToString(q);
			nTbx.Text = Convert.ToString(n);
			phiTbx.Text = Convert.ToString(phi);
			eTbx.Text = Convert.ToString(e);
			dTbx.Text = Convert.ToString(d);

			argsGroupBox.Enabled = true;
			cryptGroupBox.Enabled = true;
		}

		/// <summary>
		/// Генерирует n, phi, e, d
		/// </summary>
		/// <exception cref="Exception">To small N value</exception>
		/// <exception cref="Exception">Cannot Generate D</exception>
		private void GenerateVars(BigInteger bitSize, out BigInteger p, out BigInteger q,
			out BigInteger n, out BigInteger phi, out BigInteger e, out BigInteger d)
		{
			Rsa rsa = new Rsa(bitSize);
			p = rsa.P;
			q = rsa.Q;
			n = rsa.N;
			phi = rsa.Phi;
			e = rsa.E;
			d = rsa.D;

			_rsa = rsa;
		}

		/// <summary>
		/// Сгенерировать простые числа p и q
		/// с заданным размером в битах
		/// </summary>
		private void GeneratePrimeNumbers(BigInteger bitSize, out BigInteger p, out BigInteger q)
		{
			p = MillerRabin.GeneratePrimeNumber(bitSize);
			q = MillerRabin.GeneratePrimeNumber(bitSize);
			while (q == p)
				q = MillerRabin.GeneratePrimeNumber(bitSize);
		}

		private void plainTbx_TextChanged(object sender, EventArgs e)
		{
			bool isValid = !string.IsNullOrWhiteSpace(plainTbx.Text)
				&& plainTbx.Text.ToIdList().All(x => x > 0 && x <= _rsa.N - 1);


			plainLabelChange(isValid);
			encryptBtn.Enabled = isValid;
		}

		void plainLabelChange(bool isValid)
		{
			string correct = "Plain Text";
			string incorrect = "Plain Text (Not Valid Message, m must be 0<m<=n-1)";

			if (isValid)
			{
				plainLbl.Text = correct;
				plainLbl.ForeColor = Color.Black;
			}
			else
			{
				plainLbl.Text = incorrect;
				plainLbl.ForeColor = Color.Red;
			}
		}

		private void encryptBtn_Click(object sender, EventArgs e)
		{
			if (_alphabet.ConvertTextToIdsNumber(plainTbx.Text) > _rsa.N - 1)
			{
				MessageBox.Show("Plain Text (Not Valid Message, m must be 0<m<=n-1)");
				return;
			}

			var ids = _rsa.Encrypt(plainTbx.Text);
			var res = string.Join(" ", ids);
			cryptTbx.Text = res;

			cryptTbx.Enabled = true;
			decryptBtn.Enabled = true;
		}

		private void decryptBtn_Click(object sender, EventArgs e)
		{
			try
			{
				Decrypt();
			}
			catch
			{
				MessageBox.Show("Cryptogram has changed and become not valide to decrypt");
			}
		}

		private void Decrypt()
		{
			//var stringIds = cryptTbx.Text.Split(' ');
			//var ids = new List<BigInteger>();

			//foreach (var index in stringIds)
			//{
			//	ids.Add(BigInteger.Parse(index));
			//}

			//var res = "";

			var res = _rsa.Decrypt(BigInteger.Parse(cryptTbx.Text));

			decryptedTbx.Text = res;

			decryptedTbx.Enabled = true;
		}
	}
}
