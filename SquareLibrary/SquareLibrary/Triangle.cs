using System;
using System.Collections.Generic;
using System.Text;

namespace SquareLibrary
{
	public class Triangle : Shape
	{
		public double EdgeA { get; set; }
		public double EdgeB { get; set; }
		public double EdgeC { get; set; }

		public Triangle(string figureType, double a, double b, double c) : base(figureType)
		{
			if (CheckTriangle(a, b, c) == true)
			{
				EdgeA = a;
				EdgeB = b;
				EdgeC = c;
			}
		}

		private bool CheckTriangle(double a, double b, double c)
		{
			if (a < 0 || b < 0 || c < 0)
			{
				throw new FigureException("Such a triangle does not exist. (edges less than 0)");
			}
			if (a > (b + c) || b > (a + c) || c > (a + b))
			{
				throw new FigureException("Such a triangle does not exist. (side is greater than the sum of the other two)");
			}
			return true;
		}

		public override double Square()
		{
			double p = (EdgeA + EdgeB + EdgeC) / 2;
			return Math.Sqrt(p * (p - EdgeA) * (p - EdgeB) * (p - EdgeC));
		}		

		public bool IsStraightTriangle()
		{
			double a2 = EdgeA * EdgeA;
			double b2 = EdgeB * EdgeB;
			double c2 = EdgeC * EdgeC;
			return (a2 == b2 + c2 || b2 == a2 + c2 || c2 == a2 + b2);
		}
	}
}
