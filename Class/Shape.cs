using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CPaint.Class
{
	/// <summary>
	/// Abstract class for shape 
	/// </summary>
	public abstract class Shape
	{
		/// <summary>
		/// Draw Method 
		/// </summary>
		/// <param name="surface">object of Graphics</param>
		public abstract void Draw(Graphics surface);
	}
}
;