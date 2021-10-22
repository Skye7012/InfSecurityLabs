﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace XorManulKey
{
	public partial class MainForm : Form
	{
		//private ICryptographer _cryptographer;
		private Alphabet _alphabet = new Alphabet();
		private readonly Control[] _plainTextControls;
		private readonly Control[] _keyControls;
		private readonly List<Control[]> _controls;

		public MainForm()
		{
			InitializeComponent();
			_plainTextControls = new Control[] { plainTextBox, binaryPlainTextBox, plainToBinaryBtn }; //renameToGroup
			_keyControls = new Control[] { keyTbx, binaryKeyTbx, keyToBinaryBtn };
			_controls = new List<Control[]> { _plainTextControls, _keyControls };

			//originalTextBox.TextChanged += new EventHandler(IsValidAccordingAlphabet);
		}

		private void plainToBinaryBtn_Click(object sender, EventArgs e)
		{
			if (!IsValidAccordingAlphabet(plainTextBox.Text))
			{
				MessageBox.Show("Введите правильные символы, которые входят в алфавит");
				return;
			}
			binaryPlainTextBox.Text = _alphabet.ConvertToBinary(plainTextBox.Text);
			DisableControlGroup(_plainTextControls);
		}

		private void keyToBinaryBtn_Click(object sender, EventArgs e)
		{
			if (!IsValidAccordingAlphabet(keyTbx.Text))
			{
				MessageBox.Show("Введите правильные символы, которые входят в алфавит");
				return;
			}
			binaryKeyTbx.Text = _alphabet.ConvertToBinary(keyTbx.Text);
			DisableControlGroup(_keyControls);
		}
		private bool IsValidAccordingAlphabet(string text)
		{
			return _alphabet.IsValid(text);
			//if(!b)
			//	MessageBox.Show("Введите правильные символы, которые входят в алфавит");
			//return b;
		}

		void DisableControlGroup(Control[] controls)
			=> controls.ToList().
				ForEach(x => x.Enabled = false);

		//private void IsValidAccordingAlphabet(object sender, EventArgs e)
		//{
		//	var button = (Button)sender;

		//	var controls = _controls.Single(x => x[0] == button);

		//	if(IsValidAccordingAlphabet(controls[0].Text))

		//}

		//private bool AreControlsValid(RichTextBox richTextBox)
		//{
		//	if (!_alphabet.IsValid(richTextBox.Text))
		//		MessageBox.Show("Input correct text according choosed alphabet");
		//	else if (!_cryptographer.IsKeyValid(keyTextBox.Text))
		//		MessageBox.Show("Input correct key");
		//	else
		//		return true;

		//	return false;
		//}

		//private void encryptButton_Click(object sender, EventArgs e)
		//{
		//	if (AreControlsValid(plainTextBox))
		//	{
		//		cryptogramTextBox.Text = _cryptographer.Encrypt(plainTextBox.Text, keyTextBox.Text);
		//		plainTextBox.Clear();
		//	}
		//}

		//private void decryptButton_Click(object sender, EventArgs e)
		//{
		//	if (AreControlsValid(cryptogramTextBox))
		//	{
		//		plainTextBox.Text = _cryptographer.Decrypt(cryptogramTextBox.Text, keyTextBox.Text);
		//		cryptogramTextBox.Clear();
		//	}
		//}

		//private void alphabetComboBox_SelectedIndexChanged(object sender, EventArgs e)
		//	=> _alphabet.ChangeAlphabet((AlphabetsEnum)alphabetComboBox.SelectedItem);

		//private void cipherModesComboBox_SelectedIndexChanged(object sender, EventArgs e)
		//{
		//	var cipherMode = (CipherModesEnum)cipherModesComboBox.SelectedItem;

		//	switch (cipherMode)
		//	{
		//		case CipherModesEnum.CaesarCipher:
		//			_cryptographer = new CaesarCipher(_alphabet);
		//			break;
		//		case CipherModesEnum.VigenereCipher:
		//			_cryptographer = new VigenereCipher(_alphabet);
		//			break;
		//		case CipherModesEnum.XorCipher:
		//			_cryptographer = new XorCipher(_alphabet);
		//			break;
		//	}
		//}

		//private void RichTextBoxes_TextChanged(object sender, EventArgs e)
		//{
		//	bool isCryptogramNull = string.IsNullOrEmpty(cryptogramTextBox.Text);
		//	bool isOriginalTextNull = string.IsNullOrEmpty(plainTextBox.Text);
		//	List<Button> buttons = new List<Button>() { encryptButton, decryptButton };

		//	if (isCryptogramNull && isOriginalTextNull
		//		|| !isCryptogramNull && !isOriginalTextNull
		//		|| string.IsNullOrWhiteSpace(keyTextBox.Text))
		//		buttons.ForEach(x => x.Enabled = false);
		//	else if (!isOriginalTextNull)
		//		encryptButton.Enabled = true;
		//	else if (!isCryptogramNull)
		//		decryptButton.Enabled = true;
		//}
	}
}
