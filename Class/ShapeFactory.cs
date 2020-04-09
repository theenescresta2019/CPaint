using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CPaint.Class
{
	public class ShapeFactory
	{
		public static Shape CreateShape(string shapeName, float initX, float initY, float radius, float height, float width, float side1, float side2, float side3)
		{
			switch (shapeName)
			{
				case "circle":
					return new Circle() {initX=initX, initY=initY,Radius=radius };
				case "rectangle":
					return new Rectangle() { initX = initX, initY = initY, Width = width, Height = height};
				default:
					throw new NotSupportedException("shapeName");
			}
		}
	}
}
