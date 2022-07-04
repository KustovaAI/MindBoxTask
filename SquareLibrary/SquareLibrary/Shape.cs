using System;

namespace SquareLibrary
{
	public abstract class Shape
	{
		public string FigureType { get; set; }
		public Shape(string figureType)
		{
			FigureType = figureType;
		}
		public abstract double Square();
	}
}
