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
	public partial class Form5 : Form
	{
		string result = "";

		public Form5()
		{
			InitializeComponent();
		}

		private void Form5_Load(object sender, EventArgs e)
		{
			result = this.lbResult.Text;
		}

		private void btnAdd_Click(object sender, EventArgs e)
		{
			if( "" != this.tbList.Text )
			{
				this.lbView.Items.Add(this.tbList.Text);
				this.tbList.Text = "";
			}
			else
			{
				MessageBox.Show("아이템을 입력하세요", "알림", MessageBoxButtons.OK, MessageBoxIcon.Error);
				this.tbList.Focus();
			}
		}

		private void lbView_SelectedIndexChanged(object sender, EventArgs e)
		{
			this.lbResult.Text = result + this.lbView.SelectedItem.ToString();
		}
	}
}
