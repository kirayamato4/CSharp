using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chapter02
{
	public partial class Form1 : Form
	{
		// 결과 : 저장용 변수
		string result = "";

		public Form1()
		{
			InitializeComponent();
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			result = this.lbResult.Text;
		}

		private void btnEdit_Click(object sender, EventArgs e)
		{
			if( TextCheck() )
			{
				this.lbResult.Text = result + this.txtEdit.Text;
			}
		}

		private bool TextCheck()
		{
			if ("" != this.txtEdit.Text)
			{
				return true;
			}
			else
			{
				MessageBox.Show("텍스트를 입력하세요", "알림", MessageBoxButtons.OK, MessageBoxIcon.Error);
				this.txtEdit.Focus();
				return false;
			}
		}

		private void txtEdit_KeyPress( object sender, KeyPressEventArgs e )
		{
			// 13: 엔터키
			if( e.KeyChar == (char)13 )
			{
				// 소리 없애기
				e.Handled = true;

				if( TextCheck() )
				{
					this.lbResult.Text = result + this.txtEdit.Text;
				}
			}
		}
	}
}
