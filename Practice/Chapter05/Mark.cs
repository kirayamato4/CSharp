using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;	// for PictureBox

namespace Chapter05
{
	class Mark
	{
		public static string BackImagePath = null;
		public static string MarkImageText = null;
		public static float MarkOpacity = 50;
		public static Image ImageSize = null;
		public static Font fontSet = null;
		public static Color fontColor;


		public static PictureBox NewImage()
		{
			Image originalImage = Image.FromFile( BackImagePath );
			ImageSize = originalImage;

			Bitmap tempImage = new Bitmap( originalImage.Width, originalImage.Height );
			Bitmap markImage = new Bitmap( 100, 100 );

			markImage.SetResolution( 100, 100 );
			Graphics g = Graphics.FromImage( markImage );
			g.PageUnit = GraphicsUnit.Point;
			g.Clear( Color.Empty );

			Font font = fontSet;
			SolidBrush drawBrush = new SolidBrush( fontColor );
			g.DrawString( MarkImageText, font, drawBrush, new RectangleF( 0, 0, 100, 100 ), StringFormat.GenericDefault );

			float setOpacity = MarkOpacity / 100;
			Graphics newGrp = Graphics.FromImage( tempImage );
			float[][] setColorMatrix =
			{
				new float[] { 1, 0, 0, 0, 0 },
				new float[] { 0, 1, 0, 0, 0 },
				new float[] { 0, 0, 1, 0, 0 },
				new float[] { 0, 0, 0, setOpacity, 0 },
				new float[] { 0, 0, 0, 0, 1 },
			};
			System.Drawing.Imaging.ColorMatrix colorMatrix = new System.Drawing.Imaging.ColorMatrix( setColorMatrix );

			System.Drawing.Imaging.ImageAttributes imageAttributes = new System.Drawing.Imaging.ImageAttributes();
			imageAttributes.SetColorMatrix(
				colorMatrix,
				System.Drawing.Imaging.ColorMatrixFlag.Default,
				System.Drawing.Imaging.ColorAdjustType.Bitmap
			);

			newGrp.DrawImage( originalImage, 0, 0, originalImage.Width, originalImage.Height );
			float orw = (float)( originalImage.Width * 0.3 );
			float orh = (float)( originalImage.Height * 0.4 );

			float mix = ( originalImage.Width / 2 ) + ( orw / 2 );
			float miy = ( originalImage.Height / 2 ) + ( orh / 2 ) + ( ( orh / 2 ) / 2 );

			float msw = markImage.Width;
			float msh = markImage.Height;

			newGrp.DrawImage( markImage, new Rectangle( (int)mix, (int)miy, (int)orw, (int)orh ), 0.0F, 0.0F, msw, msh, GraphicsUnit.Pixel, imageAttributes );
			PictureBox pictureBox = new PictureBox();
			pictureBox.Image = tempImage;

			return pictureBox;
		}
	}
}
