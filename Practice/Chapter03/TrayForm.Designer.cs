namespace Chapter03
{
	partial class TrayForm
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
			this.plBack = new System.Windows.Forms.Panel();
			this.llResult = new System.Windows.Forms.LinkLabel();
			this.plBack.SuspendLayout();
			this.SuspendLayout();
			// 
			// plBack
			// 
			this.plBack.BackColor = System.Drawing.SystemColors.MenuHighlight;
			this.plBack.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.plBack.Controls.Add(this.llResult);
			this.plBack.Dock = System.Windows.Forms.DockStyle.Fill;
			this.plBack.Location = new System.Drawing.Point(0, 0);
			this.plBack.Name = "plBack";
			this.plBack.Size = new System.Drawing.Size(170, 120);
			this.plBack.TabIndex = 0;
			// 
			// llResult
			// 
			this.llResult.AutoSize = true;
			this.llResult.Location = new System.Drawing.Point(0, 0);
			this.llResult.Name = "llResult";
			this.llResult.Size = new System.Drawing.Size(44, 18);
			this.llResult.TabIndex = 0;
			this.llResult.TabStop = true;
			this.llResult.Text = "결과";
			this.llResult.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.llResult.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llResult_LinkClicked);
			// 
			// TrayForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(170, 120);
			this.Controls.Add(this.plBack);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "TrayForm";
			this.ShowIcon = false;
			this.ShowInTaskbar = false;
			this.Text = "메세지 창";
			this.TopMost = true;
			this.Load += new System.EventHandler(this.TrayForm_Load);
			this.plBack.ResumeLayout(false);
			this.plBack.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel plBack;
		private System.Windows.Forms.LinkLabel llResult;
	}
}