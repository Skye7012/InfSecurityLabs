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
				&& bitSize > 1;

			if (isValid)
				generateBtn.Enabled = true;
			else
				generateBtn.Enabled = false;
		}
	}
}
