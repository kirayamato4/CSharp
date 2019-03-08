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

namespace Chapter04
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private bool txtCheck()
		{
			return "" != tbReadPath.Text;
		}

		// 파일 읽기 탭
		private void btnReadPath_Click( object sender, EventArgs e )
		{
			if( DialogResult.OK == ofdFile.ShowDialog() )
			{
				tbReadPath.Text = ofdFile.FileName;
			}
		}

		private void btnReadAll_Click( object sender, EventArgs e )
		{
			if( false == txtCheck() )
				return;

			if( File.Exists( tbReadPath.Text ) )
			{
				using( StreamReader sr = new StreamReader( tbReadPath.Text, Encoding.Default ) )
				{
					tbReadView.Text = sr.ReadToEnd();
				}
			}
			else
			{
				MessageBox.Show( "읽을 파일이 없습니다.", "에러", MessageBoxButtons.OK, MessageBoxIcon.Error );
			}
		}

		private void btnReadLine_Click( object sender, EventArgs e )
		{
			if( false == txtCheck() )
				return;

			if( File.Exists( tbReadPath.Text ) )
			{
				using( StreamReader sr = new StreamReader( tbReadPath.Text, Encoding.Default ) )
				{
					string line = null;
					while( null != ( line = sr.ReadLine() ) )
					{
						tbReadView.AppendText( line + "\r\n" );
					}
				}
			}
			else
			{
				MessageBox.Show( "읽을 파일이 없습니다.", "에러", MessageBoxButtons.OK, MessageBoxIcon.Error );
			}
		}

		// 파일 쓰기 탭
		private void btnWritePath_Click( object sender, EventArgs e )
		{
			if( DialogResult.OK == sfdFile.ShowDialog())
			{
				tbWritePath.Text = sfdFile.FileName;
			}
		}

		private void btnWriteAll_Click( object sender, EventArgs e )
		{
			try
			{
				using( StreamWriter sw = new StreamWriter( tbWritePath.Text ) )
				{
					sw.WriteLine( tbWriteView.Text );
				}
			}
			catch
			{
				return;
			}

			MessageBox.Show( "파일이 저장되었습니다.", "알림", MessageBoxButtons.OK, MessageBoxIcon.Information );
		}

		private void btnWriteLine_Click( object sender, EventArgs e )
		{
			try
			{
				using( StreamWriter sw = new StreamWriter( tbWritePath.Text ) )
				{
					foreach( var str in tbWriteView.Lines )
					{
						sw.WriteLine( str );
					}
				}
			}
			catch
			{
				return;
			}

			MessageBox.Show( "파일이 저장되었습니다.", "알림", MessageBoxButtons.OK, MessageBoxIcon.Information );
		}

		private void Form1_Load( object sender, EventArgs e )
		{

		}
	}
}
