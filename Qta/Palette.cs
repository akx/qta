/*
 * Date: 9.12.2009
 * Time: 21:40
 */
using System;
using System.Drawing;
using System.Collections.Generic;
namespace Qta
{
	/// <summary>
	/// Description of Palette.
	/// </summary>
	public class Palette
	{
		public const int DEFAULT_CACHE_SIZE = 4096;
		public List<PaletteKeyPoint> keyPoints;
		private Color[] cache;
		
		
		public Palette()
		{
			keyPoints = new List<PaletteKeyPoint>();
			keyPoints.Add(new PaletteKeyPoint(Color.Black, 0f));
			keyPoints.Add(new PaletteKeyPoint(Color.Red, 0.33f));
			keyPoints.Add(new PaletteKeyPoint(Color.Yellow, 0.66f));
			keyPoints.Add(new PaletteKeyPoint(Color.White, 1f));
		}
		
		private static uint packRGB(float r, float g, float b)
		{
			//r*=255.0f;
			//g*=255.0f;
			//b*=255.0f;
			if(r>255) r=255;
			if(g>255) g=255;
			if(b>255) b=255;
			return ((uint)r)<<16|((uint)g)<<8|((uint)b);
		}
		
		public bool RequiresSort()
		{
			for(int i=1;i<keyPoints.Count;i++)
			{
				if(keyPoints[i].Position < keyPoints[i-1].Position)
				{
					return true;
				}
			}
			return false;
		}
		
		public bool prepare()
		{
			bool needsSort = RequiresSort();
			
			if(needsSort)
			{
				keyPoints.Sort(
					delegate(PaletteKeyPoint pk1, PaletteKeyPoint pk2)
					{
						float p = pk1.Position - pk2.Position;
						if(p<0)return -1;
						if(p>0)return 1;
						return 0;
					}
				);
			}
			recache(DEFAULT_CACHE_SIZE);
			return needsSort;
		}
		
		private void recache(int steps)
		{
			System.Diagnostics.Debug.Print("Running recache!");
			cache = new Color[steps];
			for(int i=0;i<steps;i++)
			{
				cache[i] = mapColorImmediate(i / (float)steps);
			}
			
		}
		
		public Color mapColorImmediate(float p)
		{
			if(p<0) p=0;
			if(p>1) p=1;
			for(int i=0;i<keyPoints.Count;i++)
			{
				if(i==keyPoints.Count-1 || keyPoints[i+1].Position>p)
				{
					PaletteKeyPoint kp = keyPoints[i];
					
					if(i==keyPoints.Count-1) return kp.Color;
					PaletteKeyPoint kp2 = keyPoints[i+1];
					float q = (p - kp.Position) / (kp2.Position - kp.Position);
					if(q<0) return kp.Color;
					if(q>1) q=1;
					float iq = 1.0f - q;
					int R = (int)Math.Round(kp.Color.R * iq + kp2.Color.R * q);
					int G = (int)Math.Round(kp.Color.G * iq + kp2.Color.G * q);
					int B = (int)Math.Round(kp.Color.B * iq + kp2.Color.B * q);
					//System.Diagnostics.Debug.Print("p={0} q={1} c1=({2}) c2=({3}) rgb={4}/{5}/{6}", p, q, kp.Color, kp2.Color, R, G, B);
					return Color.FromArgb(255, R, G, B);
				}
			}
			/*
			if(p<.3f) return packRGB(p / .3f, 0, 0);
			p -= .3f;
			if(p<.3f) return packRGB(1, p/.3f, 0);
			p -= .3f;
			return packRGB(1, 1, p/.4f);*/
			return keyPoints[0].Color;//Color.Magenta;
		}
		
		public Color mapColor(float p)
		{
			//recache(128);
			//throw new SystemException();
			if(cache == null) recache(DEFAULT_CACHE_SIZE);
			if(p<0) p=0;
			if(p>=1) p=1;
			int idx = (int)Math.Floor(p * (cache.Length-1));
			return cache[idx];
			
			//return _mapColor(p);
		}
		
		public void SetEqualDistance(bool prepareFirst)
		{
			if(prepareFirst) prepare();
			float d = ((float)keyPoints.Count-1f);
			for(int i=0;i<keyPoints.Count;i++) keyPoints[i].Position = i / d;
		}
		
		public void setKeyPointsByColors(Color[] colors)
		{
			keyPoints.Clear();
			foreach(Color c in colors) keyPoints.Add(new PaletteKeyPoint(c, 0));
			SetEqualDistance(false);
			prepare();
		}
		
		public void reverse()
		{
			if(keyPoints.Count==0)return;
			List<float> positions = new List<float>();
			foreach(PaletteKeyPoint pkp in keyPoints) positions.Add(pkp.Position);
			positions.Reverse();
			for(int i=0;i<keyPoints.Count;i++) keyPoints[i].Position = positions[i];
			prepare();
		}
	}
}
