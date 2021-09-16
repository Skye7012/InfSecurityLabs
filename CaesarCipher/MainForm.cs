﻿using CaesarCipher.CipherModes;
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

		private bool AreControlsValid(RichTextBox richTextBox)
		{
			if (!_alphabet.IsValid(richTextBox.Text))
				MessageBox.Show("Input correct text according choosed alphabet");
			else if (!_cryptography.IsKeyValid(keyTextBox.Text))
				MessageBox.Show("Input correct key");
			else
				return true;

			return false;
		}

		private void encryptButton_Click(object sender, EventArgs e)
		{
			if (AreControlsValid(originalTextBox))
			{
				cryptogramTextBox.Text = _cryptography.Encrypt(originalTextBox.Text, keyTextBox.Text);
				originalTextBox.Clear();
			}
		}

		private void decryptButton_Click(object sender, EventArgs e)
		{
			if (AreControlsValid(cryptogramTextBox))
			{
				originalTextBox.Text = _cryptography.Decrypt(cryptogramTextBox.Text, keyTextBox.Text);
				cryptogramTextBox.Clear();
			}
		}

		private void alphabetComboBox_SelectedIndexChanged(object sender, EventArgs e)
		{
			_alphabet.ChangeAlphabet((AlphabetsEnum)alphabetComboBox.SelectedItem);
		}

		private void cipherModesComboBox_SelectedIndexChanged(object sender, EventArgs e)
		{
			var cipherMode = (CipherModesEnum)cipherModesComboBox.SelectedItem;

			switch (cipherMode)
			{
				case CipherModesEnum.CaesarCipher:
					_cryptography = new CaesarCipherRename(_alphabet);
					break;
				case CipherModesEnum.VigenereCipher:
					_cryptography = new VigenereCipher(_alphabet);
					break;
			}
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
	}
}
