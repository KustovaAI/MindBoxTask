using System;
using System.Collections.Generic;
using System.Text;

namespace SquareLibrary
{
	public class FigureException : Exception
	{
		public FigureException(string message) : base(message) {}
	}
}
