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
	public partial class Form5 : Form
	{
		Point originalLocalPoint;
		Size originalLocalSize;

		bool isOriginal = true;
		bool isCapture = false;

		Graphics screenGraphics;
		Bitmap captureBitmap;

		System.Media.SoundPlayer player = new System.Media.SoundPlayer();

		public Form5()
		{
			InitializeComponent();
		}

		private void Form5_Load( object sender, EventArgs e )
		{
			if( isOriginal )
			{
				originalLocalPoint = Location;
				originalLocalSize = Size;
			}
		}

		private void Form5_KeyUp( object sender, KeyEventArgs e )
		{

		}

		private void Form5_KeyPress( object sender, KeyPressEventArgs e )
		{
			switch( e.KeyChar )
			{
			case 'c':
				{
					isOriginal = false;
					isCapture = true;

					Opacity = 0.0;
					FormBorderStyle = FormBorderStyle.None;
					Location = new Point( 0, 0 );
					Size = Screen.PrimaryScreen.Bounds.Size;
					var fullScreen = Screen.PrimaryScreen.Bounds;

					captureBitmap = new Bitmap( fullScreen.Width, fullScreen.Height );
					screenGraphics = Graphics.FromImage( captureBitmap );
					screenGraphics.CopyFromScreen( PointToScreen( new Point( 0, 0 ) ), new Point( 0, 0 ), fullScreen.Size );
					pbCapture.Image = captureBitmap;

					player.SoundLocation = @"capture.wav";
					player.Play();

					Opacity = 100.0;
					FormBorderStyle = FormBorderStyle.FixedSingle;
					Location = originalLocalPoint;
					Size = originalLocalSize;

					isOriginal = true;
				}
				break;

			case 'e':
				{
					player.SoundLocation = @"ereser.wav";
					player.Play();

					isCapture = false;
					pbCapture.Image = null;
				}
				break;

			case 's':
				{
					if( isCapture )
					{
						using( var saveFile = new SaveFileDialog() )
						{
							saveFile.OverwritePrompt = true;
							saveFile.FileName = "화면 캡처";
							saveFile.Filter = "이미지 파일(*.jpg)|*.jpg";
							DialogResult result = saveFile.ShowDialog();
							if( DialogResult.OK == result )
							{
								captureBitmap.Save( saveFile.FileName, ImageFormat.Jpeg );
							}
						}
					}
					else
					{
						MessageBox.Show( "캡처한 화면이 없습니다.", "알림", MessageBoxButtons.OK, MessageBoxIcon.Information );
					}
				}
				break;
			}
		}
	}
}
