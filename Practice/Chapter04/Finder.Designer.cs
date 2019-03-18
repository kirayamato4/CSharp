namespace Chapter04
{
	partial class Finder
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
			this.chb = new System.Windows.Forms.CheckBox();
			this.tbWord = new System.Windows.Forms.TextBox();
			this.gbDir = new System.Windows.Forms.GroupBox();
			this.rdb01 = new System.Windows.Forms.RadioButton();
			this.rdb02 = new System.Windows.Forms.RadioButton();
			this.btnOk = new System.Windows.Forms.Button();
			this.btnCancel = new System.Windows.Forms.Button();
			this.gbDir.SuspendLayout();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(25, 25);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(86, 18);
			this.label1.TabIndex = 0;
			this.label1.Text = "찾을 내용";
			// 
			// chb
			// 
			this.chb.AutoSize = true;
			this.chb.Location = new System.Drawing.Point(28, 97);
			this.chb.Name = "chb";
			this.chb.Size = new System.Drawing.Size(156, 22);
			this.chb.TabIndex = 2;
			this.chb.Text = "대/소문자 구분";
			this.chb.UseVisualStyleBackColor = true;
			// 
			// tbWord
			// 
			this.tbWord.Location = new System.Drawing.Point(140, 22);
			this.tbWord.Name = "tbWord";
			this.tbWord.Size = new System.Drawing.Size(356, 28);
			this.tbWord.TabIndex = 3;
			this.tbWord.TextChanged += new System.EventHandler(this.tbWord_TextChanged);
			// 
			// gbDir
			// 
			this.gbDir.Controls.Add(this.rdb02);
			this.gbDir.Controls.Add(this.rdb01);
			this.gbDir.Location = new System.Drawing.Point(216, 70);
			this.gbDir.Name = "gbDir";
			this.gbDir.Size = new System.Drawing.Size(280, 74);
			this.gbDir.TabIndex = 4;
			this.gbDir.TabStop = false;
			this.gbDir.Text = "방향";
			// 
			// rdb01
			// 
			this.rdb01.AutoSize = true;
			this.rdb01.Location = new System.Drawing.Point(57, 27);
			this.rdb01.Name = "rdb01";
			this.rdb01.Size = new System.Drawing.Size(69, 22);
			this.rdb01.TabIndex = 0;
			this.rdb01.Text = "위쪽";
			this.rdb01.UseVisualStyleBackColor = true;
			// 
			// rdb02
			// 
			this.rdb02.AutoSize = true;
			this.rdb02.Checked = true;
			this.rdb02.Location = new System.Drawing.Point(160, 27);
			this.rdb02.Name = "rdb02";
			this.rdb02.Size = new System.Drawing.Size(87, 22);
			this.rdb02.TabIndex = 1;
			this.rdb02.TabStop = true;
			this.rdb02.Text = "아래쪽";
			this.rdb02.UseVisualStyleBackColor = true;
			// 
			// btnOk
			// 
			this.btnOk.Location = new System.Drawing.Point(512, 17);
			this.btnOk.Name = "btnOk";
			this.btnOk.Size = new System.Drawing.Size(120, 30);
			this.btnOk.TabIndex = 5;
			this.btnOk.Text = "다음 찾기";
			this.btnOk.UseVisualStyleBackColor = true;
			// 
			// btnCancel
			// 
			this.btnCancel.Location = new System.Drawing.Point(512, 70);
			this.btnCancel.Name = "btnCancel";
			this.btnCancel.Size = new System.Drawing.Size(120, 30);
			this.btnCancel.TabIndex = 6;
			this.btnCancel.Text = "취    소";
			this.btnCancel.UseVisualStyleBackColor = true;
			this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
			// 
			// Finder
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(644, 166);
			this.Controls.Add(this.btnCancel);
			this.Controls.Add(this.btnOk);
			this.Controls.Add(this.gbDir);
			this.Controls.Add(this.tbWord);
			this.Controls.Add(this.chb);
			this.Controls.Add(this.label1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "Finder";
			this.ShowIcon = false;
			this.ShowInTaskbar = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "찾기";
			this.TopMost = true;
			this.gbDir.ResumeLayout(false);
			this.gbDir.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.GroupBox gbDir;
		internal System.Windows.Forms.TextBox tbWord;
		internal System.Windows.Forms.Button btnOk;
		internal System.Windows.Forms.Button btnCancel;
		internal System.Windows.Forms.CheckBox chb;
		internal System.Windows.Forms.RadioButton rdb02;
		internal System.Windows.Forms.RadioButton rdb01;
	}
}