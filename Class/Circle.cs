using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CPaint.Class
{
	class Circle
	{
		Graphics graphics;
		public void Draw(float initX, float initY )
		{
			//output.Show();
			Pen pen = new Pen(Color.Black, 4);
			SolidBrush brush = new SolidBrush(Color.Black);
			graphics.FillEllipse(brush, 12, 12, 12, 12);
			graphics.DrawEllipse(pen, 12, 12, 12, 12);

			//	output.outputArea.Image = graphics.DrawEllipse(pen, 12, 12, 12, 12);
			Console.WriteLine("ok drawing circle for you" + initX + "   " + initY);
		}
	}
}
