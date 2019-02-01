namespace Chapter02
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
			this.cbList = new System.Windows.Forms.ComboBox();
			this.txtList = new System.Windows.Forms.TextBox();
			this.btnAdd = new System.Windows.Forms.Button();
			this.lbResult = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// cbList
			// 
			this.cbList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbList.FormattingEnabled = true;
			this.cbList.Location = new System.Drawing.Point(40, 30);
			this.cbList.Name = "cbList";
			this.cbList.Size = new System.Drawing.Size(350, 26);
			this.cbList.TabIndex = 0;
			this.cbList.SelectedIndexChanged += new System.EventHandler(this.cbList_SelectedIndexChanged);
			// 
			// txtList
			// 
			this.txtList.Location = new System.Drawing.Point(40, 80);
			this.txtList.Name = "txtList";
			this.txtList.Size = new System.Drawing.Size(240, 28);
			this.txtList.TabIndex = 1;
			// 
			// btnAdd
			// 
			this.btnAdd.Font = new System.Drawing.Font("굴림", 9F);
			this.btnAdd.Location = new System.Drawing.Point(290, 80);
			this.btnAdd.Name = "btnAdd";
			this.btnAdd.Size = new System.Drawing.Size(100, 30);
			this.btnAdd.TabIndex = 2;
			this.btnAdd.Text = "추가";
			this.btnAdd.UseVisualStyleBackColor = true;
			this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
			// 
			// lbResult
			// 
			this.lbResult.AutoSize = true;
			this.lbResult.Font = new System.Drawing.Font("굴림", 9F);
			this.lbResult.Location = new System.Drawing.Point(37, 143);
			this.lbResult.Name = "lbResult";
			this.lbResult.Size = new System.Drawing.Size(104, 18);
			this.lbResult.TabIndex = 3;
			this.lbResult.Text = "선택 결과 : ";
			// 
			// Form3
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(463, 220);
			this.Controls.Add(this.lbResult);
			this.Controls.Add(this.btnAdd);
			this.Controls.Add(this.txtList);
			this.Controls.Add(this.cbList);
			this.Name = "Form3";
			this.Text = "메뉴 선택 추가";
			this.Load += new System.EventHandler(this.Form3_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.ComboBox cbList;
		private System.Windows.Forms.TextBox txtList;
		private System.Windows.Forms.Button btnAdd;
		private System.Windows.Forms.Label lbResult;
	}
}