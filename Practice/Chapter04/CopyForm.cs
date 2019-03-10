using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Threading;

namespace Chapter04
{
	public partial class CopyForm : Form
	{
		public delegate void SetProgressCallBack( int value );
		public delegate void SetLabelCallBack( string str );

		void SetProgress( int value )
		{
			if( pbCopy.InvokeRequired )
			{
				SetProgressCallBack callBack = new SetProgressCallBack( SetProgress );
				Invoke( callBack, new object[] { value } );
			}
			else
			{
				pbCopy.Value = value;
			}
		}

		void SetLabel( string str )
		{
			if( lbCopy.InvokeRequired )
			{
				SetLabelCallBack callBack = new SetLabelCallBack( SetLabel );
				Invoke( callBack, new object[] { str } );
			}
			else
			{
				lbCopy.Text = str;
			}
		}

		private Thread thread;
		private byte[] buffer = new byte[ 4096 ];
		private FileStream fsSrc = null;
		private FileStream fsDest = null;

		public string FileName { get; set; }

		public CopyForm( string src, string dest )
		{
			InitializeComponent();

			fsSrc = new FileStream( src, FileMode.Open, FileAccess.Read );
			fsDest = new FileStream( dest, FileMode.Create, FileAccess.Write );
		}

		private void CopyForm_Load( object sender, EventArgs e )
		{
			pbCopy.Maximum = 100;
			lbFileName.Text = "파  일 : " + FileName;
			thread = new Thread( new ThreadStart( FileCopy ) );
			thread.Start();
		}

		private void FileCopy()
		{
			const int K = 1024;
			const int block = 4 * K;

			int value = 1;
			int count = 0;

			int kk = (int)( fsSrc.Length / block ) - 1;
			int ss = (int)( fsSrc.Length % block );

			while( true )
			{
				Thread.Sleep( 10 );
				if( value >= 100 )
					break;
				
				if( count <= kk )
				{
					fsSrc.Seek( block * count, SeekOrigin.Begin );
					fsSrc.Read( buffer, 0, block );

					fsDest.Seek( block * count, SeekOrigin.Begin );
					fsDest.Write( buffer, 0, block );
				}
				else
				{
					fsSrc.Seek( block * count, SeekOrigin.Begin );
					fsSrc.Read( buffer, 0, ss );

					fsDest.Seek( block * count, SeekOrigin.Begin );
					fsDest.Write( buffer, 0, ss );
				}

				++count;

				value = (int)( fsDest.Length * 100 / fsSrc.Length );
				if( value > 100 )
					SetProgress( 100 );
				else
					SetProgress( value );

				SetLabel( "복사 : " + value.ToString() + " %" );
			}

			fsDest.Close();
			fsSrc.Close();

			DialogResult = DialogResult.OK;
		}

		private void CopyForm_FormClosing( object sender, FormClosingEventArgs e )
		{
			if( null != thread )
				thread.Abort();
		}
	}
}
