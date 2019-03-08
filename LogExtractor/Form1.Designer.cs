namespace LogExtractor
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
            this.fbDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.tbExtractPath = new System.Windows.Forms.TextBox();
            this.btnExtract = new System.Windows.Forms.Button();
            this.btnLog = new System.Windows.Forms.Button();
            this.tbLogPath = new System.Windows.Forms.TextBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.tssLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.lbFileName = new System.Windows.Forms.Label();
            this.lvFolder = new System.Windows.Forms.ListView();
            this.chFileName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cbExtension = new System.Windows.Forms.ComboBox();
            this.labelExtension = new System.Windows.Forms.Label();
            this.tbExtension = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbExtractPath
            // 
            this.tbExtractPath.Location = new System.Drawing.Point(130, 57);
            this.tbExtractPath.Name = "tbExtractPath";
            this.tbExtractPath.ReadOnly = true;
            this.tbExtractPath.Size = new System.Drawing.Size(400, 25);
            this.tbExtractPath.TabIndex = 4;
            // 
            // btnExtract
            // 
            this.btnExtract.Location = new System.Drawing.Point(14, 55);
            this.btnExtract.Name = "btnExtract";
            this.btnExtract.Size = new System.Drawing.Size(100, 30);
            this.btnExtract.TabIndex = 5;
            this.btnExtract.Text = "추출 경로";
            this.btnExtract.UseVisualStyleBackColor = true;
            this.btnExtract.Click += new System.EventHandler(this.btnExtract_Click);
            // 
            // btnLog
            // 
            this.btnLog.Location = new System.Drawing.Point(14, 12);
            this.btnLog.Name = "btnLog";
            this.btnLog.Size = new System.Drawing.Size(100, 30);
            this.btnLog.TabIndex = 7;
            this.btnLog.Text = "로그 경로";
            this.btnLog.UseVisualStyleBackColor = true;
            this.btnLog.Click += new System.EventHandler(this.btnLog_Click);
            // 
            // tbLogPath
            // 
            this.tbLogPath.Location = new System.Drawing.Point(130, 14);
            this.tbLogPath.Name = "tbLogPath";
            this.tbLogPath.ReadOnly = true;
            this.tbLogPath.Size = new System.Drawing.Size(400, 25);
            this.tbLogPath.TabIndex = 6;
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tssLabel});
            this.statusStrip1.Location = new System.Drawing.Point(0, 528);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(545, 25);
            this.statusStrip1.TabIndex = 8;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // tssLabel
            // 
            this.tssLabel.Name = "tssLabel";
            this.tssLabel.Size = new System.Drawing.Size(102, 20);
            this.tssLabel.Text = "상태 : 대기 중";
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(14, 480);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(516, 30);
            this.progressBar.TabIndex = 9;
            // 
            // lbFileName
            // 
            this.lbFileName.AutoSize = true;
            this.lbFileName.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lbFileName.Location = new System.Drawing.Point(14, 460);
            this.lbFileName.Name = "lbFileName";
            this.lbFileName.Size = new System.Drawing.Size(67, 15);
            this.lbFileName.TabIndex = 10;
            this.lbFileName.Text = "파일명 : ";
            // 
            // lvFolder
            // 
            this.lvFolder.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chFileName});
            this.lvFolder.GridLines = true;
            this.lvFolder.Location = new System.Drawing.Point(14, 136);
            this.lvFolder.Name = "lvFolder";
            this.lvFolder.Size = new System.Drawing.Size(516, 308);
            this.lvFolder.TabIndex = 11;
            this.lvFolder.UseCompatibleStateImageBehavior = false;
            this.lvFolder.View = System.Windows.Forms.View.Details;
            // 
            // chFileName
            // 
            this.chFileName.Text = "파일명";
            this.chFileName.Width = 516;
            // 
            // cbExtension
            // 
            this.cbExtension.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbExtension.FormattingEnabled = true;
            this.cbExtension.Items.AddRange(new object[] {
            "log",
            "txt",
            "s",
            "입력"});
            this.cbExtension.Location = new System.Drawing.Point(84, 95);
            this.cbExtension.Name = "cbExtension";
            this.cbExtension.Size = new System.Drawing.Size(80, 23);
            this.cbExtension.TabIndex = 12;
            this.cbExtension.SelectedIndexChanged += new System.EventHandler(this.cbExtension_SelectedIndexChanged);
            // 
            // labelExtension
            // 
            this.labelExtension.AutoSize = true;
            this.labelExtension.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.labelExtension.Location = new System.Drawing.Point(16, 103);
            this.labelExtension.Name = "labelExtension";
            this.labelExtension.Size = new System.Drawing.Size(52, 15);
            this.labelExtension.TabIndex = 13;
            this.labelExtension.Text = "확장자";
            // 
            // tbExtension
            // 
            this.tbExtension.Enabled = false;
            this.tbExtension.Location = new System.Drawing.Point(277, 96);
            this.tbExtension.MaxLength = 12;
            this.tbExtension.Name = "tbExtension";
            this.tbExtension.Size = new System.Drawing.Size(120, 25);
            this.tbExtension.TabIndex = 14;
            this.tbExtension.TextChanged += new System.EventHandler(this.tbExtension_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.Location = new System.Drawing.Point(184, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 15);
            this.label2.TabIndex = 15;
            this.label2.Text = "확장자 입력";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(423, 95);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(90, 30);
            this.button1.TabIndex = 16;
            this.button1.Text = "추출하기";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(545, 553);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbExtension);
            this.Controls.Add(this.labelExtension);
            this.Controls.Add(this.cbExtension);
            this.Controls.Add(this.lvFolder);
            this.Controls.Add(this.lbFileName);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.btnLog);
            this.Controls.Add(this.tbLogPath);
            this.Controls.Add(this.btnExtract);
            this.Controls.Add(this.tbExtractPath);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.Text = "LogExtractor";
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.FolderBrowserDialog fbDialog;
        private System.Windows.Forms.TextBox tbExtractPath;
        private System.Windows.Forms.Button btnExtract;
        private System.Windows.Forms.Button btnLog;
        private System.Windows.Forms.TextBox tbLogPath;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel tssLabel;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.Label lbFileName;
        private System.Windows.Forms.ListView lvFolder;
        private System.Windows.Forms.ColumnHeader chFileName;
        private System.Windows.Forms.ComboBox cbExtension;
        private System.Windows.Forms.Label labelExtension;
        private System.Windows.Forms.TextBox tbExtension;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
    }
}

