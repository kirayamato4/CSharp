namespace Chapter03
{
	partial class Form6
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
			this.lvView = new System.Windows.Forms.ListView();
			this.btnKill = new System.Windows.Forms.Button();
			this.ssBar = new System.Windows.Forms.StatusStrip();
			this.chName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.chPID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.chTime = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.chMemory = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.tsslProcess = new System.Windows.Forms.ToolStripStatusLabel();
			this.tsslCpu = new System.Windows.Forms.ToolStripStatusLabel();
			this.tsslMemory = new System.Windows.Forms.ToolStripStatusLabel();
			this.ssBar.SuspendLayout();
			this.SuspendLayout();
			// 
			// lvView
			// 
			this.lvView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chName,
            this.chPID,
            this.chTime,
            this.chMemory});
			this.lvView.FullRowSelect = true;
			this.lvView.GridLines = true;
			this.lvView.Location = new System.Drawing.Point(0, 0);
			this.lvView.Name = "lvView";
			this.lvView.Size = new System.Drawing.Size(740, 380);
			this.lvView.TabIndex = 0;
			this.lvView.UseCompatibleStateImageBehavior = false;
			this.lvView.View = System.Windows.Forms.View.Details;
			// 
			// btnKill
			// 
			this.btnKill.Location = new System.Drawing.Point(366, 392);
			this.btnKill.Name = "btnKill";
			this.btnKill.Size = new System.Drawing.Size(150, 35);
			this.btnKill.TabIndex = 1;
			this.btnKill.Text = "프로세스 끝내기";
			this.btnKill.UseVisualStyleBackColor = true;
			this.btnKill.Click += new System.EventHandler(this.btnKill_Click);
			// 
			// ssBar
			// 
			this.ssBar.ImageScalingSize = new System.Drawing.Size(24, 24);
			this.ssBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsslProcess,
            this.tsslCpu,
            this.tsslMemory});
			this.ssBar.Location = new System.Drawing.Point(0, 434);
			this.ssBar.Name = "ssBar";
			this.ssBar.Size = new System.Drawing.Size(518, 30);
			this.ssBar.TabIndex = 2;
			this.ssBar.Text = "statusStrip1";
			// 
			// chName
			// 
			this.chName.Text = "프로세스 이름";
			this.chName.Width = 108;
			// 
			// chPID
			// 
			this.chPID.Text = "PID";
			this.chPID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// chTime
			// 
			this.chTime.Text = "Time";
			this.chTime.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.chTime.Width = 90;
			// 
			// chMemory
			// 
			this.chMemory.Text = "메모리 사용";
			this.chMemory.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			this.chMemory.Width = 100;
			// 
			// tsslProcess
			// 
			this.tsslProcess.Name = "tsslProcess";
			this.tsslProcess.Size = new System.Drawing.Size(128, 25);
			this.tsslProcess.Text = "프로세스 : 0개";
			// 
			// tsslCpu
			// 
			this.tsslCpu.Name = "tsslCpu";
			this.tsslCpu.Size = new System.Drawing.Size(129, 25);
			this.tsslCpu.Text = "CPU 사용 : 0%";
			// 
			// tsslMemory
			// 
			this.tsslMemory.Name = "tsslMemory";
			this.tsslMemory.Size = new System.Drawing.Size(149, 25);
			this.tsslMemory.Text = "실제 메모리 : 0%";
			// 
			// Form6
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(518, 464);
			this.Controls.Add(this.ssBar);
			this.Controls.Add(this.btnKill);
			this.Controls.Add(this.lvView);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "Form6";
			this.Text = "프로세스 보기";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form6_FormClosing);
			this.Load += new System.EventHandler(this.Form6_Load);
			this.ssBar.ResumeLayout(false);
			this.ssBar.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.ListView lvView;
		private System.Windows.Forms.ColumnHeader chName;
		private System.Windows.Forms.ColumnHeader chPID;
		private System.Windows.Forms.ColumnHeader chTime;
		private System.Windows.Forms.ColumnHeader chMemory;
		private System.Windows.Forms.Button btnKill;
		private System.Windows.Forms.StatusStrip ssBar;
		private System.Windows.Forms.ToolStripStatusLabel tsslProcess;
		private System.Windows.Forms.ToolStripStatusLabel tsslCpu;
		private System.Windows.Forms.ToolStripStatusLabel tsslMemory;
	}
}