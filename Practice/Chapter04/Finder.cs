using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chapter04
{
	public partial class Finder : Form
	{
		public Finder()
		{
			InitializeComponent();
		}

		private void tbWord_TextChanged( object sender, EventArgs e )
		{
			if( "" == tbWord.Text )
				btnOk.Enabled = false;
			else
				btnOk.Enabled = true;
		}

		private void btnCancel_Click( object sender, EventArgs e )
		{
			Close();
		}
	}
}
