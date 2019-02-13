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
	public partial class Form2 : Form
	{
		Thread threadFileView = null;

		private delegate void OnDelegateFile( string filePath, string fileName, string fileLength, string fileCreateTime );
		private OnDelegateFile OnFile = null;

		bool allFileFlag = true;

		int dirCount = 0;
		int fileCount = 0;

		void FileResult( string filePath, string fileName, string fileLength, string fileCreateTime )
		{
			string fileSize = GetFileSize( Convert.ToDouble( fileLength ) );
			lvFile.Items.Add( new ListViewItem( new string[] { filePath, fileName, fileCreateTime, fileSize } ) );
			tsslbResult.Text = String.Format( "폴더 : {0}개, 파일 : {1}개", dirCount, fileCount );
		}

		string GetFileSize( double byteCount )
		{
			string size = "0 Bytes";

			if( byteCount >= 1073741824.0 )
				size = String.Format( "{0:##.##}", byteCount / 1073741824.0 ) + " GB";
			else if( byteCount >= 1048576.0 )
				size = String.Format( "{0:##.##}", byteCount / 1048576.0 ) + " MB";
			else if( byteCount >= 1024.0 )
				size = String.Format( "{0:##.##}", byteCount / 1024.0 ) + " KB";
			else
				size = byteCount.ToString() + " Bytes";

			return size;
		}

		public Form2()
		{
			InitializeComponent();
		}

		private void Form2_Load( object sender, EventArgs e )
		{
			OnFile = new OnDelegateFile( FileResult );
		}

		private void rbAll_CheckedChanged( object sender, EventArgs e )
		{
			ItemsClear();

			allFileFlag = true;

			if( null != threadFileView )
				threadFileView.Abort();

			if( "" != tbPath.Text )
			{
				lvFile.Items.Clear();
				StartThread();
			}
		}

		private void rbHidden_CheckedChanged( object sender, EventArgs e )
		{
			ItemsClear();

			allFileFlag = false;

			if( null != threadFileView )
				threadFileView.Abort();

			if( "" != tbPath.Text )
			{
				lvFile.Items.Clear();
				StartThread();
			}
		}

		private void btnPath_Click( object sender, EventArgs e )
		{
			if( DialogResult.OK == fbdFolder.ShowDialog() )
			{
				ItemsClear();

				tbPath.Text = fbdFolder.SelectedPath;
				StartThread();
			}
		}

		void StartThread()
		{
			threadFileView = new Thread( new ParameterizedThreadStart( FileView ) );
			threadFileView.Start( fbdFolder.SelectedPath );
		}

		void ItemsClear()
		{
			dirCount = 0;
			fileCount = 0;
			lvFile.Items.Clear();
		}

		void FileView( object path )
		{
			++dirCount;

			DirectoryInfo di = new DirectoryInfo( (string)path );
			DirectoryInfo[] directoires = di.GetDirectories();

			// 파일 처리
			foreach( var file in di.GetFiles() )
			{
				if( allFileFlag )
				{
					++fileCount;
					Invoke( OnFile, file.DirectoryName, file.Name, file.Length.ToString(), file.CreationTime.ToString() );
				}
				else
				{
					if( file.Attributes.ToString().Contains( FileAttributes.Hidden.ToString() ) )
					{
						++fileCount;
						Invoke( OnFile, file.DirectoryName, file.Name, file.Length.ToString(), file.CreationTime.ToString() );
					}
				}
			}

			// 디렉토리 처리
			for( int i = 0; i < di.GetDirectories().Length; ++i )
			{
				try
				{
					FileView( directoires[i].FullName );
				}
				catch
				{
					continue;
				}
			}
		}
	}
}
