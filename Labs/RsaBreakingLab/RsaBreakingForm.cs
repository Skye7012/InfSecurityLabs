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
			if (!AreTbxValid())
			{
				MessageBox.Show("Some var is not valid");
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
			BigInteger n = BigInteger.Parse(nTbx.Text);
			BigInteger e = BigInteger.Parse(eTbx.Text);
			BigInteger cryptogram = BigInteger.Parse(swTbx.Text);
			var breaker = new RsaBreaking(n, e);
			var res = breaker.Break(cryptogram);
			decryptedTbx.Text = res;
			string info = $"iterations: {breaker.Iter}\ntime past: {timer.GetPast()}";
			InfoLbl.Text = info;
		}

		bool AreTbxValid()
		{
			List<TextBox> textBoxes = new List<TextBox>()
				{ nTbx,eTbx,swTbx};
			BigInteger q;
			return textBoxes.All(x => 
				!string.IsNullOrWhiteSpace(x.Text)
				&& BigInteger.TryParse(x.Text, out q)
				&& q > 100);
		}
	}
}
