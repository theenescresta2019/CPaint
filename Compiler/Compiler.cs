using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CPaint.Class;

namespace CPaint.Compilers
{

//	public class Compiler
//	{
//		//initializing all the variables 


//		//putting all the pre-defined commands in an commands array and making it readonly
//	//	readonly string[] commands = { "clear", "reset", "rectangle", "circle", "triangle", "moveto", "drawto","var" };
//	//	public string Line { get; set; }
//		//public Compiler() { }

//		//// <summary>
//		//// Check whether syntax is correct or not 
//		//// </summary>
//		//// <param name="syntax">name of syntax </param>
//		//// <returns>true or false </returns>
//		////private bool IsSyntax(string syntax)
//		//{
//		//	bool result = false;
//		//	if (Array.Exists(commands, element => element == syntax.ToLower().Trim()))
//		//	{
//		//		result = true;
//		//	}
//		//	return result;
//		//}

//		//private bool IsNumeric(string number)
//		//{
//		//	bool result = false;
//		//	try
//		//	{
//		//		Convert.ToInt32(number);
//		//		result = true;
//		//	}
//		//	catch 
//		//	{
//		//		result = false;
//		//	}

//		//	return result;
//		//}

/////// <summary>
////// Compiles the program by checking its syntax and parameters and return message
////// </summary>
////// <param name="line">line in the text editor </param>
////// <returns>Reurns success or error message regarding code </returns>
//		//public string Compile(string line)
//		//{
//		//	string shapeName = "";
//		//	string message = "";
//		//	string[] code = line.Split(new char[] { ',', '(', ')' }, StringSplitOptions.RemoveEmptyEntries);
//		//	int count = code.Count();
//		//	if (IsSyntax(code[0]))
//		//	{
//		//		shapeName = code[0].Trim().ToLower();
//		//		if (shapeName.Equals("circle"))
//		//		{
//		//			if (count == 2)
//		//			{
//		//				if (IsNumeric(code[1].Trim()))
//		//				{
//		//					message = "Success :- " + code[0] + "(" + code[1] + ") is correct syntax and parameter.";
//		//				}
//		//				else
//		//				{
//		//					message = "Error :- Invalid Parameter near " + code[0] + " Please check and run the program again. Example: circle(radius) ";
//		//					Console.WriteLine(message);
//		//				}
//		//			}
//		//			else
//		//			{
//		//				message = "Error :- Invalid Parameter near " + code[0] + " Please check and run the program again. Example: circle(radius)";
//		//				Console.WriteLine(message);
//		//			}

//		//		}
//		//		else if (shapeName.Equals("rectangle"))
//		//		{
//		//			if (count == 3)
//		//			{
//		//				if (IsNumeric(code[1].Trim()) && IsNumeric(code[2].Trim()))
//		//				{
//		//					message = "Success :- " + code[0] + "(" + code[1] + "," + code[2] + ") is correct syntax and parameter.";

//		//				}
//		//				else
//		//				{
//		//					message = "Error :- Invalid Parameter near " + code[0] + " Please check and run the program again. Example: rectangle(Width,Height)";
//		//					Console.WriteLine(message);

//		//				}
//		//			}
//		//			else
//		//			{
//		//				message = "Error :- Invalid Parameter near " + code[0] + " Please check and run the program again. Example: rectangle(Width, Height)";
//		//				Console.WriteLine(message);

//		//			}
//		//		}
//		//		else if (shapeName.Equals("triangle"))
//		//		{
//		//			if (count == 5)
//		//			{
//		//				if (IsNumeric(code[1].Trim()) && IsNumeric(code[2].Trim()) && IsNumeric(code[3].Trim()) && IsNumeric(code[4].Trim()))
//		//				{
//		//					message = "Success :- " + code[0] + "((" + code[1] + "," + code[2] + ")" + "(" + code[3] + ", " + code[4] + ")) is correct syntax and parameter.";
//		//				}
//		//				else
//		//				{
//		//					message = "Error :- Invalid Parameter near " + code[0] + " Please check and run the program again. Example: triangle((X-axis2,Y-axis2),(X-axis3,Y-axis3)). Note that initial position is current pen position.";
//		//					Console.WriteLine(message);
//		//				}
//		//			}
//		//			else
//		//			{
//		//				message = "Error :- Invalid Parameter near " + code[0] + " Please check and run the program again. Example: triangle((X-axis2,Y-axis2),(X-axis3,Y-axis3)). Note that initial position is current pen position.";
//		//				Console.WriteLine(message);
//		//			}
//		//		}
//		//		else if (shapeName.Equals("drawto"))
//		//		{
//		//			if (count == 3)
//		//			{
//		//				if (IsNumeric(code[1].Trim()) && IsNumeric(code[2].Trim()))
//		//				{

//		//					message = "Success :- " + code[0] + "(" + code[1] + "," + code[2] + ") is correct syntax and parameter.";

//		//				}
//		//				else
//		//				{
//		//					message = "Error :- Invalid Parameter near " + code[0] + " Please check and run the program again. Example: drawto(X-axis2,Y-axis2). Note that initial points is current pen position.";
//		//					Console.WriteLine(message);
//		//				}
//		//			}
//		//			else
//		//			{
//		//				message = "Error :- Invalid Parameter near " + code[0] + " Please check and run the program again. Example: drawto(X-axis2,Y-axis2). Note that initial points is current pen position.";
//		//				Console.WriteLine(message);
//		//			}
//		//		}
//		//		else if (shapeName.Equals("moveto"))
//		//		{
//		//			if (count == 3)
//		//			{
//		//				if (IsNumeric(code[1].Trim()) && IsNumeric(code[2].Trim()))
//		//				{
//		//					message = "Success :- " + code[0] + "(" + code[1] + "," + code[2] + ") is correct syntax and parameter.";


//		//				}
//		//				else
//		//				{
//		//					message = "Error :- Invalid Parameter near " + code[0] + " Please check and run the program again. Example: moveto(X-axis,Y-axis)";
//		//					Console.WriteLine(message);
//		//				}
//		//			}
//		//			else
//		//			{
//		//				message = "Error :- Invalid Parameter near " + code[0] + " Please check and run the program again. Example: move to (X-axis,Y-axis)";
//		//				Console.WriteLine(message);

//		//			}
//		//		}
//		//		else if (shapeName.Equals("reset"))
//		//		{

//		//			message = "Success: Command Reset is Correct syntax";

//		//		}
//		//		else if (shapeName.Equals("clear"))
//		//		{
//		//			//					message = "Success :- Clear command found";
//		//			message = "Error :- Command found but please enter " + code[0] + " in command line below.";
//		//			Console.WriteLine(message);
//		//		}
				
//		//	}
//		//	else
//		//	{
//		//		message = "Error :- Invalid Syntax. " + code[0] + " Please check and run the program again.";
//		//		Console.WriteLine(message);
//		//	}
//		//	return message;
//		//}
			
//		}
	//public string Compiless(string line)
	//{

