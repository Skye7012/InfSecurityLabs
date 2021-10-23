using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace XorManulKey
{
	public partial class MainForm : Form
	{
		private readonly Alphabet _alphabet = new Alphabet();
		private readonly XorCipher _cryptographer;
		private readonly Control[] _plainTextControls;
		private readonly Control[] _keyControls;
		private readonly Control[] _encryptControls;
		private readonly Control[] _decryptControls;
		private readonly Control[] _decryptPlainTextControls;
		private readonly List<Control[]> _controls;

		public MainForm()
		{
			InitializeComponent();
			_cryptographer = new XorCipher(_alphabet);
			_plainTextControls = new Control[] { plainTextBox, binaryPlainTextBox, plainToBinaryBtn }; //renameToGroup
			_keyControls = new Control[] { keyTbx, binaryKeyTbx, keyToBinaryBtn };
			_encryptControls = new Control[] { gammaTbx, encryptBtn };
			_decryptControls = new Control[] { decryptedGammaTbx, decryptBtn };
			_decryptPlainTextControls = new Control[] { decryptedPlainTextTbx, decryptedPlainTextToBinaryBtn };
			
			_controls = new List<Control[]> 
				{ 
					_plainTextControls, 
					_keyControls, 
					_encryptControls, 
					_decryptControls,
					_decryptPlainTextControls,
				};

			_controls.Skip(1).ToList()
				.ForEach(x => DisableControlGroup(x));

			comboBox.SelectedItem = comboBox.Items[0];
		}

		private void restartBtn_Click(object sender, EventArgs e)
		{
			foreach(var group in _controls)
			{
				foreach (var control in group)
				{
					if (control.GetType() == typeof(TextBox))
					{
						var textBox = control as TextBox;
						textBox.Clear();
					}
				}
			}
			_controls.ForEach(x => DisableControlGroup(x));
			EnableControlGroup(_controls[0]);
		}

		private void plainToBinaryBtn_Click(object sender, EventArgs e)
		{
			if (!IsValidAccordingAlphabet(plainTextBox.Text))
			{
				MessageBox.Show("Введите правильные символы, которые входят в алфавит");
				return;
			}
			binaryPlainTextBox.Text = _alphabet.ConvertToBinary(plainTextBox.Text);
			NextControlGroup(_plainTextControls);
		}

		private void keyToBinaryBtn_Click(object sender, EventArgs e)
		{
			if (!IsValidAccordingAlphabet(keyTbx.Text))
			{
				MessageBox.Show("Введите правильные символы, которые входят в алфавит");
				return;
			}
			binaryKeyTbx.Text = _alphabet.ConvertToBinary(keyTbx.Text);
			NextControlGroup(_keyControls);
		}

		private void decryptedPlainTextToBinaryBtn_Click(object sender, EventArgs e)
		{
			decryptedPlainTextTbx.Text = _alphabet.ConvertFromBinary(decryptedGammaTbx.Text);
			DisableControlGroup(_decryptPlainTextControls);
		}

		private void encryptBtn_Click(object sender, EventArgs e)
		{
			gammaTbx.Text = _cryptographer.Encrypt(binaryPlainTextBox.Text, binaryKeyTbx.Text);
			NextControlGroup(_encryptControls);
		}

		private void decryptBtn_Click(object sender, EventArgs e)
		{
			decryptedGammaTbx.Text = _cryptographer.Decrypt(gammaTbx.Text, binaryKeyTbx.Text);
			NextControlGroup(_decryptControls);
		}

		private bool IsValidAccordingAlphabet(string text)
		{
			return _alphabet.IsValid(text);
		}

		void DisableControlGroup(Control[] controls)
			=> controls.ToList().
				ForEach(x => x.Enabled = false);

		void EnableControlGroup(Control[] controls)
			=> controls.ToList().
				ForEach(x => x.Enabled = true);

		void NextControlGroup(Control[] controls)
		{
			if (controls == _controls.Last())
				return;

			int index = _controls.FindIndex(x => x == controls);

			DisableControlGroup(_controls[index]);
			EnableControlGroup(_controls[index + 1]);
		}
		private void comboBox_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (comboBox.SelectedItem == comboBox.Items[1])
			{
				generateKeyBtn.Show();
				genLabel.Show();
				keyLabel.Hide();
				keyTbx.Hide();
			}
		}

		private void generateKeyBtn_Click(object sender, EventArgs e)
		{
			
		}
	}
}
