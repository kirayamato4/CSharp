using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chapter03
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
			// Application.Run(new Form1());	// 트레이 아이콘 예제
			// Application.Run(new Form2());	// 폼 꾸미기 예제
			Application.Run(new Form3());	// 폰트 꾸미기 예제
		}
	}
}
