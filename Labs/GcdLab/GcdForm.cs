using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Numerics;
using System.Text;
using System.Windows.Forms;
using System.Linq;
using Labs.Enums;
using Labs.PowLab;

namespace Labs.GcdLab
{
	public partial class GcdForm : Form
	{
		BigInteger _a;
		BigInteger _b;
		List<TextBox> _varTextBoxes;
		public GcdForm()
		{
			InitializeComponent();

			_varTextBoxes = new List<TextBox>()
			{
				aTbx, bTbx,
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

			BigInteger gcd, x, y;

			Gcd.Calculate(_a, _b, out gcd, out x, out y);

			gcdTbx.Text = Convert.ToString(gcd);
			xTbx.Text = Convert.ToString(x);
			yTbx.Text = Convert.ToString(y);
		}

		void MapVars()
		{
			_a = BigInteger.Parse(aTbx.Text);
			_b = BigInteger.Parse(bTbx.Text);
		}

		#endregion


		#region Servise

		bool AreVariablesValid()
		{
			BigInteger temp;

			bool isValid = _varTextBoxes.All(x => !string.IsNullOrWhiteSpace(x.Text)
				&& BigInteger.TryParse(x.Text, out temp)
				&& temp > 1);
			//Больше 1, Нод м/у 1 сравнивать нет смысла

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
