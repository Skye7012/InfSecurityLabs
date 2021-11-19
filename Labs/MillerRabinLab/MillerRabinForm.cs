using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Numerics;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;

namespace Labs.MillerRabinLab
{
	public partial class MillerRabinForm : Form
	{
		public MillerRabinForm()
		{
			InitializeComponent();

			byte[] bytes = new byte[] { 1, 2, 3, 4, 5 };

			BigInteger b = new BigInteger(bytes);

			var bytes2 = b.ToByteArray();

			var rng = new RNGCryptoServiceProvider();
			rng.GetBytes(bytes);

			b = new BigInteger(bytes);
		}
	}
}
