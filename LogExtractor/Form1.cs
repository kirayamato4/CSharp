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

namespace LogExtractor
{
	public partial class Form1 : Form
	{
		string baseFileName = "파일명 : ";
		string baseStatus = "상태 : ";

		string m_extension = ".log";

		bool m_bExtract = false;
		delegate void OnCopy();

		public Form1()
		{
			InitializeComponent();

			cbExtension.SelectedIndex = 0;
		}

		bool IsExtract()
		{
			if(m_bExtract)
			{
				MessageBox.Show( "추출중입니다.", "알림", MessageBoxButtons.OK, MessageBoxIcon.Information );
				return true;
			}

			return false;
		}

		private void btnLog_Click( object sender, EventArgs e )
		{
			if(IsExtract())
				return;

			if(DialogResult.OK != fbDialog.ShowDialog())
				return;

			tbLogPath.Text = fbDialog.SelectedPath;
			AddFileList();
		}

		private void btnExtract_Click( object sender, EventArgs e )
		{
			if(IsExtract())
				return;

			if(DialogResult.OK != fbDialog.ShowDialog())
				return;

			if(fbDialog.SelectedPath == tbLogPath.Text)
			{
				MessageBox.Show( "로그 파일 경로와 추출 경로가 같습니다.", "에러", MessageBoxButtons.OK, MessageBoxIcon.Error );
				return;
			}

			tbExtractPath.Text = fbDialog.SelectedPath;
		}

		private void cbExtension_SelectedIndexChanged( object sender, EventArgs e )
		{
			if(IsExtract())
				return;

			int index = cbExtension.SelectedIndex;
			string extension = cbExtension.Items[ index ] as string;

			if(extension.Equals( "입력" ))
			{
				tbExtension.Text = "";
				tbExtension.Enabled = true;
			}
			else
			{
				tbExtension.Text = "";
				tbExtension.Enabled = false;
			}

			m_extension = "." + extension;
			AddFileList();
		}

		private void tbExtension_TextChanged( object sender, EventArgs e )
		{
			if(IsExtract())
				return;

			m_extension = "." + tbExtension.Text;
		}

		private void AddFileList()
		{
			if(IsExtract())
				return;

			if(tbLogPath.Text == "")
				return;

			string directoryPath = tbLogPath.Text;
			if(!Directory.Exists( directoryPath ))
			{
				MessageBox.Show( "폴더가 존재하지 않습니다.", "에러", MessageBoxButtons.OK, MessageBoxIcon.Error );
				return;
			}

			lvFolder.Items.Clear();

			var directoryInfo = new DirectoryInfo( directoryPath );
			foreach(var file in directoryInfo.GetFiles())
			{
				if(!m_extension.Equals( file.Extension ))
					continue;

				var item = new ListViewItem( file.Name );
				lvFolder.Items.Add( item );
			}
		}

		#region EXTRACT_WITH_THREAD
		private Thread extractThread = null;
		private const long BUFFER_MAX = 4096;
		private byte[] buffer = new byte[ BUFFER_MAX ];

		private void button1_Click( object sender, EventArgs e )
		{
			if( m_bExtract )
				return;

			m_bExtract = true;

			progressBar.Maximum = lvFolder.SelectedItems.Count;

			extractThread = new Thread( new ParameterizedThreadStart( ExtractFile ) );
			extractThread.Start( lvFolder );
		}

		ListView GetFolderListView()
		{
			return lvFolder;
		}

		private void ExtractFile( object obj )
		{
			ListView lvFolder = obj as ListView;

			m_bExtract = false;
		}

		private void Test( ListView lv )
		{

		}

		public delegate void SetFileNameLabelCallBack( string fileName );
		void SetFileNameLabel( string fileName )
		{
			lbFileName.Text = fileName;
		}

		public delegate void SetProgressCallBack( int value );
		void SetProgress( int value )
		{
			if( progressBar.InvokeRequired )
			{
				SetProgressCallBack callBack = new SetProgressCallBack( SetProgress );
				Invoke( callBack, new object[] { value } );
			}
			else
			{
				progressBar.Value = value;
			}
		}

		#endregion
	}
}
