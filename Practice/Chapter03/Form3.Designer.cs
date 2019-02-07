namespace Chapter03
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
			this.tlsMenu = new System.Windows.Forms.ToolStrip();
			this.fontDlg = new System.Windows.Forms.FontDialog();
			this.colorDlg = new System.Windows.Forms.ColorDialog();
			this.rtbText = new System.Windows.Forms.RichTextBox();
			this.tsBtnFont = new System.Windows.Forms.ToolStripButton();
			this.tsBtnColor = new System.Windows.Forms.ToolStripButton();
			this.tlsMenu.SuspendLayout();
			this.SuspendLayout();
			// 
			// tlsMenu
			// 
			this.tlsMenu.ImageScalingSize = new System.Drawing.Size(24, 24);
			this.tlsMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsBtnFont,
            this.tsBtnColor});
			this.tlsMenu.Location = new System.Drawing.Point(0, 0);
			this.tlsMenu.Name = "tlsMenu";
			this.tlsMenu.Size = new System.Drawing.Size(578, 31);
			this.tlsMenu.TabIndex = 0;
			this.tlsMenu.Text = "toolStrip1";
			// 
			// rtbText
			// 
			this.rtbText.Dock = System.Windows.Forms.DockStyle.Fill;
			this.rtbText.Location = new System.Drawing.Point(0, 31);
			this.rtbText.Name = "rtbText";
			this.rtbText.Size = new System.Drawing.Size(578, 313);
			this.rtbText.TabIndex = 1;
			this.rtbText.Text = "";
			// 
			// tsBtnFont
			// 
			this.tsBtnFont.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.tsBtnFont.Image = ((System.Drawing.Image)(resources.GetObject("tsBtnFont.Image")));
			this.tsBtnFont.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.tsBtnFont.Name = "tsBtnFont";
			this.tsBtnFont.Size = new System.Drawing.Size(28, 28);
			this.tsBtnFont.Text = "toolStripButton1";
			this.tsBtnFont.Click += new System.EventHandler(this.tsBtnFont_Click);
			// 
			// tsBtnColor
			// 
			this.tsBtnColor.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.tsBtnColor.Image = ((System.Drawing.Image)(resources.GetObject("tsBtnColor.Image")));
			this.tsBtnColor.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.tsBtnColor.Name = "tsBtnColor";
			this.tsBtnColor.Size = new System.Drawing.Size(28, 28);
			this.tsBtnColor.Text = "toolStripButton2";
			this.tsBtnColor.Click += new System.EventHandler(this.tsBtnColor_Click);
			// 
			// Form3
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(578, 344);
			this.Controls.Add(this.rtbText);
			this.Controls.Add(this.tlsMenu);
			this.Name = "Form3";
			this.Text = "폰트 꾸미기";
			this.tlsMenu.ResumeLayout(false);
			this.tlsMenu.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.ToolStrip tlsMenu;
		private System.Windows.Forms.ToolStripButton tsBtnFont;
		private System.Windows.Forms.ToolStripButton tsBtnColor;
		private System.Windows.Forms.FontDialog fontDlg;
		private System.Windows.Forms.ColorDialog colorDlg;
		private System.Windows.Forms.RichTextBox rtbText;
	}
}