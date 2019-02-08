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
using System.Threading;
using System.Collections;

namespace Chapter03
{
	public partial class Form6 : Form
	{
		private Thread ProcessThread = null;
		Thread CheckThread = null;

		private delegate void ProcessUpdateDelegate();  // 델리게이트 생성
		private ProcessUpdateDelegate UpProc = null;

		private delegate void TotalUpdateDelegate( int m, int n );	// 델리게이트 생성
		private TotalUpdateDelegate OnTotal = null;

		// oCPU를 통해 전체 CPU 사용량 확인
		private PerformanceCounter oCPU = new PerformanceCounter( "Processor", "% Processor Time", "_Total");
		// oMemory를 통해 전체 메모리 사용량 확인
		private PerformanceCounter oMemory = new PerformanceCounter( "Memory", "% Committed Bytes in Use" );
		// 프로세스의 각 CPU 사용량 체크
		private PerformanceCounter pCPU = new PerformanceCounter();

		bool bExit = false;
		int cp = 0;


		public Form6()
		{
			InitializeComponent();
		}

		private void Form6_Load( object sender, EventArgs e )
		{
			ProcessView();

			UpProc = new ProcessUpdateDelegate( ProcessView );
			OnTotal = new TotalUpdateDelegate( TotalView );

			this.ProcessThread = new Thread( ProcessUpdate );
			this.ProcessThread.Start();

			CheckThread = new Thread( getCPU_Info );
			CheckThread.Start();
		}

		void ProcessUpdate()
		{
			try
			{
				while( true )
				{
					// 기존 프로세스 얻기
					var oldList = new ArrayList();
					foreach( var oldproc in Process.GetProcesses() )
					{
						oldList.Add( oldproc.Id.ToString() );
					}
					Thread.Sleep( 1000 );

					// 새로운 프로세스 확인
					var newProc = Process.GetProcesses();
					if( oldList.Count != newProc.Length )
					{
						Invoke( UpProc );
						continue;
					}

					int i = 0;
					foreach( var rewProc in Process.GetProcesses() )
					{
						if( oldList[i++].ToString() != rewProc.Id.ToString() )
						{
							Invoke( UpProc );
							break;
						}
					}
				}
			}
			catch
			{

			}
		}

		void ProcessView()
		{
			try
			{
				lvView.Items.Clear();
				cp = 0;

				foreach( var proc in Process.GetProcesses() )
				{
					string[] str;
					try
					{
						str = proc.TotalProcessorTime.ToString().Split( new char[] { '.' } );
					}
					catch
					{
						str = new string[] { "" };
					}

					var strArray = new string[]
					{
						proc.ProcessName.ToString(),
						proc.Id.ToString(),
						str[0],
						NumFormat( proc.WorkingSet64 )
					};

					var lvItem = new ListViewItem( strArray );
					lvView.Items.Add( lvItem );

					++cp;
				}
			}
			catch
			{
				
			}

			tsslProcess.Text = "프로세스 : " + cp.ToString() + "개";
		}

		string NumFormat( long MemNum )
		{
			MemNum /= 1024;
			return String.Format( "{0:N}", MemNum ) + "KB";
		}

		void getCPU_Info()
		{
			int iCPU = (int)oCPU.NextValue();
			int iMemory = (int)oMemory.NextValue();
			Invoke( OnTotal, iCPU, iMemory );
			Thread.Sleep( 1000 );
		}

		void TotalView( int m, int n )
		{
			tsslCpu.Text = "CPU 사용 : " + m.ToString() + "%";
			tsslMemory.Text = "실제메모리 : " + n.ToString() + "%";
		}

		private void btnKill_Click( object sender, EventArgs e )
		{
			ProcessKill();
		}

		void ProcessKill()
		{
			try
			{
				// 리스트 뷰에서 선택된 목록중 첫번째 아이템에서 PID를 얻는다
				int PID = Convert.ToInt32( lvView.SelectedItems[0].SubItems[1].Text );

				Process process = Process.GetProcessById( PID );
				if( null != process )
				{
					var dlr = MessageBox.Show( "프로세스를 종료하시겠습니까?", "알림", MessageBoxButtons.YesNo, MessageBoxIcon.Warning );

					if( DialogResult.Yes == dlr )
					{
						process.Kill();
						ProcessView();
					}
				}
				else
				{
					MessageBox.Show( "프로세스가 존재하지 않습니다.", "알림", MessageBoxButtons.OK, MessageBoxIcon.Error );
					ProcessView();
				}

			}
			catch
			{

			}
		}

		private void Form6_FormClosing( object sender, FormClosingEventArgs e )
		{
			if( null != ProcessThread )
				ProcessThread.Abort();

			if( null != CheckThread )
				CheckThread.Abort();
		}
	}
}
