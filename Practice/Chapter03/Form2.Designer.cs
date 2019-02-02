namespace Chapter03
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
			this.btnModaless = new System.Windows.Forms.Button();
			this.btnModal = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// btnModaless
			// 
			this.btnModaless.Location = new System.Drawing.Point(391, 111);
			this.btnModaless.Name = "btnModaless";
			this.btnModaless.Size = new System.Drawing.Size(150, 40);
			this.btnModaless.TabIndex = 0;
			this.btnModaless.Text = "모달리스";
			this.btnModaless.UseVisualStyleBackColor = true;
			this.btnModaless.Click += new System.EventHandler(this.btnModaless_Click);
			// 
			// btnModal
			// 
			this.btnModal.Location = new System.Drawing.Point(135, 111);
			this.btnModal.Name = "btnModal";
			this.btnModal.Size = new System.Drawing.Size(150, 40);
			this.btnModal.TabIndex = 1;
			this.btnModal.Text = "모달";
			this.btnModal.UseVisualStyleBackColor = true;
			this.btnModal.Click += new System.EventHandler(this.btnModal_Click);
			// 
			// Form2
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(706, 244);
			this.Controls.Add(this.btnModal);
			this.Controls.Add(this.btnModaless);
			this.Name = "Form2";
			this.Text = "Form2";
			this.Load += new System.EventHandler(this.Form2_Load);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button btnModaless;
		private System.Windows.Forms.Button btnModal;
	}
}