namespace Chapter04
{
	partial class Form3
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
			this.tbSrc = new System.Windows.Forms.TextBox();
			this.tbDest = new System.Windows.Forms.TextBox();
			this.btnSrc = new System.Windows.Forms.Button();
			this.btnDest = new System.Windows.Forms.Button();
			this.btnRun = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.gbSelect = new System.Windows.Forms.GroupBox();
			this.lvSrc = new System.Windows.Forms.ListView();
			this.rbCopy = new System.Windows.Forms.RadioButton();
			this.rbMove = new System.Windows.Forms.RadioButton();
			this.fbDialog = new System.Windows.Forms.FolderBrowserDialog();
			this.ssBar = new System.Windows.Forms.StatusStrip();
			this.lvDest = new System.Windows.Forms.ListView();
			this.chFileSrc = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.chFileDest = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.tssLabel = new System.Windows.Forms.ToolStripStatusLabel();
			this.tsProgressBar = new System.Windows.Forms.ToolStripProgressBar();
			this.tssStatus = new System.Windows.Forms.ToolStripStatusLabel();
			this.gbSelect.SuspendLayout();
			this.ssBar.SuspendLayout();
			this.SuspendLayout();
			// 
			// tbSrc
			// 
			this.tbSrc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.tbSrc.Location = new System.Drawing.Point(40, 20);
			this.tbSrc.Name = "tbSrc";
			this.tbSrc.ReadOnly = true;
			this.tbSrc.Size = new System.Drawing.Size(500, 28);
			this.tbSrc.TabIndex = 0;
			// 
			// tbDest
			// 
			this.tbDest.Location = new System.Drawing.Point(40, 70);
			this.tbDest.Name = "tbDest";
			this.tbDest.ReadOnly = true;
			this.tbDest.Size = new System.Drawing.Size(500, 28);
			this.tbDest.TabIndex = 1;
			// 
			// btnSrc
			// 
			this.btnSrc.Location = new System.Drawing.Point(560, 20);
			this.btnSrc.Name = "btnSrc";
			this.btnSrc.Size = new System.Drawing.Size(120, 35);
			this.btnSrc.TabIndex = 2;
			this.btnSrc.Text = "대상 경로";
			this.btnSrc.UseVisualStyleBackColor = true;
			this.btnSrc.Click += new System.EventHandler(this.btnSrc_Click);
			// 
			// btnDest
			// 
			this.btnDest.Location = new System.Drawing.Point(560, 70);
			this.btnDest.Name = "btnDest";
			this.btnDest.Size = new System.Drawing.Size(120, 35);
			this.btnDest.TabIndex = 3;
			this.btnDest.Text = "결과 경로";
			this.btnDest.UseVisualStyleBackColor = true;
			this.btnDest.Click += new System.EventHandler(this.btnDest_Click);
			// 
			// btnRun
			// 
			this.btnRun.Location = new System.Drawing.Point(1011, 20);
			this.btnRun.Name = "btnRun";
			this.btnRun.Size = new System.Drawing.Size(90, 70);
			this.btnRun.TabIndex = 4;
			this.btnRun.Text = "실행";
			this.btnRun.UseVisualStyleBackColor = true;
			this.btnRun.Click += new System.EventHandler(this.btnRun_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(40, 150);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(44, 18);
			this.label1.TabIndex = 5;
			this.label1.Text = "대상";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(600, 150);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(44, 18);
			this.label2.TabIndex = 6;
			this.label2.Text = "결과";
			// 
			// gbSelect
			// 
			this.gbSelect.Controls.Add(this.rbMove);
			this.gbSelect.Controls.Add(this.rbCopy);
			this.gbSelect.Location = new System.Drawing.Point(708, 20);
			this.gbSelect.Name = "gbSelect";
			this.gbSelect.Size = new System.Drawing.Size(280, 70);
			this.gbSelect.TabIndex = 7;
			this.gbSelect.TabStop = false;
			this.gbSelect.Text = "선택";
			// 
			// lvSrc
			// 
			this.lvSrc.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chFileSrc});
			this.lvSrc.GridLines = true;
			this.lvSrc.Location = new System.Drawing.Point(40, 180);
			this.lvSrc.Name = "lvSrc";
			this.lvSrc.Size = new System.Drawing.Size(500, 400);
			this.lvSrc.TabIndex = 8;
			this.lvSrc.UseCompatibleStateImageBehavior = false;
			this.lvSrc.View = System.Windows.Forms.View.Details;
			// 
			// rbCopy
			// 
			this.rbCopy.AutoSize = true;
			this.rbCopy.Checked = true;
			this.rbCopy.Location = new System.Drawing.Point(20, 27);
			this.rbCopy.Name = "rbCopy";
			this.rbCopy.Size = new System.Drawing.Size(105, 22);
			this.rbCopy.TabIndex = 10;
			this.rbCopy.TabStop = true;
			this.rbCopy.Text = "파일복사";
			this.rbCopy.UseVisualStyleBackColor = true;
			// 
			// rbMove
			// 
			this.rbMove.AutoSize = true;
			this.rbMove.Location = new System.Drawing.Point(161, 28);
			this.rbMove.Name = "rbMove";
			this.rbMove.Size = new System.Drawing.Size(105, 22);
			this.rbMove.TabIndex = 11;
			this.rbMove.Text = "파일이동";
			this.rbMove.UseVisualStyleBackColor = true;
			// 
			// ssBar
			// 
			this.ssBar.ImageScalingSize = new System.Drawing.Size(24, 24);
			this.ssBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tssLabel,
            this.tsProgressBar,
            this.tssStatus});
			this.ssBar.Location = new System.Drawing.Point(0, 614);
			this.ssBar.Name = "ssBar";
			this.ssBar.Size = new System.Drawing.Size(1134, 30);
			this.ssBar.TabIndex = 10;
			this.ssBar.Text = "statusStrip1";
			// 
			// lvDest
			// 
			this.lvDest.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chFileDest});
			this.lvDest.GridLines = true;
			this.lvDest.Location = new System.Drawing.Point(600, 180);
			this.lvDest.Name = "lvDest";
			this.lvDest.Size = new System.Drawing.Size(500, 400);
			this.lvDest.TabIndex = 11;
			this.lvDest.UseCompatibleStateImageBehavior = false;
			this.lvDest.View = System.Windows.Forms.View.Details;
			// 
			// chFileSrc
			// 
			this.chFileSrc.Text = "파일";
			this.chFileSrc.Width = 400;
			// 
			// chFileDest
			// 
			this.chFileDest.Text = "파일";
			this.chFileDest.Width = 400;
			// 
			// tssLabel
			// 
			this.tssLabel.Name = "tssLabel";
			this.tssLabel.Size = new System.Drawing.Size(142, 25);
			this.tssLabel.Text = "전체 진행사항 : ";
			// 
			// tsProgressBar
			// 
			this.tsProgressBar.Name = "tsProgressBar";
			this.tsProgressBar.Size = new System.Drawing.Size(200, 24);
			// 
			// tssStatus
			// 
			this.tssStatus.Name = "tssStatus";
			this.tssStatus.Size = new System.Drawing.Size(43, 25);
			this.tssStatus.Text = "0 %";
			// 
			// Form3
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1134, 644);
			this.Controls.Add(this.lvDest);
			this.Controls.Add(this.ssBar);
			this.Controls.Add(this.lvSrc);
			this.Controls.Add(this.gbSelect);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.btnRun);
			this.Controls.Add(this.btnDest);
			this.Controls.Add(this.btnSrc);
			this.Controls.Add(this.tbDest);
			this.Controls.Add(this.tbSrc);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "Form3";
			this.Text = "파일 복사/이동";
			this.Load += new System.EventHandler(this.Form3_Load);
			this.gbSelect.ResumeLayout(false);
			this.gbSelect.PerformLayout();
			this.ssBar.ResumeLayout(false);
			this.ssBar.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox tbSrc;
		private System.Windows.Forms.TextBox tbDest;
		private System.Windows.Forms.Button btnSrc;
		private System.Windows.Forms.Button btnDest;
		private System.Windows.Forms.Button btnRun;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.GroupBox gbSelect;
		private System.Windows.Forms.RadioButton rbMove;
		private System.Windows.Forms.RadioButton rbCopy;
		private System.Windows.Forms.ListView lvSrc;
		private System.Windows.Forms.FolderBrowserDialog fbDialog;
		private System.Windows.Forms.StatusStrip ssBar;
		private System.Windows.Forms.ListView lvDest;
		private System.Windows.Forms.ColumnHeader chFileSrc;
		private System.Windows.Forms.ToolStripStatusLabel tssLabel;
		private System.Windows.Forms.ToolStripProgressBar tsProgressBar;
		private System.Windows.Forms.ToolStripStatusLabel tssStatus;
		private System.Windows.Forms.ColumnHeader chFileDest;
	}
}