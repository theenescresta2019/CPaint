using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CPaint.Class
{
	/// <summary>
	/// Implements shape to draw Line
	/// </summary>
	public class Line : Shape
	{
		/// <summary>
		/// Initial point X-axis 
		/// </summary>
		public int x1 { get; set; }
		/// <summary>
		/// Initial point Y-axis 
		/// </summary>
		public int y1 { get; set; }
		/// <summary>
		/// Another point X-axis 
		/// </summary>
		public int X2 { get; set; }
		/// <summary>
		/// Another point X-axis 
		/// </summary>
		public int Y2 { get; set; }

		/// <summary>
		/// Draws circle by overriding Draw Method
		/// </summary>
		/// <param name="surface">Object of Graphics</param>
		public override void Draw(Graphics surface)
		{
			Pen myPen = new Pen(Color.Black, 2);
			surface.DrawLine(myPen, x1, y1, X2, Y2);
		}
	}
}
