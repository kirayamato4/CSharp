using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chapter05
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
			// Application.Run( new Form1() );	// 우산 폼 예제
			// Application.Run( new Form2() );	// 시스템 성능 보기 예제
			// Application.Run( new Form3() );	// 워터마킹 예제
			// Application.Run( new Form4() );	// 그래프 그리기 예제
			Application.Run( new Form5() );	// 화면 캡쳐 예제
		}
	}
}
