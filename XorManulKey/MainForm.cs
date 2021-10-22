using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace XorManulKey
{
	public partial class MainForm : Form
	{
		//private ICryptographer _cryptographer;
		private Alphabet _alphabet = new Alphabet();
		public MainForm()
		{
			InitializeComponent();
			//alphabetComboBox.DataSource = Enum.GetValues(typeof(AlphabetsEnum));
			//alphabetComboBox.SelectedItem = alphabetComboBox.Items[0];
			//cipherModesComboBox.DataSource = Enum.GetValues(typeof(CipherModesEnum));
			//cipherModesComboBox.SelectedItem = cipherModesComboBox.Items[0];

			//plainTextBox.TextChanged += new EventHandler(RichTextBoxes_TextChanged);
			//cryptogramTextBox.TextChanged += new EventHandler(RichTextBoxes_TextChanged);
			//keyTextBox.TextChanged += new EventHandler(RichTextBoxes_TextChanged);
		}

		private void plainToBinaryBtn_Click(object sender, EventArgs e)
		{
			binaryPlainTextBox.Text = _alphabet.ConvertToBinary(plainTextBox.Text);
		}

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
