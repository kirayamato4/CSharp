using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chapter02
{
	public partial class Form8 : Form
	{
		int status = 0;
		string result = "";

		public Form8()
		{
			InitializeComponent();
		}

		private void Form8_Load(object sender, EventArgs e)
		{
			result = this.lblStatus.Text;
		}

		private void btnRun_Click(object sender, EventArgs e)
		{
			this.timer.Enabled = true;
		}

		private void timer_Tick(object sender, EventArgs e)
		{
			++status;

			if (status > 100)
			{
				status = 0;
				this.timer.Enabled = false;
				return;
			}

			this.pbStatus.Value = status;
			this.lblStatus.Text = result + status.ToString() + "%";
				

		}
	}
}
