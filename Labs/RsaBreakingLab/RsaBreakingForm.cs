using Labs.Service;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
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
			if (IsSomeTbxEmpty())
			{
				MessageBox.Show("Some var is empty");
				return;
			}
			try
			{
				Break();
			}
			catch
			{
				MessageBox.Show("Wrong Vars");
			}
		}

		void Break()
		{
			using var timer = new MyTimer();
			BigInteger N = BigInteger.Parse(nTbx.Text);
			BigInteger e = BigInteger.Parse(eTbx.Text);
			BigInteger sw = BigInteger.Parse(swTbx.Text);
			BigInteger p, q, iter;
			RsaBreaking.BreakN(N, out p, out q, out iter);
			BigInteger phi = (p - 1) * (q - 1);
			BigInteger d = RsaBreaking.FindD(phi, e, N);
			var res = RsaBreaking.Decrypt(sw, d, N);
			decryptedTbx.Text = res;
			string info = $"iterations: {iter}\ntime past: {timer.GetPast()}";
			InfoLbl.Text = info;
		}

		bool IsSomeTbxEmpty()
		{
			List<TextBox> textBoxes = new List<TextBox>()
				{ nTbx,eTbx,swTbx};
			return textBoxes.Any(x => string.IsNullOrWhiteSpace(x.Text));
		}
	}
}
