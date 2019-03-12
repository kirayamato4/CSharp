using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chapter04
{
	static class Program
	{
		/// <summary>
		/// 해당 응용 프로그램의 주 진입점입니다.
		/// </summary>
		[STAThread]
		static void Main()
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault( false );
			// Application.Run( new Form1() );	// 파일 읽기 쓰기 예제
			// Application.Run( new Form2() );	// 파일 보기 예제
			// Application.Run( new Form3() );	// 파일 복사 이동 예제
			// Application.Run( new Form4() );	// 파일 지우기 예제
			Application.Run( new Form5() );	// 파일 모니터 예제
		}
	}
}
