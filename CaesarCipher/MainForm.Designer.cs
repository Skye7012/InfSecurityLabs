
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
			this.editingTextBox = new System.Windows.Forms.RichTextBox();
			this.SuspendLayout();
			// 
			// decryptButton
			// 
			this.decryptButton.Location = new System.Drawing.Point(750, 56);
			this.decryptButton.Name = "decryptButton";
			this.decryptButton.Size = new System.Drawing.Size(100, 30);
			this.decryptButton.TabIndex = 7;
			this.decryptButton.Text = "Decrypt";
			this.decryptButton.UseVisualStyleBackColor = true;
			// 
			// encryptButton
			// 
			this.encryptButton.Location = new System.Drawing.Point(150, 56);
			this.encryptButton.Name = "encryptButton";
			this.encryptButton.Size = new System.Drawing.Size(100, 30);
			this.encryptButton.TabIndex = 6;
			this.encryptButton.Text = "Encrypt";
			this.encryptButton.UseVisualStyleBackColor = true;
			this.encryptButton.Click += new System.EventHandler(this.encryptButton_Click);
			// 
			// stepsTextBox
			// 
			this.stepsTextBox.Location = new System.Drawing.Point(400, 56);
			this.stepsTextBox.Name = "stepsTextBox";
			this.stepsTextBox.Size = new System.Drawing.Size(150, 29);
			this.stepsTextBox.TabIndex = 5;
			this.stepsTextBox.TextChanged += new System.EventHandler(this.stepsTextBox_TextChanged);
			// 
			// editingTextBox
			// 
			this.editingTextBox.Location = new System.Drawing.Point(12, 155);
			this.editingTextBox.Name = "editingTextBox";
			this.editingTextBox.Size = new System.Drawing.Size(960, 449);
			this.editingTextBox.TabIndex = 4;
			this.editingTextBox.Text = "";
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(984, 660);
			this.Controls.Add(this.decryptButton);
			this.Controls.Add(this.encryptButton);
			this.Controls.Add(this.stepsTextBox);
			this.Controls.Add(this.editingTextBox);
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
		private System.Windows.Forms.RichTextBox editingTextBox;
	}
}

