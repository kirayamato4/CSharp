using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chapter02
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
			Application.SetCompatibleTextRenderingDefault(false);
			// Application.Run(new Form1());	// 문자 입출력 예제
			// Application.Run(new Form2());	// 메세지 박스 보기 예제
			// Application.Run(new Form3());	// 메뉴 선택 추가 예제
			// Application.Run(new Form4());	// 타이머 예제
			// Application.Run(new Form5());	// 리스트 추가 예제
			// Application.Run(new Form6());	// 입력 목록 보기 예제
			Application.Run(new Form7());	// 그림 보기 예제
		}
	}
}
