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
	public partial class Form3 : Form
	{
		string fileSrc = "";
		string fileDest = "";

		public Form3()
		{
			InitializeComponent();
		}

		private void btnSrc_Click( object sender, EventArgs e )
		{
			if( DialogResult.OK != fbDialog.ShowDialog() )
				return;

			lvSrc.Items.Clear();
			tbSrc.Text = fbDialog.SelectedPath;
			fileSrc = fbDialog.SelectedPath;

			var directoryInfo = new DirectoryInfo( fileSrc );

			foreach( var file in directoryInfo.GetFiles() )
				lvSrc.Items.Add( new ListViewItem( new string[] { file.Name } ) );
		}

		private void btnDest_Click( object sender, EventArgs e )
		{
			if( DialogResult.OK != fbDialog.ShowDialog() )
				return;

			lvDest.Items.Clear();
			tbDest.Text = fbDialog.SelectedPath;
			fileDest = fbDialog.SelectedPath;

			var directoryInfo = new DirectoryInfo( fileDest );

			foreach( var file in directoryInfo.GetFiles() )
				lvDest.Items.Add( new ListViewItem( new string[] { file.Name } ) );
		}

		private void btnRun_Click( object sender, EventArgs e )
		{
			if( tbDest.Text == tbSrc.Text )
			{
				MessageBox.Show( "경로가 같을 수 없습니다", "에러", MessageBoxButtons.OK, MessageBoxIcon.Error );
				return;
			}

			int i = 0;
			int sum = lvSrc.SelectedItems.Count;

			foreach( ListViewItem Item in lvSrc.SelectedItems )
			{
				++i;

				string sFilePath = fileSrc + @"\" + Item.Text;
				string dFilePath = fileDest + @"\" + Item.Text;

				if( false == File.Exists( sFilePath ) )
				{
					MessageBox.Show( "존재하지 않는 파일입니다.", "에러", MessageBoxButtons.OK, MessageBoxIcon.Error );
					continue;
				}

				var fileInfo = new FileInfo( sFilePath );
				CopyForm copyForm = new CopyForm( sFilePath, dFilePath );
				copyForm.FileName = Item.Text;

				if( DialogResult.OK == copyForm.ShowDialog() )
				{
					copyForm.Close();
					ListViewItem item = lvDest.FindItemWithText( Item.Text );
					if( null == item )
						lvDest.Items.Add( new ListViewItem( new string[] { Item.Text } ) );

					if( rbMove.Checked )
					{
						fileInfo.Delete();
						lvSrc.Items.RemoveAt( Item.Index );
					}
				}

				int statusValue = i * 100 / sum;
				tsProgressBar.Value = statusValue;
				tssStatus.Text = " " + statusValue.ToString() + " %";
			}

		}

		private void Form3_Load( object sender, EventArgs e )
		{

		}
	}
}
