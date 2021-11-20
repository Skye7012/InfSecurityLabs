namespace Labs.MillerRabinLab
{
	partial class MillerRabinForm
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
			this.varGroupBox = new System.Windows.Forms.GroupBox();
			this.answerTbx = new System.Windows.Forms.TextBox();
			this.nLbl = new System.Windows.Forms.Label();
			this.isPrimeBtn = new System.Windows.Forms.Button();
			this.numberTbx = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.generateNumberBtn = new System.Windows.Forms.Button();
			this.bitNumberSizeTbx = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.varGroupBox.SuspendLayout();
			this.SuspendLayout();
			// 
			// varGroupBox
			// 
			this.varGroupBox.Controls.Add(this.answerTbx);
			this.varGroupBox.Controls.Add(this.nLbl);
			this.varGroupBox.Controls.Add(this.isPrimeBtn);
			this.varGroupBox.Controls.Add(this.numberTbx);
			this.varGroupBox.Controls.Add(this.label2);
			this.varGroupBox.Controls.Add(this.generateNumberBtn);
			this.varGroupBox.Controls.Add(this.bitNumberSizeTbx);
			this.varGroupBox.Controls.Add(this.label3);
			this.varGroupBox.Location = new System.Drawing.Point(12, 62);
			this.varGroupBox.Name = "varGroupBox";
			this.varGroupBox.Size = new System.Drawing.Size(760, 262);
			this.varGroupBox.TabIndex = 4;
			this.varGroupBox.TabStop = false;
			// 
			// answerTbx
			// 
			this.answerTbx.Dock = System.Windows.Forms.DockStyle.Top;
			this.answerTbx.Location = new System.Drawing.Point(3, 206);
			this.answerTbx.Name = "answerTbx";
			this.answerTbx.ReadOnly = true;
			this.answerTbx.Size = new System.Drawing.Size(754, 29);
			this.answerTbx.TabIndex = 5;
			// 
			// nLbl
			// 
			this.nLbl.Dock = System.Windows.Forms.DockStyle.Top;
			this.nLbl.Location = new System.Drawing.Point(3, 185);
			this.nLbl.Name = "nLbl";
			this.nLbl.Size = new System.Drawing.Size(754, 21);
			this.nLbl.TabIndex = 4;
			this.nLbl.Text = "Ответ";
			// 
			// isPrimeBtn
			// 
			this.isPrimeBtn.Dock = System.Windows.Forms.DockStyle.Top;
			this.isPrimeBtn.Enabled = false;
			this.isPrimeBtn.Location = new System.Drawing.Point(3, 155);
			this.isPrimeBtn.Margin = new System.Windows.Forms.Padding(0);
			this.isPrimeBtn.Name = "isPrimeBtn";
			this.isPrimeBtn.Size = new System.Drawing.Size(754, 30);
			this.isPrimeBtn.TabIndex = 7;
			this.isPrimeBtn.Text = "Проверить на простоту";
			this.isPrimeBtn.UseVisualStyleBackColor = true;
			this.isPrimeBtn.Click += new System.EventHandler(this.isPrimeBtn_Click);
			// 
			// numberTbx
			// 
			this.numberTbx.Dock = System.Windows.Forms.DockStyle.Top;
			this.numberTbx.Location = new System.Drawing.Point(3, 126);
			this.numberTbx.Name = "numberTbx";
			this.numberTbx.Size = new System.Drawing.Size(754, 29);
			this.numberTbx.TabIndex = 1;
			this.numberTbx.TextChanged += new System.EventHandler(this.numberTbx_TextChanged);
			// 
			// label2
			// 
			this.label2.Dock = System.Windows.Forms.DockStyle.Top;
			this.label2.Location = new System.Drawing.Point(3, 105);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(754, 21);
			this.label2.TabIndex = 0;
			this.label2.Text = "Число";
			// 
			// generateNumberBtn
			// 
			this.generateNumberBtn.Dock = System.Windows.Forms.DockStyle.Top;
			this.generateNumberBtn.Enabled = false;
			this.generateNumberBtn.Location = new System.Drawing.Point(3, 75);
			this.generateNumberBtn.Margin = new System.Windows.Forms.Padding(0);
			this.generateNumberBtn.Name = "generateNumberBtn";
			this.generateNumberBtn.Size = new System.Drawing.Size(754, 30);
			this.generateNumberBtn.TabIndex = 6;
			this.generateNumberBtn.Text = "Сгенерировать число";
			this.generateNumberBtn.UseVisualStyleBackColor = true;
			this.generateNumberBtn.Click += new System.EventHandler(this.generateNumberBtn_Click);
			// 
			// bitNumberSizeTbx
			// 
			this.bitNumberSizeTbx.Dock = System.Windows.Forms.DockStyle.Top;
			this.bitNumberSizeTbx.Location = new System.Drawing.Point(3, 46);
			this.bitNumberSizeTbx.Name = "bitNumberSizeTbx";
			this.bitNumberSizeTbx.Size = new System.Drawing.Size(754, 29);
			this.bitNumberSizeTbx.TabIndex = 3;
			this.bitNumberSizeTbx.TextChanged += new System.EventHandler(this.bitNumberSizeTbx_TextChanged);
			// 
			// label3
			// 
			this.label3.Dock = System.Windows.Forms.DockStyle.Top;
			this.label3.Location = new System.Drawing.Point(3, 25);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(754, 21);
			this.label3.TabIndex = 2;
			this.label3.Text = "Размер числа в битах";
			// 
			// MillerRabinForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(784, 460);
			this.Controls.Add(this.varGroupBox);
			this.Name = "MillerRabinForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "MillerRabinForm";
			this.varGroupBox.ResumeLayout(false);
			this.varGroupBox.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.GroupBox varGroupBox;
		private System.Windows.Forms.TextBox answerTbx;
		private System.Windows.Forms.Label nLbl;
		private System.Windows.Forms.TextBox bitNumberSizeTbx;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox numberTbx;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Button generateNumberBtn;
		private System.Windows.Forms.Button isPrimeBtn;
	}
}