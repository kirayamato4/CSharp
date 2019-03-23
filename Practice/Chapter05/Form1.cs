using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chapter05
{
	public partial class Form1 : Form
	{
		private Bitmap bmpBackground = new Bitmap( typeof( Form1 ), "bg.bmp" );
		private Bitmap bmpCloseUp = new Bitmap( typeof( Form1 ), "closeup.bmp" );
		private Bitmap bmpCloseDown = new Bitmap( typeof( Form1 ), "closedown.bmp" );

		private bool isFormMouseDown = false;
		Point ptMouseCurrentPos;
		Point ptMouseMovePos;
		Point ptFormCurrentPos;
		Point ptFormMovePos;

		public Form1()
		{
			InitializeComponent();

			FlexibleForm.CreateControlRegion( this, bmpBackground );
			FlexibleForm.CreateControlRegion( btnClose, bmpCloseUp );
		}

		private void Form1_MouseDown( object sender, MouseEventArgs e )
		{
			if( MouseButtons.Left != e.Button )
				return;

			isFormMouseDown = true;

			ptMouseCurrentPos = Control.MousePosition;
			ptFormCurrentPos = Location;
		}

		private void Form1_MouseUp( object sender, MouseEventArgs e )
		{
			if( MouseButtons.Left != e.Button )
				return;

			isFormMouseDown = false;
		}

		private void Form1_MouseMove( object sender, MouseEventArgs e )
		{
			if( !isFormMouseDown )
				return;

			// 마우스 이동 메세지 받은 경우 폼 위치 갱신
			ptMouseMovePos = Control.MousePosition;
			ptFormMovePos.X = ptMouseMovePos.X - ptMouseCurrentPos.X + ptFormCurrentPos.X;
			ptFormMovePos.Y = ptMouseMovePos.Y - ptMouseCurrentPos.Y + ptFormCurrentPos.Y;

			Location = ptFormMovePos;

			// 값 갱신
			ptFormCurrentPos = ptFormMovePos;
			ptMouseCurrentPos = ptMouseMovePos;

		}

		private void btnClose_MouseEnter( object sender, EventArgs e )
		{
			FlexibleForm.CreateControlRegion( btnClose, bmpCloseDown );
		}

		private void btnClose_MouseLeave( object sender, EventArgs e )
		{
			FlexibleForm.CreateControlRegion( btnClose, bmpCloseUp );
		}

		private void btnClose_Click( object sender, EventArgs e )
		{
			Application.ExitThread();
		}
	}
}
