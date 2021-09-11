
namespace CaesarCipher
{
	partial class MainForm
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
			this.stepsTextBox = new System.Windows.Forms.TextBox();
			this.originalTextBox = new System.Windows.Forms.RichTextBox();
			this.alphabetComboBox = new System.Windows.Forms.ComboBox();
			this.cryptogramTextBox = new System.Windows.Forms.RichTextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// decryptButton
			// 
			this.decryptButton.Enabled = false;
			this.decryptButton.Location = new System.Drawing.Point(770, 440);
			this.decryptButton.Name = "decryptButton";
			this.decryptButton.Size = new System.Drawing.Size(150, 30);
			this.decryptButton.TabIndex = 7;
			this.decryptButton.Text = "Decrypt";
			this.decryptButton.UseVisualStyleBackColor = true;
			this.decryptButton.Click += new System.EventHandler(this.decryptButton_Click);
			// 
			// encryptButton
			// 
			this.encryptButton.Enabled = false;
			this.encryptButton.Location = new System.Drawing.Point(770, 120);
			this.encryptButton.Name = "encryptButton";
			this.encryptButton.Size = new System.Drawing.Size(150, 30);
			this.encryptButton.TabIndex = 6;
			this.encryptButton.Text = "Encrypt";
			this.encryptButton.UseVisualStyleBackColor = true;
			this.encryptButton.Click += new System.EventHandler(this.encryptButton_Click);
			// 
			// stepsTextBox
			// 
			this.stepsTextBox.Location = new System.Drawing.Point(770, 252);
			this.stepsTextBox.Name = "stepsTextBox";
			this.stepsTextBox.Size = new System.Drawing.Size(150, 29);
			this.stepsTextBox.TabIndex = 5;
			this.stepsTextBox.Text = "0";
			// 
			// originalTextBox
			// 
			this.originalTextBox.Location = new System.Drawing.Point(20, 40);
			this.originalTextBox.Name = "originalTextBox";
			this.originalTextBox.Size = new System.Drawing.Size(700, 200);
			this.originalTextBox.TabIndex = 4;
			this.originalTextBox.Tag = "Original Text";
			this.originalTextBox.Text = "";
			this.originalTextBox.TextChanged += new System.EventHandler(this.originalTextBox_TextChanged);
			// 
			// alphabetComboBox
			// 
			this.alphabetComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.alphabetComboBox.FormattingEnabled = true;
			this.alphabetComboBox.Location = new System.Drawing.Point(770, 308);
			this.alphabetComboBox.Name = "alphabetComboBox";
			this.alphabetComboBox.Size = new System.Drawing.Size(150, 29);
			this.alphabetComboBox.TabIndex = 8;
			this.alphabetComboBox.SelectedIndexChanged += new System.EventHandler(this.alphabetComboBox_SelectedIndexChanged);
			// 
			// cryptogramTextBox
			// 
			this.cryptogramTextBox.Location = new System.Drawing.Point(20, 340);
			this.cryptogramTextBox.Name = "cryptogramTextBox";
			this.cryptogramTextBox.Size = new System.Drawing.Size(700, 200);
			this.cryptogramTextBox.TabIndex = 9;
			this.cryptogramTextBox.Tag = "Cryptogram";
			this.cryptogramTextBox.Text = "";
			this.cryptogramTextBox.TextChanged += new System.EventHandler(this.cryptogramTextBox_TextChanged);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(20, 16);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(96, 21);
			this.label1.TabIndex = 10;
			this.label1.Text = "Original Text";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(20, 316);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(94, 21);
			this.label2.TabIndex = 11;
			this.label2.Text = "Cryptogram";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(770, 284);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(79, 21);
			this.label3.TabIndex = 12;
			this.label3.Text = "Alphabets";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(770, 228);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(35, 21);
			this.label4.TabIndex = 13;
			this.label4.Text = "Key";
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(984, 560);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.cryptogramTextBox);
			this.Controls.Add(this.alphabetComboBox);
			this.Controls.Add(this.decryptButton);
			this.Controls.Add(this.encryptButton);
			this.Controls.Add(this.stepsTextBox);
			this.Controls.Add(this.originalTextBox);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Name = "MainForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Caesar Cipher";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button decryptButton;
		private System.Windows.Forms.Button encryptButton;
		private System.Windows.Forms.TextBox stepsTextBox;
		private System.Windows.Forms.RichTextBox originalTextBox;
		private System.Windows.Forms.ComboBox alphabetComboBox;
		private System.Windows.Forms.RichTextBox cryptogramTextBox;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
	}
}

