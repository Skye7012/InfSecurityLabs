
namespace Labs.PowLab
{
	partial class PowForm
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
			this.label1 = new System.Windows.Forms.Label();
			this.varGroupBox = new System.Windows.Forms.GroupBox();
			this.calculateBtn = new System.Windows.Forms.Button();
			this.nTbx = new System.Windows.Forms.TextBox();
			this.nLbl = new System.Windows.Forms.Label();
			this.bTbx = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.aTbx = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.zTbx = new System.Windows.Forms.TextBox();
			this.zLbl = new System.Windows.Forms.Label();
			this.varGroupBox.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(303, 75);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(113, 21);
			this.label1.TabIndex = 2;
			this.label1.Text = "a^b mod n = z";
			// 
			// varGroupBox
			// 
			this.varGroupBox.Controls.Add(this.calculateBtn);
			this.varGroupBox.Controls.Add(this.nTbx);
			this.varGroupBox.Controls.Add(this.nLbl);
			this.varGroupBox.Controls.Add(this.bTbx);
			this.varGroupBox.Controls.Add(this.label3);
			this.varGroupBox.Controls.Add(this.aTbx);
			this.varGroupBox.Controls.Add(this.label2);
			this.varGroupBox.Location = new System.Drawing.Point(12, 113);
			this.varGroupBox.Name = "varGroupBox";
			this.varGroupBox.Size = new System.Drawing.Size(776, 211);
			this.varGroupBox.TabIndex = 3;
			this.varGroupBox.TabStop = false;
			// 
			// calculateBtn
			// 
			this.calculateBtn.Dock = System.Windows.Forms.DockStyle.Top;
			this.calculateBtn.Enabled = false;
			this.calculateBtn.Location = new System.Drawing.Point(3, 175);
			this.calculateBtn.Margin = new System.Windows.Forms.Padding(0);
			this.calculateBtn.Name = "calculateBtn";
			this.calculateBtn.Size = new System.Drawing.Size(770, 30);
			this.calculateBtn.TabIndex = 6;
			this.calculateBtn.Text = "Calculate";
			this.calculateBtn.UseVisualStyleBackColor = true;
			this.calculateBtn.Click += new System.EventHandler(this.calculateBtn_Click);
			// 
			// nTbx
			// 
			this.nTbx.Dock = System.Windows.Forms.DockStyle.Top;
			this.nTbx.Location = new System.Drawing.Point(3, 146);
			this.nTbx.Name = "nTbx";
			this.nTbx.Size = new System.Drawing.Size(770, 29);
			this.nTbx.TabIndex = 5;
			// 
			// nLbl
			// 
			this.nLbl.Dock = System.Windows.Forms.DockStyle.Top;
			this.nLbl.Location = new System.Drawing.Point(3, 125);
			this.nLbl.Name = "nLbl";
			this.nLbl.Size = new System.Drawing.Size(770, 21);
			this.nLbl.TabIndex = 4;
			this.nLbl.Text = "n";
			// 
			// bTbx
			// 
			this.bTbx.Dock = System.Windows.Forms.DockStyle.Top;
			this.bTbx.Location = new System.Drawing.Point(3, 96);
			this.bTbx.Name = "bTbx";
			this.bTbx.Size = new System.Drawing.Size(770, 29);
			this.bTbx.TabIndex = 3;
			// 
			// label3
			// 
			this.label3.Dock = System.Windows.Forms.DockStyle.Top;
			this.label3.Location = new System.Drawing.Point(3, 75);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(770, 21);
			this.label3.TabIndex = 2;
			this.label3.Text = "b";
			// 
			// aTbx
			// 
			this.aTbx.Dock = System.Windows.Forms.DockStyle.Top;
			this.aTbx.Location = new System.Drawing.Point(3, 46);
			this.aTbx.Name = "aTbx";
			this.aTbx.Size = new System.Drawing.Size(770, 29);
			this.aTbx.TabIndex = 1;
			// 
			// label2
			// 
			this.label2.Dock = System.Windows.Forms.DockStyle.Top;
			this.label2.Location = new System.Drawing.Point(3, 25);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(770, 21);
			this.label2.TabIndex = 0;
			this.label2.Text = "a";
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.zTbx);
			this.groupBox2.Controls.Add(this.zLbl);
			this.groupBox2.Location = new System.Drawing.Point(15, 324);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(770, 114);
			this.groupBox2.TabIndex = 4;
			this.groupBox2.TabStop = false;
			// 
			// zTbx
			// 
			this.zTbx.Dock = System.Windows.Forms.DockStyle.Top;
			this.zTbx.Location = new System.Drawing.Point(3, 46);
			this.zTbx.Name = "zTbx";
			this.zTbx.ReadOnly = true;
			this.zTbx.Size = new System.Drawing.Size(764, 29);
			this.zTbx.TabIndex = 10;
			// 
			// zLbl
			// 
			this.zLbl.Dock = System.Windows.Forms.DockStyle.Top;
			this.zLbl.Location = new System.Drawing.Point(3, 25);
			this.zLbl.Name = "zLbl";
			this.zLbl.Size = new System.Drawing.Size(764, 21);
			this.zLbl.TabIndex = 9;
			this.zLbl.Text = "z";
			// 
			// PowForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.varGroupBox);
			this.Controls.Add(this.label1);
			this.Name = "PowForm";
			this.Text = "PowForm";
			this.varGroupBox.ResumeLayout(false);
			this.varGroupBox.PerformLayout();
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.GroupBox varGroupBox;
		private System.Windows.Forms.TextBox aTbx;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox bTbx;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Button calculateBtn;
		private System.Windows.Forms.TextBox nTbx;
		private System.Windows.Forms.Label nLbl;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.TextBox zTbx;
		private System.Windows.Forms.Label zLbl;
	}
}