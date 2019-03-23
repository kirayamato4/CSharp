using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chapter05
{
	public partial class Form4 : Form
	{
		Random random = new Random();

		public Form4()
		{
			InitializeComponent();

			timer.Start();
		}

		private void Form4_Load( object sender, EventArgs e )
		{
			graphCore._openType = GraphCore.ChartControlOpenType.Bar;
		}

		private void btnBar_Click( object sender, EventArgs e )
		{
			graphCore._openType = GraphCore.ChartControlOpenType.Bar;
		}

		private void btnGraph_Click( object sender, EventArgs e )
		{
			graphCore._openType = GraphCore.ChartControlOpenType.Graph;
		}

		private void timer_Tick( object sender, EventArgs e )
		{
			double valueAdd;
			int n = random.Next( 1, 45 );
			int s = random.Next( 1, 3 );

			try
			{
				if( s / 2 == 0 )
					valueAdd = Convert.ToDouble( n );
				else
					valueAdd = Convert.ToDouble( -n );

				graphCore.AddValue( (float)valueAdd );
				graphCore.Refresh();
			}
			catch
			{
				return;
			}
		}
	}
}
