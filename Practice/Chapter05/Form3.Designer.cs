namespace Chapter05
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
			this.msBar = new System.Windows.Forms.MenuStrip();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.tbBackground = new System.Windows.Forms.TextBox();
			this.tbMarking = new System.Windows.Forms.TextBox();
			this.btnBackground = new System.Windows.Forms.Button();
			this.btnPreview = new System.Windows.Forms.Button();
			this.btnSave = new System.Windows.Forms.Button();
			this.pbPreview = new System.Windows.Forms.PictureBox();
			this.hsbOpacity = new System.Windows.Forms.HScrollBar();
			this.ofDlg = new System.Windows.Forms.OpenFileDialog();
			this.sfDlg = new System.Windows.Forms.SaveFileDialog();
			this.colorDlg = new System.Windows.Forms.ColorDialog();
			this.fontDlg = new System.Windows.Forms.FontDialog();
			this.폰트설정ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.글꼴ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.색상ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.msBar.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pbPreview)).BeginInit();
			this.SuspendLayout();
			// 
			// msBar
			// 
			this.msBar.ImageScalingSize = new System.Drawing.Size(24, 24);
			this.msBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.폰트설정ToolStripMenuItem});
			this.msBar.Location = new System.Drawing.Point(0, 0);
			this.msBar.Name = "msBar";
			this.msBar.Size = new System.Drawing.Size(698, 33);
			this.msBar.TabIndex = 0;
			this.msBar.Text = "menuStrip1";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(30, 50);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(56, 18);
			this.label1.TabIndex = 1;
			this.label1.Text = "배  경";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(30, 90);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(56, 18);
			this.label2.TabIndex = 2;
			this.label2.Text = "마  킹";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(30, 135);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(62, 18);
			this.label3.TabIndex = 3;
			this.label3.Text = "투명도";
			// 
			// tbBackground
			// 
			this.tbBackground.Location = new System.Drawing.Point(100, 43);
			this.tbBackground.Name = "tbBackground";
			this.tbBackground.Size = new System.Drawing.Size(419, 28);
			this.tbBackground.TabIndex = 4;
			// 
			// tbMarking
			// 
			this.tbMarking.Location = new System.Drawing.Point(100, 84);
			this.tbMarking.Name = "tbMarking";
			this.tbMarking.Size = new System.Drawing.Size(419, 28);
			this.tbMarking.TabIndex = 5;
			// 
			// btnBackground
			// 
			this.btnBackground.Location = new System.Drawing.Point(544, 43);
			this.btnBackground.Name = "btnBackground";
			this.btnBackground.Size = new System.Drawing.Size(120, 30);
			this.btnBackground.TabIndex = 6;
			this.btnBackground.Text = "배경파일";
			this.btnBackground.UseVisualStyleBackColor = true;
			this.btnBackground.Click += new System.EventHandler(this.btnBackground_Click);
			// 
			// btnPreview
			// 
			this.btnPreview.Location = new System.Drawing.Point(544, 84);
			this.btnPreview.Name = "btnPreview";
			this.btnPreview.Size = new System.Drawing.Size(120, 30);
			this.btnPreview.TabIndex = 7;
			this.btnPreview.Text = "미리보기";
			this.btnPreview.UseVisualStyleBackColor = true;
			this.btnPreview.Click += new System.EventHandler(this.btnPreview_Click);
			// 
			// btnSave
			// 
			this.btnSave.Location = new System.Drawing.Point(544, 123);
			this.btnSave.Name = "btnSave";
			this.btnSave.Size = new System.Drawing.Size(120, 30);
			this.btnSave.TabIndex = 8;
			this.btnSave.Text = "저장하기";
			this.btnSave.UseVisualStyleBackColor = true;
			this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
			// 
			// pbPreview
			// 
			this.pbPreview.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.pbPreview.Location = new System.Drawing.Point(33, 187);
			this.pbPreview.Name = "pbPreview";
			this.pbPreview.Size = new System.Drawing.Size(631, 496);
			this.pbPreview.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pbPreview.TabIndex = 9;
			this.pbPreview.TabStop = false;
			// 
			// hsbOpacity
			// 
			this.hsbOpacity.Location = new System.Drawing.Point(101, 127);
			this.hsbOpacity.Name = "hsbOpacity";
			this.hsbOpacity.Size = new System.Drawing.Size(418, 26);
			this.hsbOpacity.TabIndex = 10;
			this.hsbOpacity.Value = 50;
			// 
			// ofDlg
			// 
			this.ofDlg.FileName = "ofd";
			this.ofDlg.Filter = "JPEG Image(*.jpg,*.jpeg)|*.jpg;*.jpeg|GIF Image(*.gif)|*.gif|Bitmap Image(*.bmp)|" +
    "*.bmp|All Image Format|*.jpg;*jpeg;*.gif;*.bmp";
			// 
			// sfDlg
			// 
			this.sfDlg.Filter = "이미지 파일(*.jpg)|*.jpg";
			// 
			// 폰트설정ToolStripMenuItem
			// 
			this.폰트설정ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.글꼴ToolStripMenuItem,
            this.색상ToolStripMenuItem});
			this.폰트설정ToolStripMenuItem.Name = "폰트설정ToolStripMenuItem";
			this.폰트설정ToolStripMenuItem.Size = new System.Drawing.Size(102, 29);
			this.폰트설정ToolStripMenuItem.Text = "폰트 설정";
			// 
			// 글꼴ToolStripMenuItem
			// 
			this.글꼴ToolStripMenuItem.Name = "글꼴ToolStripMenuItem";
			this.글꼴ToolStripMenuItem.Size = new System.Drawing.Size(210, 30);
			this.글꼴ToolStripMenuItem.Text = "글꼴";
			this.글꼴ToolStripMenuItem.Click += new System.EventHandler(this.글꼴ToolStripMenuItem_Click);
			// 
			// 색상ToolStripMenuItem
			// 
			this.색상ToolStripMenuItem.Name = "색상ToolStripMenuItem";
			this.색상ToolStripMenuItem.Size = new System.Drawing.Size(210, 30);
			this.색상ToolStripMenuItem.Text = "색상";
			this.색상ToolStripMenuItem.Click += new System.EventHandler(this.색상ToolStripMenuItem_Click);
			// 
			// Form3
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(698, 731);
			this.Controls.Add(this.hsbOpacity);
			this.Controls.Add(this.pbPreview);
			this.Controls.Add(this.btnSave);
			this.Controls.Add(this.btnPreview);
			this.Controls.Add(this.btnBackground);
			this.Controls.Add(this.tbMarking);
			this.Controls.Add(this.tbBackground);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.msBar);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.MainMenuStrip = this.msBar;
			this.MaximizeBox = false;
			this.Name = "Form3";
			this.Text = "워터 마킹";
			this.msBar.ResumeLayout(false);
			this.msBar.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pbPreview)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.MenuStrip msBar;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox tbBackground;
		private System.Windows.Forms.TextBox tbMarking;
		private System.Windows.Forms.Button btnBackground;
		private System.Windows.Forms.Button btnPreview;
		private System.Windows.Forms.Button btnSave;
		private System.Windows.Forms.PictureBox pbPreview;
		private System.Windows.Forms.HScrollBar hsbOpacity;
		private System.Windows.Forms.OpenFileDialog ofDlg;
		private System.Windows.Forms.SaveFileDialog sfDlg;
		private System.Windows.Forms.ColorDialog colorDlg;
		private System.Windows.Forms.FontDialog fontDlg;
		private System.Windows.Forms.ToolStripMenuItem 폰트설정ToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem 글꼴ToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem 색상ToolStripMenuItem;
	}
}