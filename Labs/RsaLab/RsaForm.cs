using Labs.MillerRabinLab;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Numerics;
using System.Text;
using System.Windows.Forms;

namespace Labs.RsaLab
{
	public partial class RsaForm : Form
	{
		private List<TextBox> _argsTbx;

		public RsaForm()
		{
			InitializeComponent();
			_argsTbx = new List<TextBox> { pTbx, qTbx };
			varsGroupBox.Enabled = false;
		}

		private void sizeTbx_TextChanged(object sender, EventArgs e)
		{
			BigInteger bitSize;
			bool isValid = BigInteger.TryParse(sizeTbx.Text, out bitSize)
				&& !string.IsNullOrWhiteSpace(sizeTbx.Text)
				&& bitSize > 2;

			if (isValid)
				generateBtn.Enabled = true;
			else
				generateBtn.Enabled = false;
		}

		private void generateBtn_Click(object sender, EventArgs e)
		{
			BigInteger bitSize = BigInteger.Parse(sizeTbx.Text);
			BigInteger p = MillerRabin.GeneratePrimeNumber(bitSize);
			BigInteger q = MillerRabin.GeneratePrimeNumber(bitSize);
			while (q == p)
				q = MillerRabin.GeneratePrimeNumber(bitSize);
			pTbx.Text = Convert.ToString(p);
			qTbx.Text = Convert.ToString(q);
			argsGroupBox.Enabled = true;
		}

		private void calculateBtn_Click(object sender, EventArgs e)
		{
			BigInteger p = BigInteger.Parse(pTbx.Text);
			BigInteger q = BigInteger.Parse(qTbx.Text);
			Rsa rsa = new Rsa(p,q);
			nTbx.Text = Convert.ToString(rsa.N);
			phiTbx.Text = Convert.ToString(rsa.Phi);
			eTbx.Text = Convert.ToString(rsa.E);
			dTbx.Text = Convert.ToString(rsa.D);

			varsGroupBox.Enabled = true;
			cryptGroupBox.Enabled = true;
		}
	}
}
