using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace XorCryptography
{
	public partial class MainForm : Form
	{
		private readonly Alphabet _alphabet = new Alphabet();
		private readonly XorCipher _cryptographer;
		private readonly List<Control> _plainTextControls;
		private readonly List<Control> _keyControls;
		private readonly List<Control> _encryptControls;
		private readonly List<Control> _decryptControls;
		private readonly List<Control> _decryptPlainTextControls;
		private object _prevComboBoxItem;
		public List<List<Control>> ControlGroups { get; protected set; }

		public MainForm()
		{
			InitializeComponent();
			_cryptographer = new XorCipher(_alphabet);
			_plainTextControls = new List<Control> { plainTbx, binaryPlainTbx, plainToBinaryBtn }; 
			_keyControls = new List<Control> { keyTbx, binaryKeyTbx, keyToBinaryBtn };
			_encryptControls = new List<Control> { gammaTbx, encryptBtn };
			_decryptControls = new List<Control> { decryptedGammaTbx, decryptBtn };
			_decryptPlainTextControls = new List<Control> { decryptedPlainTextTbx, decryptedPlainTextToBinaryBtn };

			UpdateControlGroups();

			ControlGroups.Skip(1).ToList()
				.ForEach(x => DisableControlGroup(x));

			comboBox.SelectedItem = comboBox.Items[0];
		}

		#region ServiceMethods

		void Restart()
		{
			foreach (var group in ControlGroups)
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
			ControlGroups.ForEach(x => DisableControlGroup(x));
			EnableControlGroup(ControlGroups[0]);
			comboBox.Enabled = true;
		}

		private bool IsValidAccordingAlphabet(string text)
		{
			return _alphabet.IsValid(text);
		}

		void UpdateControlGroups()
		{
			ControlGroups = new List<List<Control>>
				{
					_plainTextControls,
					_keyControls,
					_encryptControls,
					_decryptControls,
					_decryptPlainTextControls,
				};
		}

#endregion

		#region Navigation

		void DisableControlGroup(List<Control> controls)
			=> controls.ToList().
				ForEach(x => x.Enabled = false);

		void EnableControlGroup(List<Control> controls)
			=> controls.ToList().
				ForEach(x => x.Enabled = true);

		void NextControlGroup(List<Control> controls)
		{
			if (controls == ControlGroups.Last())
				return;

			int index = ControlGroups.FindIndex(x => x == controls);

			DisableControlGroup(ControlGroups[index]);
			EnableControlGroup(ControlGroups[index + 1]);
		}

#endregion

		#region Controls

		private void comboBox_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (_prevComboBoxItem == comboBox.SelectedItem)
				return;

			_prevComboBoxItem = comboBox.SelectedItem;
			
			if (comboBox.SelectedItem == comboBox.Items[1])
			{
				binaryKeyLabel.Text = "Ключ";
				generateKeyBtn.Text = "Сгенирировать ключ";
				generateKeyBtn.Enabled = true;
				keyConvertLabel.Hide();
				keyToBinaryBtn.Hide();
				keyLabel.Hide();
				keyTbx.Hide();
				_keyControls.Add(generateKeyBtn);
				Restart();
			}
			else
			{
				binaryKeyLabel.Text = "Бинарное представление ключа";
				generateKeyBtn.Text = "";
				generateKeyBtn.Enabled = false;
				keyConvertLabel.Show();
				keyToBinaryBtn.Show();
				keyLabel.Show();
				keyTbx.Show();
				_keyControls.Remove(generateKeyBtn);
				Restart();
			}
		}

		private void generateKeyBtn_Click(object sender, EventArgs e)
		{
			binaryKeyTbx.Text = _cryptographer.GenerateKey(binaryPlainTbx.Text);

			NextControlGroup(_keyControls);
		}

		private void plainToBinaryBtn_Click(object sender, EventArgs e)
		{
			if (!IsValidAccordingAlphabet(plainTbx.Text))
			{
				MessageBox.Show("Введите правильные символы, которые входят в алфавит");
				return;
			}
			binaryPlainTbx.Text = _alphabet.ConvertToBinary(plainTbx.Text);
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
			gammaTbx.Text = _cryptographer.Encrypt(binaryPlainTbx.Text, binaryKeyTbx.Text);
			NextControlGroup(_encryptControls);
		}

		private void decryptBtn_Click(object sender, EventArgs e)
		{
			decryptedGammaTbx.Text = _cryptographer.Decrypt(gammaTbx.Text, binaryKeyTbx.Text);
			NextControlGroup(_decryptControls);
		}

		private void restartBtn_Click(object sender, EventArgs e)
		{
			Restart();
		}

		#endregion
	}
}
