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

			var enums = Enum.GetValues(typeof(MainEnum)).Cast<object>().ToArray();
			mainComboBox.Items.AddRange(enums);
			mainComboBox.SelectedItem = MainEnum.Gcd;

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

			BigInteger gcd;
			var vars = new List<(BigInteger A, BigInteger B)>() { (_a, _b) };
			var operations = new List<(BigInteger mod, BigInteger div)>() { (_a % _b, _a / _b) };

			for (int i = 1; ; i++)
			{
				vars.Add((vars[i - 1].B, operations[i - 1].mod));
				var a = vars[i].A;
				var b = vars[i].B;
				operations.Add((a % b, a / b));

				if (a % b == 0)
				{
					gcd = vars.Last().B;
					break;
				}
			}

			var res = InitializeRes(vars.Count);

			for (int i = vars.Count - 1 - 1; i >= 0; i--)
			{
				var x = res[i + 1].x;
				var y = res[i + 1].y;
				var newY = x - y * operations[i].div;
				res[i] = (y, newY);
			}

			gcdTbx.Text = Convert.ToString(gcd);
			xTbx.Text = Convert.ToString(res.First().x);
			yTbx.Text = Convert.ToString(res.First().y);
		}

		void MapVars()
		{
			_a = BigInteger.Parse(aTbx.Text);
			_b = BigInteger.Parse(bTbx.Text);
		}

		List<(BigInteger x, BigInteger y)> InitializeRes(int num)
		{
			List<(BigInteger x, BigInteger y)> res = new List<(BigInteger x, BigInteger y)>() { (0, 1 )};

			for (int i = 1; i < num; i++)
			{
				res.Add((0, 0));
			}

			res.Reverse();

			return res;
		}

		#endregion


		#region Servise

		bool AreVariablesValid()
		{
			BigInteger temp;

			bool isValid = _varTextBoxes.All(x => BigInteger.TryParse
				 (x.Text, out temp)
				 && !string.IsNullOrWhiteSpace(x.Text));

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
			Calculate();
		}


		#endregion

		private void mainComboBox_SelectedIndexChanged(object sender, EventArgs e)
		{
			if((MainEnum)mainComboBox.SelectedItem != MainEnum.Gcd)
			{
				//var x = new PowForm();
				//x.Show();
				//Close();
				//this = new PowForm();
			}
		}
	}
}
