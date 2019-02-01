namespace Chapter02
{
	partial class Form2
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
			this.gbType = new System.Windows.Forms.GroupBox();
			this.gbIcon = new System.Windows.Forms.GroupBox();
			this.rbOk = new System.Windows.Forms.RadioButton();
			this.rbOkCancel = new System.Windows.Forms.RadioButton();
			this.rbYesNo = new System.Windows.Forms.RadioButton();
			this.rbError = new System.Windows.Forms.RadioButton();
			this.rbInformation = new System.Windows.Forms.RadioButton();
			this.rbQuestion = new System.Windows.Forms.RadioButton();
			this.btnShow = new System.Windows.Forms.Button();
			this.gbType.SuspendLayout();
			this.gbIcon.SuspendLayout();
			this.SuspendLayout();
			// 
			// gbType
			// 
			this.gbType.Controls.Add(this.rbOk);
			this.gbType.Controls.Add(this.rbOkCancel);
			this.gbType.Controls.Add(this.rbYesNo);
			this.gbType.Location = new System.Drawing.Point(20, 20);
			this.gbType.Name = "gbType";
			this.gbType.Size = new System.Drawing.Size(200, 200);
			this.gbType.TabIndex = 0;
			this.gbType.TabStop = false;
			this.gbType.Text = "Type";
			// 
			// gbIcon
			// 
			this.gbIcon.Controls.Add(this.rbError);
			this.gbIcon.Controls.Add(this.rbQuestion);
			this.gbIcon.Controls.Add(this.rbInformation);
			this.gbIcon.Location = new System.Drawing.Point(250, 20);
			this.gbIcon.Name = "gbIcon";
			this.gbIcon.Size = new System.Drawing.Size(200, 200);
			this.gbIcon.TabIndex = 1;
			this.gbIcon.TabStop = false;
			this.gbIcon.Text = "Icon";
			// 
			// rbOk
			// 
			this.rbOk.AutoSize = true;
			this.rbOk.Location = new System.Drawing.Point(25, 40);
			this.rbOk.Name = "rbOk";
			this.rbOk.Size = new System.Drawing.Size(55, 22);
			this.rbOk.TabIndex = 2;
			this.rbOk.TabStop = true;
			this.rbOk.Text = "Ok";
			this.rbOk.UseVisualStyleBackColor = true;
			// 
			// rbOkCancel
			// 
			this.rbOkCancel.AutoSize = true;
			this.rbOkCancel.Location = new System.Drawing.Point(25, 95);
			this.rbOkCancel.Name = "rbOkCancel";
			this.rbOkCancel.Size = new System.Drawing.Size(110, 22);
			this.rbOkCancel.TabIndex = 3;
			this.rbOkCancel.TabStop = true;
			this.rbOkCancel.Text = "OkCancel";
			this.rbOkCancel.UseVisualStyleBackColor = true;
			// 
			// rbYesNo
			// 
			this.rbYesNo.AutoSize = true;
			this.rbYesNo.Location = new System.Drawing.Point(25, 150);
			this.rbYesNo.Name = "rbYesNo";
			this.rbYesNo.Size = new System.Drawing.Size(87, 22);
			this.rbYesNo.TabIndex = 4;
			this.rbYesNo.TabStop = true;
			this.rbYesNo.Text = "YesNo";
			this.rbYesNo.UseVisualStyleBackColor = true;
			// 
			// rbError
			// 
			this.rbError.AutoSize = true;
			this.rbError.Location = new System.Drawing.Point(25, 40);
			this.rbError.Name = "rbError";
			this.rbError.Size = new System.Drawing.Size(73, 22);
			this.rbError.TabIndex = 5;
			this.rbError.TabStop = true;
			this.rbError.Text = "Error";
			this.rbError.UseVisualStyleBackColor = true;
			// 
			// rbInformation
			// 
			this.rbInformation.AutoSize = true;
			this.rbInformation.Location = new System.Drawing.Point(25, 95);
			this.rbInformation.Name = "rbInformation";
			this.rbInformation.Size = new System.Drawing.Size(122, 22);
			this.rbInformation.TabIndex = 6;
			this.rbInformation.TabStop = true;
			this.rbInformation.Text = "Information";
			this.rbInformation.UseVisualStyleBackColor = true;
			// 
			// rbQuestion
			// 
			this.rbQuestion.AutoSize = true;
			this.rbQuestion.Location = new System.Drawing.Point(25, 150);
			this.rbQuestion.Name = "rbQuestion";
			this.rbQuestion.Size = new System.Drawing.Size(105, 22);
			this.rbQuestion.TabIndex = 7;
			this.rbQuestion.TabStop = true;
			this.rbQuestion.Text = "Question";
			this.rbQuestion.UseVisualStyleBackColor = true;
			// 
			// btnShow
			// 
			this.btnShow.Location = new System.Drawing.Point(176, 251);
			this.btnShow.Name = "btnShow";
			this.btnShow.Size = new System.Drawing.Size(100, 30);
			this.btnShow.TabIndex = 8;
			this.btnShow.Text = "Show";
			this.btnShow.UseVisualStyleBackColor = true;
			this.btnShow.Click += new System.EventHandler(this.btnShow_Click);
			// 
			// Form2
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(468, 294);
			this.Controls.Add(this.btnShow);
			this.Controls.Add(this.gbIcon);
			this.Controls.Add(this.gbType);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.MaximizeBox = false;
			this.Name = "Form2";
			this.Text = "메세지 박스 보기";
			this.gbType.ResumeLayout(false);
			this.gbType.PerformLayout();
			this.gbIcon.ResumeLayout(false);
			this.gbIcon.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.GroupBox gbType;
		private System.Windows.Forms.RadioButton rbOk;
		private System.Windows.Forms.RadioButton rbOkCancel;
		private System.Windows.Forms.RadioButton rbYesNo;
		private System.Windows.Forms.GroupBox gbIcon;
		private System.Windows.Forms.RadioButton rbError;
		private System.Windows.Forms.RadioButton rbQuestion;
		private System.Windows.Forms.RadioButton rbInformation;
		private System.Windows.Forms.Button btnShow;
	}
}