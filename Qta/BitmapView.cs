/*
 * Date: 10.12.2009
 * Time: 0:13
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Qta
{
	/// <summary>
	/// Description of BitmapView.
	/// </summary>
	public partial class BitmapView : Form
	{
		public BitmapView()
		{
			InitializeComponent();

		}
		
		public void setBitmap(Bitmap bmp, bool resizeFrame)
		{
			pictureBox1.Image = bmp;
			pictureBox1.Width = bmp.Width;
			pictureBox1.Height = bmp.Height;
			if(resizeFrame)
			{
				ClientSize = new Size(pictureBox1.Width, pictureBox1.Height);
			}
			this.Text = String.Format("{0} x {1}", bmp.Width, bmp.Height);
		}
	}
}
