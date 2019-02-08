namespace Chapter03
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form5));
			this.lbURL = new System.Windows.Forms.Label();
			this.tbURL = new System.Windows.Forms.TextBox();
			this.btnFolder = new System.Windows.Forms.Button();
			this.btnDownload = new System.Windows.Forms.Button();
			this.cbOpen = new System.Windows.Forms.CheckBox();
			this.pbDownload = new System.Windows.Forms.ProgressBar();
			this.fbdFile = new System.Windows.Forms.FolderBrowserDialog();
			this.webClient = new System.Net.WebClient();
			this.SuspendLayout();
			// 
			// lbURL
			// 
			this.lbURL.AutoSize = true;
			this.lbURL.Font = new System.Drawing.Font("Bitstream Vera Sans Mono", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbURL.Location = new System.Drawing.Point(25, 29);
			this.lbURL.Name = "lbURL";
			this.lbURL.Size = new System.Drawing.Size(65, 35);
			this.lbURL.TabIndex = 0;
			this.lbURL.Text = "주소";
			// 
			// tbURL
			// 
			this.tbURL.Location = new System.Drawing.Point(96, 34);
			this.tbURL.Name = "tbURL";
			this.tbURL.Size = new System.Drawing.Size(400, 28);
			this.tbURL.TabIndex = 1;
			// 
			// btnFolder
			// 
			this.btnFolder.Location = new System.Drawing.Point(640, 34);
			this.btnFolder.Name = "btnFolder";
			this.btnFolder.Size = new System.Drawing.Size(120, 30);
			this.btnFolder.TabIndex = 2;
			this.btnFolder.Text = "폴더";
			this.btnFolder.UseVisualStyleBackColor = true;
			this.btnFolder.Click += new System.EventHandler(this.btnFolder_Click);
			// 
			// btnDownload
			// 
			this.btnDownload.Enabled = false;
			this.btnDownload.Location = new System.Drawing.Point(514, 34);
			this.btnDownload.Name = "btnDownload";
			this.btnDownload.Size = new System.Drawing.Size(120, 30);
			this.btnDownload.TabIndex = 3;
			this.btnDownload.Text = "다운로드";
			this.btnDownload.UseVisualStyleBackColor = true;
			this.btnDownload.Click += new System.EventHandler(this.btnDownload_Click);
			// 
			// cbOpen
			// 
			this.cbOpen.AutoSize = true;
			this.cbOpen.Location = new System.Drawing.Point(778, 39);
			this.cbOpen.Name = "cbOpen";
			this.cbOpen.Size = new System.Drawing.Size(88, 22);
			this.cbOpen.TabIndex = 4;
			this.cbOpen.Text = "창열기";
			this.cbOpen.UseVisualStyleBackColor = true;
			// 
			// pbDownload
			// 
			this.pbDownload.Location = new System.Drawing.Point(48, 86);
			this.pbDownload.Name = "pbDownload";
			this.pbDownload.Size = new System.Drawing.Size(800, 30);
			this.pbDownload.TabIndex = 5;
			// 
			// webClient
			// 
			this.webClient.BaseAddress = "";
			this.webClient.CachePolicy = null;
			this.webClient.Credentials = null;
			this.webClient.Encoding = ((System.Text.Encoding)(resources.GetObject("webClient.Encoding")));
			this.webClient.Headers = ((System.Net.WebHeaderCollection)(resources.GetObject("webClient.Headers")));
			this.webClient.QueryString = ((System.Collections.Specialized.NameValueCollection)(resources.GetObject("webClient.QueryString")));
			this.webClient.UseDefaultCredentials = false;
			this.webClient.DownloadFileCompleted += new System.ComponentModel.AsyncCompletedEventHandler(this.webClient_DownloadFileCompleted);
			this.webClient.DownloadProgressChanged += new System.Net.DownloadProgressChangedEventHandler(this.webClient_DownloadProgressChanged);
			// 
			// Form5
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(878, 144);
			this.Controls.Add(this.pbDownload);
			this.Controls.Add(this.cbOpen);
			this.Controls.Add(this.btnDownload);
			this.Controls.Add(this.btnFolder);
			this.Controls.Add(this.tbURL);
			this.Controls.Add(this.lbURL);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.MaximizeBox = false;
			this.Name = "Form5";
			this.Text = "웹 다운로드";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label lbURL;
		private System.Windows.Forms.TextBox tbURL;
		private System.Windows.Forms.Button btnFolder;
		private System.Windows.Forms.Button btnDownload;
		private System.Windows.Forms.CheckBox cbOpen;
		private System.Windows.Forms.ProgressBar pbDownload;
		private System.Windows.Forms.FolderBrowserDialog fbdFile;
		private System.Net.WebClient webClient;
	}
}