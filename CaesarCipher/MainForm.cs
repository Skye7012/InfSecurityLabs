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

		private bool AreControlsValid()
		{
			if (!alphabet.IsValid(mainTextBox.Text))
				MessageBox.Show("Input correct text according choosed alphabet");
			else if (!BigInteger.TryParse(stepsTextBox.Text, out steps))
				MessageBox.Show("Input correct key");
			else
				return true;

			return false;
		}

		private void encryptButton_Click(object sender, EventArgs e)
		{
			if (AreControlsValid())
				mainTextBox.Text = alphabet.MakeCipherSteps(mainTextBox.Text, steps);
		}

		private void decryptButton_Click(object sender, EventArgs e)
		{
			if (AreControlsValid())
				mainTextBox.Text = alphabet.MakeCipherSteps(mainTextBox.Text, -steps);
		}

		private void alphabetComboBox_SelectedIndexChanged(object sender, EventArgs e)
		{
			alphabet = new Alphabet((AlphabetsEnum)alphabetComboBox.SelectedItem);
		}
	}
}
