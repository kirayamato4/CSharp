using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chapter03
{
	public partial class FormModaless : Form
	{
		public FormModaless()
		{
			InitializeComponent();
		}

		public string SetText
		{
			set
			{
				this.Text = value;
			}
		}

		private void FormModaless_Load(object sender, EventArgs e)
		{
			this.Opacity = Convert.ToSingle(100 / 100);
			this.timer1.Enabled = true;
		}

		private void timer1_Tick(object sender, EventArgs e)
		{
			if (this.Size.Width > 300 && this.Size.Height > 300)
				this.timer1.Enabled = false;
			else
				this.Size += new Size(5, 5);
		}
	}
}
