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
		List<TextBox> _varTextBoxes;
		public RsaBreakingForm()
		{
			InitializeComponent();
			_varTextBoxes = new List<TextBox>()
			{
				nTbx, eTbx,swTbx
			};

			foreach (var item in _varTextBoxes)
			{
				item.TextChanged += new EventHandler(VariablesTextChanged);
			}
		}

		private void breakBtn_Click(object sender, EventArgs eA)
		{
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

		bool AreVariablesValid()
		{
			BigInteger temp;

			return _varTextBoxes.All(x => !string.IsNullOrWhiteSpace(x.Text)
				&& BigInteger.TryParse(x.Text, out temp)
				&& temp > 100);
		}

		private void VariablesTextChanged(object sender, EventArgs e)
		{
			if (AreVariablesValid())
				breakBtn.Enabled = true;
			else
				breakBtn.Enabled = false;
		}
	}
}
