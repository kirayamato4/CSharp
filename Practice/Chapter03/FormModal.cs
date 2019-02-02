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
	public partial class FormModal : Form
	{
		double opacity = 0.0;

		public FormModal()
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

		private void timer1_Tick(object sender, EventArgs e)
		{
			if( opacity < 100.0 )
			{
				opacity += 3.6;
				float c = Convert.ToSingle(opacity);
				float f = c / 100;
				this.Opacity = f;
			}
			else
			{
				this.Opacity = Convert.ToSingle(100 / 100);
				opacity = 0.0;
				this.timer1.Enabled = false;
			}
		}

		private void FormModal_Load(object sender, EventArgs e)
		{
			this.timer1.Enabled = true;
		}
	}
}