	//	//string[] code = line.Split(new char[] { ',', '(', ')' }, StringSplitOptions.RemoveEmptyEntries);
	//	//int count = code.Count();
	//	if (IsSyntax(code[0]))
	//	{
	//		shapeName = code[0].Trim().ToLower();

	//		if (shapeName.Equals("circle"))
	//		{
	//			if (count >= 2)
	//			{
	//				if (IsNumeric(code[1].Trim()))
	//				{
	//					radius = Convert.ToInt32(code[1].Trim());
	//					validation = "pass";
	//				}
	//				else
	//				{
	//					message = "Error :- Invalid Parameter near " + code[0] + " Please check and run the program again.";
	//					Console.WriteLine(message);
	//					validation = "fail";
	//				}
	//			}
	//			else
	//			{
	//				message = "Error :- Invalid Parameter near " + code[0] + " Please check and run the program again.";
	//				Console.WriteLine(message);
	//				validation = "fail";
	//			}

	//		}
	//		else if (shapeName.Equals("rectangle"))
	//		{
	//			if (count >= 3)
	//			{
	//				if (IsNumeric(code[1].Trim()) && IsNumeric(code[2].Trim()))
	//				{
	//					width = Convert.ToInt32(code[1].Trim());
	//					height = Convert.ToInt32(code[2].Trim());
	//					validation = "pass";
	//				}
	//				else
	//				{
	//					message = "Error :- Invalid Parameter near " + code[0] + " Please check and run the program again.";
	//					Console.WriteLine(message);
	//					validation = "fail";
	//				}
	//			}
	//			else
	//			{
	//				message = "Error :- Invalid Parameter near " + code[0] + " Please check and run the program again.";
	//				Console.WriteLine(message);
	//				validation = "fail";
	//			}
	//		}
	//		else if (shapeName.Equals("triangle"))
	//		{
	//			if (count >= 5)
	//			{
	//				if (IsNumeric(code[1].Trim()) && IsNumeric(code[2].Trim()) && IsNumeric(code[3].Trim()) && IsNumeric(code[4].Trim()))
	//				{
	//					x2 = Convert.ToInt32(code[1].Trim());
	//					y2 = Convert.ToInt32(code[2].Trim());
	//					x3 = Convert.ToInt32(code[3].Trim());
	//					y3 = Convert.ToInt32(code[4].Trim());
	//					validation = "pass";
	//				}
	//				else
	//				{
	//					message = "Error :- Invalid Parameter near " + code[0] + " Please check and run the program again.";
	//					Console.WriteLine(message);
	//					validation = "fail";
	//				}
	//			}
	//			else
	//			{
	//				message = "Error :- Invalid Parameter near " + code[0] + " Please check and run the program again.";
	//				Console.WriteLine(message);
	//				validation = "fail";
	//			}
	//		}
	//		else if (shapeName.Equals("drawto"))
	//		{
	//			if (count >= 3)
	//			{
	//				if (IsNumeric(code[1].Trim()) && IsNumeric(code[2].Trim()))
	//				{
	//					x2 = Convert.ToInt32(code[1].Trim());
	//					y2 = Convert.ToInt32(code[2].Trim());
	//					validation = "pass";

