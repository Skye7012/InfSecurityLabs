using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CaesarCipher
{
	public partial class MainForm : Form
	{
		public int Steps { get; set; }
		public MainForm()
		{
			InitializeComponent();
		}

		private void encryptButton_Click(object sender, EventArgs e)
		{
			if (!string.IsNullOrEmpty(editingTextBox.Text))
			{
				//editingTextBox.Text = editingTextBox.Text.Select(x => x + stepsTextBox.Text);
				string res = new string(
					editingTextBox.Text.Select(x => (char)(x + Steps))
					.ToArray());

				editingTextBox.Text = res;
				//editingTextBox.Text = editingTextBox.Text.Select(x => (x + 3)).First();
				//int.Parse(editingTextBox.Text[0]);
				//var z = (int)editingTextBox.Text[0];
			}
			else
				MessageBox.Show("Input some text");
		}

		private void stepsTextBox_TextChanged(object sender, EventArgs e)
		{
			int res;
			var s = !string.IsNullOrEmpty(stepsTextBox.Text);

			if (int.TryParse(stepsTextBox.Text, out res))
				Steps = res;

			else if(!string.IsNullOrEmpty(stepsTextBox.Text))
			{
				MessageBox.Show($"Cant't convert to int this: \n\"{stepsTextBox.Text}\"");
				stepsTextBox.Text = stepsTextBox.Text.Remove(stepsTextBox.Text.Length - 1);
			}
		}
	}
}
