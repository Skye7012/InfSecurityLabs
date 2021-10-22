
using System.Windows.Forms;

namespace XorManulKey
{
	partial class MainForm : Form
	{
		/// <summary>
		///  Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		///  Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		///  Required method for Designer support - do not modify
		///  the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.decryptButton = new System.Windows.Forms.Button();
			this.encryptButton = new System.Windows.Forms.Button();
			this.keyTextBox = new System.Windows.Forms.TextBox();
			this.plainTextBox = new System.Windows.Forms.TextBox();
			this.alphabetComboBox = new System.Windows.Forms.ComboBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.cipherModesComboBox = new System.Windows.Forms.ComboBox();
			this.panel1 = new System.Windows.Forms.Panel();
			this.richTextBox4 = new System.Windows.Forms.RichTextBox();
			this.label8 = new System.Windows.Forms.Label();
			this.richTextBox3 = new System.Windows.Forms.RichTextBox();
			this.label7 = new System.Windows.Forms.Label();
			this.richTextBox2 = new System.Windows.Forms.RichTextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.binaryPlainTextBox = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.panel2 = new System.Windows.Forms.Panel();
			this.plainToBinaryBtn = new System.Windows.Forms.Button();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.panel1.SuspendLayout();
			this.panel2.SuspendLayout();
			this.SuspendLayout();
			// 
			// decryptButton
			// 
			this.decryptButton.Enabled = false;
			this.decryptButton.Location = new System.Drawing.Point(770, 460);
			this.decryptButton.Name = "decryptButton";
			this.decryptButton.Size = new System.Drawing.Size(150, 30);
			this.decryptButton.TabIndex = 7;
			this.decryptButton.Text = "Decrypt";
			this.decryptButton.UseVisualStyleBackColor = true;
			// 
			// encryptButton
			// 
			this.encryptButton.Enabled = false;
			this.encryptButton.Location = new System.Drawing.Point(770, 100);
			this.encryptButton.Name = "encryptButton";
			this.encryptButton.Size = new System.Drawing.Size(150, 30);
			this.encryptButton.TabIndex = 6;
			this.encryptButton.Text = "Encrypt";
			this.encryptButton.UseVisualStyleBackColor = true;
			// 
			// keyTextBox
			// 
			this.keyTextBox.Location = new System.Drawing.Point(770, 275);
			this.keyTextBox.Name = "keyTextBox";
			this.keyTextBox.Size = new System.Drawing.Size(150, 29);
			this.keyTextBox.TabIndex = 5;
			// 
			// plainTextBox
			// 
			this.plainTextBox.Dock = System.Windows.Forms.DockStyle.Top;
			this.plainTextBox.Location = new System.Drawing.Point(0, 21);
			this.plainTextBox.Name = "plainTextBox";
			this.plainTextBox.Size = new System.Drawing.Size(400, 40);
			this.plainTextBox.TabIndex = 4;
			this.plainTextBox.Tag = "";
			this.plainTextBox.Text = "";
			// 
			// alphabetComboBox
			// 
			this.alphabetComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.alphabetComboBox.FormattingEnabled = true;
			this.alphabetComboBox.Location = new System.Drawing.Point(770, 211);
			this.alphabetComboBox.Name = "alphabetComboBox";
			this.alphabetComboBox.Size = new System.Drawing.Size(150, 29);
			this.alphabetComboBox.TabIndex = 8;
			// 
			// label1
			// 
			this.label1.Dock = System.Windows.Forms.DockStyle.Top;
			this.label1.Location = new System.Drawing.Point(0, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(400, 21);
			this.label1.TabIndex = 10;
			this.label1.Text = "Исходный текст";
			this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(770, 187);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(72, 21);
			this.label3.TabIndex = 12;
			this.label3.Text = "Alphabet";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(770, 251);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(35, 21);
			this.label4.TabIndex = 13;
			this.label4.Text = "Key";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(770, 316);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(96, 21);
			this.label5.TabIndex = 15;
			this.label5.Text = "CipherMode";
			// 
			// cipherModesComboBox
			// 
			this.cipherModesComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cipherModesComboBox.FormattingEnabled = true;
			this.cipherModesComboBox.Location = new System.Drawing.Point(770, 340);
			this.cipherModesComboBox.Name = "cipherModesComboBox";
			this.cipherModesComboBox.Size = new System.Drawing.Size(150, 29);
			this.cipherModesComboBox.TabIndex = 16;
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.textBox1);
			this.panel1.Controls.Add(this.richTextBox4);
			this.panel1.Controls.Add(this.label8);
			this.panel1.Controls.Add(this.richTextBox3);
			this.panel1.Controls.Add(this.label7);
			this.panel1.Controls.Add(this.richTextBox2);
			this.panel1.Controls.Add(this.label6);
			this.panel1.Controls.Add(this.binaryPlainTextBox);
			this.panel1.Controls.Add(this.label2);
			this.panel1.Controls.Add(this.plainTextBox);
			this.panel1.Controls.Add(this.label1);
			this.panel1.Location = new System.Drawing.Point(12, 12);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(400, 393);
			this.panel1.TabIndex = 17;
			// 
			// richTextBox4
			// 
			this.richTextBox4.Dock = System.Windows.Forms.DockStyle.Top;
			this.richTextBox4.Location = new System.Drawing.Point(0, 265);
			this.richTextBox4.Name = "richTextBox4";
			this.richTextBox4.Size = new System.Drawing.Size(400, 40);
			this.richTextBox4.TabIndex = 17;
			this.richTextBox4.Tag = "Original Text";
			this.richTextBox4.Text = "";
			// 
			// label8
			// 
			this.label8.Dock = System.Windows.Forms.DockStyle.Top;
			this.label8.Location = new System.Drawing.Point(0, 244);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(400, 21);
			this.label8.TabIndex = 18;
			this.label8.Text = "Исходиный текст";
			this.label8.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// richTextBox3
			// 
			this.richTextBox3.Dock = System.Windows.Forms.DockStyle.Top;
			this.richTextBox3.Location = new System.Drawing.Point(0, 204);
			this.richTextBox3.Name = "richTextBox3";
			this.richTextBox3.Size = new System.Drawing.Size(400, 40);
			this.richTextBox3.TabIndex = 15;
			this.richTextBox3.Tag = "Original Text";
			this.richTextBox3.Text = "";
			// 
			// label7
			// 
			this.label7.Dock = System.Windows.Forms.DockStyle.Top;
			this.label7.Location = new System.Drawing.Point(0, 183);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(400, 21);
			this.label7.TabIndex = 16;
			this.label7.Text = "Исходиный текст";
			this.label7.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// richTextBox2
			// 
			this.richTextBox2.Dock = System.Windows.Forms.DockStyle.Top;
			this.richTextBox2.Location = new System.Drawing.Point(0, 143);
			this.richTextBox2.Name = "richTextBox2";
			this.richTextBox2.Size = new System.Drawing.Size(400, 40);
			this.richTextBox2.TabIndex = 13;
			this.richTextBox2.Tag = "Original Text";
			this.richTextBox2.Text = "";
			// 
			// label6
			// 
			this.label6.Dock = System.Windows.Forms.DockStyle.Top;
			this.label6.Location = new System.Drawing.Point(0, 122);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(400, 21);
			this.label6.TabIndex = 14;
			this.label6.Text = "Исходиный текст";
			this.label6.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// binaryPlainTextBox
			// 
			this.binaryPlainTextBox.Dock = System.Windows.Forms.DockStyle.Top;
			this.binaryPlainTextBox.Location = new System.Drawing.Point(0, 82);
			this.binaryPlainTextBox.Name = "binaryPlainTextBox";
			this.binaryPlainTextBox.Size = new System.Drawing.Size(400, 40);
			this.binaryPlainTextBox.TabIndex = 11;
			this.binaryPlainTextBox.Tag = "Original Text";
			this.binaryPlainTextBox.Text = "";
			// 
			// label2
			// 
			this.label2.Dock = System.Windows.Forms.DockStyle.Top;
			this.label2.Location = new System.Drawing.Point(0, 61);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(400, 21);
			this.label2.TabIndex = 12;
			this.label2.Text = "Бинарное представление исходного текста";
			this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// panel2
			// 
			this.panel2.Controls.Add(this.plainToBinaryBtn);
			this.panel2.Location = new System.Drawing.Point(418, 34);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(200, 371);
			this.panel2.TabIndex = 18;
			// 
			// plainToBinaryBtn
			// 
			this.plainToBinaryBtn.Location = new System.Drawing.Point(3, 39);
			this.plainToBinaryBtn.Name = "plainToBinaryBtn";
			this.plainToBinaryBtn.Size = new System.Drawing.Size(100, 40);
			this.plainToBinaryBtn.TabIndex = 0;
			this.plainToBinaryBtn.Text = "Перевести";
			this.plainToBinaryBtn.UseVisualStyleBackColor = true;
			this.plainToBinaryBtn.Click += new System.EventHandler(this.plainToBinaryBtn_Click);
			// 
			// textBox1
			// 
			this.textBox1.Dock = System.Windows.Forms.DockStyle.Top;
			this.textBox1.Location = new System.Drawing.Point(0, 305);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(400, 29);
			this.textBox1.TabIndex = 1;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(984, 560);
			this.Controls.Add(this.panel2);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.cipherModesComboBox);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.alphabetComboBox);
			this.Controls.Add(this.decryptButton);
			this.Controls.Add(this.encryptButton);
			this.Controls.Add(this.keyTextBox);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Name = "MainForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Cryptography";
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.panel2.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button decryptButton;
		private System.Windows.Forms.Button encryptButton;
		private System.Windows.Forms.TextBox keyTextBox;
		private System.Windows.Forms.TextBox plainTextBox;
		private System.Windows.Forms.ComboBox alphabetComboBox;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.ComboBox cipherModesComboBox;
		private Panel panel1;
		private RichTextBox richTextBox4;
		private Label label8;
		private RichTextBox richTextBox3;
		private Label label7;
		private RichTextBox richTextBox2;
		private Label label6;
		private TextBox binaryPlainTextBox;
		private Label label2;
		private Panel panel2;
		private Button plainToBinaryBtn;
		private TextBox textBox1;
	}
}

