using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CPaint.Class
{
	/// <summary>
	/// Implementing shape to draw triangle 
	/// </summary>
	public class Triangle : Shape
	{
		/// <summary>
		/// X-axis point1
		/// </summary>
		public int initX { get; set; }
		/// <summary>
		/// Y-axis point1 
		/// </summary>
		public int initY { get; set; }
		/// <summary>
		/// X-axis point 2
		/// </summary>
		public int x2 { get; set; }
		/// <summary>
		/// Y-axis point 2
		/// </summary>
		public int y2 { get; set; }
		/// <summary>
		/// X-axis point 3 
		/// </summary>
		public int x3 { get; set; }
		/// <summary>
		/// Y-axis point 3
		/// </summary>
		public int y3 { get; set; }

		/// <summary>
		/// Draw Method overriding draw method of shape to draw triangle (three sides polygon)
		/// </summary>
		/// <param name="surface">object of graphics  </param>
		public override void Draw(Graphics surface)
		{
			//first point as position of pen 
			Point point1 = new Point(initX, initY);
			Point point2 = new Point(x2, y2);
			Point point3 = new Point(x3, y3);
			//assigning all the points to Point array 
			Point[] curvePoints =
			{
				 point1,
				 point2,
				 point3,
			 };
			Pen myPen = new Pen(Color.Black, 2);
			surface.DrawPolygon(myPen, curvePoints);
		}
	}

}
