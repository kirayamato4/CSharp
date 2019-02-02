namespace Chapter02
{
	partial class Form4
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
			this.components = new System.ComponentModel.Container();
			this.txtNum = new System.Windows.Forms.TextBox();
			this.txtCountDown = new System.Windows.Forms.TextBox();
			this.timer1 = new System.Windows.Forms.Timer(this.components);
			this.btnStart = new System.Windows.Forms.Button();
			this.timer2 = new System.Windows.Forms.Timer(this.components);
			this.SuspendLayout();
			// 
			// txtNum
			// 
			this.txtNum.Location = new System.Drawing.Point(38, 42);
			this.txtNum.Name = "txtNum";
			this.txtNum.Size = new System.Drawing.Size(150, 28);
			this.txtNum.TabIndex = 0;
			// 
			// txtCountDown
			// 
			this.txtCountDown.Location = new System.Drawing.Point(38, 113);
			this.txtCountDown.Name = "txtCountDown";
			this.txtCountDown.ReadOnly = true;
			this.txtCountDown.Size = new System.Drawing.Size(150, 28);
			this.txtCountDown.TabIndex = 1;
			// 
			// timer1
			// 
			this.timer1.Interval = 1000;
			this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
			// 
			// btnStart
			// 
			this.btnStart.Location = new System.Drawing.Point(222, 40);
			this.btnStart.Name = "btnStart";
			this.btnStart.Size = new System.Drawing.Size(130, 30);
			this.btnStart.TabIndex = 2;
			this.btnStart.Text = "카운트다운";
			this.btnStart.UseVisualStyleBackColor = true;
			this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
			// 
			// Form4
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(428, 213);
			this.Controls.Add(this.btnStart);
			this.Controls.Add(this.txtCountDown);
			this.Controls.Add(this.txtNum);
			this.Name = "Form4";
			this.Text = "Form4";
			this.Load += new System.EventHandler(this.Form4_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox txtNum;
		private System.Windows.Forms.TextBox txtCountDown;
		private System.Windows.Forms.Timer timer1;
		private System.Windows.Forms.Button btnStart;
		private System.Windows.Forms.Timer timer2;
	}
}