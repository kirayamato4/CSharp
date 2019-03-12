namespace Chapter04
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
			this.lbPath = new System.Windows.Forms.Label();
			this.lbExtenstion = new System.Windows.Forms.Label();
			this.lbMonitor = new System.Windows.Forms.Label();
			this.tbPath = new System.Windows.Forms.TextBox();
			this.tbExtension = new System.Windows.Forms.TextBox();
			this.btnPath = new System.Windows.Forms.Button();
			this.btnMonitor = new System.Windows.Forms.Button();
			this.btnSave = new System.Windows.Forms.Button();
			this.cbMonitor = new System.Windows.Forms.ComboBox();
			this.lvLog = new System.Windows.Forms.ListBox();
			this.fbDialog = new System.Windows.Forms.FolderBrowserDialog();
			this.sfDialog = new System.Windows.Forms.SaveFileDialog();
			this.SuspendLayout();
			// 
			// lbPath
			// 
			this.lbPath.AutoSize = true;
			this.lbPath.Location = new System.Drawing.Point(20, 20);
			this.lbPath.Name = "lbPath";
			this.lbPath.Size = new System.Drawing.Size(44, 18);
			this.lbPath.TabIndex = 0;
			this.lbPath.Text = "경로";
			// 
			// lbExtenstion
			// 
			this.lbExtenstion.AutoSize = true;
			this.lbExtenstion.Location = new System.Drawing.Point(20, 66);
			this.lbExtenstion.Name = "lbExtenstion";
			this.lbExtenstion.Size = new System.Drawing.Size(44, 18);
			this.lbExtenstion.TabIndex = 1;
			this.lbExtenstion.Text = "타입";
			// 
			// lbMonitor
			// 
			this.lbMonitor.AutoSize = true;
			this.lbMonitor.Location = new System.Drawing.Point(210, 66);
			this.lbMonitor.Name = "lbMonitor";
			this.lbMonitor.Size = new System.Drawing.Size(86, 18);
			this.lbMonitor.TabIndex = 2;
			this.lbMonitor.Text = "하위 검사";
			// 
			// tbPath
			// 
			this.tbPath.Location = new System.Drawing.Point(85, 17);
			this.tbPath.Name = "tbPath";
			this.tbPath.ReadOnly = true;
			this.tbPath.Size = new System.Drawing.Size(420, 28);
			this.tbPath.TabIndex = 3;
			// 
			// tbExtension
			// 
			this.tbExtension.Location = new System.Drawing.Point(85, 60);
			this.tbExtension.Name = "tbExtension";
			this.tbExtension.Size = new System.Drawing.Size(100, 28);
			this.tbExtension.TabIndex = 4;
			// 
			// btnPath
			// 
			this.btnPath.Location = new System.Drawing.Point(520, 17);
			this.btnPath.Name = "btnPath";
			this.btnPath.Size = new System.Drawing.Size(75, 30);
			this.btnPath.TabIndex = 5;
			this.btnPath.Text = "...";
			this.btnPath.UseVisualStyleBackColor = true;
			this.btnPath.Click += new System.EventHandler(this.btnPath_Click);
			// 
			// btnMonitor
			// 
			this.btnMonitor.Location = new System.Drawing.Point(620, 20);
			this.btnMonitor.Name = "btnMonitor";
			this.btnMonitor.Size = new System.Drawing.Size(120, 60);
			this.btnMonitor.TabIndex = 6;
			this.btnMonitor.Text = "모니터 ON";
			this.btnMonitor.UseVisualStyleBackColor = true;
			this.btnMonitor.Click += new System.EventHandler(this.btnMonitor_Click);
			// 
			// btnSave
			// 
			this.btnSave.Location = new System.Drawing.Point(750, 20);
			this.btnSave.Name = "btnSave";
			this.btnSave.Size = new System.Drawing.Size(120, 60);
			this.btnSave.TabIndex = 7;
			this.btnSave.Text = "로그 저장";
			this.btnSave.UseVisualStyleBackColor = true;
			this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
			// 
			// cbMonitor
			// 
			this.cbMonitor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbMonitor.FormattingEnabled = true;
			this.cbMonitor.Items.AddRange(new object[] {
            "ON",
            "OFF"});
			this.cbMonitor.Location = new System.Drawing.Point(302, 62);
			this.cbMonitor.Name = "cbMonitor";
			this.cbMonitor.Size = new System.Drawing.Size(135, 26);
			this.cbMonitor.TabIndex = 8;
			// 
			// lvLog
			// 
			this.lvLog.FormattingEnabled = true;
			this.lvLog.ItemHeight = 18;
			this.lvLog.Location = new System.Drawing.Point(23, 116);
			this.lvLog.Name = "lvLog";
			this.lvLog.Size = new System.Drawing.Size(847, 454);
			this.lvLog.TabIndex = 9;
			// 
			// sfDialog
			// 
			this.sfDialog.Filter = "로그 파일(*.log)|*.log";
			// 
			// Form5
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(897, 591);
			this.Controls.Add(this.lvLog);
			this.Controls.Add(this.cbMonitor);
			this.Controls.Add(this.btnSave);
			this.Controls.Add(this.btnMonitor);
			this.Controls.Add(this.btnPath);
			this.Controls.Add(this.tbExtension);
			this.Controls.Add(this.tbPath);
			this.Controls.Add(this.lbMonitor);
			this.Controls.Add(this.lbExtenstion);
			this.Controls.Add(this.lbPath);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.MaximizeBox = false;
			this.Name = "Form5";
			this.Text = "파일 모니터";
			this.Load += new System.EventHandler(this.Form5_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label lbPath;
		private System.Windows.Forms.Label lbExtenstion;
		private System.Windows.Forms.Label lbMonitor;
		private System.Windows.Forms.TextBox tbPath;
		private System.Windows.Forms.TextBox tbExtension;
		private System.Windows.Forms.Button btnPath;
		private System.Windows.Forms.Button btnMonitor;
		private System.Windows.Forms.Button btnSave;
		private System.Windows.Forms.ComboBox cbMonitor;
		private System.Windows.Forms.ListBox lvLog;
		private System.Windows.Forms.FolderBrowserDialog fbDialog;
		private System.Windows.Forms.SaveFileDialog sfDialog;
	}
}