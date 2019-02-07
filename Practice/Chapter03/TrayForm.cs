using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Timers;

namespace Chapter03
{
	public partial class TrayForm : Form
	{
		private static System.Timers.Timer TimerEvent;

		private delegate void OnDelegateHeight(int Flag);
		private OnDelegateHeight OnHeight = null;

		public TrayForm()
		{
			int x = Screen.PrimaryScreen.WorkingArea.Width - Width - 20;
			int y = Screen.PrimaryScreen.WorkingArea.Height - Height;

			DesktopLocation = new Point(x, y);
			Size = new Size(170, 0);

			InitializeComponent();
		}

		public string MsgText
		{
			set
			{
				llResult.Text = value;
			}
		}

		private void TrayForm_Load(object sender, EventArgs e)
		{
			OnHeight = new OnDelegateHeight(MsgView);

			Size = new System.Drawing.Size(170, 0);
			Location = new System.Drawing.Point(
				Screen.PrimaryScreen.WorkingArea.Width - Width - 20,
				Screen.PrimaryScreen.WorkingArea.Height
			);

			TimerEvent = new System.Timers.Timer( 2 );
			TimerEvent.Elapsed += new ElapsedEventHandler(OnPopUp);
			TimerEvent.Start();
		}

		private void MsgView( int Flag )
		{
			if( 0 == Flag )
			{
				++Height;	// 세로 크기 늘리기
				--Top;		// 세로 위치를 올려서 폼이 올리는 듯한 효과
			}
			else if( 1 == Flag )
			{
				--Height;	// 세로 크기 줄이기
				++Top;		// 세로 위치를 내려서 폼을 내리는 효과
			}
			else if( 2 == Flag )
			{
				Close();
			}
		}

		private void OnPopUp( object sender, ElapsedEventArgs e )
		{
			if( Height < 120 )
			{
				Invoke(OnHeight, 0);
			}
			else
			{
				TimerEvent.Stop();
				TimerEvent.Elapsed -= new ElapsedEventHandler(OnPopUp);
				TimerEvent.Elapsed += new ElapsedEventHandler(OnPopOut);
				TimerEvent.Interval = 3000;
				TimerEvent.Start();
			}

			Application.DoEvents();
		}

		private void OnPopOut( object sender, ElapsedEventArgs e )
		{
			while (Height > 2)
				Invoke(OnHeight, 1);

			TimerEvent.Stop();
			Application.DoEvents();
			Invoke(OnHeight, 2);
		}

		private void llResult_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			Close();
			TimerEvent.Stop();
		}
	}
}