	//				}
	//				else
	//				{
	//					message = "Error :- Invalid Parameter near " + code[0] + " Please check and run the program again.";
	//					Console.WriteLine(message);
	//					validation = "fail";
	//				}
	//			}
	//			else
	//			{
	//				message = "Error :- Invalid Parameter near " + code[0] + " Please check and run the program again.";
	//				Console.WriteLine(message);
	//				validation = "fail";
	//			}
	//		}
	//		else if (shapeName.Equals("moveto"))
	//		{
	//			if (count >= 3)
	//			{
	//				if (IsNumeric(code[1].Trim()) && IsNumeric(code[2].Trim()))
	//				{
	//					initX = Convert.ToInt32(code[1].Trim());
	//					initY = Convert.ToInt32(code[2].Trim());
	//				}
	//				else
	//				{
	//					message = "Error :- Invalid Parameter near " + code[0] + " Please check and run the program again.";
	//					Console.WriteLine(message);
	//					validation = "fail";
	//				}
	//			}
	//			else
	//			{
	//				message = "Error :- Invalid Parameter near " + code[0] + " Please check and run the program again.";
	//				Console.WriteLine(message);
	//				validation = "fail";
	//			}
	//		}
	//		else if (shapeName.Equals("reset"))
	//		{
	//			Reset();
	//			message = "Success: Reset Successfully";

	//		}

