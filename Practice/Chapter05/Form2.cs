using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Diagnostics;

namespace Chapter05
{
	public partial class Form2 : Form
	{
		private PerformanceCounter oCPU = null;
		private bool bExit = false;
		private int iCPU = 0;
		Font font = null;
		private Thread checkThread = null;
		private delegate void ProcessEventHandler( int Current );
		private ProcessEventHandler resultView = null;


		public Form2()
		{
			InitializeComponent();

			oCPU = new PerformanceCounter( "Processor", "% Processor Time", "_Total" );
			font = new Font( "굴림", 12 );

		}

		private void Form2_Load( object sender, EventArgs e )
		{
			resultView = new ProcessEventHandler( Current );
			checkThread = new Thread( getCPU_Info );
			checkThread.Start();
		}

		private void Current( int Current )
		{
			Text = "CPU 사용 : " + Current.ToString() + " %";
			iCPU = Current * 3;
			panalBar.Invalidate();
		}

		private void getCPU_Info()
		{
			while( !bExit )
			{
				iCPU = (int)oCPU.NextValue();
				Invoke( resultView, iCPU );
				Thread.Sleep( 1000 );
			}
		}

		private void panalBar_Paint( object sender, PaintEventArgs e )
		{
			Graphics g = e.Graphics;

			if( iCPU <= 60 )
				g.FillRectangle( Brushes.BlanchedAlmond, 0, 0, iCPU, panalBar.Height );
			else if( iCPU <= 120 )
				g.FillRectangle( Brushes.Wheat, 0, 0, iCPU, panalBar.Height );
			else if( iCPU <= 180 )
				g.FillRectangle( Brushes.NavajoWhite, 0, 0, iCPU, panalBar.Height );
			else if( iCPU <= 240 )
				g.FillRectangle( Brushes.Orange, 0, 0, iCPU, panalBar.Height );
			else
				g.FillRectangle( Brushes.DarkOrange, 0, 0, iCPU, panalBar.Height );

			iCPU = iCPU / 3;
			g.DrawString( iCPU.ToString() + " %", font, Brushes.DarkRed, panalBar.Width / 2 - 17, panalBar.Height / 4 );
		}

		private void Form2_FormClosing( object sender, FormClosingEventArgs e )
		{
			checkThread.Abort();
		}
	}
}
