namespace Chapter04
{
	partial class Form1
	{
		/// <summary>
		/// 필수 디자이너 변수입니다.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// 사용 중인 모든 리소스를 정리합니다.
		/// </summary>
		/// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
		protected override void Dispose( bool disposing )
		{
			if( disposing && ( components != null ) )
			{
				components.Dispose();
			}
			base.Dispose( disposing );
		}

		#region Windows Form 디자이너에서 생성한 코드

		/// <summary>
		/// 디자이너 지원에 필요한 메서드입니다. 
		/// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
		/// </summary>
		private void InitializeComponent()
		{
			this.tabMenu = new System.Windows.Forms.TabControl();
			this.tpRead = new System.Windows.Forms.TabPage();
			this.tpWrite = new System.Windows.Forms.TabPage();
			this.ofdFile = new System.Windows.Forms.OpenFileDialog();
			this.sfdFile = new System.Windows.Forms.SaveFileDialog();
			this.btnReadPath = new System.Windows.Forms.Button();
			this.btnReadLine = new System.Windows.Forms.Button();
			this.btnReadAll = new System.Windows.Forms.Button();
			this.tbReadView = new System.Windows.Forms.TextBox();
			this.tbReadPath = new System.Windows.Forms.TextBox();
			this.tbWritePath = new System.Windows.Forms.TextBox();
			this.btnWritePath = new System.Windows.Forms.Button();
			this.btnWriteAll = new System.Windows.Forms.Button();
			this.btnWriteLine = new System.Windows.Forms.Button();
			this.tbWriteView = new System.Windows.Forms.TextBox();
			this.tabMenu.SuspendLayout();
			this.tpRead.SuspendLayout();
			this.tpWrite.SuspendLayout();
			this.SuspendLayout();
			// 
			// tabMenu
			// 
			this.tabMenu.Controls.Add(this.tpRead);
			this.tabMenu.Controls.Add(this.tpWrite);
			this.tabMenu.Location = new System.Drawing.Point(17, 5);
			this.tabMenu.Name = "tabMenu";
			this.tabMenu.SelectedIndex = 0;
			this.tabMenu.Size = new System.Drawing.Size(850, 520);
			this.tabMenu.TabIndex = 0;
			// 
			// tpRead
			// 
			this.tpRead.Controls.Add(this.tbReadPath);
			this.tpRead.Controls.Add(this.tbReadView);
			this.tpRead.Controls.Add(this.btnReadAll);
			this.tpRead.Controls.Add(this.btnReadLine);
			this.tpRead.Controls.Add(this.btnReadPath);
			this.tpRead.Location = new System.Drawing.Point(4, 28);
			this.tpRead.Name = "tpRead";
			this.tpRead.Padding = new System.Windows.Forms.Padding(3);
			this.tpRead.Size = new System.Drawing.Size(842, 488);
			this.tpRead.TabIndex = 0;
			this.tpRead.Text = "파일 읽기";
			this.tpRead.UseVisualStyleBackColor = true;
			// 
			// tpWrite
			// 
			this.tpWrite.Controls.Add(this.tbWriteView);
			this.tpWrite.Controls.Add(this.btnWriteAll);
			this.tpWrite.Controls.Add(this.btnWriteLine);
			this.tpWrite.Controls.Add(this.btnWritePath);
			this.tpWrite.Controls.Add(this.tbWritePath);
			this.tpWrite.Location = new System.Drawing.Point(4, 28);
			this.tpWrite.Name = "tpWrite";
			this.tpWrite.Padding = new System.Windows.Forms.Padding(3);
			this.tpWrite.Size = new System.Drawing.Size(842, 488);
			this.tpWrite.TabIndex = 1;
			this.tpWrite.Text = "파일 쓰기";
			this.tpWrite.UseVisualStyleBackColor = true;
			// 
			// ofdFile
			// 
			this.ofdFile.Filter = "텍스트 파일(*.txt)|*.txt|모든 파일(*.*)|*.*";
			// 
			// sfdFile
			// 
			this.sfdFile.Filter = "텍스트 파일(*.txt)|*.txt";
			// 
			// btnReadPath
			// 
			this.btnReadPath.Location = new System.Drawing.Point(560, 28);
			this.btnReadPath.Name = "btnReadPath";
			this.btnReadPath.Size = new System.Drawing.Size(120, 30);
			this.btnReadPath.TabIndex = 0;
			this.btnReadPath.Text = "파일";
			this.btnReadPath.UseVisualStyleBackColor = true;
			this.btnReadPath.Click += new System.EventHandler(this.btnReadPath_Click);
			// 
			// btnReadLine
			// 
			this.btnReadLine.Location = new System.Drawing.Point(224, 94);
			this.btnReadLine.Name = "btnReadLine";
			this.btnReadLine.Size = new System.Drawing.Size(150, 30);
			this.btnReadLine.TabIndex = 1;
			this.btnReadLine.Text = "라인 읽기";
			this.btnReadLine.UseVisualStyleBackColor = true;
			this.btnReadLine.Click += new System.EventHandler(this.btnReadLine_Click);
			// 
			// btnReadAll
			// 
			this.btnReadAll.Location = new System.Drawing.Point(30, 94);
			this.btnReadAll.Name = "btnReadAll";
			this.btnReadAll.Size = new System.Drawing.Size(150, 30);
			this.btnReadAll.TabIndex = 2;
			this.btnReadAll.Text = "전체 읽기";
			this.btnReadAll.UseVisualStyleBackColor = true;
			this.btnReadAll.Click += new System.EventHandler(this.btnReadAll_Click);
			// 
			// tbReadView
			// 
			this.tbReadView.Location = new System.Drawing.Point(30, 161);
			this.tbReadView.Multiline = true;
			this.tbReadView.Name = "tbReadView";
			this.tbReadView.ReadOnly = true;
			this.tbReadView.ScrollBars = System.Windows.Forms.ScrollBars.Both;
			this.tbReadView.Size = new System.Drawing.Size(650, 300);
			this.tbReadView.TabIndex = 3;
			// 
			// tbReadPath
			// 
			this.tbReadPath.Location = new System.Drawing.Point(30, 28);
			this.tbReadPath.Name = "tbReadPath";
			this.tbReadPath.ReadOnly = true;
			this.tbReadPath.Size = new System.Drawing.Size(500, 28);
			this.tbReadPath.TabIndex = 4;
			// 
			// tbWritePath
			// 
			this.tbWritePath.Location = new System.Drawing.Point(30, 28);
			this.tbWritePath.Name = "tbWritePath";
			this.tbWritePath.ReadOnly = true;
			this.tbWritePath.Size = new System.Drawing.Size(500, 28);
			this.tbWritePath.TabIndex = 5;
			// 
			// btnWritePath
			// 
			this.btnWritePath.Location = new System.Drawing.Point(560, 28);
			this.btnWritePath.Name = "btnWritePath";
			this.btnWritePath.Size = new System.Drawing.Size(120, 30);
			this.btnWritePath.TabIndex = 6;
			this.btnWritePath.Text = "파일";
			this.btnWritePath.UseVisualStyleBackColor = true;
			this.btnWritePath.Click += new System.EventHandler(this.btnWritePath_Click);
			// 
			// btnWriteAll
			// 
			this.btnWriteAll.Location = new System.Drawing.Point(30, 94);
			this.btnWriteAll.Name = "btnWriteAll";
			this.btnWriteAll.Size = new System.Drawing.Size(150, 30);
			this.btnWriteAll.TabIndex = 8;
			this.btnWriteAll.Text = "전체 저장";
			this.btnWriteAll.UseVisualStyleBackColor = true;
			this.btnWriteAll.Click += new System.EventHandler(this.btnWriteAll_Click);
			// 
			// btnWriteLine
			// 
			this.btnWriteLine.Location = new System.Drawing.Point(224, 94);
			this.btnWriteLine.Name = "btnWriteLine";
			this.btnWriteLine.Size = new System.Drawing.Size(150, 30);
			this.btnWriteLine.TabIndex = 7;
			this.btnWriteLine.Text = "라인 저장";
			this.btnWriteLine.UseVisualStyleBackColor = true;
			this.btnWriteLine.Click += new System.EventHandler(this.btnWriteLine_Click);
			// 
			// tbWriteView
			// 
			this.tbWriteView.Location = new System.Drawing.Point(30, 161);
			this.tbWriteView.Multiline = true;
			this.tbWriteView.Name = "tbWriteView";
			this.tbWriteView.ScrollBars = System.Windows.Forms.ScrollBars.Both;
			this.tbWriteView.Size = new System.Drawing.Size(650, 300);
			this.tbWriteView.TabIndex = 9;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(878, 544);
			this.Controls.Add(this.tabMenu);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.MaximizeBox = false;
			this.Name = "Form1";
			this.Text = "Form1";
			this.tabMenu.ResumeLayout(false);
			this.tpRead.ResumeLayout(false);
			this.tpRead.PerformLayout();
			this.tpWrite.ResumeLayout(false);
			this.tpWrite.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.TabControl tabMenu;
		private System.Windows.Forms.TabPage tpRead;
		private System.Windows.Forms.TabPage tpWrite;
		private System.Windows.Forms.OpenFileDialog ofdFile;
		private System.Windows.Forms.SaveFileDialog sfdFile;
		private System.Windows.Forms.TextBox tbReadPath;
		private System.Windows.Forms.TextBox tbReadView;
		private System.Windows.Forms.Button btnReadAll;
		private System.Windows.Forms.Button btnReadLine;
		private System.Windows.Forms.Button btnReadPath;
		private System.Windows.Forms.TextBox tbWriteView;
		private System.Windows.Forms.Button btnWriteAll;
		private System.Windows.Forms.Button btnWriteLine;
		private System.Windows.Forms.Button btnWritePath;
		private System.Windows.Forms.TextBox tbWritePath;
	}
}

