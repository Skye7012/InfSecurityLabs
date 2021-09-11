﻿using System;
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

		private string MakeCipherSteps(string text, int steps)
		{
			return new string(
					text.Select(x => (char)(x + steps))
					.ToArray());
		}

		private void encryptButton_Click(object sender, EventArgs e)
		{
			if (!string.IsNullOrEmpty(editingTextBox.Text))
				editingTextBox.Text = MakeCipherSteps(editingTextBox.Text, Steps);
			else
				MessageBox.Show("Input some text");
		}

		private void decryptButton_Click(object sender, EventArgs e)
		{
			if (!string.IsNullOrEmpty(editingTextBox.Text))
				editingTextBox.Text = MakeCipherSteps(editingTextBox.Text, -Steps);
			else
				MessageBox.Show("Input some text");
		}

		private void stepsTextBox_TextChanged(object sender, EventArgs e)
		{
			int res;
			var s = !string.IsNullOrEmpty(stepsTextBox.Text);

			if (int.TryParse(stepsTextBox.Text, out res))
				Steps = res;

			else
			{
				MessageBox.Show($"Cant't convert to int this: \n\"{stepsTextBox.Text}\"");

				if (stepsTextBox.Text.Length <= 1)
					stepsTextBox.Text = "0";
				else
					stepsTextBox.Text = stepsTextBox.Text.Remove(stepsTextBox.Text.Length - 1);
			}
		}
	}
}
