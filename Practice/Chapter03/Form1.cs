﻿using System;
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
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void VisibleChange( bool formVisible, bool taryIconVisible )
		{
			this.Visible = formVisible;
			this.nfiTray.Visible = taryIconVisible;
		}

		private void btnTray_Click(object sender, EventArgs e)
		{
			VisibleChange(false, true);
		}

		private void Form1_FormClosing(object sender, FormClosingEventArgs e)
		{
			e.Cancel = true;
			VisibleChange(false, true);
		}

		private void 폼보이기ToolStripMenuItem_Click(object sender, EventArgs e)
		{
			VisibleChange(true, false);
		}

		private void nfiTray_DoubleClick(object sender, EventArgs e)
		{
			VisibleChange(true, false);
		}

		private void 종료ToolStripMenuItem_Click(object sender, EventArgs e)
		{
			this.nfiTray.Visible = false;
			Application.ExitThread();
		}
	}
}
