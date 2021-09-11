using CaesarCipher.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CaesarCipher
{
	public partial class MainForm : Form
	{
		private BigInteger steps;
		private Alphabet alphabet;
		public MainForm()
		{
			InitializeComponent();
			alphabetComboBox.DataSource = Enum.GetValues(typeof(AlphabetsEnum));
			alphabetComboBox.SelectedItem = alphabetComboBox.Items[0];
		}

		private bool AreControlsValid(RichTextBox richTextBox, Button button)
		{
			var oppositeRichTextBox = Controls.OfType<RichTextBox>().First(x => x != richTextBox);

			 if (!alphabet.IsValid(richTextBox.Text))
				MessageBox.Show("Input correct text according choosed alphabet");
			else if (!string.IsNullOrEmpty(oppositeRichTextBox.Text))
				MessageBox.Show($"Clear {oppositeRichTextBox.Tag} before {button.Text}");
			else if (!BigInteger.TryParse(stepsTextBox.Text, out steps))
				MessageBox.Show("Input correct key");
			else
				return true;

			return false;
		}

		private void encryptButton_Click(object sender, EventArgs e)
		{
			if (AreControlsValid(originalTextBox, sender as Button))
			{
				cryptogramTextBox.Text = alphabet.MakeCipherSteps(originalTextBox.Text, steps);
				originalTextBox.Clear();
			}
		}

		private void decryptButton_Click(object sender, EventArgs e)
		{
			if (AreControlsValid(cryptogramTextBox, sender as Button))
			{
				originalTextBox.Text = alphabet.MakeCipherSteps(cryptogramTextBox.Text, -steps);
				cryptogramTextBox.Clear();
			}
		}

		private void alphabetComboBox_SelectedIndexChanged(object sender, EventArgs e)
		{
			alphabet = new Alphabet((AlphabetsEnum)alphabetComboBox.SelectedItem);
		}

		private void originalTextBox_TextChanged(object sender, EventArgs e)
		{
			if (string.IsNullOrEmpty(originalTextBox.Text))
				encryptButton.Enabled = false;
			else
				encryptButton.Enabled = true;
		}

		private void cryptogramTextBox_TextChanged(object sender, EventArgs e)
		{
			if (string.IsNullOrEmpty(cryptogramTextBox.Text))
				decryptButton.Enabled = false;
			else
				decryptButton.Enabled = true;
		}
	}
}
