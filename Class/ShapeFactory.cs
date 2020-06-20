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
		/// <param name="x1">point1 X-axis of triangle </param>
		/// <param name="y1">point1 Y-axis of triangle </param>
		/// <param name="x2">point2 X-axis of triangle </param>
		/// <param name="y2">point2 Y-axis of triangle </param>
		/// <param name="x3">point3 X-axis of triangle </param>
		/// <param name="y3">point3 Y-axis of triangle </param>
		/// 		/// <param name="x4">point4 X-axis of triangle </param>
		/// <param name="y4">point4 Y-axis of triangle </param>
		/// 		/// <param name="x5">point5 X-axis of triangle </param>
		/// <param name="y5">point5 Y-axis of triangle </param>
		/// <returns></returns>
		public static Shape CreateShape(string shapeName, int initX, int initY, int radius, int height, int width, int x1, int y1, int x2, int y2, int x3, int y3, int x4, int y4, int x5, int y5)
		{
			switch (shapeName)
			{
				case "circle":
					return new Circle() { InitX = initX, InitY = initY, Radius = radius };
				case "rectangle":
					return new Rectangle() { InitX = initX, InitY = initY, Width = width, Height = height };
				case "triangle":
					return new Triangle() { x1 = x1, y1 = y1, x2 = x2, y2 = y2, x3 = x3, y3 = y3 };
				case "polygon":
					return new Polygon() { x1 = x1, y1 = y1, x2 = x2, y2 = y2, x3 = x3, y3 = y3, x4 = x4, y4 = y4, x5 = x5, y5 = y5 };
				case "drawto":
					return new Line() { x1 = x1, y1 = y1, X2 = x2, Y2 = y2 };
				default:
					throw new NotSupportedException("shapeName");
			}
		}
	}
}
