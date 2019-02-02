namespace Chapter02
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
			this.lvView = new System.Windows.Forms.ListView();
			this.chName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.chAge = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.chWork = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.lbName = new System.Windows.Forms.Label();
			this.lbAge = new System.Windows.Forms.Label();
			this.lbWork = new System.Windows.Forms.Label();
			this.tbName = new System.Windows.Forms.TextBox();
			this.tbAge = new System.Windows.Forms.TextBox();
			this.tbWork = new System.Windows.Forms.TextBox();
			this.btnAdd = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// lvView
			// 
			this.lvView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chName,
            this.chAge,
            this.chWork});
			this.lvView.FullRowSelect = true;
			this.lvView.GridLines = true;
			this.lvView.Location = new System.Drawing.Point(35, 35);
			this.lvView.Name = "lvView";
			this.lvView.Size = new System.Drawing.Size(664, 147);
			this.lvView.TabIndex = 0;
			this.lvView.UseCompatibleStateImageBehavior = false;
			this.lvView.View = System.Windows.Forms.View.Details;
			this.lvView.Click += new System.EventHandler(this.lvView_Click);
			// 
			// chName
			// 
			this.chName.Text = "이름";
			this.chName.Width = 100;
			// 
			// chAge
			// 
			this.chAge.Text = "나이";
			this.chAge.Width = 100;
			// 
			// chWork
			// 
			this.chWork.Text = "직업";
			this.chWork.Width = 200;
			// 
			// lbName
			// 
			this.lbName.AutoSize = true;
			this.lbName.Location = new System.Drawing.Point(35, 200);
			this.lbName.Name = "lbName";
			this.lbName.Size = new System.Drawing.Size(56, 18);
			this.lbName.TabIndex = 1;
			this.lbName.Text = "이름 :";
			// 
			// lbAge
			// 
			this.lbAge.AutoSize = true;
			this.lbAge.Location = new System.Drawing.Point(35, 236);
			this.lbAge.Name = "lbAge";
			this.lbAge.Size = new System.Drawing.Size(56, 18);
			this.lbAge.TabIndex = 2;
			this.lbAge.Text = "나이 :";
			// 
			// lbWork
			// 
			this.lbWork.AutoSize = true;
			this.lbWork.Location = new System.Drawing.Point(35, 273);
			this.lbWork.Name = "lbWork";
			this.lbWork.Size = new System.Drawing.Size(56, 18);
			this.lbWork.TabIndex = 3;
			this.lbWork.Text = "직업 :";
			// 
			// tbName
			// 
			this.tbName.Location = new System.Drawing.Point(100, 200);
			this.tbName.Name = "tbName";
			this.tbName.Size = new System.Drawing.Size(150, 28);
			this.tbName.TabIndex = 4;
			// 
			// tbAge
			// 
			this.tbAge.Location = new System.Drawing.Point(100, 236);
			this.tbAge.Name = "tbAge";
			this.tbAge.Size = new System.Drawing.Size(150, 28);
			this.tbAge.TabIndex = 5;
			// 
			// tbWork
			// 
			this.tbWork.Location = new System.Drawing.Point(100, 273);
			this.tbWork.Name = "tbWork";
			this.tbWork.Size = new System.Drawing.Size(150, 28);
			this.tbWork.TabIndex = 6;
			// 
			// btnAdd
			// 
			this.btnAdd.Location = new System.Drawing.Point(599, 200);
			this.btnAdd.Name = "btnAdd";
			this.btnAdd.Size = new System.Drawing.Size(100, 30);
			this.btnAdd.TabIndex = 7;
			this.btnAdd.Text = "추가";
			this.btnAdd.UseVisualStyleBackColor = true;
			this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
			// 
			// Form6
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(732, 337);
			this.Controls.Add(this.btnAdd);
			this.Controls.Add(this.tbWork);
			this.Controls.Add(this.tbAge);
			this.Controls.Add(this.tbName);
			this.Controls.Add(this.lbWork);
			this.Controls.Add(this.lbAge);
			this.Controls.Add(this.lbName);
			this.Controls.Add(this.lvView);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.MaximizeBox = false;
			this.Name = "Form6";
			this.Text = "입력 목록 보기";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.ListView lvView;
		private System.Windows.Forms.ColumnHeader chName;
		private System.Windows.Forms.ColumnHeader chAge;
		private System.Windows.Forms.ColumnHeader chWork;
		private System.Windows.Forms.Label lbName;
		private System.Windows.Forms.Label lbAge;
		private System.Windows.Forms.Label lbWork;
		private System.Windows.Forms.TextBox tbName;
		private System.Windows.Forms.TextBox tbAge;
		private System.Windows.Forms.TextBox tbWork;
		private System.Windows.Forms.Button btnAdd;
	}
}