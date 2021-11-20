using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Numerics;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;

namespace Labs.MillerRabinLab
{
	public partial class MillerRabinForm : Form
	{
		private readonly List<TextBox> _varTextBoxes;

		public MillerRabinForm()
		{
			InitializeComponent();
		}

		private void Solve()
		{
			var number = BigInteger.Parse(numberTbx.Text);
			if (MillerRabin.IsPrime(number))
				answerTbx.Text = "Число вероятно простое";
			else
				answerTbx.Text = "Число составное";
		}

		private void generateNumberBtn_Click(object sender, EventArgs e)
		{
			var bitSize = BigInteger.Parse(bitNumberSizeTbx.Text);
			numberTbx.Text = Convert.ToString(MillerRabin.GenerateRandomNumberByBitSize(bitSize));
		}

		private void bitNumberSizeTbx_TextChanged(object sender, EventArgs e)
		{
			BigInteger bitSize;
			bool isValid = BigInteger.TryParse(bitNumberSizeTbx.Text, out bitSize)
				&& !string.IsNullOrWhiteSpace(bitNumberSizeTbx.Text)
				&& bitSize > 0;

			if (isValid)
				generateNumberBtn.Enabled = true;
			else
				generateNumberBtn.Enabled = false;
		}

		private void numberTbx_TextChanged(object sender, EventArgs e)
		{
			BigInteger number;
			bool isValid = BigInteger.TryParse(numberTbx.Text, out number)
				&& !string.IsNullOrWhiteSpace(numberTbx.Text)
				&& number > 1;

			if (isValid)
				isPrimeBtn.Enabled = true;
			else
				isPrimeBtn.Enabled = false;
		}

		private void isPrimeBtn_Click(object sender, EventArgs e)
		{
			try
			{
				Solve();
			}
			catch
			{
				MessageBox.Show("Неверные исходные данные");
			}
		}
	}
}
