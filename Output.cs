using CPaint.Class;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace CPaint
{
	public partial class Output : Form
	{
		public List<Shape> Shapes { get; set; }

		public Output()
		{
			Shapes = new List<Shape>();
			InitializeComponent();
		}

		protected override void OnPaint(PaintEventArgs e)
		{
			foreach (Shape shapeToDraw in Shapes)
			{
				shapeToDraw.Draw(e.Graphics);
			}
		}


		private void Output_Load(object sender, EventArgs e)
		{

		}

		private void outputArea_Paint(object sender, PaintEventArgs e)
		{

		}
		




	}
}
