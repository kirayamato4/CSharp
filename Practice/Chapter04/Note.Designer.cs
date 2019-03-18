namespace Chapter04
{
	partial class Note
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
			this.menuStrip = new System.Windows.Forms.MenuStrip();
			this.파일FToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.새로만들기NToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.열기OToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.저장SToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.다른이름으로저장AToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.fontDialog = new System.Windows.Forms.FontDialog();
			this.ofDialog = new System.Windows.Forms.OpenFileDialog();
			this.sfDialog = new System.Windows.Forms.SaveFileDialog();
			this.tbNote = new System.Windows.Forms.TextBox();
			this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
			this.끝내기XToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.편집EToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.실행취소UToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
			this.잘라내기TToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.복사CToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.붙여넣기PToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.삭제LToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
			this.찾기FToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.다음찾기NToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
			this.모두선택AToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.시간날짜DToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.서식OToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.자동줄바꿈WToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.글꼴FToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.menuStrip.SuspendLayout();
			this.SuspendLayout();
			// 
			// menuStrip
			// 
			this.menuStrip.ImageScalingSize = new System.Drawing.Size(24, 24);
			this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.파일FToolStripMenuItem,
            this.편집EToolStripMenuItem,
            this.서식OToolStripMenuItem});
			this.menuStrip.Location = new System.Drawing.Point(0, 0);
			this.menuStrip.Name = "menuStrip";
			this.menuStrip.Size = new System.Drawing.Size(1175, 33);
			this.menuStrip.TabIndex = 0;
			this.menuStrip.Text = "menuStrip1";
			// 
			// 파일FToolStripMenuItem
			// 
			this.파일FToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.새로만들기NToolStripMenuItem,
            this.열기OToolStripMenuItem,
            this.저장SToolStripMenuItem,
            this.다른이름으로저장AToolStripMenuItem,
            this.toolStripSeparator1,
            this.끝내기XToolStripMenuItem});
			this.파일FToolStripMenuItem.Name = "파일FToolStripMenuItem";
			this.파일FToolStripMenuItem.Size = new System.Drawing.Size(79, 29);
			this.파일FToolStripMenuItem.Text = "파일(F)";
			// 
			// 새로만들기NToolStripMenuItem
			// 
			this.새로만들기NToolStripMenuItem.Name = "새로만들기NToolStripMenuItem";
			this.새로만들기NToolStripMenuItem.Size = new System.Drawing.Size(286, 30);
			this.새로만들기NToolStripMenuItem.Text = "새로만들기(N)";
			this.새로만들기NToolStripMenuItem.Click += new System.EventHandler(this.새로만들기NToolStripMenuItem_Click);
			// 
			// 열기OToolStripMenuItem
			// 
			this.열기OToolStripMenuItem.Name = "열기OToolStripMenuItem";
			this.열기OToolStripMenuItem.Size = new System.Drawing.Size(286, 30);
			this.열기OToolStripMenuItem.Text = "열기(O)...";
			this.열기OToolStripMenuItem.Click += new System.EventHandler(this.열기OToolStripMenuItem_Click);
			// 
			// 저장SToolStripMenuItem
			// 
			this.저장SToolStripMenuItem.Name = "저장SToolStripMenuItem";
			this.저장SToolStripMenuItem.Size = new System.Drawing.Size(286, 30);
			this.저장SToolStripMenuItem.Text = "저장(S)...";
			this.저장SToolStripMenuItem.Click += new System.EventHandler(this.저장SToolStripMenuItem_Click);
			// 
			// 다른이름으로저장AToolStripMenuItem
			// 
			this.다른이름으로저장AToolStripMenuItem.Name = "다른이름으로저장AToolStripMenuItem";
			this.다른이름으로저장AToolStripMenuItem.Size = new System.Drawing.Size(286, 30);
			this.다른이름으로저장AToolStripMenuItem.Text = "다른 이름으로 저장(A)...";
			this.다른이름으로저장AToolStripMenuItem.Click += new System.EventHandler(this.다른이름으로저장AToolStripMenuItem_Click);
			// 
			// ofDialog
			// 
			this.ofDialog.FileName = "openFileDialog1";
			// 
			// tbNote
			// 
			this.tbNote.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tbNote.Location = new System.Drawing.Point(0, 33);
			this.tbNote.Multiline = true;
			this.tbNote.Name = "tbNote";
			this.tbNote.ScrollBars = System.Windows.Forms.ScrollBars.Both;
			this.tbNote.Size = new System.Drawing.Size(1175, 682);
			this.tbNote.TabIndex = 1;
			this.tbNote.TextChanged += new System.EventHandler(this.tbNote_TextChanged);
			// 
			// toolStripSeparator1
			// 
			this.toolStripSeparator1.Name = "toolStripSeparator1";
			this.toolStripSeparator1.Size = new System.Drawing.Size(283, 6);
			// 
			// 끝내기XToolStripMenuItem
			// 
			this.끝내기XToolStripMenuItem.Name = "끝내기XToolStripMenuItem";
			this.끝내기XToolStripMenuItem.Size = new System.Drawing.Size(286, 30);
			this.끝내기XToolStripMenuItem.Text = "끝내기(X)";
			this.끝내기XToolStripMenuItem.Click += new System.EventHandler(this.끝내기XToolStripMenuItem_Click);
			// 
			// 편집EToolStripMenuItem
			// 
			this.편집EToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.실행취소UToolStripMenuItem,
            this.toolStripSeparator2,
            this.잘라내기TToolStripMenuItem,
            this.복사CToolStripMenuItem,
            this.붙여넣기PToolStripMenuItem,
            this.삭제LToolStripMenuItem,
            this.toolStripSeparator3,
            this.찾기FToolStripMenuItem,
            this.다음찾기NToolStripMenuItem,
            this.toolStripSeparator4,
            this.모두선택AToolStripMenuItem,
            this.시간날짜DToolStripMenuItem});
			this.편집EToolStripMenuItem.Name = "편집EToolStripMenuItem";
			this.편집EToolStripMenuItem.Size = new System.Drawing.Size(79, 29);
			this.편집EToolStripMenuItem.Text = "편집(E)";
			// 
			// 실행취소UToolStripMenuItem
			// 
			this.실행취소UToolStripMenuItem.Name = "실행취소UToolStripMenuItem";
			this.실행취소UToolStripMenuItem.Size = new System.Drawing.Size(210, 30);
			this.실행취소UToolStripMenuItem.Text = "실행 취소(U)";
			this.실행취소UToolStripMenuItem.Click += new System.EventHandler(this.실행취소UToolStripMenuItem_Click);
			// 
			// toolStripSeparator2
			// 
			this.toolStripSeparator2.Name = "toolStripSeparator2";
			this.toolStripSeparator2.Size = new System.Drawing.Size(207, 6);
			// 
			// 잘라내기TToolStripMenuItem
			// 
			this.잘라내기TToolStripMenuItem.Name = "잘라내기TToolStripMenuItem";
			this.잘라내기TToolStripMenuItem.Size = new System.Drawing.Size(210, 30);
			this.잘라내기TToolStripMenuItem.Text = "잘라내기(T)";
			this.잘라내기TToolStripMenuItem.Click += new System.EventHandler(this.잘라내기TToolStripMenuItem_Click);
			// 
			// 복사CToolStripMenuItem
			// 
			this.복사CToolStripMenuItem.Name = "복사CToolStripMenuItem";
			this.복사CToolStripMenuItem.Size = new System.Drawing.Size(210, 30);
			this.복사CToolStripMenuItem.Text = "복사(C)";
			this.복사CToolStripMenuItem.Click += new System.EventHandler(this.복사CToolStripMenuItem_Click);
			// 
			// 붙여넣기PToolStripMenuItem
			// 
			this.붙여넣기PToolStripMenuItem.Name = "붙여넣기PToolStripMenuItem";
			this.붙여넣기PToolStripMenuItem.Size = new System.Drawing.Size(210, 30);
			this.붙여넣기PToolStripMenuItem.Text = "붙여넣기(P)";
			this.붙여넣기PToolStripMenuItem.Click += new System.EventHandler(this.붙여넣기PToolStripMenuItem_Click);
			// 
			// 삭제LToolStripMenuItem
			// 
			this.삭제LToolStripMenuItem.Name = "삭제LToolStripMenuItem";
			this.삭제LToolStripMenuItem.Size = new System.Drawing.Size(210, 30);
			this.삭제LToolStripMenuItem.Text = "삭제(L)";
			this.삭제LToolStripMenuItem.Click += new System.EventHandler(this.삭제LToolStripMenuItem_Click);
			// 
			// toolStripSeparator3
			// 
			this.toolStripSeparator3.Name = "toolStripSeparator3";
			this.toolStripSeparator3.Size = new System.Drawing.Size(207, 6);
			// 
			// 찾기FToolStripMenuItem
			// 
			this.찾기FToolStripMenuItem.Name = "찾기FToolStripMenuItem";
			this.찾기FToolStripMenuItem.Size = new System.Drawing.Size(210, 30);
			this.찾기FToolStripMenuItem.Text = "찾기(F)";
			this.찾기FToolStripMenuItem.Click += new System.EventHandler(this.찾기FToolStripMenuItem_Click);
			// 
			// 다음찾기NToolStripMenuItem
			// 
			this.다음찾기NToolStripMenuItem.Name = "다음찾기NToolStripMenuItem";
			this.다음찾기NToolStripMenuItem.Size = new System.Drawing.Size(210, 30);
			this.다음찾기NToolStripMenuItem.Text = "다음 찾기(N)";
			this.다음찾기NToolStripMenuItem.Click += new System.EventHandler(this.다음찾기NToolStripMenuItem_Click);
			// 
			// toolStripSeparator4
			// 
			this.toolStripSeparator4.Name = "toolStripSeparator4";
			this.toolStripSeparator4.Size = new System.Drawing.Size(207, 6);
			// 
			// 모두선택AToolStripMenuItem
			// 
			this.모두선택AToolStripMenuItem.Name = "모두선택AToolStripMenuItem";
			this.모두선택AToolStripMenuItem.Size = new System.Drawing.Size(210, 30);
			this.모두선택AToolStripMenuItem.Text = "모두 선택(A)";
			this.모두선택AToolStripMenuItem.Click += new System.EventHandler(this.모두선택AToolStripMenuItem_Click);
			// 
			// 시간날짜DToolStripMenuItem
			// 
			this.시간날짜DToolStripMenuItem.Name = "시간날짜DToolStripMenuItem";
			this.시간날짜DToolStripMenuItem.Size = new System.Drawing.Size(210, 30);
			this.시간날짜DToolStripMenuItem.Text = "시간/날짜(D)";
			this.시간날짜DToolStripMenuItem.Click += new System.EventHandler(this.시간날짜DToolStripMenuItem_Click);
			// 
			// 서식OToolStripMenuItem
			// 
			this.서식OToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.자동줄바꿈WToolStripMenuItem,
            this.글꼴FToolStripMenuItem});
			this.서식OToolStripMenuItem.Name = "서식OToolStripMenuItem";
			this.서식OToolStripMenuItem.Size = new System.Drawing.Size(84, 29);
			this.서식OToolStripMenuItem.Text = "서식(O)";
			// 
			// 자동줄바꿈WToolStripMenuItem
			// 
			this.자동줄바꿈WToolStripMenuItem.Checked = true;
			this.자동줄바꿈WToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
			this.자동줄바꿈WToolStripMenuItem.Name = "자동줄바꿈WToolStripMenuItem";
			this.자동줄바꿈WToolStripMenuItem.Size = new System.Drawing.Size(225, 30);
			this.자동줄바꿈WToolStripMenuItem.Text = "자동 줄 바꿈(W)";
			// 
			// 글꼴FToolStripMenuItem
			// 
			this.글꼴FToolStripMenuItem.Name = "글꼴FToolStripMenuItem";
			this.글꼴FToolStripMenuItem.Size = new System.Drawing.Size(225, 30);
			this.글꼴FToolStripMenuItem.Text = "글꼴(F)";
			this.글꼴FToolStripMenuItem.Click += new System.EventHandler(this.글꼴FToolStripMenuItem_Click);
			// 
			// Note
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1175, 715);
			this.Controls.Add(this.tbNote);
			this.Controls.Add(this.menuStrip);
			this.MainMenuStrip = this.menuStrip;
			this.Name = "Note";
			this.Text = "제목 없음";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Note_FormClosing);
			this.menuStrip.ResumeLayout(false);
			this.menuStrip.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.MenuStrip menuStrip;
		private System.Windows.Forms.FontDialog fontDialog;
		private System.Windows.Forms.OpenFileDialog ofDialog;
		private System.Windows.Forms.SaveFileDialog sfDialog;
		private System.Windows.Forms.TextBox tbNote;
		private System.Windows.Forms.ToolStripMenuItem 파일FToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem 새로만들기NToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem 열기OToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem 저장SToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem 다른이름으로저장AToolStripMenuItem;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
		private System.Windows.Forms.ToolStripMenuItem 끝내기XToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem 편집EToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem 실행취소UToolStripMenuItem;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
		private System.Windows.Forms.ToolStripMenuItem 잘라내기TToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem 복사CToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem 붙여넣기PToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem 삭제LToolStripMenuItem;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
		private System.Windows.Forms.ToolStripMenuItem 찾기FToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem 다음찾기NToolStripMenuItem;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
		private System.Windows.Forms.ToolStripMenuItem 모두선택AToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem 시간날짜DToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem 서식OToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem 자동줄바꿈WToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem 글꼴FToolStripMenuItem;
	}
}