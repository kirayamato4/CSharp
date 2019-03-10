namespace Chapter04
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
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.lbPercent = new System.Windows.Forms.Label();
			this.btnPath = new System.Windows.Forms.Button();
			this.btnDelete = new System.Windows.Forms.Button();
			this.tbPath = new System.Windows.Forms.TextBox();
			this.cbDelete = new System.Windows.Forms.ComboBox();
			this.ofDialog = new System.Windows.Forms.OpenFileDialog();
			this.progressBar = new System.Windows.Forms.ProgressBar();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(20, 20);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(56, 18);
			this.label1.TabIndex = 0;
			this.label1.Text = "파일 :";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(20, 61);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(56, 18);
			this.label2.TabIndex = 1;
			this.label2.Text = "선택 :";
			// 
			// lbPercent
			// 
			this.lbPercent.AutoSize = true;
			this.lbPercent.Location = new System.Drawing.Point(20, 124);
			this.lbPercent.Name = "lbPercent";
			this.lbPercent.Size = new System.Drawing.Size(38, 18);
			this.lbPercent.TabIndex = 2;
			this.lbPercent.Text = "0 %";
			// 
			// btnPath
			// 
			this.btnPath.Location = new System.Drawing.Point(423, 12);
			this.btnPath.Name = "btnPath";
			this.btnPath.Size = new System.Drawing.Size(50, 35);
			this.btnPath.TabIndex = 3;
			this.btnPath.Text = "...";
			this.btnPath.UseVisualStyleBackColor = true;
			this.btnPath.Click += new System.EventHandler(this.btnPath_Click);
			// 
			// btnDelete
			// 
			this.btnDelete.Location = new System.Drawing.Point(479, 14);
			this.btnDelete.Name = "btnDelete";
			this.btnDelete.Size = new System.Drawing.Size(87, 73);
			this.btnDelete.TabIndex = 4;
			this.btnDelete.Text = "삭제";
			this.btnDelete.UseVisualStyleBackColor = true;
			this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
			// 
			// tbPath
			// 
			this.tbPath.Location = new System.Drawing.Point(82, 14);
			this.tbPath.Name = "tbPath";
			this.tbPath.ReadOnly = true;
			this.tbPath.Size = new System.Drawing.Size(335, 28);
			this.tbPath.TabIndex = 5;
			// 
			// cbDelete
			// 
			this.cbDelete.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbDelete.FormattingEnabled = true;
			this.cbDelete.Items.AddRange(new object[] {
            "British HMG IS5 (Base Line)",
            "British HMG IS5 (Enhanced)"});
			this.cbDelete.Location = new System.Drawing.Point(82, 61);
			this.cbDelete.Name = "cbDelete";
			this.cbDelete.Size = new System.Drawing.Size(391, 26);
			this.cbDelete.TabIndex = 6;
			// 
			// ofDialog
			// 
			this.ofDialog.FileName = "openFileDialog1";
			this.ofDialog.Filter = "모든파일(*.*)|*.*";
			// 
			// progressBar
			// 
			this.progressBar.Location = new System.Drawing.Point(82, 119);
			this.progressBar.Name = "progressBar";
			this.progressBar.Size = new System.Drawing.Size(484, 23);
			this.progressBar.TabIndex = 7;
			// 
			// Form4
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(578, 168);
			this.Controls.Add(this.progressBar);
			this.Controls.Add(this.cbDelete);
			this.Controls.Add(this.tbPath);
			this.Controls.Add(this.btnDelete);
			this.Controls.Add(this.btnPath);
			this.Controls.Add(this.lbPercent);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.MaximizeBox = false;
			this.Name = "Form4";
			this.Text = "파일 지우기";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label lbPercent;
		private System.Windows.Forms.Button btnPath;
		private System.Windows.Forms.Button btnDelete;
		private System.Windows.Forms.TextBox tbPath;
		private System.Windows.Forms.ComboBox cbDelete;
		private System.Windows.Forms.OpenFileDialog ofDialog;
		private System.Windows.Forms.ProgressBar progressBar;
	}
}