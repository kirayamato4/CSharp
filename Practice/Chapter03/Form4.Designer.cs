namespace Chapter03
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
			this.tbMsg = new System.Windows.Forms.TextBox();
			this.btnMsg = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// tbMsg
			// 
			this.tbMsg.Location = new System.Drawing.Point(87, 59);
			this.tbMsg.Name = "tbMsg";
			this.tbMsg.Size = new System.Drawing.Size(400, 28);
			this.tbMsg.TabIndex = 0;
			// 
			// btnMsg
			// 
			this.btnMsg.Location = new System.Drawing.Point(216, 141);
			this.btnMsg.Name = "btnMsg";
			this.btnMsg.Size = new System.Drawing.Size(150, 35);
			this.btnMsg.TabIndex = 1;
			this.btnMsg.Text = "보이기";
			this.btnMsg.UseVisualStyleBackColor = true;
			this.btnMsg.Click += new System.EventHandler(this.btnMsg_Click);
			// 
			// Form4
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(578, 244);
			this.Controls.Add(this.btnMsg);
			this.Controls.Add(this.tbMsg);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.MaximizeBox = false;
			this.Name = "Form4";
			this.Text = "트레이 메세지";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox tbMsg;
		private System.Windows.Forms.Button btnMsg;
	}
}