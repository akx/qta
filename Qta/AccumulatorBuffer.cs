/*
 * Date: 9.12.2009
 * Time: 21:12
 */
using System;
using System.Drawing;

namespace Qta
{
	/// <summary>
	/// Description of AccumulatorBuffer.
	/// </summary>
	public class AccumulatorBuffer
	{
		private float[] buffer;
		private uint width;
		private uint height;
		public uint Width {
			get { return width; }
		}
		
		public uint Height {
			get { return height; }
		}
		
		public AccumulatorBuffer(uint width, uint height)
		{
			buffer = new float[width*height];
			this.width = width;
			this.height = height;
			clear();
		}
		public void clear()
		{
			for(uint n=0;n<width*height;n++) buffer[n]=0;
		}
		public void add(uint x, uint y, float val)
		{
			//if(x<0||x>=width||y<0||y>=height) return;
			buffer[y*width + x] += val;
		}
		public float get(uint x, uint y)
		{
			if(x<0||x>=width||y<0||y>=height) return 0;
			return buffer[y*width + x];
		}
		
		public float[] getData()
		{
			return buffer;
		}
	}
}
