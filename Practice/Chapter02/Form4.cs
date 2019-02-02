using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;	// 프로젝트 참조 / 어셈블리 / Microsoft.VisualBasic 추가


namespace Chapter02
{
	public partial class Form4 : Form
	{
		int count = 0;

		public Form4()
		{
			InitializeComponent();
		}

		private void Form4_Load(object sender, EventArgs e)
		{

		}

		private void btnStart_Click(object sender, EventArgs e)
		{
			if( IntCheck() )
			{
				count = Convert.ToInt32(this.txtNum.Text);
				this.txtNum.ReadOnly = true;
				this.timer1.Enabled = true;
			}
		}

		private bool IntCheck()
		{
			// Microsoft.VisualBasic
			if( Information.IsNumeric( this.txtNum.Text ) )
			{
				return true;
			}
			else
			{
				MessageBox.Show("숫자를 입력하세요", "알림", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return false;
			}
		}

		private void timer1_Tick( object sender, EventArgs e )
		{
			if (count < 1)
			{
				this.timer1.Enabled = false;
				this.txtNum.ReadOnly = false;
				this.txtNum.Text = "";

				MessageBox.Show("펑", "알림", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
			else
			{
				--count;
				this.txtCountDown.Text = Convert.ToString(count);
			}
		}
	}
}
