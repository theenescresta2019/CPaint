using CPaint.Class;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace CPaint
{
	/// <summary>
	/// Output form class to show output 
	/// </summary>
	public partial class Output : Form
	{
		/// <summary>
		/// List of all the shapes 
		/// </summary>
		public List<Shape> Shapes { get; set; }

		/// <summary>
		/// Initializing all the components 
		/// </summary>
		public Output()
		{
			Shapes = new List<Shape>();
			InitializeComponent();
		}
		/// <summary>
		/// clears the output 
		/// </summary>
		public void ClearOutput()
		{
			this.Controls.Clear();
			
		}
		/// <summary>
		/// Draws all the shapes 
		/// </summary>
		/// <param name="e">Paint Event object </param>
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
