using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CPaint.Class
{
	/// <summary>
	/// Circle class which implements shape 
	/// </summary>
	public class Circle : Shape
	{
		/// <summary>
		/// Radius of circle
		/// </summary>
		public int Radius { get; set; }
		/// <summary>
		/// X-axis point to draw circle 
		/// </summary>
		public int InitX { get; set; }
		/// <summary>
		/// Y-axis point to draw circle 
		/// </summary>
		public int InitY { get; set; }
		/// <summary>
		/// Overrides Draw Methods and draw Circle 
		/// </summary>
		/// <param name="surface">Object of Graphics</param>
		public override void Draw(Graphics surface)
		{
			Pen myPen = new Pen(Color.Black, 2);
			surface.DrawEllipse(myPen, InitX, InitY, Radius, Radius);
		}
	}
}