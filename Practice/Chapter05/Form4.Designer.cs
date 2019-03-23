namespace Chapter05
{
	partial class Form4
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
			this.components = new System.ComponentModel.Container();
			this.graphCore = new GraphCore.GraphCore();
			this.btnBar = new System.Windows.Forms.Button();
			this.btnGraph = new System.Windows.Forms.Button();
			this.timer = new System.Windows.Forms.Timer(this.components);
			this.SuspendLayout();
			// 
			// graphCore
			// 
			this.graphCore.Location = new System.Drawing.Point(12, 12);
			this.graphCore.Name = "graphCore";
			this.graphCore.Size = new System.Drawing.Size(600, 230);
			this.graphCore.TabIndex = 0;
			// 
			// btnBar
			// 
			this.btnBar.Location = new System.Drawing.Point(387, 248);
			this.btnBar.Name = "btnBar";
			this.btnBar.Size = new System.Drawing.Size(100, 35);
			this.btnBar.TabIndex = 1;
			this.btnBar.Text = "막대";
			this.btnBar.UseVisualStyleBackColor = true;
			this.btnBar.Click += new System.EventHandler(this.btnBar_Click);
			// 
			// btnGraph
			// 
			this.btnGraph.Location = new System.Drawing.Point(512, 248);
			this.btnGraph.Name = "btnGraph";
			this.btnGraph.Size = new System.Drawing.Size(100, 35);
			this.btnGraph.TabIndex = 2;
			this.btnGraph.Text = "그래프";
			this.btnGraph.UseVisualStyleBackColor = true;
			this.btnGraph.Click += new System.EventHandler(this.btnGraph_Click);
			// 
			// timer
			// 
			this.timer.Tick += new System.EventHandler(this.timer_Tick);
			// 
			// Form4
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(628, 302);
			this.Controls.Add(this.btnGraph);
			this.Controls.Add(this.btnBar);
			this.Controls.Add(this.graphCore);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.MaximizeBox = false;
			this.Name = "Form4";
			this.Text = "그래프 그리기";
			this.Load += new System.EventHandler(this.Form4_Load);
			this.ResumeLayout(false);

		}

		#endregion

		private GraphCore.GraphCore graphCore;
		private System.Windows.Forms.Button btnBar;
		private System.Windows.Forms.Button btnGraph;
		private System.Windows.Forms.Timer timer;
	}
}