using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Imaging;

namespace Chapter05
{
	public partial class Form3 : Form
	{
		Bitmap imageFile = null;
		bool fontSet = false;
		bool fontColor = false;

		public Form3()
		{
			InitializeComponent();
		}

		private void btnBackground_Click( object sender, EventArgs e )
		{
			if( DialogResult.OK != ofDlg.ShowDialog() )
				return;

			tbBackground.Text = ofDlg.FileName;
		}

		private void 글꼴ToolStripMenuItem_Click( object sender, EventArgs e )
		{
			if( DialogResult.OK != fontDlg.ShowDialog() )
				return;

			Mark.fontSet = fontDlg.Font;
			fontSet = true;
		}

		private void 색상ToolStripMenuItem_Click( object sender, EventArgs e )
		{
			if( DialogResult.OK != colorDlg.ShowDialog() )
				return;

			Mark.fontColor = colorDlg.Color;
			fontColor = true;
		}

		private void btnPreview_Click( object sender, EventArgs e )
		{
			if( !textCheck() )
				return;

			Mark.BackImagePath = tbBackground.Text;
			Mark.MarkImageText = tbMarking.Text;
			Mark.MarkOpacity = hsbOpacity.Value;

			pbPreview.Image = Mark.NewImage().Image;
		}

		private bool textCheck()
		{
			if( "" == tbBackground.Text )
			{
				MessageBox.Show( "배경 이미지 파일을 선택하지 않았습니다.", "알림", MessageBoxButtons.OK, MessageBoxIcon.Information );
				return false;
			}

			if( "" == tbMarking.Text )
			{
				MessageBox.Show( "마킹 이미지 파일을 선택하지 않았습니다.", "알림", MessageBoxButtons.OK, MessageBoxIcon.Information );
				return false;
			}

			if( !fontSet )
			{
				MessageBox.Show( "마킹 글꼴을 선택하지 않았습니다.", "알림", MessageBoxButtons.OK, MessageBoxIcon.Information );
				return false;
			}

			if( !fontColor )
			{
				MessageBox.Show( "마킹 색상을 선택하지 않았습니다.", "알림", MessageBoxButtons.OK, MessageBoxIcon.Information );
				return false;
			}

			return true;
		}

		private void btnSave_Click( object sender, EventArgs e )
		{
			if( null == pbPreview.Image )
				return;

			if( DialogResult.OK != sfDlg.ShowDialog() )
				return;

			imageFile = new Bitmap( Mark.ImageSize.Width, Mark.ImageSize.Height );
			imageFile = (Bitmap)pbPreview.Image;
			imageFile.Save( sfDlg.FileName, ImageFormat.Jpeg );
		}
	}
}
