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
	public partial class Form4 : Form
	{
		FileDelete fileDelete = null;
		

		public Form4()
		{
			InitializeComponent();
		}

		private void btnPath_Click( object sender, EventArgs e )
		{
			if( DialogResult.OK != ofDialog.ShowDialog() )
				return;

			tbPath.Text = ofDialog.FileName;
		}

		private void btnDelete_Click( object sender, EventArgs e )
		{
			if( "" == cbDelete.Text )
			{
				MessageBox.Show( "Wipe 방법 선택", "알림", MessageBoxButtons.OK, MessageBoxIcon.Information );
				return;
			}

			if( "" == tbPath.Text )
			{
				MessageBox.Show( "삭제할 파일을 선택하세요", "알림", MessageBoxButtons.OK, MessageBoxIcon.Information );
				return;
			}

			switch( cbDelete.Text )
			{
				case "British HMG IS5 (Base Line)":
					fileDelete = new FileDelete( tbPath.Text );
					fileDelete.runPer += new FileDelete.ProcessEventHandler( DeleteStatus );
					fileDelete.British_HMG_IS5_BaseLine( tbPath.Text );
					break;

				case "British HMG IS5 (Enhanced)":
					fileDelete = new FileDelete( tbPath.Text );
					fileDelete.runPer += new FileDelete.ProcessEventHandler( DeleteStatus );
					fileDelete.British_HMG_IS5_Enhanced( tbPath.Text );
					break;
			}
		}

		private void DeleteStatus( int Current )
		{
			switch( Current )
			{
				case 0:
					lbPercent.Text = Current + " %";
					progressBar.Value = Current;
					break;

				default:
					lbPercent.Text = Current + " %";
					progressBar.Value = Current;
					if( 100 == Current )
						tbPath.Text = "";
					break;
			}

			Application.DoEvents();
		}
	}
}
