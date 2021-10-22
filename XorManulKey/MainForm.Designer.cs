
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
			this.gammaTbx = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.binaryKeyTbx = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.keyTbx = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.binaryPlainTextBox = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.panel2 = new System.Windows.Forms.Panel();
			this.encryptBtn = new System.Windows.Forms.Button();
			this.keyToBinaryBtn = new System.Windows.Forms.Button();
			this.plainToBinaryBtn = new System.Windows.Forms.Button();
			this.decryptedGammaTbx = new System.Windows.Forms.TextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.decryptBtn = new System.Windows.Forms.Button();
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
			this.panel1.Controls.Add(this.decryptedGammaTbx);
			this.panel1.Controls.Add(this.label6);
			this.panel1.Controls.Add(this.gammaTbx);
			this.panel1.Controls.Add(this.label5);
			this.panel1.Controls.Add(this.binaryKeyTbx);
			this.panel1.Controls.Add(this.label3);
			this.panel1.Controls.Add(this.keyTbx);
			this.panel1.Controls.Add(this.label4);
			this.panel1.Controls.Add(this.binaryPlainTextBox);
			this.panel1.Controls.Add(this.label2);
			this.panel1.Controls.Add(this.plainTextBox);
			this.panel1.Controls.Add(this.label1);
			this.panel1.Location = new System.Drawing.Point(12, 12);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(400, 393);
			this.panel1.TabIndex = 17;
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
			// label3
			// 
			this.label3.Dock = System.Windows.Forms.DockStyle.Top;
			this.label3.Location = new System.Drawing.Point(0, 150);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(400, 21);
			this.label3.TabIndex = 16;
			this.label3.Text = "Бинарное представление ключа";
			this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
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
			// label4
			// 
			this.label4.Dock = System.Windows.Forms.DockStyle.Top;
			this.label4.Location = new System.Drawing.Point(0, 100);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(400, 21);
			this.label4.TabIndex = 14;
			this.label4.Text = "Ключ";
			this.label4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
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
			this.panel2.Controls.Add(this.decryptBtn);
			this.panel2.Controls.Add(this.encryptBtn);
			this.panel2.Controls.Add(this.keyToBinaryBtn);
			this.panel2.Controls.Add(this.plainToBinaryBtn);
			this.panel2.Location = new System.Drawing.Point(418, 12);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(194, 393);
			this.panel2.TabIndex = 18;
			// 
			// encryptBtn
			// 
			this.encryptBtn.Location = new System.Drawing.Point(0, 221);
			this.encryptBtn.Name = "encryptBtn";
			this.encryptBtn.Size = new System.Drawing.Size(194, 30);
			this.encryptBtn.TabIndex = 2;
			this.encryptBtn.Text = "Зашифровать";
			this.encryptBtn.UseVisualStyleBackColor = true;
			this.encryptBtn.Click += new System.EventHandler(this.encryptBtn_Click);
			// 
			// keyToBinaryBtn
			// 
			this.keyToBinaryBtn.Location = new System.Drawing.Point(0, 171);
			this.keyToBinaryBtn.Name = "keyToBinaryBtn";
			this.keyToBinaryBtn.Size = new System.Drawing.Size(194, 30);
			this.keyToBinaryBtn.TabIndex = 1;
			this.keyToBinaryBtn.Text = "Перевести";
			this.keyToBinaryBtn.UseVisualStyleBackColor = true;
			this.keyToBinaryBtn.Click += new System.EventHandler(this.keyToBinaryBtn_Click);
			// 
			// plainToBinaryBtn
			// 
			this.plainToBinaryBtn.Location = new System.Drawing.Point(0, 71);
			this.plainToBinaryBtn.Name = "plainToBinaryBtn";
			this.plainToBinaryBtn.Size = new System.Drawing.Size(194, 30);
			this.plainToBinaryBtn.TabIndex = 0;
			this.plainToBinaryBtn.Text = "Перевести";
			this.plainToBinaryBtn.UseVisualStyleBackColor = true;
			this.plainToBinaryBtn.Click += new System.EventHandler(this.plainToBinaryBtn_Click);
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
			// decryptBtn
			// 
			this.decryptBtn.Location = new System.Drawing.Point(0, 271);
			this.decryptBtn.Name = "decryptBtn";
			this.decryptBtn.Size = new System.Drawing.Size(194, 30);
			this.decryptBtn.TabIndex = 3;
			this.decryptBtn.Text = "Расшифровать";
			this.decryptBtn.UseVisualStyleBackColor = true;
			this.decryptBtn.Click += new System.EventHandler(this.decryptBtn_Click);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(624, 560);
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
		private Label label3;
		private TextBox keyTbx;
		private Label label4;
		private Button keyToBinaryBtn;
		private TextBox gammaTbx;
		private Label label5;
		private Button encryptBtn;
		private TextBox decryptedGammaTbx;
		private Label label6;
		private Button decryptBtn;
	}
}

