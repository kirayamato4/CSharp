namespace Chapter02
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
			this.lbView = new System.Windows.Forms.ListBox();
			this.tbList = new System.Windows.Forms.TextBox();
			this.btnAdd = new System.Windows.Forms.Button();
			this.lbResult = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// lbView
			// 
			this.lbView.FormattingEnabled = true;
			this.lbView.ItemHeight = 18;
			this.lbView.Location = new System.Drawing.Point(12, 30);
			this.lbView.Name = "lbView";
			this.lbView.Size = new System.Drawing.Size(200, 292);
			this.lbView.TabIndex = 0;
			this.lbView.SelectedIndexChanged += new System.EventHandler(this.lbView_SelectedIndexChanged);
			// 
			// tbList
			// 
			this.tbList.Location = new System.Drawing.Point(259, 30);
			this.tbList.Name = "tbList";
			this.tbList.Size = new System.Drawing.Size(150, 28);
			this.tbList.TabIndex = 1;
			// 
			// btnAdd
			// 
			this.btnAdd.Location = new System.Drawing.Point(259, 98);
			this.btnAdd.Name = "btnAdd";
			this.btnAdd.Size = new System.Drawing.Size(150, 40);
			this.btnAdd.TabIndex = 2;
			this.btnAdd.Text = "추가";
			this.btnAdd.UseVisualStyleBackColor = true;
			this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
			// 
			// lbResult
			// 
			this.lbResult.AutoSize = true;
			this.lbResult.Location = new System.Drawing.Point(12, 385);
			this.lbResult.Name = "lbResult";
			this.lbResult.Size = new System.Drawing.Size(62, 18);
			this.lbResult.TabIndex = 3;
			this.lbResult.Text = "결과 : ";
			// 
			// Form5
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(440, 432);
			this.Controls.Add(this.lbResult);
			this.Controls.Add(this.btnAdd);
			this.Controls.Add(this.tbList);
			this.Controls.Add(this.lbView);
			this.Name = "Form5";
			this.Text = "Form5";
			this.Load += new System.EventHandler(this.Form5_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.ListBox lbView;
		private System.Windows.Forms.TextBox tbList;
		private System.Windows.Forms.Button btnAdd;
		private System.Windows.Forms.Label lbResult;
	}
}