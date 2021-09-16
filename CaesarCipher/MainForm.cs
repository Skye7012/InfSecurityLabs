using CaesarCipher.CipherModes;
using CaesarCipher.Enums;
using CaesarCipher.Interfaces;
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
		//private BigInteger steps;
		private ICryptography _cryptography;
		private Alphabet _alphabet = new Alphabet();
		public MainForm()
		{
			InitializeComponent();
			alphabetComboBox.DataSource = Enum.GetValues(typeof(AlphabetsEnum));
			alphabetComboBox.SelectedItem = alphabetComboBox.Items[0];
			cipherModesComboBox.DataSource = Enum.GetValues(typeof(CipherModesEnum));
			cipherModesComboBox.SelectedItem = cipherModesComboBox.Items[0];

			originalTextBox.TextChanged += new EventHandler(RichTextBoxes_TextChanged);
			cryptogramTextBox.TextChanged += new EventHandler(RichTextBoxes_TextChanged);
		}

		private bool AreControlsValid(RichTextBox richTextBox, Button button)
		{
			var oppositeRichTextBox = Controls.OfType<RichTextBox>().First(x => x != richTextBox);

			if (!_alphabet.IsValid(richTextBox.Text))
				MessageBox.Show("Input correct text according choosed alphabet");
			else if (!string.IsNullOrEmpty(oppositeRichTextBox.Text))
				MessageBox.Show($"Clear {oppositeRichTextBox.Tag} before {button.Text}");
			else if (!_cryptography.IsKeyValid(keyTextBox.Text))
				MessageBox.Show("Input correct key");
			else
			{
			
				return true;
			}

			return false;
		}

		private void InitializeVars()
		{
			//if (!_alphabet.IsValid(richTextBox.Text))
			//	MessageBox.Show("Input correct text according choosed alphabet");
			//else if (!string.IsNullOrEmpty(oppositeRichTextBox.Text))
			//	MessageBox.Show($"Clear {oppositeRichTextBox.Tag} before {button.Text}");
			//else if (!_cryptography.IsKeyValid(keyTextBox.Text))
			//	MessageBox.Show("Input correct key");
			//else
			//{

			//	return true;
			//}

			//if()

			//return false;

			_alphabet.ChangeAlphabet((AlphabetsEnum)alphabetComboBox.SelectedItem);

			var cipherMode = (CipherModesEnum)cipherModesComboBox.SelectedItem;
			var key = keyTextBox.Text;

			switch (cipherMode)
			{
				case CipherModesEnum.CaesarCipher:
					_cryptography = new CaesarCipherRename(_alphabet, key);
					break;
				case CipherModesEnum.VigenereCipher:
					_cryptography = new VigenereCipher(_alphabet, key);
					break;
			}
		}

		private void encryptButton_Click(object sender, EventArgs e)
		{
			if (AreControlsValid(originalTextBox, sender as Button))
			{
				//	cryptogramTextBox.Text = alphabet.MakeCipherSteps(originalTextBox.Text, steps);
				//cryptogramTextBox.Text = new CaesarCipherRename(_alphabet, steps).Encrypt(originalTextBox.Text);
				cryptogramTextBox.Text = _cryptography.Encrypt(originalTextBox.Text);
				originalTextBox.Clear();
			}
		}

		private void decryptButton_Click(object sender, EventArgs e)
		{
			if (AreControlsValid(cryptogramTextBox, sender as Button))
			{
				//originalTextBox.Text = alphabet.MakeCipherSteps(cryptogramTextBox.Text, -steps);
				originalTextBox.Text = _cryptography.Decrypt(cryptogramTextBox.Text);
				cryptogramTextBox.Clear();
			}
		}

		private void alphabetComboBox_SelectedIndexChanged(object sender, EventArgs e)
		{
			//alphabet = new Alphabet((AlphabetsEnum)alphabetComboBox.SelectedItem);
			_alphabet.ChangeAlphabet((AlphabetsEnum)alphabetComboBox.SelectedItem);
		}

		private void originalTextBox_TextChanged(object sender, EventArgs e)
		{
			//if (string.IsNullOrEmpty(originalTextBox.Text))
			//	encryptButton.Enabled = false;
			//else if (!string.IsNullOrEmpty(cryptogramTextBox.Text))
			//{
			//	encryptButton.Enabled = false;
			//	decryptButton.Enabled = false;
			//}
			//else
			//	encryptButton.Enabled = true;
		}

		private void cryptogramTextBox_TextChanged(object sender, EventArgs e)
		{
			//if (string.IsNullOrEmpty(cryptogramTextBox.Text))
			//	decryptButton.Enabled = false;
			//else if(!string.IsNullOrEmpty(originalTextBox.Text))
			//{
			//	encryptButton.Enabled = false;
			//	decryptButton.Enabled = false;
			//}
			//else
			//	decryptButton.Enabled = true;
		}

		private void RichTextBoxes_TextChanged(object sender, EventArgs e)
		{
			bool isCryptogramNull = string.IsNullOrEmpty(cryptogramTextBox.Text);
			bool isOriginalTextNull = string.IsNullOrEmpty(originalTextBox.Text);
			List<Button> buttons = new List<Button>() { encryptButton, decryptButton };

			if (isCryptogramNull && isOriginalTextNull
				|| !isCryptogramNull && !isOriginalTextNull)
				buttons.ForEach(x => x.Enabled = false);
			else if (!isOriginalTextNull)
				encryptButton.Enabled = true;
			else if (!isCryptogramNull)
				decryptButton.Enabled = true;
		}

		private void cipherModesComboBox_SelectedIndexChanged(object sender, EventArgs e)
		{
			
		}
	}
}
