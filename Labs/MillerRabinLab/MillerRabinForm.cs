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

			_varTextBoxes = new List<TextBox>()
			{
				bitNumberSizeTbx, numberTbx,
			};

			foreach (var item in _varTextBoxes)
			{
				item.TextChanged += new EventHandler(VariablesTextChanged);
			}
		}

		private void generateNumberBtn_Click(object sender, EventArgs e)
		{
			var bitSize = BigInteger.Parse(bitNumberSizeTbx.Text);
			numberTbx.Text = Convert.ToString(MillerRabin.GenerateRandomNumberByBitSize(bitSize));
		}

		private void VariablesTextChanged(object sender, EventArgs e)
		{
			if (AreVariablesValid())
				generateNumberBtn.Enabled = true;
			else
				generateNumberBtn.Enabled = false;
			//BigInteger bitSize;
			//bool b = BigInteger.TryParse(bitNumberSizeTbx.Text, out bitSize)
			//	&& !string.IsNullOrWhiteSpace(bitNumberSizeTbx.Text);
			//if (b)
			//	generateNumberBtn.Enabled = true;
			//else
			//	generateNumberBtn.Enabled = false;
		}

		bool AreVariablesValid()
		{
			BigInteger temp;

			bool isValid = _varTextBoxes.All(x => !string.IsNullOrWhiteSpace(x.Text)
				&& BigInteger.TryParse(x.Text, out temp)
				&& temp > 0);

			if (isValid)
				return true;
			return false;
		}


	}
}
