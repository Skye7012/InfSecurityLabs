
namespace Labs.RsaBreakingLab
{
	partial class RsaBreakingForm
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
			this.eTbx = new System.Windows.Forms.TextBox();
			this.eLbl = new System.Windows.Forms.Label();
			this.nTbx = new System.Windows.Forms.TextBox();
			this.nLbl = new System.Windows.Forms.Label();
			this.swTbx = new System.Windows.Forms.TextBox();
			this.SwLbl = new System.Windows.Forms.Label();
			this.argsGroupBox = new System.Windows.Forms.GroupBox();
			this.decryptedTbx = new System.Windows.Forms.TextBox();
			this.decrLbl = new System.Windows.Forms.Label();
			this.breakBtn = new System.Windows.Forms.Button();
			this.argsGroupBox.SuspendLayout();
			this.SuspendLayout();
			// 
			// eTbx
			// 
			this.eTbx.Dock = System.Windows.Forms.DockStyle.Top;
			this.eTbx.Location = new System.Drawing.Point(3, 96);
			this.eTbx.Name = "eTbx";
			this.eTbx.Size = new System.Drawing.Size(794, 29);
			this.eTbx.TabIndex = 18;
			// 
			// eLbl
			// 
			this.eLbl.Dock = System.Windows.Forms.DockStyle.Top;
			this.eLbl.Location = new System.Drawing.Point(3, 75);
			this.eLbl.Name = "eLbl";
			this.eLbl.Size = new System.Drawing.Size(794, 21);
			this.eLbl.TabIndex = 17;
			this.eLbl.Text = "e";
			// 
			// nTbx
			// 
			this.nTbx.Dock = System.Windows.Forms.DockStyle.Top;
			this.nTbx.Location = new System.Drawing.Point(3, 46);
			this.nTbx.Name = "nTbx";
			this.nTbx.Size = new System.Drawing.Size(794, 29);
			this.nTbx.TabIndex = 14;
			// 
			// nLbl
			// 
			this.nLbl.Dock = System.Windows.Forms.DockStyle.Top;
			this.nLbl.Location = new System.Drawing.Point(3, 25);
			this.nLbl.Name = "nLbl";
			this.nLbl.Size = new System.Drawing.Size(794, 21);
			this.nLbl.TabIndex = 13;
			this.nLbl.Text = "n";
			// 
			// swTbx
			// 
			this.swTbx.Dock = System.Windows.Forms.DockStyle.Top;
			this.swTbx.Location = new System.Drawing.Point(3, 146);
			this.swTbx.Name = "swTbx";
			this.swTbx.Size = new System.Drawing.Size(794, 29);
			this.swTbx.TabIndex = 8;
			// 
			// SwLbl
			// 
			this.SwLbl.Dock = System.Windows.Forms.DockStyle.Top;
			this.SwLbl.Location = new System.Drawing.Point(3, 125);
			this.SwLbl.Name = "SwLbl";
			this.SwLbl.Size = new System.Drawing.Size(794, 21);
			this.SwLbl.TabIndex = 7;
			this.SwLbl.Text = "sw";
			// 
			// argsGroupBox
			// 
			this.argsGroupBox.Controls.Add(this.decryptedTbx);
			this.argsGroupBox.Controls.Add(this.decrLbl);
			this.argsGroupBox.Controls.Add(this.breakBtn);
			this.argsGroupBox.Controls.Add(this.swTbx);
			this.argsGroupBox.Controls.Add(this.SwLbl);
			this.argsGroupBox.Controls.Add(this.eTbx);
			this.argsGroupBox.Controls.Add(this.eLbl);
			this.argsGroupBox.Controls.Add(this.nTbx);
			this.argsGroupBox.Controls.Add(this.nLbl);
			this.argsGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
			this.argsGroupBox.Location = new System.Drawing.Point(0, 0);
			this.argsGroupBox.Name = "argsGroupBox";
			this.argsGroupBox.Size = new System.Drawing.Size(800, 510);
			this.argsGroupBox.TabIndex = 14;
			this.argsGroupBox.TabStop = false;
			// 
			// decryptedTbx
			// 
			this.decryptedTbx.Dock = System.Windows.Forms.DockStyle.Top;
			this.decryptedTbx.Enabled = false;
			this.decryptedTbx.Location = new System.Drawing.Point(3, 226);
			this.decryptedTbx.Name = "decryptedTbx";
			this.decryptedTbx.ReadOnly = true;
			this.decryptedTbx.Size = new System.Drawing.Size(794, 29);
			this.decryptedTbx.TabIndex = 20;
			// 
			// decrLbl
			// 
			this.decrLbl.Dock = System.Windows.Forms.DockStyle.Top;
			this.decrLbl.Location = new System.Drawing.Point(3, 205);
			this.decrLbl.Name = "decrLbl";
			this.decrLbl.Size = new System.Drawing.Size(794, 21);
			this.decrLbl.TabIndex = 19;
			this.decrLbl.Text = "Decrypted Text";
			// 
			// breakBtn
			// 
			this.breakBtn.Dock = System.Windows.Forms.DockStyle.Top;
			this.breakBtn.Location = new System.Drawing.Point(3, 175);
			this.breakBtn.Margin = new System.Windows.Forms.Padding(0);
			this.breakBtn.Name = "breakBtn";
			this.breakBtn.Size = new System.Drawing.Size(794, 30);
			this.breakBtn.TabIndex = 21;
			this.breakBtn.Text = "Break";
			this.breakBtn.UseVisualStyleBackColor = true;
			this.breakBtn.Click += new System.EventHandler(this.breakBtn_Click);
			// 
			// RsaBreakingForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 510);
			this.Controls.Add(this.argsGroupBox);
			this.Name = "RsaBreakingForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "RsaBreakingForm";
			this.argsGroupBox.ResumeLayout(false);
			this.argsGroupBox.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.TextBox eTbx;
		private System.Windows.Forms.Label eLbl;
		private System.Windows.Forms.TextBox nTbx;
		private System.Windows.Forms.Label nLbl;
		private System.Windows.Forms.TextBox swTbx;
		private System.Windows.Forms.Label SwLbl;
		private System.Windows.Forms.GroupBox argsGroupBox;
		private System.Windows.Forms.TextBox decryptedTbx;
		private System.Windows.Forms.Label decrLbl;
		private System.Windows.Forms.Button breakBtn;
	}
}