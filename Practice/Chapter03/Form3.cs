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
	public partial class Form3 : Form
	{
		public Form3()
		{
			InitializeComponent();
		}

		private void tsBtnFont_Click(object sender, EventArgs e)
		{
			if( fontDlg.ShowDialog() == DialogResult.OK )
			{
				rtbText.SelectionFont = fontDlg.Font;
			}
		}

		private void tsBtnColor_Click(object sender, EventArgs e)
		{
			if( colorDlg.ShowDialog() == DialogResult.OK )
			{
				rtbText.SelectionColor = colorDlg.Color;
			}
		}
	}
}
