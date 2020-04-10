using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Threading.Tasks;

namespace CPaint.Class
{
	/// <summary>
	/// implements shape class to draw rectangle 
	/// </summary>
	public class Rectangle : Shape
	{
		/// <summary>
		/// Width of the rectangle 
		/// </summary>
		public int Width { get; set; }
		/// <summary>
		/// Height of the rectangle 
		/// </summary>
		public int Height { get; set; }
		/// <summary>
		/// X-axis point
		/// </summary>
		public int InitX { get; set; }
		/// <summary>
		/// Y-axis point 
		/// </summary>
		public int InitY { get; set; }

		/// <summary>
		/// Override draw method of shape and draw rectangle 
		/// </summary>
		/// <param name="surface">Object of Graphics </param>
		public override void Draw(Graphics surface)
		{
			Pen myPen = new Pen(Color.Black, 2);
			surface.DrawRectangle(myPen, InitX, InitY, Width, Height);
		}
	}
}
