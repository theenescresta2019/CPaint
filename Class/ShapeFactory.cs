using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CPaint.Class
{
	/// <summary>
	/// ShapeFactory Class 
	/// </summary>
	public class ShapeFactory
	{
		/// <summary>
		/// CreateShape Class 
		/// </summary>
		/// <param name="shapeName">Name of Shape </param>
		/// <param name="initX">initial X-axis (pen position )</param>
		/// <param name="initY">initial Y-axis (pen position )</param>
		/// <param name="radius">radius of circle</param>
		/// <param name="height">height of rectangle </param>
		/// <param name="width">width of rectangle </param>
		/// <param name="x2">point1 X-axis of triangle </param>
		/// <param name="y2">point1 Y-axis of triangle </param>
		/// <param name="x3">point2 X-axis of triangle </param>
		/// <param name="y3">point2 Y-axis of triangle </param>
		/// <returns></returns>
		public static Shape CreateShape(string shapeName, int initX, int initY, int radius, int height, int width, int x2, int y2, int x3, int y3)
		{
			switch (shapeName)
			{
				case "circle":
					return new Circle() { InitX = initX, InitY = initY, Radius = radius };
				case "rectangle":
					return new Rectangle() { InitX = initX, InitY = initY, Width = width, Height = height };
				case "triangle":
					return new Triangle() { initX = initX, initY = initY, x2 = x2, y2 = y2, x3 = x3, y3 = y3 };
				case "drawto":
					return new Line() { InitX = initX, InitY = initY, X2 = x2, Y2 = y2 };
				default:
					throw new NotSupportedException("shapeName");
			}
		}
	}
}
