using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SquareLibrary;

namespace SquareLibraryTests
{
	[TestClass]
	public class CircleTest
	{
		[TestMethod]
		public void Check_Circle_Square_15()
		{
			Shape circle = new Circle("Circle", 15);

			double result = circle.Square();

			double expected = 706.86;

			Assert.AreEqual(expected, result);
		}

		[TestMethod]
		[ExpectedException(typeof(FigureException),	"There is no circle with this radius.")]
		public void Check_Circle_Square_With_Wrong_Radius()
		{
			Shape circle = new Circle("Circle", -15);
			var result = circle.Square();
		}
	}

	[TestClass]
	public class TriangleTests
	{
		[TestMethod]
		public void Check_Triangle_Square_3and4and5()
		{
			Shape triangle = new Triangle("Triangle", 3, 4, 5);
			
			double result = triangle.Square();

			double expected = 6;

			Assert.AreEqual(expected, result);
		}

		[TestMethod]
		public void Is_Straight_Triangle_1()
		{
			var triangle = new Triangle("Triangle", 3, 4, 5);

			var result = triangle.IsStraightTriangle();

			Assert.IsTrue(result);
		}

		[TestMethod]
		public void Is_Straight_Triangle_2()
		{
			var triangle = new Triangle("Triangle", 13, 14, 15);

			var result = triangle.IsStraightTriangle();

			Assert.IsFalse(result);
		}

		[TestMethod]
		[ExpectedException(typeof(FigureException), "Such a triangle does not exist. (edges less than 0)")]
		public void Check_Triangle_Square_With_Negative_Edges()
		{
			Shape triangle = new Triangle("Triangle", -15, -16, -17);
			var result = triangle.Square();
		}

		[TestMethod]
		[ExpectedException(typeof(FigureException), "Such a triangle does not exist. (side is greater than the sum of the other two)")]
		public void Check_Triangle_Square_With_Wrong_Edges()
		{
			Shape triangle = new Triangle("Triangle", 12, 1, 7);
			var result = triangle.Square();
		}
	}

}
