/*
 * Date: 14.12.2009
 * Time: 19:56
 */
using System;
using System.Drawing;

namespace Qta
{
	/// <summary>
	/// Description of PaletteKeyPoint.
	/// </summary>
	public class PaletteKeyPoint
	{
		private Color color;
		private float position;
		
		public Color Color {
			get { return color; }
			set { color = value; }
		}
		
		public float Position {
			get { return position; }
			set { position = value; }
		}
		
		
		public PaletteKeyPoint()
		{
			color = Color.Black;
			position = 0;
		}
		
		public PaletteKeyPoint(Color color, float position)
		{
			this.color = color;
			this.position = position;
		}
		
	}
}
