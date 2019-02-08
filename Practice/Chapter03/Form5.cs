using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace Chapter03
{
	public partial class Form5 : Form
	{
		bool isBusy = false;
		private string filePath = null;

		public Form5()
		{
			InitializeComponent();
		}

		private void btnFolder_Click( object sender, EventArgs e )
		{
			if( DialogResult.OK == fbdFile.ShowDialog())
			{
				btnDownload.Enabled = true;
				filePath = fbdFile.SelectedPath;
			}
		}

		private void btnDownload_Click( object sender, EventArgs e )
		{
			if( isBusy )
			{
				webClient.CancelAsync();
				isBusy = false;
			}
			else
			{
				try
				{
					var strFileName = tbURL.Text.Split( new char[] { '/' } );
					System.Array.Reverse( strFileName );
					Uri uri = new Uri( tbURL.Text );


					var str = webClient.DownloadString( uri );
					webClient.DownloadFileAsync( uri, filePath + @"\" + strFileName[0] );
					isBusy = true;
				}
				catch
				{
					btnDownload.Enabled = false;
					MessageBox.Show( "다운로드 실패", "알림", MessageBoxButtons.OK, MessageBoxIcon.Error );
				}
			}
		}

		private void webClient_DownloadProgressChanged( object sender, System.Net.DownloadProgressChangedEventArgs e )
		{
			pbDownload.Value = e.ProgressPercentage;
		}

		private void webClient_DownloadFileCompleted( object sender, AsyncCompletedEventArgs e )
		{
			isBusy = false;
			btnDownload.Enabled = false;

			if( null == e.Error )
			{
				if( cbOpen.Checked )
				{
					Process process = new Process();
					process.StartInfo.FileName = filePath;
					process.Start();
				}
				else
				{
					MessageBox.Show( "다운로드 완료", "알림", MessageBoxButtons.OK, MessageBoxIcon.Information );
				}
			}
			else
			{
				MessageBox.Show( "다운로드 실패 : " + e.Error.Message.ToString() );
			}
		}
	}
}
