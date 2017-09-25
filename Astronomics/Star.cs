/*
 * Сделано в SharpDevelop.
 * Пользователь: suvoroda
 * Дата: 06/03/2015
 * Время: 17:36
 */
using System;

namespace Astronomics
{
	/// <summary>
	/// Description of Star.
	/// </summary>
	public class Star
	{
		public Star()
		{						
		}
		
		public Star(string name, double rad, double mass, double speedrotat, double svetimost)
		{
			this.Name = name;
			this.Radius = rad;
			this.Massa = mass;
			this.SpeedRotationAftesIstAxis = speedrotat;
			this.Svetimost = svetimost;
		}
		
		string _name;
		double _radius;
		double _massa;
		double _svetimost;
		double _speedrotationitsafteraxis;
		
		public string Name
		{
			get { return this._name; }
			set { this._name = value; }
		}
		public double Radius
		{
			get { return this._radius; }
			set { this._radius = value; }
		}
		public double Massa
		{
			get { return this._massa; }
			set { this._massa = value; }
		}
		public double Svetimost
		{
			get { return this._svetimost; }
			set { this._svetimost = value; }
		}
		public double SpeedRotationAftesIstAxis
		{
			get { return this._speedrotationitsafteraxis; }
			set { this._speedrotationitsafteraxis = value; }
		}
		
	}
}
