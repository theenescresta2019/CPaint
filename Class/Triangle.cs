using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CPaint.Class
{
	public class Triangle : Shape
	{
		public float Width { get; set; }
		public float Height { get; set; }
		public float initX { get; set; }
		public float initY { get; set; }

		public override void Draw(Graphics surface)
		{
			Pen myPen = new Pen(Color.Black, 2);
			surface.DrawRectangle(myPen, initX, initY, Width, Height);
		}
	}

}
