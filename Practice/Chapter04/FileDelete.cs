using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace Chapter04
{
	public class FileDelete
	{
		FileInfo fileInfo = null;
		FileStream fileStream = null;
		byte[] bytes = null;

		public delegate void ProcessEventHandler( int Current );
		public event ProcessEventHandler runPer;

		public FileDelete( string filePath )
		{
			fileInfo = new FileInfo( filePath );
		}

		public void British_HMG_IS5_BaseLine( string filePath )
		{
			try
			{
				bytes = new byte[ fileInfo.Length ];
				runPer( 0 );

				Application.DoEvents();

				for( int i = 0; i < fileInfo.Length; ++i )
				{
					bytes[ i ] = 0x0;
					runPer( (int)( (float)i / (float)( fileInfo.Length - 1.0 ) * 100.0 ) );
				}

				RunBuffer( filePath, bytes );
				fileInfo.Delete();
				Application.DoEvents();
			}
			catch( Exception ex )
			{
				MessageBox.Show( ex.ToString() );
			}
		}

		public void British_HMG_IS5_Enhanced( string filePath )
		{
			try
			{
				
				runPer( 0 );

				Application.DoEvents();

				int percent1 = 0;
				// Delete 1
				bytes = new byte[ fileInfo.Length ];
				for( int i = 0; i < fileInfo.Length; ++i )
				{
					bytes[ i ] = 0x0;
					percent1 = (int)(i / (float)( fileInfo.Length - 1.0 ) * 50.0);
					runPer( percent1 );
				}
				RunBuffer( filePath, bytes );


				// Delete 2
				bytes = new byte[ fileInfo.Length ];
				int percent2 = 0;
				for( int i = 0; i < fileInfo.Length; ++i )
				{
					bytes[ i ] = 0x0;
					percent2 = (int)( i / (float)( fileInfo.Length - 1.0 ) * 50.0 );
					runPer( percent1 + percent2 );
				}
				RunBuffer( filePath, bytes );



				fileInfo.Delete();
				Application.DoEvents();
			}
			catch( Exception ex )
			{
				MessageBox.Show( ex.ToString() );
			}
		}

		private void RunBuffer( string filePath, byte[] buffer )
		{
			fileStream = new FileStream( filePath, FileMode.Open, FileAccess.Write, FileShare.None );

			fileStream.Write( buffer, 0, buffer.Length );
			fileStream.Flush();
			fileStream.Close();
		}
	}
}
