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
	/// Description of Planet.
	/// </summary>
	public class Planet
	{
		public Planet()
		{
		}
		
		public Planet(string name, double rad, double mass, double speedrotat, double speedrotatafterstar)
		{
			this.Name = name;
			this.Radius = rad;
			this.Massa = mass;
			this.SpeedRotationAftesIstAxis = speedrotat;
			this.SpeedRotationAfterStar = speedrotatafterstar;
		}
		
		string _name;
		double _radius;
		double _massa;
		double _speedrotationafteristaxis;
		double _speedrotationafterstar;
		
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
		public double SpeedRotationAftesIstAxis
		{
			get { return this._speedrotationafteristaxis; }
			set { this._speedrotationafteristaxis = value; }
		}
		public double SpeedRotationAfterStar
		{
			get { return this._speedrotationafterstar; }
			set { this._speedrotationafterstar = value; }
		}
	}
}
