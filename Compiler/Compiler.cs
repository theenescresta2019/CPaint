using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CPaint.Compilers
{
	class Compiler
	{
		Graphics graphics;
		int? penPosition = null;
		int? initX = null;
		int? initY = null;
		string[] commands = { "clear", "reset", "rectangle", "circle", "triangle", "position pen", "pen draw" };
		public string Line { get; set; }
		public Output outputWindow;

		public Compiler(Output form)
		{
			outputWindow = form;
			
		}
		public Compiler() { }

		public bool CheckSyntax(string syntax)
		{
			bool result = false;
			if(Array.Exists(commands, element => element == syntax.ToLower().Trim())){
				result = true;
			}
			return result;
		}

		public void ClearOutput()
		{
			if(outputWindow.Visible== true)
			{
//			outputWindow.outputArea.BackColor = Color.Red;
			outputWindow.outputArea.Image = null;

			}
			else
			{
				outputWindow.Show();
			//	outputWindow.outputArea.BackColor = Color.Red;
				outputWindow.outputArea.Image = null;
			}
			
		}

		public void ResetOutput()
		{

			if (outputWindow.Visible == true)
			{
				penPosition = null;
			}
			else
			{
				penPosition = null;
				//outputWindow.Show();
				//outputWindow.outputArea.BackColor = Color.Pink;

			}
			//Output o = new Output();
			//o.outputArea.Image=null ;
			//o.outputArea.BackColor = Color.Red;
			//o.Show();
		}


		public string Compile(string line)
		{
			//outputWindow.outputArea.BackColor= Color.Black;

						
		
			string output = "";
			string[] code = line.Split(',', '(', ')');
			code = code.Where(x => !string.IsNullOrEmpty(x)).ToArray();

			bool checkSyntax = CheckSyntax(code[0]);
			if(checkSyntax == true)
			{
				

				outputWindow.outputArea = null;
				//Output o = new Output();
				//o.outputArea =null

				//outputWindow=new Output()
				outputWindow.Show();
				
				output = "valid syntax found" +code[0];
			

			}
			else
			{
				output = "\n Synax Error:"+ code[0]+ " is not a valid syntax; \n Info: clear, reset, rectangle, circle, triangle, position, pen, draw are some of the valid syntax. \n";
			}
			
			//foreach (var c in code)
			//{
				//if (!String.IsNullOrWhiteSpace(c))
				//{

				//}



			//}
			return output;
		}




	}
}
