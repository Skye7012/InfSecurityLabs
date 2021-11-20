using System;
using System.Collections;
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

			var qw =MillerRabin.IsPrime(35);

			byte[] bytes = new byte[512];

			var rng = new RNGCryptoServiceProvider();
			rng.GetBytes(bytes);

			var b = new BigInteger(bytes);
			var x = b.ToByteArray().Length;

			var size = b.ToString().Length;

			BigInteger z = BigInteger.Pow(2,64);

			size = z.ToString().Length;

			//BitArray bitArray = new BitArray(512);

			string bit = "";
			Random rnd = new Random();

			z = 0;

			for (int i = 0; i < 512; i++)
			{
				bit += rnd.Next(2);
			}

			for (int i = 0; i < 512; i++)
			{
				if(bit[i] == '1')
					z += BigInteger.Pow(2, i);
			}

			//bytes = new byte[] {255,255,255,255,255,255,255,255 };
			//rng.GetBytes(bytes);

			//z = new BigInteger(bytes);
			size = z.ToString().Length;
		}
	}
}
