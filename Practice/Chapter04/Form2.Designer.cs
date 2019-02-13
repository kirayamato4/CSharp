namespace Chapter04
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
			this.lbPath = new System.Windows.Forms.Label();
			this.tbPath = new System.Windows.Forms.TextBox();
			this.btnPath = new System.Windows.Forms.Button();
			this.rbAll = new System.Windows.Forms.RadioButton();
			this.rbHidden = new System.Windows.Forms.RadioButton();
			this.lvFile = new System.Windows.Forms.ListView();
			this.chPath = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.chName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.chFileTime = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.chFileSize = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.fbdFolder = new System.Windows.Forms.FolderBrowserDialog();
			this.ssBar = new System.Windows.Forms.StatusStrip();
			this.tsslbResult = new System.Windows.Forms.ToolStripStatusLabel();
			this.ssBar.SuspendLayout();
			this.SuspendLayout();
			// 
			// lbPath
			// 
			this.lbPath.AutoSize = true;
			this.lbPath.Font = new System.Drawing.Font("굴림", 9F);
			this.lbPath.Location = new System.Drawing.Point(28, 40);
			this.lbPath.Name = "lbPath";
			this.lbPath.Size = new System.Drawing.Size(62, 18);
			this.lbPath.TabIndex = 0;
			this.lbPath.Text = "경로 : ";
			// 
			// tbPath
			// 
			this.tbPath.Font = new System.Drawing.Font("굴림", 9F);
			this.tbPath.Location = new System.Drawing.Point(104, 35);
			this.tbPath.Name = "tbPath";
			this.tbPath.ReadOnly = true;
			this.tbPath.Size = new System.Drawing.Size(668, 28);
			this.tbPath.TabIndex = 1;
			// 
			// btnPath
			// 
			this.btnPath.Font = new System.Drawing.Font("굴림", 9F);
			this.btnPath.Location = new System.Drawing.Point(805, 35);
			this.btnPath.Name = "btnPath";
			this.btnPath.Size = new System.Drawing.Size(100, 30);
			this.btnPath.TabIndex = 2;
			this.btnPath.Text = "경로";
			this.btnPath.UseVisualStyleBackColor = true;
			this.btnPath.Click += new System.EventHandler(this.btnPath_Click);
			// 
			// rbAll
			// 
			this.rbAll.AutoSize = true;
			this.rbAll.Location = new System.Drawing.Point(32, 107);
			this.rbAll.Name = "rbAll";
			this.rbAll.Size = new System.Drawing.Size(105, 22);
			this.rbAll.TabIndex = 3;
			this.rbAll.TabStop = true;
			this.rbAll.Text = "전체파일";
			this.rbAll.UseVisualStyleBackColor = true;
			this.rbAll.CheckedChanged += new System.EventHandler(this.rbAll_CheckedChanged);
			// 
			// rbHidden
			// 
			this.rbHidden.AutoSize = true;
			this.rbHidden.Location = new System.Drawing.Point(239, 107);
			this.rbHidden.Name = "rbHidden";
			this.rbHidden.Size = new System.Drawing.Size(105, 22);
			this.rbHidden.TabIndex = 4;
			this.rbHidden.TabStop = true;
			this.rbHidden.Text = "숨김파일";
			this.rbHidden.UseVisualStyleBackColor = true;
			this.rbHidden.CheckedChanged += new System.EventHandler(this.rbHidden_CheckedChanged);
			// 
			// lvFile
			// 
			this.lvFile.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chPath,
            this.chName,
            this.chFileTime,
            this.chFileSize});
			this.lvFile.GridLines = true;
			this.lvFile.Location = new System.Drawing.Point(32, 162);
			this.lvFile.Name = "lvFile";
			this.lvFile.Size = new System.Drawing.Size(873, 417);
			this.lvFile.TabIndex = 5;
			this.lvFile.UseCompatibleStateImageBehavior = false;
			this.lvFile.View = System.Windows.Forms.View.Details;
			// 
			// chPath
			// 
			this.chPath.Text = "경로";
			this.chPath.Width = 400;
			// 
			// chName
			// 
			this.chName.Text = "이름";
			this.chName.Width = 120;
			// 
			// chFileTime
			// 
			this.chFileTime.Text = "수정한 날짜";
			this.chFileTime.Width = 150;
			// 
			// chFileSize
			// 
			this.chFileSize.Text = "파일 크기";
			this.chFileSize.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			this.chFileSize.Width = 150;
			// 
			// ssBar
			// 
			this.ssBar.ImageScalingSize = new System.Drawing.Size(24, 24);
			this.ssBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsslbResult});
			this.ssBar.Location = new System.Drawing.Point(0, 586);
			this.ssBar.Name = "ssBar";
			this.ssBar.Size = new System.Drawing.Size(944, 30);
			this.ssBar.TabIndex = 6;
			this.ssBar.Text = "statusStrip1";
			// 
			// tsslbResult
			// 
			this.tsslbResult.Name = "tsslbResult";
			this.tsslbResult.Size = new System.Drawing.Size(194, 25);
			this.tsslbResult.Text = "폴더 : 0 개, 파일 : 0 개";
			// 
			// Form2
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(944, 616);
			this.Controls.Add(this.ssBar);
			this.Controls.Add(this.lvFile);
			this.Controls.Add(this.rbHidden);
			this.Controls.Add(this.rbAll);
			this.Controls.Add(this.btnPath);
			this.Controls.Add(this.tbPath);
			this.Controls.Add(this.lbPath);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.MaximizeBox = false;
			this.Name = "Form2";
			this.Text = "파일 보기";
			this.Load += new System.EventHandler(this.Form2_Load);
			this.ssBar.ResumeLayout(false);
			this.ssBar.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label lbPath;
		private System.Windows.Forms.TextBox tbPath;
		private System.Windows.Forms.Button btnPath;
		private System.Windows.Forms.RadioButton rbAll;
		private System.Windows.Forms.RadioButton rbHidden;
		private System.Windows.Forms.ListView lvFile;
		private System.Windows.Forms.FolderBrowserDialog fbdFolder;
		private System.Windows.Forms.StatusStrip ssBar;
		private System.Windows.Forms.ColumnHeader chPath;
		private System.Windows.Forms.ColumnHeader chName;
		private System.Windows.Forms.ColumnHeader chFileTime;
		private System.Windows.Forms.ColumnHeader chFileSize;
		private System.Windows.Forms.ToolStripStatusLabel tsslbResult;
	}
}