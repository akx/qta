/*
 * Date: 14.12.2009
 * Time: 19:44
 */
using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
using System.Collections.Generic;

namespace Qta
{
	/// <summary>
	/// Description of PaletteEditor.
	/// </summary>
	public partial class PaletteEditor : Form
	{
		private Palette pal;
		public Palette Pal {
			get { return pal; }
			set {
				pal = value;
				UpdateView();
			}
		}
		
		
		
		public PaletteEditor()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
		}
		
		public void UpdateView()
		{
			pal.prepare();
			flowLayoutPanel1.SuspendLayout();
			while(flowLayoutPanel1.Controls.Count > pal.keyPoints.Count) flowLayoutPanel1.Controls.RemoveAt(flowLayoutPanel1.Controls.Count-1);
			while(flowLayoutPanel1.Controls.Count < pal.keyPoints.Count) flowLayoutPanel1.Controls.Add(new PaletteEntryControl(this, null));
			for(int i=0;i<pal.keyPoints.Count;i++) ((PaletteEntryControl)flowLayoutPanel1.Controls[i]).Pkp = pal.keyPoints[i];
			flowLayoutPanel1.ResumeLayout(true);
			UpdateGradient();
		}
		
		public void UpdateGradient()
		{
			pal.prepare();
			Bitmap tbmp = new Bitmap(previewBox.ClientSize.Width, 1, PixelFormat.Format24bppRgb);
			for(int x=0;x<tbmp.Width;x++)
			{
				float p = x / (float)tbmp.Width;
				Color c = pal.mapColorImmediate(p);//Color.FromArgb((int)(pal.map(p) | (uint)0xFF000000));
				tbmp.SetPixel(x, 0, c);
			}
			Bitmap bmp = new Bitmap(previewBox.ClientSize.Width, previewBox.ClientSize.Height, PixelFormat.Format24bppRgb);
			Graphics g = Graphics.FromImage(bmp);
			g.InterpolationMode = InterpolationMode.NearestNeighbor;
			g.DrawImage(tbmp, 0, 0, bmp.Width, bmp.Height * 3);
			previewBox.Image = bmp;
		}
		
		void AddColorButtonClick(object sender, EventArgs e)
		{
			PaletteKeyPoint pkp = new PaletteKeyPoint();
			pkp.Position = 1.0f;
			pkp.Color = Color.OrangeRed;//Envelope
			pal.keyPoints.Add(pkp);
			UpdateView();
		}
		
		void UpdateButtonClick(object sender, EventArgs e)
		{
			UpdateView();
		}
		
		public void DeleteEntry(PaletteKeyPoint pkp)
		{
			if(pal.keyPoints.Count > 1)
			{
				pal.keyPoints.Remove(pkp);
				UpdateView();
			}
			else
			{
				MessageBox.Show("Can not remove last palette key point.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
			}
			
		}
		
		void PaletteEditorFormClosing(object sender, FormClosingEventArgs e)
		{
			Hide();
			e.Cancel=true;
		}
		
		void EqualDistancesButtonClick(object sender, EventArgs e)
		{
			pal.prepare();
			for(int i=0;i<pal.keyPoints.Count;i++)
			{
				pal.keyPoints[i].Position = i / ((float)pal.keyPoints.Count-1f);
			}
			UpdateView();
		}
		
		void ColourLoversToolStripMenuItemClick(object sender, EventArgs e)
		{
			(new ColourLoversBrowser(this)).Show();
		}
		
		void ReverseButtonClick(object sender, EventArgs e)
		{
			pal.reverse();
			UpdateView();
		}
	}
}
