using System;
using System.Collections.Generic;
using System.Text;

namespace SquareLibrary
{
	public class Circle : Shape
	{
		public double Radius { get; set; }

		public Circle(string _typeName, double _radius) : base(_typeName)
		{
			if (CheckCircle(_radius))
				Radius = _radius;
		}

		private bool CheckCircle(double _radius)
		{
			if (_radius <= 0)
				throw new FigureException("There is no circle with this radius.");
			return true;
		}

		public override double Square()
		{
			return Math.Round(Math.PI * Radius * Radius, 2);
		}
	}
}
