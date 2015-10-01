/*
 * Date: 9.12.2009
 * Time: 23:17
 */
using System;

namespace Qta
{
	/// <summary>
	/// Description of Particle.
	/// </summary>
	public class Particle
	{
		public float x, y, dx, dy;
		public uint life;
		public Particle(float x, float y, float dx, float dy, uint life)
		{
			this.x = x;
			this.y = y;
			this.dx = dx;
			this.dy = dy;
			this.life = life;
		}
		
	}
}
