
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
			this.binaryPlainTextBox = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.panel2 = new System.Windows.Forms.Panel();
			this.plainToBinaryBtn = new System.Windows.Forms.Button();
			this.binaryKeyTbx = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.keyTbx = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.keyToBinaryBtn = new System.Windows.Forms.Button();
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
			// binaryPlainTextBox
			// 
			this.binaryPlainTextBox.Dock = System.Windows.Forms.DockStyle.Top;
			this.binaryPlainTextBox.Location = new System.Drawing.Point(0, 71);
			this.binaryPlainTextBox.Name = "binaryPlainTextBox";
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
			this.panel2.Controls.Add(this.keyToBinaryBtn);
			this.panel2.Controls.Add(this.plainToBinaryBtn);
			this.panel2.Location = new System.Drawing.Point(418, 12);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(194, 393);
			this.panel2.TabIndex = 18;
			// 
			// plainToBinaryBtn
			// 
			this.plainToBinaryBtn.Location = new System.Drawing.Point(0, 70);
			this.plainToBinaryBtn.Name = "plainToBinaryBtn";
			this.plainToBinaryBtn.Size = new System.Drawing.Size(194, 29);
			this.plainToBinaryBtn.TabIndex = 0;
			this.plainToBinaryBtn.Text = "Перевести";
			this.plainToBinaryBtn.UseVisualStyleBackColor = true;
			this.plainToBinaryBtn.Click += new System.EventHandler(this.plainToBinaryBtn_Click);
			// 
			// binaryKeyTbx
			// 
			this.binaryKeyTbx.Dock = System.Windows.Forms.DockStyle.Top;
			this.binaryKeyTbx.Location = new System.Drawing.Point(0, 171);
			this.binaryKeyTbx.Name = "binaryKeyTbx";
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
			this.label3.Text = "Бинарное ключа";
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
			// keyToBinaryBtn
			// 
			this.keyToBinaryBtn.Location = new System.Drawing.Point(0, 171);
			this.keyToBinaryBtn.Name = "keyToBinaryBtn";
			this.keyToBinaryBtn.Size = new System.Drawing.Size(194, 29);
			this.keyToBinaryBtn.TabIndex = 1;
			this.keyToBinaryBtn.Text = "Перевести";
			this.keyToBinaryBtn.UseVisualStyleBackColor = true;
			this.keyToBinaryBtn.Click += new System.EventHandler(this.keyToBinaryBtn_Click);
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
	}
}

