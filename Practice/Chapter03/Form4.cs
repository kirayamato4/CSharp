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
	public partial class Form4 : Form
	{
		public Form4()
		{
			InitializeComponent();
		}

		private void btnMsg_Click(object sender, EventArgs e)
		{
			TrayForm form = new TrayForm();

			form.MsgText = tbMsg.Text;
			form.ShowDialog();
		}
	}
}
