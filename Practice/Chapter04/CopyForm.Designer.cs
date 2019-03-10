namespace Chapter04
{
	partial class CopyForm
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
			this.lbFileName = new System.Windows.Forms.Label();
			this.lbCopy = new System.Windows.Forms.Label();
			this.pbCopy = new System.Windows.Forms.ProgressBar();
			this.SuspendLayout();
			// 
			// lbFileName
			// 
			this.lbFileName.AutoSize = true;
			this.lbFileName.Location = new System.Drawing.Point(15, 30);
			this.lbFileName.Name = "lbFileName";
			this.lbFileName.Size = new System.Drawing.Size(62, 18);
			this.lbFileName.TabIndex = 0;
			this.lbFileName.Text = "파 일 :";
			// 
			// lbCopy
			// 
			this.lbCopy.AutoSize = true;
			this.lbCopy.Location = new System.Drawing.Point(15, 62);
			this.lbCopy.Name = "lbCopy";
			this.lbCopy.Size = new System.Drawing.Size(92, 18);
			this.lbCopy.TabIndex = 1;
			this.lbCopy.Text = "복사 : 0 %";
			// 
			// pbCopy
			// 
			this.pbCopy.Location = new System.Drawing.Point(125, 57);
			this.pbCopy.Name = "pbCopy";
			this.pbCopy.Size = new System.Drawing.Size(500, 30);
			this.pbCopy.Step = 1;
			this.pbCopy.TabIndex = 2;
			// 
			// CopyForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(650, 120);
			this.Controls.Add(this.pbCopy);
			this.Controls.Add(this.lbCopy);
			this.Controls.Add(this.lbFileName);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "CopyForm";
			this.ShowIcon = false;
			this.ShowInTaskbar = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "파일 복사";
			this.TopMost = true;
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.CopyForm_FormClosing);
			this.Load += new System.EventHandler(this.CopyForm_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label lbFileName;
		private System.Windows.Forms.Label lbCopy;
		private System.Windows.Forms.ProgressBar pbCopy;
	}
}