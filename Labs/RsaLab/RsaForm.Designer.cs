namespace Labs.RsaLab
{
	partial class RsaForm
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
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
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.leftGroupBox = new System.Windows.Forms.GroupBox();
			this.argsGroupBox = new System.Windows.Forms.GroupBox();
			this.dTbx = new System.Windows.Forms.TextBox();
			this.label8 = new System.Windows.Forms.Label();
			this.eTbx = new System.Windows.Forms.TextBox();
			this.label7 = new System.Windows.Forms.Label();
			this.phiTbx = new System.Windows.Forms.TextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.nTbx = new System.Windows.Forms.TextBox();
			this.nLbl = new System.Windows.Forms.Label();
			this.qTbx = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.pTbx = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.generateBtn = new System.Windows.Forms.Button();
			this.sizeTbx = new System.Windows.Forms.TextBox();
			this.sizeLbl = new System.Windows.Forms.Label();
			this.cryptGroupBox = new System.Windows.Forms.GroupBox();
			this.decryptedTbx = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.decryptBtn = new System.Windows.Forms.Button();
			this.cryptTbx = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.encryptBtn = new System.Windows.Forms.Button();
			this.plainTbx = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.leftGroupBox.SuspendLayout();
			this.argsGroupBox.SuspendLayout();
			this.cryptGroupBox.SuspendLayout();
			this.SuspendLayout();
			// 
			// leftGroupBox
			// 
			this.leftGroupBox.Controls.Add(this.argsGroupBox);
			this.leftGroupBox.Controls.Add(this.generateBtn);
			this.leftGroupBox.Controls.Add(this.sizeTbx);
			this.leftGroupBox.Controls.Add(this.sizeLbl);
			this.leftGroupBox.Dock = System.Windows.Forms.DockStyle.Left;
			this.leftGroupBox.Location = new System.Drawing.Point(0, 0);
			this.leftGroupBox.Name = "leftGroupBox";
			this.leftGroupBox.Size = new System.Drawing.Size(385, 510);
			this.leftGroupBox.TabIndex = 4;
			this.leftGroupBox.TabStop = false;
			// 
			// argsGroupBox
			// 
			this.argsGroupBox.Controls.Add(this.dTbx);
			this.argsGroupBox.Controls.Add(this.label8);
			this.argsGroupBox.Controls.Add(this.eTbx);
			this.argsGroupBox.Controls.Add(this.label7);
			this.argsGroupBox.Controls.Add(this.phiTbx);
			this.argsGroupBox.Controls.Add(this.label6);
			this.argsGroupBox.Controls.Add(this.nTbx);
			this.argsGroupBox.Controls.Add(this.nLbl);
			this.argsGroupBox.Controls.Add(this.qTbx);
			this.argsGroupBox.Controls.Add(this.label3);
			this.argsGroupBox.Controls.Add(this.pTbx);
			this.argsGroupBox.Controls.Add(this.label2);
			this.argsGroupBox.Dock = System.Windows.Forms.DockStyle.Top;
			this.argsGroupBox.Enabled = false;
			this.argsGroupBox.Location = new System.Drawing.Point(3, 105);
			this.argsGroupBox.Name = "argsGroupBox";
			this.argsGroupBox.Size = new System.Drawing.Size(379, 405);
			this.argsGroupBox.TabIndex = 13;
			this.argsGroupBox.TabStop = false;
			// 
			// dTbx
			// 
			this.dTbx.Dock = System.Windows.Forms.DockStyle.Top;
			this.dTbx.Location = new System.Drawing.Point(3, 296);
			this.dTbx.Name = "dTbx";
			this.dTbx.ReadOnly = true;
			this.dTbx.Size = new System.Drawing.Size(373, 29);
			this.dTbx.TabIndex = 20;
			// 
			// label8
			// 
			this.label8.Dock = System.Windows.Forms.DockStyle.Top;
			this.label8.Location = new System.Drawing.Point(3, 275);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(373, 21);
			this.label8.TabIndex = 19;
			this.label8.Text = "d";
			// 
			// eTbx
			// 
			this.eTbx.Dock = System.Windows.Forms.DockStyle.Top;
			this.eTbx.Location = new System.Drawing.Point(3, 246);
			this.eTbx.Name = "eTbx";
			this.eTbx.ReadOnly = true;
			this.eTbx.Size = new System.Drawing.Size(373, 29);
			this.eTbx.TabIndex = 18;
			// 
			// label7
			// 
			this.label7.Dock = System.Windows.Forms.DockStyle.Top;
			this.label7.Location = new System.Drawing.Point(3, 225);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(373, 21);
			this.label7.TabIndex = 17;
			this.label7.Text = "e";
			// 
			// phiTbx
			// 
			this.phiTbx.Dock = System.Windows.Forms.DockStyle.Top;
			this.phiTbx.Location = new System.Drawing.Point(3, 196);
			this.phiTbx.Name = "phiTbx";
			this.phiTbx.ReadOnly = true;
			this.phiTbx.Size = new System.Drawing.Size(373, 29);
			this.phiTbx.TabIndex = 16;
			// 
			// label6
			// 
			this.label6.Dock = System.Windows.Forms.DockStyle.Top;
			this.label6.Location = new System.Drawing.Point(3, 175);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(373, 21);
			this.label6.TabIndex = 15;
			this.label6.Text = "φ(n)";
			// 
			// nTbx
			// 
			this.nTbx.Dock = System.Windows.Forms.DockStyle.Top;
			this.nTbx.Location = new System.Drawing.Point(3, 146);
			this.nTbx.Name = "nTbx";
			this.nTbx.ReadOnly = true;
			this.nTbx.Size = new System.Drawing.Size(373, 29);
			this.nTbx.TabIndex = 14;
			// 
			// nLbl
			// 
			this.nLbl.Dock = System.Windows.Forms.DockStyle.Top;
			this.nLbl.Location = new System.Drawing.Point(3, 125);
			this.nLbl.Name = "nLbl";
			this.nLbl.Size = new System.Drawing.Size(373, 21);
			this.nLbl.TabIndex = 13;
			this.nLbl.Text = "n";
			// 
			// qTbx
			// 
			this.qTbx.Dock = System.Windows.Forms.DockStyle.Top;
			this.qTbx.Location = new System.Drawing.Point(3, 96);
			this.qTbx.Name = "qTbx";
			this.qTbx.ReadOnly = true;
			this.qTbx.Size = new System.Drawing.Size(373, 29);
			this.qTbx.TabIndex = 10;
			// 
			// label3
			// 
			this.label3.Dock = System.Windows.Forms.DockStyle.Top;
			this.label3.Location = new System.Drawing.Point(3, 75);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(373, 21);
			this.label3.TabIndex = 9;
			this.label3.Text = "q";
			// 
			// pTbx
			// 
			this.pTbx.Dock = System.Windows.Forms.DockStyle.Top;
			this.pTbx.Location = new System.Drawing.Point(3, 46);
			this.pTbx.Name = "pTbx";
			this.pTbx.ReadOnly = true;
			this.pTbx.Size = new System.Drawing.Size(373, 29);
			this.pTbx.TabIndex = 8;
			// 
			// label2
			// 
			this.label2.Dock = System.Windows.Forms.DockStyle.Top;
			this.label2.Location = new System.Drawing.Point(3, 25);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(373, 21);
			this.label2.TabIndex = 7;
			this.label2.Text = "p";
			// 
			// generateBtn
			// 
			this.generateBtn.Dock = System.Windows.Forms.DockStyle.Top;
			this.generateBtn.Enabled = false;
			this.generateBtn.Location = new System.Drawing.Point(3, 75);
			this.generateBtn.Margin = new System.Windows.Forms.Padding(0);
			this.generateBtn.Name = "generateBtn";
			this.generateBtn.Size = new System.Drawing.Size(379, 30);
			this.generateBtn.TabIndex = 16;
			this.generateBtn.Text = "Generate Arguments";
			this.generateBtn.UseVisualStyleBackColor = true;
			this.generateBtn.Click += new System.EventHandler(this.generateBtn_Click);
			// 
			// sizeTbx
			// 
			this.sizeTbx.Dock = System.Windows.Forms.DockStyle.Top;
			this.sizeTbx.Location = new System.Drawing.Point(3, 46);
			this.sizeTbx.Name = "sizeTbx";
			this.sizeTbx.Size = new System.Drawing.Size(379, 29);
			this.sizeTbx.TabIndex = 15;
			this.sizeTbx.TextChanged += new System.EventHandler(this.sizeTbx_TextChanged);
			// 
			// sizeLbl
			// 
			this.sizeLbl.Dock = System.Windows.Forms.DockStyle.Top;
			this.sizeLbl.Location = new System.Drawing.Point(3, 25);
			this.sizeLbl.Name = "sizeLbl";
			this.sizeLbl.Size = new System.Drawing.Size(379, 21);
			this.sizeLbl.TabIndex = 14;
			this.sizeLbl.Text = "Bit Size";
			// 
			// cryptGroupBox
			// 
			this.cryptGroupBox.Controls.Add(this.decryptedTbx);
			this.cryptGroupBox.Controls.Add(this.label1);
			this.cryptGroupBox.Controls.Add(this.decryptBtn);
			this.cryptGroupBox.Controls.Add(this.cryptTbx);
			this.cryptGroupBox.Controls.Add(this.label4);
			this.cryptGroupBox.Controls.Add(this.encryptBtn);
			this.cryptGroupBox.Controls.Add(this.plainTbx);
			this.cryptGroupBox.Controls.Add(this.label5);
			this.cryptGroupBox.Dock = System.Windows.Forms.DockStyle.Right;
			this.cryptGroupBox.Enabled = false;
			this.cryptGroupBox.Location = new System.Drawing.Point(391, 0);
			this.cryptGroupBox.Name = "cryptGroupBox";
			this.cryptGroupBox.Size = new System.Drawing.Size(409, 510);
			this.cryptGroupBox.TabIndex = 7;
			this.cryptGroupBox.TabStop = false;
			// 
			// decryptedTbx
			// 
			this.decryptedTbx.Dock = System.Windows.Forms.DockStyle.Top;
			this.decryptedTbx.Enabled = false;
			this.decryptedTbx.Location = new System.Drawing.Point(3, 206);
			this.decryptedTbx.Name = "decryptedTbx";
			this.decryptedTbx.ReadOnly = true;
			this.decryptedTbx.Size = new System.Drawing.Size(403, 29);
			this.decryptedTbx.TabIndex = 5;
			// 
			// label1
			// 
			this.label1.Dock = System.Windows.Forms.DockStyle.Top;
			this.label1.Location = new System.Drawing.Point(3, 185);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(403, 21);
			this.label1.TabIndex = 4;
			this.label1.Text = "Decrypted Text";
			// 
			// decryptBtn
			// 
			this.decryptBtn.Dock = System.Windows.Forms.DockStyle.Top;
			this.decryptBtn.Enabled = false;
			this.decryptBtn.Location = new System.Drawing.Point(3, 155);
			this.decryptBtn.Margin = new System.Windows.Forms.Padding(0);
			this.decryptBtn.Name = "decryptBtn";
			this.decryptBtn.Size = new System.Drawing.Size(403, 30);
			this.decryptBtn.TabIndex = 7;
			this.decryptBtn.Text = "Decrypt";
			this.decryptBtn.UseVisualStyleBackColor = true;
			this.decryptBtn.Click += new System.EventHandler(this.decryptBtn_Click);
			// 
			// cryptTbx
			// 
			this.cryptTbx.Dock = System.Windows.Forms.DockStyle.Top;
			this.cryptTbx.Enabled = false;
			this.cryptTbx.Location = new System.Drawing.Point(3, 126);
			this.cryptTbx.Name = "cryptTbx";
			this.cryptTbx.Size = new System.Drawing.Size(403, 29);
			this.cryptTbx.TabIndex = 3;
			// 
			// label4
			// 
			this.label4.Dock = System.Windows.Forms.DockStyle.Top;
			this.label4.Location = new System.Drawing.Point(3, 105);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(403, 21);
			this.label4.TabIndex = 2;
			this.label4.Text = "Cryptogram";
			// 
			// encryptBtn
			// 
			this.encryptBtn.Dock = System.Windows.Forms.DockStyle.Top;
			this.encryptBtn.Enabled = false;
			this.encryptBtn.Location = new System.Drawing.Point(3, 75);
			this.encryptBtn.Margin = new System.Windows.Forms.Padding(0);
			this.encryptBtn.Name = "encryptBtn";
			this.encryptBtn.Size = new System.Drawing.Size(403, 30);
			this.encryptBtn.TabIndex = 6;
			this.encryptBtn.Text = "Encrypt";
			this.encryptBtn.UseVisualStyleBackColor = true;
			this.encryptBtn.Click += new System.EventHandler(this.encryptBtn_Click);
			// 
			// plainTbx
			// 
			this.plainTbx.Dock = System.Windows.Forms.DockStyle.Top;
			this.plainTbx.Location = new System.Drawing.Point(3, 46);
			this.plainTbx.Name = "plainTbx";
			this.plainTbx.Size = new System.Drawing.Size(403, 29);
			this.plainTbx.TabIndex = 1;
			this.plainTbx.TextChanged += new System.EventHandler(this.plainTbx_TextChanged);
			// 
			// label5
			// 
			this.label5.Dock = System.Windows.Forms.DockStyle.Top;
			this.label5.Location = new System.Drawing.Point(3, 25);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(403, 21);
			this.label5.TabIndex = 0;
			this.label5.Text = "Plain Text";
			// 
			// RsaForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 510);
			this.Controls.Add(this.cryptGroupBox);
			this.Controls.Add(this.leftGroupBox);
			this.Name = "RsaForm";
			this.Text = "RsaForm";
			this.leftGroupBox.ResumeLayout(false);
			this.leftGroupBox.PerformLayout();
			this.argsGroupBox.ResumeLayout(false);
			this.argsGroupBox.PerformLayout();
			this.cryptGroupBox.ResumeLayout(false);
			this.cryptGroupBox.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.GroupBox leftGroupBox;
		private System.Windows.Forms.GroupBox cryptGroupBox;
		private System.Windows.Forms.Button encryptBtn;
		private System.Windows.Forms.TextBox decryptedTbx;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox cryptTbx;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox plainTbx;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.GroupBox argsGroupBox;
		private System.Windows.Forms.TextBox dTbx;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.TextBox eTbx;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.TextBox phiTbx;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.TextBox nTbx;
		private System.Windows.Forms.Label nLbl;
		private System.Windows.Forms.Button decryptBtn;
		private System.Windows.Forms.TextBox sizeTbx;
		private System.Windows.Forms.Label sizeLbl;
		private System.Windows.Forms.Button generateBtn;
		private System.Windows.Forms.TextBox qTbx;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox pTbx;
		private System.Windows.Forms.Label label2;
	}
}