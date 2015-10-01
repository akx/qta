/*
 * Date: 9.12.2009
 * Time: 23:07
 */
using System;
using System.Collections.Generic;

namespace Qta
{
	/// <summary>
	/// Description of ParticleChamber.
	/// </summary>
	public class ParticleChamber
	{
		AccumulatorBuffer buffer;
		List<SimPoint> points;
		SimPoint[] gPoints;
		SimPoint[] sPoints;
		LinkedList<Particle> particles;
		List<Particle> deletionMarks;
		Random r;
		
		public ParticleChamber(AccumulatorBuffer buf)
		{
			buffer = buf;
			points = new List<SimPoint>();
			gPoints = null;
			sPoints = null;
			particles = new LinkedList<Particle>();
			deletionMarks = new List<Particle>();
			
			ResetChamber(5, false, 0);
		}
		
		public void ResetChamber(int nPoints, bool allowMultipleEmitters, float repellerPerc)
		{
			r = new Random();
			particles.Clear();
			deletionMarks.Clear();
			points.Clear();
			if(!allowMultipleEmitters) points.Add(new SimPoint(buffer.Width/2, buffer.Height/2, SimPoint.PointType.SpawnPoint, 5, 0));
			for(int i=0;i < nPoints; i++)
			{
				float x = (float)r.NextDouble() * buffer.Width;
				float y = (float)r.NextDouble() * buffer.Height;
				if(allowMultipleEmitters && r.Next(100) < 33)
				{
					points.Add(new SimPoint(
						x, y,
						SimPoint.PointType.SpawnPoint,
						5,
						0
					));
				}
				else
				{
					float pole =(r.NextDouble() < repellerPerc ? -.1f: 1);
					points.Add(new SimPoint(
						x, y,
						SimPoint.PointType.GravityPoint,
						(float)r.NextDouble()*-.05f * pole,
						.1f//(float)(-.5 + r.NextDouble()) * .005f
					));
				}
			}
			List<SimPoint> lgPoints = new List<SimPoint>();
			List<SimPoint> lsPoints = new List<SimPoint>();
			//gPoints.Clear();
			//sPoints.Clear();
			foreach(SimPoint point in points)
			{
				switch(point.type)
				{
					case SimPoint.PointType.GravityPoint:
						lgPoints.Add(point);
						break;
					case SimPoint.PointType.SpawnPoint:
						lsPoints.Add(point);
						break;
				}
			}
			gPoints = lgPoints.ToArray();
			sPoints = lsPoints.ToArray();
		}
		
		public int GetActiveParticleCount()
		{
			return particles.Count;
		}
		
		public void update(float friction)
		{
			
			foreach(SimPoint point in sPoints)
			{
				for(int i=0;i<15;i++)
				{
					double angle = r.NextDouble() * 6.282;
					double speed = r.NextDouble() * point.strength;
					Particle p = new Particle(
						point.x, point.y,
						(float)(Math.Cos(angle) * speed),
						(float)(Math.Sin(angle) * speed),
						(uint)((2500) * (r.NextDouble() * 0.33 + 0.67))
					);
					particles.AddLast(p);
				}
			}
			uint w = buffer.Width;
			uint h = buffer.Height;
			deletionMarks.Clear();
			foreach(Particle p in particles)
			{
				p.life--;
				if(p.life>0)
				{
					foreach(SimPoint point in gPoints) // gPoints already only has gravity points
					{
						float dx = (p.x - point.x);
						float dy = (p.y - point.y);
						float ds = (float)Math.Sqrt(dx*dx + dy*dy);
						if(point.twist!=0)
						{
							float an = (float)Math.Atan2(dy, dx);
							dx = (float)Math.Cos(an + point.twist) * ds;
							dy = (float)Math.Sin(an + point.twist) * ds;
						}
						float s = (float)(point.strength * (1f / ds));
						
						
						p.dx += s * dx;
						p.dy += s * dy;
					}
					p.x += p.dx;
					p.y += p.dy;
					p.dx /= friction;
					p.dy /= friction;
					int drawX = (int)Math.Round(p.x-.5+r.NextDouble());
					int drawY = (int)Math.Round(p.y-.5+r.NextDouble());
					if(drawX>=0&&drawX<w&&drawY>=0&&drawY<h) buffer.add((uint)drawX, (uint)drawY, .5f);
				}
				else
				{
					//particles.Remove(p);
					deletionMarks.Add(p);
				}
			}
			foreach(Particle p in deletionMarks) particles.Remove(p);
		}
	}
}
