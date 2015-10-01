/*
 * Date: 9.12.2009
 * Time: 23:08
 */
using System;

namespace Qta
{
	/// <summary>
	/// Description of SimPoint.
	/// </summary>
	public class SimPoint
	{
		public enum PointType {
			SpawnPoint,
			GravityPoint
		};

		public float x, y;
		public PointType type;
		public float strength;
		public float twist;
		
		public SimPoint(float x, float y, PointType type, float strength, float twist)
		{
			this.x = x;
			this.y = y;
			this.type = type;
			this.strength = strength;
			this.twist = twist;
		}
		
	}
}
