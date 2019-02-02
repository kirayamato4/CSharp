namespace Chapter02
{
	partial class Form7
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
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form7));
			this.picImage = new System.Windows.Forms.PictureBox();
			this.imgList = new System.Windows.Forms.ImageList(this.components);
			this.btnNext = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.picImage)).BeginInit();
			this.SuspendLayout();
			// 
			// picImage
			// 
			this.picImage.Location = new System.Drawing.Point(62, 41);
			this.picImage.Name = "picImage";
			this.picImage.Size = new System.Drawing.Size(250, 100);
			this.picImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.picImage.TabIndex = 0;
			this.picImage.TabStop = false;
			// 
			// imgList
			// 
			this.imgList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imgList.ImageStream")));
			this.imgList.TransparentColor = System.Drawing.Color.Transparent;
			this.imgList.Images.SetKeyName(0, "strike.jpg");
			this.imgList.Images.SetKeyName(1, "prinny.jpg");
			this.imgList.Images.SetKeyName(2, "pizza.jpg");
			// 
			// btnNext
			// 
			this.btnNext.Location = new System.Drawing.Point(126, 166);
			this.btnNext.Name = "btnNext";
			this.btnNext.Size = new System.Drawing.Size(120, 30);
			this.btnNext.TabIndex = 1;
			this.btnNext.Text = "다음";
			this.btnNext.UseVisualStyleBackColor = true;
			this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
			// 
			// Form7
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.Info;
			this.ClientSize = new System.Drawing.Size(378, 244);
			this.Controls.Add(this.btnNext);
			this.Controls.Add(this.picImage);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.MaximizeBox = false;
			this.Name = "Form7";
			this.Text = "그림 보기";
			this.Load += new System.EventHandler(this.Form7_Load);
			((System.ComponentModel.ISupportInitialize)(this.picImage)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.PictureBox picImage;
		private System.Windows.Forms.ImageList imgList;
		private System.Windows.Forms.Button btnNext;
	}
}