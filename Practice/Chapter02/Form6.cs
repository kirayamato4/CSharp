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
	public partial class Form6 : Form
	{
		string name, age, work;

		enum Info
		{
			NAME = 0,
			AGE,
			WORK
		}

		public Form6()
		{
			InitializeComponent();
		}

		private void lvView_Click(object sender, EventArgs e)
		{
			if( 0 == this.lvView.SelectedItems.Count )
			{
				MessageBox.Show("아이템을 선택하세요", "알림", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			else
			{
				ListViewItem selectedItem = this.lvView.SelectedItems[0];

				string notice =
					"이름 : " + selectedItem.SubItems[(int)Info.NAME].Text + "\n" +
					"나이 : " + selectedItem.SubItems[(int)Info.AGE].Text + "\n" +
					"직업 : " + selectedItem.SubItems[(int)Info.WORK].Text;

				MessageBox.Show(this, notice, "알림", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
		}

		private void btnAdd_Click(object sender, EventArgs e)
		{
			if( TextCheck() )
			{
				name = this.tbName.Text;
				age = this.tbAge.Text;
				work = this.tbWork.Text;

				this.tbName.Text = "";
				this.tbAge.Text = "";
				this.tbWork.Text = "";
			}
			else
			{
				return;
			}

			ListViewItem item = new ListViewItem(new string[] { name, age, work });
			this.lvView.Items.Add(item);
		}

		private bool TextCheck()
		{


			return true;
		}
	}
}
