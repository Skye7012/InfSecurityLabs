
namespace Labs.GcdLab
{
	partial class GcdForm
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
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.mainComboBox = new System.Windows.Forms.ToolStripComboBox();
			this.label1 = new System.Windows.Forms.Label();
			this.varGroupBox = new System.Windows.Forms.GroupBox();
			this.calculateBtn = new System.Windows.Forms.Button();
			this.bTbx = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.aTbx = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.gcdTbx = new System.Windows.Forms.TextBox();
			this.zLbl = new System.Windows.Forms.Label();
			this.xTbx = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.yTbx = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.menuStrip1.SuspendLayout();
			this.varGroupBox.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.SuspendLayout();
			// 
			// menuStrip1
			// 
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mainComboBox});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(800, 33);
			this.menuStrip1.TabIndex = 1;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// mainComboBox
			// 
			this.mainComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.mainComboBox.Name = "mainComboBox";
			this.mainComboBox.Size = new System.Drawing.Size(121, 29);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(301, 60);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(155, 21);
			this.label1.TabIndex = 2;
			this.label1.Text = "A*x + B*y = Gcd(A,B)";
			// 
			// varGroupBox
			// 
			this.varGroupBox.Controls.Add(this.calculateBtn);
			this.varGroupBox.Controls.Add(this.bTbx);
			this.varGroupBox.Controls.Add(this.label3);
			this.varGroupBox.Controls.Add(this.aTbx);
			this.varGroupBox.Controls.Add(this.label2);
			this.varGroupBox.Location = new System.Drawing.Point(12, 102);
			this.varGroupBox.Name = "varGroupBox";
			this.varGroupBox.Size = new System.Drawing.Size(776, 161);
			this.varGroupBox.TabIndex = 3;
			this.varGroupBox.TabStop = false;
			// 
			// calculateBtn
			// 
			this.calculateBtn.Dock = System.Windows.Forms.DockStyle.Top;
			this.calculateBtn.Enabled = false;
			this.calculateBtn.Location = new System.Drawing.Point(3, 125);
			this.calculateBtn.Margin = new System.Windows.Forms.Padding(0);
			this.calculateBtn.Name = "calculateBtn";
			this.calculateBtn.Size = new System.Drawing.Size(770, 30);
			this.calculateBtn.TabIndex = 6;
			this.calculateBtn.Text = "Calculate";
			this.calculateBtn.UseVisualStyleBackColor = true;
			this.calculateBtn.Click += new System.EventHandler(this.calculateBtn_Click);
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
			this.label3.Text = "B";
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
			this.label2.Text = "A";
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.yTbx);
			this.groupBox2.Controls.Add(this.label5);
			this.groupBox2.Controls.Add(this.xTbx);
			this.groupBox2.Controls.Add(this.label4);
			this.groupBox2.Controls.Add(this.gcdTbx);
			this.groupBox2.Controls.Add(this.zLbl);
			this.groupBox2.Location = new System.Drawing.Point(15, 260);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(770, 178);
			this.groupBox2.TabIndex = 4;
			this.groupBox2.TabStop = false;
			// 
			// gcdTbx
			// 
			this.gcdTbx.Dock = System.Windows.Forms.DockStyle.Top;
			this.gcdTbx.Location = new System.Drawing.Point(3, 46);
			this.gcdTbx.Name = "gcdTbx";
			this.gcdTbx.ReadOnly = true;
			this.gcdTbx.Size = new System.Drawing.Size(764, 29);
			this.gcdTbx.TabIndex = 10;
			// 
			// zLbl
			// 
			this.zLbl.Dock = System.Windows.Forms.DockStyle.Top;
			this.zLbl.Location = new System.Drawing.Point(3, 25);
			this.zLbl.Name = "zLbl";
			this.zLbl.Size = new System.Drawing.Size(764, 21);
			this.zLbl.TabIndex = 9;
			this.zLbl.Text = "Gcd(A,B)";
			// 
			// xTbx
			// 
			this.xTbx.Dock = System.Windows.Forms.DockStyle.Top;
			this.xTbx.Location = new System.Drawing.Point(3, 96);
			this.xTbx.Name = "xTbx";
			this.xTbx.ReadOnly = true;
			this.xTbx.Size = new System.Drawing.Size(764, 29);
			this.xTbx.TabIndex = 12;
			// 
			// label4
			// 
			this.label4.Dock = System.Windows.Forms.DockStyle.Top;
			this.label4.Location = new System.Drawing.Point(3, 75);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(764, 21);
			this.label4.TabIndex = 11;
			this.label4.Text = "x";
			// 
			// yTbx
			// 
			this.yTbx.Dock = System.Windows.Forms.DockStyle.Top;
			this.yTbx.Location = new System.Drawing.Point(3, 146);
			this.yTbx.Name = "yTbx";
			this.yTbx.ReadOnly = true;
			this.yTbx.Size = new System.Drawing.Size(764, 29);
			this.yTbx.TabIndex = 14;
			// 
			// label5
			// 
			this.label5.Dock = System.Windows.Forms.DockStyle.Top;
			this.label5.Location = new System.Drawing.Point(3, 125);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(764, 21);
			this.label5.TabIndex = 13;
			this.label5.Text = "y";
			// 
			// GcdForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.varGroupBox);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.menuStrip1);
			this.Name = "GcdForm";
			this.Text = "GcdForm";
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.varGroupBox.ResumeLayout(false);
			this.varGroupBox.PerformLayout();
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ToolStripComboBox mainComboBox;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.GroupBox varGroupBox;
		private System.Windows.Forms.TextBox aTbx;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox bTbx;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Button calculateBtn;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.TextBox gcdTbx;
		private System.Windows.Forms.Label zLbl;
		private System.Windows.Forms.TextBox yTbx;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox xTbx;
		private System.Windows.Forms.Label label4;
	}
}