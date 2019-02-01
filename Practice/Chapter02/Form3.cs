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
	public partial class Form3 : Form
	{
		string[] foodList = new string[] { "스테이크", "카레라이스", "라면", "만두국" };
		string result;

		public Form3()
		{
			InitializeComponent();
		}

		private void Form3_Load(object sender, EventArgs e)
		{
			result = this.lbResult.Text;

			foreach( string food in foodList )
			{
				this.cbList.Items.Add(food);
			}
		}

		private void btnAdd_Click(object sender, EventArgs e)
		{
			string food = this.txtList.Text;

			if( "" != food )
			{
				this.cbList.Items.Add(food);

				MessageBox.Show($"{food}을/를 추가했습니다.", "알림", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
			else
			{
				this.txtList.Focus();
			}

			this.txtList.Text = "";
		}

		private void cbList_SelectedIndexChanged(object sender, EventArgs e)
		{
			if( "" != this.cbList.Text )
			{
				this.lbResult.Text = result + this.cbList.Text;
			}
		}
	}
}
