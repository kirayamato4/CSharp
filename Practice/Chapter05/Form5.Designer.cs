namespace Chapter05
{
	partial class Form5
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
			this.ssMenu = new System.Windows.Forms.StatusStrip();
			this.tsLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
			this.pbCapture = new System.Windows.Forms.PictureBox();
			this.ssMenu.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pbCapture)).BeginInit();
			this.SuspendLayout();
			// 
			// ssMenu
			// 
			this.ssMenu.ImageScalingSize = new System.Drawing.Size(24, 24);
			this.ssMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsLabel1});
			this.ssMenu.Location = new System.Drawing.Point(0, 564);
			this.ssMenu.Name = "ssMenu";
			this.ssMenu.Size = new System.Drawing.Size(778, 30);
			this.ssMenu.TabIndex = 0;
			this.ssMenu.Text = "statusStrip1";
			// 
			// tsLabel1
			// 
			this.tsLabel1.Name = "tsLabel1";
			this.tsLabel1.Size = new System.Drawing.Size(383, 25);
			this.tsLabel1.Text = "전체 화면캡처 : c, 화면지우기 : e, 캡처저장 : s";
			// 
			// pbCapture
			// 
			this.pbCapture.BackColor = System.Drawing.Color.Silver;
			this.pbCapture.Dock = System.Windows.Forms.DockStyle.Fill;
			this.pbCapture.Location = new System.Drawing.Point(0, 0);
			this.pbCapture.Name = "pbCapture";
			this.pbCapture.Size = new System.Drawing.Size(778, 564);
			this.pbCapture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pbCapture.TabIndex = 1;
			this.pbCapture.TabStop = false;
			// 
			// Form5
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(778, 594);
			this.Controls.Add(this.pbCapture);
			this.Controls.Add(this.ssMenu);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "Form5";
			this.Text = "화면 캡처";
			this.Load += new System.EventHandler(this.Form5_Load);
			this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Form5_KeyPress);
			this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form5_KeyUp);
			this.ssMenu.ResumeLayout(false);
			this.ssMenu.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pbCapture)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.StatusStrip ssMenu;
		private System.Windows.Forms.ToolStripStatusLabel tsLabel1;
		private System.Windows.Forms.PictureBox pbCapture;
	}
}