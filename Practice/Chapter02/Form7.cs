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
	public partial class Form7 : Form
	{
		int imageCount = 0;
		public Form7()
		{
			InitializeComponent();
		}

		private void Form7_Load(object sender, EventArgs e)
		{
			this.picImage.Image = (Image)this.imgList.Images[0];
			imageCount = this.imgList.Images.Count;
		}

		private void btnNext_Click(object sender, EventArgs e)
		{
			--imageCount;
			if (imageCount < 0)
				imageCount = this.imgList.Images.Count - 1;

			this.picImage.Image = (Image)this.imgList.Images[imageCount];
		}
	}
}
