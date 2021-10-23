
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
			this.plainTextBox = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.panel1 = new System.Windows.Forms.Panel();
			this.decryptedPlainTextTbx = new System.Windows.Forms.TextBox();
			this.label7 = new System.Windows.Forms.Label();
			this.decryptedGammaTbx = new System.Windows.Forms.TextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.gammaTbx = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.binaryKeyTbx = new System.Windows.Forms.TextBox();
			this.binaryKeyLabel = new System.Windows.Forms.Label();
			this.keyTbx = new System.Windows.Forms.TextBox();
			this.keyLabel = new System.Windows.Forms.Label();
			this.binaryPlainTextBox = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.panel2 = new System.Windows.Forms.Panel();
			this.decryptedPlainTextToBinaryBtn = new System.Windows.Forms.Button();
			this.label13 = new System.Windows.Forms.Label();
			this.decryptBtn = new System.Windows.Forms.Button();
			this.label12 = new System.Windows.Forms.Label();
			this.encryptBtn = new System.Windows.Forms.Button();
			this.label11 = new System.Windows.Forms.Label();
			this.keyToBinaryBtn = new System.Windows.Forms.Button();
			this.keyConvertLabel = new System.Windows.Forms.Label();
			this.generateKeyBtn = new System.Windows.Forms.Button();
			this.genLabel = new System.Windows.Forms.Label();
			this.plainToBinaryBtn = new System.Windows.Forms.Button();
			this.label9 = new System.Windows.Forms.Label();
			this.comboBox = new System.Windows.Forms.ComboBox();
			this.label8 = new System.Windows.Forms.Label();
			this.restartBtn = new System.Windows.Forms.Button();
			this.panel1.SuspendLayout();
			this.panel2.SuspendLayout();
			this.SuspendLayout();
			// 
			// plainTextBox
			// 
			this.plainTextBox.Dock = System.Windows.Forms.DockStyle.Top;
			this.plainTextBox.Location = new System.Drawing.Point(0, 21);
			this.plainTextBox.Name = "plainTextBox";
			this.plainTextBox.Size = new System.Drawing.Size(400, 29);
			this.plainTextBox.TabIndex = 4;
			this.plainTextBox.Tag = "";
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
			// panel1
			// 
			this.panel1.Controls.Add(this.decryptedPlainTextTbx);
			this.panel1.Controls.Add(this.label7);
			this.panel1.Controls.Add(this.decryptedGammaTbx);
			this.panel1.Controls.Add(this.label6);
			this.panel1.Controls.Add(this.gammaTbx);
			this.panel1.Controls.Add(this.label5);
			this.panel1.Controls.Add(this.binaryKeyTbx);
			this.panel1.Controls.Add(this.binaryKeyLabel);
			this.panel1.Controls.Add(this.keyTbx);
			this.panel1.Controls.Add(this.keyLabel);
			this.panel1.Controls.Add(this.binaryPlainTextBox);
			this.panel1.Controls.Add(this.label2);
			this.panel1.Controls.Add(this.plainTextBox);
			this.panel1.Controls.Add(this.label1);
			this.panel1.Location = new System.Drawing.Point(12, 12);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(400, 393);
			this.panel1.TabIndex = 17;
			// 
			// decryptedPlainTextTbx
			// 
			this.decryptedPlainTextTbx.Dock = System.Windows.Forms.DockStyle.Top;
			this.decryptedPlainTextTbx.Location = new System.Drawing.Point(0, 321);
			this.decryptedPlainTextTbx.Name = "decryptedPlainTextTbx";
			this.decryptedPlainTextTbx.ReadOnly = true;
			this.decryptedPlainTextTbx.Size = new System.Drawing.Size(400, 29);
			this.decryptedPlainTextTbx.TabIndex = 21;
			this.decryptedPlainTextTbx.Tag = "Original Text";
			// 
			// label7
			// 
			this.label7.Dock = System.Windows.Forms.DockStyle.Top;
			this.label7.Location = new System.Drawing.Point(0, 300);
			this.label7.Margin = new System.Windows.Forms.Padding(10, 0, 10, 0);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(400, 21);
			this.label7.TabIndex = 22;
			this.label7.Text = "Расшифрованный исходный текст";
			this.label7.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// decryptedGammaTbx
			// 
			this.decryptedGammaTbx.Dock = System.Windows.Forms.DockStyle.Top;
			this.decryptedGammaTbx.Location = new System.Drawing.Point(0, 271);
			this.decryptedGammaTbx.Name = "decryptedGammaTbx";
			this.decryptedGammaTbx.ReadOnly = true;
			this.decryptedGammaTbx.Size = new System.Drawing.Size(400, 29);
			this.decryptedGammaTbx.TabIndex = 19;
			this.decryptedGammaTbx.Tag = "Original Text";
			// 
			// label6
			// 
			this.label6.Dock = System.Windows.Forms.DockStyle.Top;
			this.label6.Location = new System.Drawing.Point(0, 250);
			this.label6.Margin = new System.Windows.Forms.Padding(10, 0, 10, 0);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(400, 21);
			this.label6.TabIndex = 20;
			this.label6.Text = "Расшифрованная гамма";
			this.label6.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// gammaTbx
			// 
			this.gammaTbx.Dock = System.Windows.Forms.DockStyle.Top;
			this.gammaTbx.Location = new System.Drawing.Point(0, 221);
			this.gammaTbx.Name = "gammaTbx";
			this.gammaTbx.ReadOnly = true;
			this.gammaTbx.Size = new System.Drawing.Size(400, 29);
			this.gammaTbx.TabIndex = 17;
			this.gammaTbx.Tag = "Original Text";
			// 
			// label5
			// 
			this.label5.Dock = System.Windows.Forms.DockStyle.Top;
			this.label5.Location = new System.Drawing.Point(0, 200);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(400, 21);
			this.label5.TabIndex = 18;
			this.label5.Text = "Гамма";
			this.label5.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// binaryKeyTbx
			// 
			this.binaryKeyTbx.Dock = System.Windows.Forms.DockStyle.Top;
			this.binaryKeyTbx.Location = new System.Drawing.Point(0, 171);
			this.binaryKeyTbx.Name = "binaryKeyTbx";
			this.binaryKeyTbx.ReadOnly = true;
			this.binaryKeyTbx.Size = new System.Drawing.Size(400, 29);
			this.binaryKeyTbx.TabIndex = 15;
			this.binaryKeyTbx.Tag = "Original Text";
			// 
			// binaryKeyLabel
			// 
			this.binaryKeyLabel.Dock = System.Windows.Forms.DockStyle.Top;
			this.binaryKeyLabel.Location = new System.Drawing.Point(0, 150);
			this.binaryKeyLabel.Name = "binaryKeyLabel";
			this.binaryKeyLabel.Size = new System.Drawing.Size(400, 21);
			this.binaryKeyLabel.TabIndex = 16;
			this.binaryKeyLabel.Text = "Бинарное представление ключа";
			this.binaryKeyLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// keyTbx
			// 
			this.keyTbx.Dock = System.Windows.Forms.DockStyle.Top;
			this.keyTbx.Location = new System.Drawing.Point(0, 121);
			this.keyTbx.Name = "keyTbx";
			this.keyTbx.Size = new System.Drawing.Size(400, 29);
			this.keyTbx.TabIndex = 13;
			this.keyTbx.Tag = "";
			// 
			// keyLabel
			// 
			this.keyLabel.Dock = System.Windows.Forms.DockStyle.Top;
			this.keyLabel.Location = new System.Drawing.Point(0, 100);
			this.keyLabel.Name = "keyLabel";
			this.keyLabel.Size = new System.Drawing.Size(400, 21);
			this.keyLabel.TabIndex = 14;
			this.keyLabel.Text = "Ключ";
			this.keyLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// binaryPlainTextBox
			// 
			this.binaryPlainTextBox.Dock = System.Windows.Forms.DockStyle.Top;
			this.binaryPlainTextBox.Location = new System.Drawing.Point(0, 71);
			this.binaryPlainTextBox.Name = "binaryPlainTextBox";
			this.binaryPlainTextBox.ReadOnly = true;
			this.binaryPlainTextBox.Size = new System.Drawing.Size(400, 29);
			this.binaryPlainTextBox.TabIndex = 11;
			this.binaryPlainTextBox.Tag = "Original Text";
			// 
			// label2
			// 
			this.label2.Dock = System.Windows.Forms.DockStyle.Top;
			this.label2.Location = new System.Drawing.Point(0, 50);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(400, 21);
			this.label2.TabIndex = 12;
			this.label2.Text = "Бинарное представление исходного текста";
			this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// panel2
			// 
			this.panel2.Controls.Add(this.decryptedPlainTextToBinaryBtn);
			this.panel2.Controls.Add(this.label13);
			this.panel2.Controls.Add(this.decryptBtn);
			this.panel2.Controls.Add(this.label12);
			this.panel2.Controls.Add(this.encryptBtn);
			this.panel2.Controls.Add(this.label11);
			this.panel2.Controls.Add(this.keyToBinaryBtn);
			this.panel2.Controls.Add(this.keyConvertLabel);
			this.panel2.Controls.Add(this.generateKeyBtn);
			this.panel2.Controls.Add(this.genLabel);
			this.panel2.Controls.Add(this.plainToBinaryBtn);
			this.panel2.Controls.Add(this.label9);
			this.panel2.Controls.Add(this.comboBox);
			this.panel2.Controls.Add(this.label8);
			this.panel2.Location = new System.Drawing.Point(418, 12);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(194, 393);
			this.panel2.TabIndex = 18;
			// 
			// decryptedPlainTextToBinaryBtn
			// 
			this.decryptedPlainTextToBinaryBtn.Dock = System.Windows.Forms.DockStyle.Top;
			this.decryptedPlainTextToBinaryBtn.Location = new System.Drawing.Point(0, 320);
			this.decryptedPlainTextToBinaryBtn.Name = "decryptedPlainTextToBinaryBtn";
			this.decryptedPlainTextToBinaryBtn.Size = new System.Drawing.Size(194, 30);
			this.decryptedPlainTextToBinaryBtn.TabIndex = 4;
			this.decryptedPlainTextToBinaryBtn.Text = "Перевести";
			this.decryptedPlainTextToBinaryBtn.UseVisualStyleBackColor = true;
			this.decryptedPlainTextToBinaryBtn.Click += new System.EventHandler(this.decryptedPlainTextToBinaryBtn_Click);
			// 
			// label13
			// 
			this.label13.Dock = System.Windows.Forms.DockStyle.Top;
			this.label13.Location = new System.Drawing.Point(0, 300);
			this.label13.Name = "label13";
			this.label13.Size = new System.Drawing.Size(194, 20);
			this.label13.TabIndex = 24;
			this.label13.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// decryptBtn
			// 
			this.decryptBtn.Dock = System.Windows.Forms.DockStyle.Top;
			this.decryptBtn.Location = new System.Drawing.Point(0, 270);
			this.decryptBtn.Name = "decryptBtn";
			this.decryptBtn.Size = new System.Drawing.Size(194, 30);
			this.decryptBtn.TabIndex = 3;
			this.decryptBtn.Text = "Расшифровать";
			this.decryptBtn.UseVisualStyleBackColor = true;
			this.decryptBtn.Click += new System.EventHandler(this.decryptBtn_Click);
			// 
			// label12
			// 
			this.label12.Dock = System.Windows.Forms.DockStyle.Top;
			this.label12.Location = new System.Drawing.Point(0, 250);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(194, 20);
			this.label12.TabIndex = 23;
			this.label12.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// encryptBtn
			// 
			this.encryptBtn.Dock = System.Windows.Forms.DockStyle.Top;
			this.encryptBtn.Location = new System.Drawing.Point(0, 220);
			this.encryptBtn.Name = "encryptBtn";
			this.encryptBtn.Size = new System.Drawing.Size(194, 30);
			this.encryptBtn.TabIndex = 2;
			this.encryptBtn.Text = "Зашифровать";
			this.encryptBtn.UseVisualStyleBackColor = true;
			this.encryptBtn.Click += new System.EventHandler(this.encryptBtn_Click);
			// 
			// label11
			// 
			this.label11.Dock = System.Windows.Forms.DockStyle.Top;
			this.label11.Location = new System.Drawing.Point(0, 200);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(194, 20);
			this.label11.TabIndex = 22;
			this.label11.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// keyToBinaryBtn
			// 
			this.keyToBinaryBtn.Dock = System.Windows.Forms.DockStyle.Top;
			this.keyToBinaryBtn.Location = new System.Drawing.Point(0, 170);
			this.keyToBinaryBtn.Name = "keyToBinaryBtn";
			this.keyToBinaryBtn.Size = new System.Drawing.Size(194, 30);
			this.keyToBinaryBtn.TabIndex = 1;
			this.keyToBinaryBtn.Text = "Перевести";
			this.keyToBinaryBtn.UseVisualStyleBackColor = true;
			this.keyToBinaryBtn.Click += new System.EventHandler(this.keyToBinaryBtn_Click);
			// 
			// keyConvertLabel
			// 
			this.keyConvertLabel.Dock = System.Windows.Forms.DockStyle.Top;
			this.keyConvertLabel.Location = new System.Drawing.Point(0, 150);
			this.keyConvertLabel.Name = "keyConvertLabel";
			this.keyConvertLabel.Size = new System.Drawing.Size(194, 20);
			this.keyConvertLabel.TabIndex = 21;
			this.keyConvertLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// generateKeyBtn
			// 
			this.generateKeyBtn.Dock = System.Windows.Forms.DockStyle.Top;
			this.generateKeyBtn.Enabled = false;
			this.generateKeyBtn.Location = new System.Drawing.Point(0, 120);
			this.generateKeyBtn.Name = "generateKeyBtn";
			this.generateKeyBtn.Size = new System.Drawing.Size(194, 30);
			this.generateKeyBtn.TabIndex = 5;
			this.generateKeyBtn.UseVisualStyleBackColor = true;
			this.generateKeyBtn.Click += new System.EventHandler(this.generateKeyBtn_Click);
			// 
			// genLabel
			// 
			this.genLabel.Dock = System.Windows.Forms.DockStyle.Top;
			this.genLabel.Location = new System.Drawing.Point(0, 100);
			this.genLabel.Name = "genLabel";
			this.genLabel.Size = new System.Drawing.Size(194, 20);
			this.genLabel.TabIndex = 15;
			this.genLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// plainToBinaryBtn
			// 
			this.plainToBinaryBtn.Dock = System.Windows.Forms.DockStyle.Top;
			this.plainToBinaryBtn.Location = new System.Drawing.Point(0, 70);
			this.plainToBinaryBtn.Name = "plainToBinaryBtn";
			this.plainToBinaryBtn.Size = new System.Drawing.Size(194, 30);
			this.plainToBinaryBtn.TabIndex = 0;
			this.plainToBinaryBtn.Text = "Перевести";
			this.plainToBinaryBtn.UseVisualStyleBackColor = true;
			this.plainToBinaryBtn.Click += new System.EventHandler(this.plainToBinaryBtn_Click);
			// 
			// label9
			// 
			this.label9.Dock = System.Windows.Forms.DockStyle.Top;
			this.label9.Location = new System.Drawing.Point(0, 50);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(194, 20);
			this.label9.TabIndex = 16;
			this.label9.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// comboBox
			// 
			this.comboBox.Dock = System.Windows.Forms.DockStyle.Top;
			this.comboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboBox.FormattingEnabled = true;
			this.comboBox.Items.AddRange(new object[] {
            "Ручной ввод",
            "Автоматический ввод"});
			this.comboBox.Location = new System.Drawing.Point(0, 21);
			this.comboBox.Name = "comboBox";
			this.comboBox.Size = new System.Drawing.Size(194, 29);
			this.comboBox.TabIndex = 20;
			this.comboBox.SelectedIndexChanged += new System.EventHandler(this.comboBox_SelectedIndexChanged);
			// 
			// label8
			// 
			this.label8.Dock = System.Windows.Forms.DockStyle.Top;
			this.label8.Location = new System.Drawing.Point(0, 0);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(194, 21);
			this.label8.TabIndex = 11;
			this.label8.Text = "Режим";
			this.label8.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// restartBtn
			// 
			this.restartBtn.Location = new System.Drawing.Point(220, 420);
			this.restartBtn.Name = "restartBtn";
			this.restartBtn.Size = new System.Drawing.Size(200, 40);
			this.restartBtn.TabIndex = 5;
			this.restartBtn.Text = "Заново";
			this.restartBtn.UseVisualStyleBackColor = true;
			this.restartBtn.Click += new System.EventHandler(this.restartBtn_Click);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(624, 471);
			this.Controls.Add(this.restartBtn);
			this.Controls.Add(this.panel2);
			this.Controls.Add(this.panel1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Name = "MainForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Cryptography";
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.panel2.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion
		private System.Windows.Forms.TextBox plainTextBox;
		private System.Windows.Forms.Label label1;
		private Panel panel1;
		private TextBox binaryPlainTextBox;
		private Label label2;
		private Panel panel2;
		private Button plainToBinaryBtn;
		private TextBox binaryKeyTbx;
		private Label binaryKeyLabel;
		private TextBox keyTbx;
		private Label keyLabel;
		private Button keyToBinaryBtn;
		private TextBox gammaTbx;
		private Label label5;
		private Button encryptBtn;
		private TextBox decryptedGammaTbx;
		private Label label6;
		private Button decryptBtn;
		private TextBox decryptedPlainTextTbx;
		private Label label7;
		private Button decryptedPlainTextToBinaryBtn;
		private Button restartBtn;
		private Button generateKeyBtn;
		private ComboBox comboBox;
		private Label label8;
		private Label label9;
		private Label genLabel;
		private Label label11;
		private Label keyConvertLabel;
		private Label label12;
		private Label label13;
	}
}