	//		if (validation.Equals("pass"))
	//		{
	//			try
	//			{
	//				message = "Success:- Program Executed Successfully";
	//				return ShapeFactory.CreateShape(shapeName, initX, initY, radius, height, width, x2, y2, x3, y3);
	//			}
	//			catch (Exception shapeCreationException)
	//			{
	//				message = "Error :- Error in Drawing Shapes. " + shapeCreationException.Message;
	//				Console.WriteLine(message);
	//			}
	//		}
	//	}
	//	else
	//	{
	//		message = "Error :- Invalid Syntax. " + code[0] + " Please check and run the program again.";
	//		Console.WriteLine(message);
	//	}
	//	return message;
	//}



	

	//public string Compile(string line)
	//{
	//	//outputWindow.outputArea.BackColor= Color.Black;
	//	//setting default value of output to return 
	//	string output = "";
	//	//splitting the line by comma"," and small brackets "()" and assigning into an string array
	//	string[] code = line.Split(',', '(', ')');
	//	//removing extra spaces 
	//	code = code.Where(x => !string.IsNullOrEmpty(x)).ToArray();
	//	//counting array 
	//	int count = code.Count();
	//	//			checking if array is null or not 
	//	if (count >= 1)
	//	{
	//		//checking if it is valid syntax or not if not returns false 
	//		bool checkSyntax = IsSyntax(code[0]);
	//		if (checkSyntax == true)
	//		{
	//			//conditions if command is clear 
	//			if (code[0].Trim().ToLower().Equals("clear"))
	//			{
	//				try
	//				{
	//					ClearOutput();
	//				}
	//				catch (Exception ex)
	//				{
	//					Console.WriteLine("Exception Message: " + ex.Message);
	//					output = "\n Error in executing clear command. \n";
	//				}

	//			}
	//			//conditions if the command is reset 
	//			else if (code[0].Trim().ToLower().Equals("reset"))
	//			{
	//				try
	//				{
	//					ResetOutput();
	//				}
	//				catch (Exception ex)
	//				{

	//					Console.WriteLine("Exception Message: " + ex.Message);
	//					output = "\n Error in executing clear command. \n";
	//				}

	//			}
	//			//condition if the command is moveto and checking for parameter 
	//			else if (code[0].Trim().ToLower().Equals("moveto"))
	//			{
	//				try
	//				{
	//					//checking if parameter exist 
	//					if (count >= 2)
	//					{
	//						//trying to convert parameter to int if not converted catch block will send error message
	//						int parameter1 = Int32.Parse(code[1]);
	//						output = "command executed successfully: parameter is" + parameter1;
	//						output = "is numeric ";
	//					}
	//					else
	//					{
	//						output = "\n Parameter Error : Insufficient Parameter. \n";
	//					}

	//				}
	//				catch (Exception ex)
	//				{

	//					Console.WriteLine("Exception Message: " + ex.Message);
	//					output = "\n Parameter Error : Invalid/Insufficient Parameter. \n";
	//				}

	//			}
	//			else if (code[0].Trim().ToLower().Equals("moveto"))
	//			{
	//				try
	//				{
	//					if (count >= 2)
	//					{
	//						int parameter1 = Int32.Parse(code[1]);
	//						output = "command executed successfully: parameter is" + parameter1;
	//						//	output = "is numeric ";
	//					}
	//					else
	//					{
	//						output = "\n Parameter Error : Insufficient Parameter. \n";
	//					}

	//				}
	//				catch (Exception ex)
	//				{

	//					Console.WriteLine("Exception Message: " + ex.Message);
	//					output = "\n Parameter Error : Invalid/Insufficient Parameter. \n";
	//				}

	//			}
	//			else if (code[0].Trim().ToLower().Equals("drawto"))
	//			{
	//				try
	//				{
	//					if (count >= 2)
	//					{
	//						int parameter1 = Int32.Parse(code[1]);
	//						output = "command executed successfully: parameter is" + parameter1;
	//						//		output = "is numeric ";
	//					}
	//					else
	//					{
	//						output = "\n Parameter Error : Insufficient Parameter. \n";
	//					}

