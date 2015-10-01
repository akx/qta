/*
 * Date: 9.12.2009
 * Time: 21:27
 */
using System;
using System.Drawing;
using System.Drawing.Imaging;

namespace Qta
{
	
	
	
	public class Renderer
	{
		private AccumulatorBuffer buffer;
		private Palette palette;
		private float sigma;
		private float zeta;
		private float gamma;
		public float lastRenderGValue;
		
		public AccumulatorBuffer Buffer {
			get { return buffer; }
			set { buffer = value; }
		}
		
		public Palette Palette {
			get { return palette; }
		}
		
		public float Sigma {
			get { return sigma; }
			set { sigma = value; }
		}
		
		public float Zeta {
			get { return zeta; }
			set { zeta = value; }
		}
		
		public float Gamma {
			get { return gamma; }
			set { gamma = value; }
		}
		
		
		
		public Renderer(AccumulatorBuffer buf, Palette pal)
		{
			buffer = buf;
			sigma = 0.475f;
			gamma = .15f;
			zeta = 1.0f;
			palette = pal;
		}
		
		public void Render(Bitmap bmp)
		{
			float xScale = bmp.Width / (float)buffer.Width;
			float yScale = bmp.Height / (float)buffer.Height;
			uint n = 0;
			float v = 0;
			for(uint x=0;x<buffer.Width;x++)
			{
				for(uint y=0;y<buffer.Height;y++)
				{
					float val = buffer.get(x, y);
					if(val>0) {
						v += val;
						n ++;
					}
				}
			}
			if(n==0) v=0;
			else v /= (float)n;
			lastRenderGValue = v;
			
			//System.Diagnostics.Debug.Print("N = {0}, GVal = {1}", n, v);
			unsafe {
				float[] bdata = buffer.getData();
				uint w = buffer.Width;
				BitmapData bd = bmp.LockBits(new Rectangle(0, 0, bmp.Width, bmp.Height), ImageLockMode.ReadWrite, PixelFormat.Format24bppRgb);
				//System.Diagnostics.Debug.Print("{0}, {1} - s = {2}", bd.Width, bd.Height, bd.Stride);
				for(uint y=0;y<bd.Height;y++)
				{
					byte* row=(byte *)bd.Scan0 + (y * bd.Stride);
					for(uint x=0;x<bd.Width;x++)
					{
						int cv;
						if(v == 0)
						{
							cv = 0;
						}
						else
						{
							float val = (float)Math.Pow(bdata[w*y+x] / v * zeta, sigma) * gamma;
							//uint sx = x;//(uint)Math.Round(x / xScale);
							//uint sy = y;//(uint)Math.Round(y / yScale);
							
							//float val = (float)Math.Pow(buffer.get(sx, sy) / v * zeta, sigma) * gamma;
							cv = palette.mapColor(val).ToArgb();
						}
						uint xp=x*3;
						row[xp] = (byte)(cv&0xFF);
						row[xp+1] = (byte)((cv>>8)&0xFF);
						row[xp+2] = (byte)((cv>>16)&0xFF);
					}
				}
				bmp.UnlockBits(bd);
			}
		}
	}
}
