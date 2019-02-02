using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chapter03
{
	public partial class Form2 : Form
	{
		public Form2()
		{
			InitializeComponent();
		}


		private void Form2_Load(object sender, EventArgs e)
		{

		}

		private void btnModal_Click(object sender, EventArgs e)
		{
			FormModal modal = new FormModal();
			modal.SetText = this.btnModal.Text + " 실행";
			modal.Show();	
		}

		private void btnModaless_Click(object sender, EventArgs e)
		{
			FormModaless modaless = new FormModaless();
			modaless.SetText = this.btnModaless.Text + " 실행";
			modaless.ShowDialog();
		}
	}
}
