namespace Chapter05
{
	partial class Form2
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose( bool disposing )
		{
			if( disposing && ( components != null ) )
			{
				components.Dispose();
			}
			base.Dispose( disposing );
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.panalBar = new System.Windows.Forms.Panel();
			this.SuspendLayout();
			// 
			// panalBar
			// 
			this.panalBar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panalBar.Location = new System.Drawing.Point(20, 20);
			this.panalBar.Name = "panalBar";
			this.panalBar.Size = new System.Drawing.Size(700, 100);
			this.panalBar.TabIndex = 0;
			this.panalBar.Paint += new System.Windows.Forms.PaintEventHandler(this.panalBar_Paint);
			// 
			// Form2
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(738, 144);
			this.Controls.Add(this.panalBar);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.MaximizeBox = false;
			this.Name = "Form2";
			this.Text = "시스템 성능 보기";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form2_FormClosing);
			this.Load += new System.EventHandler(this.Form2_Load);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel panalBar;
	}
}