using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Numerics;
using System.Text;
using System.Windows.Forms;
using System.Linq;
using Labs.Servise;

namespace Labs.PowLab
{
	public partial class PowForm : Form
	{
		BigInteger _a;
		BigInteger _b;
		BigInteger _n;
		List<TextBox> _varTextBoxes;
		List<BigInteger> _vars;
		public PowForm()
		{
			InitializeComponent();
			_varTextBoxes = new List<TextBox>()
			{
				aTbx, bTbx,nTbx,
			};

			_vars = new List<BigInteger>()
			{
				_a, _b, _n
			};

			foreach (var item in _varTextBoxes)
			{
				item.TextChanged += new EventHandler(VariablesTextChanged);
			}
		}

		#region Logic

		void Calculate()
		{
			MapVars();

			var res = ModPow.Calculate(_a,_b,_n);

			zTbx.Text = Convert.ToString(res);
		}

		void MapVars()
		{
			_a = BigInteger.Parse(aTbx.Text);
			_b = BigInteger.Parse(bTbx.Text);
			_n = BigInteger.Parse(nTbx.Text);
		}

		#endregion


		#region Servise

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

		private void VariablesTextChanged(object sender, EventArgs e)
		{
			if (AreVariablesValid())
				calculateBtn.Enabled = true;
			else
				calculateBtn.Enabled = false;
		}

		private void calculateBtn_Click(object sender, EventArgs e)
		{
			try
			{
				Calculate();
			}
			catch
			{
				MessageBox.Show("Неверные исходные данные");
			}
		}

		#endregion
	}
}
