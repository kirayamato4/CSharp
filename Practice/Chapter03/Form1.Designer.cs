﻿namespace Chapter03
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
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form 디자이너에서 생성한 코드

		/// <summary>
		/// 디자이너 지원에 필요한 메서드입니다. 
		/// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
			this.btnTray = new System.Windows.Forms.Button();
			this.nfiTray = new System.Windows.Forms.NotifyIcon(this.components);
			this.cmMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.폼보이기ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.종료ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.cmMenu.SuspendLayout();
			this.SuspendLayout();
			// 
			// btnTray
			// 
			this.btnTray.Location = new System.Drawing.Point(217, 206);
			this.btnTray.Name = "btnTray";
			this.btnTray.Size = new System.Drawing.Size(150, 35);
			this.btnTray.TabIndex = 0;
			this.btnTray.Text = "트레이 이동";
			this.btnTray.UseVisualStyleBackColor = true;
			this.btnTray.Click += new System.EventHandler(this.btnTray_Click);
			// 
			// nfiTray
			// 
			this.nfiTray.ContextMenuStrip = this.cmMenu;
			this.nfiTray.Icon = ((System.Drawing.Icon)(resources.GetObject("nfiTray.Icon")));
			this.nfiTray.Text = "트레이 아이콘";
			this.nfiTray.Visible = true;
			this.nfiTray.DoubleClick += new System.EventHandler(this.nfiTray_DoubleClick);
			// 
			// cmMenu
			// 
			this.cmMenu.ImageScalingSize = new System.Drawing.Size(24, 24);
			this.cmMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.폼보이기ToolStripMenuItem,
            this.종료ToolStripMenuItem});
			this.cmMenu.Name = "cmMenu";
			this.cmMenu.Size = new System.Drawing.Size(199, 97);
			// 
			// 폼보이기ToolStripMenuItem
			// 
			this.폼보이기ToolStripMenuItem.Name = "폼보이기ToolStripMenuItem";
			this.폼보이기ToolStripMenuItem.Size = new System.Drawing.Size(198, 30);
			this.폼보이기ToolStripMenuItem.Text = "폼 보이기";
			this.폼보이기ToolStripMenuItem.Click += new System.EventHandler(this.폼보이기ToolStripMenuItem_Click);
			// 
			// 종료ToolStripMenuItem
			// 
			this.종료ToolStripMenuItem.Name = "종료ToolStripMenuItem";
			this.종료ToolStripMenuItem.Size = new System.Drawing.Size(198, 30);
			this.종료ToolStripMenuItem.Text = "종료";
			this.종료ToolStripMenuItem.Click += new System.EventHandler(this.종료ToolStripMenuItem_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(637, 512);
			this.Controls.Add(this.btnTray);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.MaximizeBox = false;
			this.Name = "Form1";
			this.Text = "트레이 아이콘";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
			this.cmMenu.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button btnTray;
		private System.Windows.Forms.NotifyIcon nfiTray;
		private System.Windows.Forms.ContextMenuStrip cmMenu;
		private System.Windows.Forms.ToolStripMenuItem 폼보이기ToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem 종료ToolStripMenuItem;
	}
}

