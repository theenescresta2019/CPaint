using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CPaint.Class;

namespace CPaint.Compilers
{
	class Compiler
	{
		Graphics graphics;
		//int? penPosition = null;
		float initX = 0;
		float initY = 0;
		Color color = Color.Red;
		/// <summary>
		/// Array of Predefined commands 
		/// </summary>
		string[] commands = { "clear", "reset", "rectangle", "circle", "triangle", "position pen", "pen draw" };
		public string Line { get; set; }
		public Output outputWindow;

		public Compiler(Output form)
		{
			outputWindow = form;
		}
		public Compiler() { }

		/// <summary>
		/// Check whether syntax is correct or not 
		/// </summary>
		/// <param name="syntax">name of syntax </param>
		/// <returns>true or false </returns>
		public bool IsSyntax(string syntax)
		{
			bool result = false;
			if (Array.Exists(commands, element => element == syntax.ToLower().Trim()))
			{
				result = true;
			}
			return result;
		}

		public bool IsNumeric(int? number)
		{
			bool result = false;
			//if()

			return result;
		}



		/// <summary>
		/// Used to clear the output window.
		/// </summary>
		public void ClearOutput()
		{
			if (outputWindow.Visible == true)
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
		/// <summary>
		/// to reset the output window 
		/// </summary>
		public void ResetOutput()
		{
			initX = 0;
			initY = 0;
			//	penPosition = null;
			//Output o = new Output();
			//o.outputArea.Image=null ;
			//o.outputArea.BackColor = Color.Red;
			//o.Show();
		}

		/// <summary>
		/// This method is used for compiling i.e check the syntax and parameters 
		/// </summary>
		/// <param name="line">line represents to the single line of richtextbox </param>
		/// <returns>Error Message or Success Messages </returns>
		public string Compile(string line)
		{
			//outputWindow.outputArea.BackColor= Color.Black;
			//setting default value of output to return 
			string output = "";
			//splitting the line by comma"," and small brackets "()" and assigning into an string array
			string[] code = line.Split(',', '(', ')');
			//removing extra spaces 
			code = code.Where(x => !string.IsNullOrEmpty(x)).ToArray();
			//counting array 
			int count = code.Count();
			//			checking if array is null or not 
			if (count >= 1)
			{
				//checking if it is valid syntax or not if not returns false 
				bool checkSyntax = IsSyntax(code[0]);
				if (checkSyntax == true)
				{
					//conditions if command is clear 
					if (code[0].Trim().ToLower().Equals("clear"))
					{
						try
						{
							ClearOutput();
						}
						catch (Exception ex)
						{
							Console.WriteLine("Exception Message: " + ex.Message);
							output = "\n Error in executing clear command. \n";
						}

					}
					//conditions if the command is reset 
					else if (code[0].Trim().ToLower().Equals("reset"))
					{
						try
						{
							ResetOutput();
						}
						catch (Exception ex)
						{

							Console.WriteLine("Exception Message: " + ex.Message);
							output = "\n Error in executing clear command. \n";
						}

					}
					//condition if the command is position pen and checking for parameter 
					else if (code[0].Trim().ToLower().Equals("position pen"))
					{
						try
						{
							//checking if parameter exist 
							if (count >= 2)
							{
								//trying to convert parameter to int if not converted catch block will send error message
								int parameter1 = Int32.Parse(code[1]);
								output = "command executed successfully: parameter is" + parameter1;
								output = "is numeric ";
							}
							else
							{
								output = "\n Parameter Error : Insufficient Parameter. \n";
							}

						}
						catch (Exception ex)
						{

							Console.WriteLine("Exception Message: " + ex.Message);
							output = "\n Parameter Error : Invalid/Insufficient Parameter. \n";
						}

					}
					else if (code[0].Trim().ToLower().Equals("position pen"))
					{
						try
						{
							if (count >= 2)
							{
								int parameter1 = Int32.Parse(code[1]);
								output = "command executed successfully: parameter is" + parameter1;
								//	output = "is numeric ";
							}
							else
							{
								output = "\n Parameter Error : Insufficient Parameter. \n";
							}

						}
						catch (Exception ex)
						{

							Console.WriteLine("Exception Message: " + ex.Message);
							output = "\n Parameter Error : Invalid/Insufficient Parameter. \n";
						}

					}
					else if (code[0].Trim().ToLower().Equals("pen draw"))
					{
						try
						{
							if (count >= 2)
							{
								int parameter1 = Int32.Parse(code[1]);
								output = "command executed successfully: parameter is" + parameter1;
								//		output = "is numeric ";
							}
							else
							{
								output = "\n Parameter Error : Insufficient Parameter. \n";
							}

						}
						catch (Exception ex)
						{

							Console.WriteLine("Exception Message: " + ex.Message);
							output = "\n Parameter Error : Invalid/Insufficient Parameter. \n";
						}

					}
					else if (code[0].Trim().ToLower().Equals("circle"))
					{
						try
						{
							if (count >= 2)
							{
								int parameter1 = Int32.Parse(code[1]);
								//string shapeType = "circle";
								
								ShapeFactory shapeFactory = new ShapeFactory();
								Circle circle = shapeFactory.GetShape("circle").Shape as Circle;
								 circle.Draw(12, 12);


//								outputWindow.outputArea.Image =
								//Console.ReadLine();

								//	IShape shape = ShapeFactory.GetShape("circle", color, initX, initY, 0, 0, parameter1, 0, 0, 0);
								//shape.Draw();
								//outputWindow.InitializeComponent();
								outputWindow.Show();

								//	outputWindow.outputArea.Image=new ShapeFactory.GetShape("circle", color, initX, initY, 0, 0, parameter1, 0, 0, 0);
								//outputWindow.outputArea.Image = shape.Draw(Graphics graphics);


								output = "command executed successfully: parameter is" + parameter1;
								//		output = "is numeric ";
							}
							else
							{
								output = "\n Parameter Error : Insufficient Parameter. \n";
							}

						}
						catch (Exception ex)
						{

							Console.WriteLine("Exception Message: " + ex.Message);
							output = "\n Parameter Error : Invalid/Insufficient Parameter. \n";
						}

					}
					else if (code[0].Trim().ToLower().Equals("rectangle"))
					{
						try
						{
							if (count >= 3)
							{
								int parameter1 = Int32.Parse(code[1]);
								int parameter2 = Int32.Parse(code[2]);
								output = "command executed successfully: parameter is" + parameter1 + "," + parameter2;
								//		output = "is numeric ";
							}
							else
							{
								output = "\n Parameter Error : Insufficient or invalid Parameter. \n";
							}

						}
						catch (Exception ex)
						{

							Console.WriteLine("Exception Message: " + ex.Message);
							output = "\n Parameter Error : Invalid/Insufficient Parameter. \n";
						}

					}
					else if (code[0].Trim().ToLower().Equals("triangle"))
					{
						try
						{
							if (count >= 3)
							{
								int parameter1 = Int32.Parse(code[1]);
								int parameter2 = Int32.Parse(code[2]);
								int parameter3 = Int32.Parse(code[3]);
								output = "command executed successfully: parameter is" + parameter1 + "," + parameter2 + "," + parameter3;
								//		output = "is numeric ";
							}
							else
							{
								output = "\n Parameter Error : Insufficient or invalid Parameter. \n";
							}

						}
						catch (Exception ex)
						{

							Console.WriteLine("Exception Message: " + ex.Message);
							output = "\n Parameter Error : Invalid/Insufficient Parameter. \n";
						}

					}


					//outputWindow.outputArea.Image = null;
					////Output o = new Output();
					////o.outputArea =null
					////outputWindow=new Output()
					//outputWindow.Show();
					//output = "valid syntax found" + code[0];

				}
				else
				{
					output = "\n Synax Error:" + code[0] + " is not a valid syntax; \n Info: clear, reset, rectangle, circle, triangle, position, pen, draw are some of the valid syntax. \n";
				}
			}
			else
			{
				output = "\n Synax Error: invalid syntax or empty file; \n Info: clear, reset, rectangle, circle, triangle, position, pen, draw are some of the valid syntax. \n";

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
