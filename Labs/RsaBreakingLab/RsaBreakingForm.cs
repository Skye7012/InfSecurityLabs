using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Numerics;
using System.Text;
using System.Windows.Forms;

namespace Labs.RsaBreakingLab
{
	public partial class RsaBreakingForm : Form
	{
		public RsaBreakingForm()
		{
			InitializeComponent();
		}

		private void breakBtn_Click(object sender, EventArgs eA)
		{
			BigInteger N = BigInteger.Parse(nTbx.Text);
			BigInteger e = BigInteger.Parse(eTbx.Text);
			BigInteger sw = BigInteger.Parse(swTbx.Text);
			BigInteger p, q;
			RsaBreaking.BreakN(N, out p, out q);
			BigInteger phi = (p - 1) * (q - 1);
			BigInteger d = RsaBreaking.FindD(phi, e, N);
			var res = RsaBreaking.Decrypt(sw, d, N);
			decryptedTbx.Text = res;
		}


	}
}