	//				}
	//				catch (Exception ex)
	//				{

	//					Console.WriteLine("Exception Message: " + ex.Message);
	//					output = "\n Parameter Error : Invalid/Insufficient Parameter. \n";
	//				}

	//			}
	//			else if (code[0].Trim().ToLower().Equals("circle"))
	//			{
	//				try
	//				{
	//					if (count >= 2)
	//					{
	//						int parameter1 = Int32.Parse(code[1]);
	//						//string shapeType = "circle";

	//						return ShapeFactory.CreateShape(code[0], code.Skip(1).ToArray());


	//						//ShapeFactory shapeFactory = new ShapeFactory();
	//						//Circle circle = shapeFactory.GetShape("circle").Shape as Circle;
	//						//circle.Draw(12, 12);
	//						//outputWindow.Show();
	//						output = "command executed successfully: parameter is" + parameter1;
	//						//		output = "is numeric ";
	//					}
	//					else
	//					{
	//						output = "\n Parameter Error : Insufficient Parameter. \n";
	//					}

	//				}
	//				catch (Exception ex)
	//				{

	//					Console.WriteLine("Exception Message: " + ex.Message);
	//					output = "\n Parameter Error : Invalid/Insufficient Parameter. \n";
	//				}

	//			}
	//			else if (code[0].Trim().ToLower().Equals("rectangle"))
	//			{
	//				try
	//				{
	//					if (count >= 3)
	//					{
	//						int parameter1 = Int32.Parse(code[1]);
	//						int parameter2 = Int32.Parse(code[2]);
	//						output = "command executed successfully: parameter is" + parameter1 + "," + parameter2;
	//						//		output = "is numeric ";
	//					}
	//					else
	//					{
	//						output = "\n Parameter Error : Insufficient or invalid Parameter. \n";
	//					}

	//				}
	//				catch (Exception ex)
	//				{

	//					Console.WriteLine("Exception Message: " + ex.Message);
	//					output = "\n Parameter Error : Invalid/Insufficient Parameter. \n";
	//				}

	//			}
	//			else if (code[0].Trim().ToLower().Equals("triangle"))
	//			{
	//				try
	//				{
	//					if (count >= 3)
	//					{
	//						int parameter1 = Int32.Parse(code[1]);
	//						int parameter2 = Int32.Parse(code[2]);
	//						int parameter3 = Int32.Parse(code[3]);
	//						output = "command executed successfully: parameter is" + parameter1 + "," + parameter2 + "," + parameter3;
	//						//		output = "is numeric ";
	//					}
	//					else
	//					{
	//						output = "\n Parameter Error : Insufficient or invalid Parameter. \n";
	//					}

	//				}
	//				catch (Exception ex)
	//				{

	//					Console.WriteLine("Exception Message: " + ex.Message);
	//					output = "\n Parameter Error : Invalid/Insufficient Parameter. \n";
	//				}

	//			}


	//			//outputWindow.outputArea.Image = null;
	//			////Output o = new Output();
	//			////o.outputArea =null
	//			////outputWindow=new Output()
	//			//outputWindow.Show();
	//			//output = "valid syntax found" + code[0];

	//		}
	//		else
	//		{
	//			output = "\n Synax Error:" + code[0] + " is not a valid syntax; \n Info: clear, reset, rectangle, circle, triangle, position, pen, draw are some of the valid syntax. \n";
	//		}
	//	}
	//	else
	//	{
	//		output = "\n Synax Error: invalid syntax or empty file; \n Info: clear, reset, rectangle, circle, triangle, position, pen, draw are some of the valid syntax. \n";

	//	}

	//	//foreach (var c in code)
	//	//{
	//	//if (!String.IsNullOrWhiteSpace(c))
	//	//{

	//	//}



	//	//}
	//	return output;
	//}




}

