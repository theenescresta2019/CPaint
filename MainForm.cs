using System;
using CPaint.Compilers;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using CPaint.Class;
using System.Collections.Generic;

namespace CPaint
{
	/// <summary>
	/// Main Interface form 
	/// </summary>
	public partial class MainForm : Form
	{

		//	Output outputWindow = new Output();
		/// <summary>
		/// initializing all the components 
		/// </summary>
		public MainForm()
		{
			InitializeComponent();
		}

		Dictionary<string, string> variableList = new Dictionary<string, string>();
		Dictionary<int, string> forLoop = new Dictionary<int, string>();
		Dictionary<int, string> method = new Dictionary<int, string>();
		bool isparameter = false;
		bool isparameter1 = false;
		bool isparameter2 = false;

		int parameter1;
		int parameter2;
		string methodName;
		bool loopStart = false;
		bool loopEnd = false;
		bool methodStart = false;
		bool methodEnd = false;
		int loopSize = 0;
		int rand = 1;
		int initX, initY, radius = 0, height = 0, width = 0, x1 = 0, y1 = 0, x2 = 0, y2 = 0, x3 = 0, y3 = 0, x4 = 0, y4 = 0, x5 = 0, y5 = 0;
		string syntaxName = "";
		readonly string[] commands = { "clear", "reset", "rectangle", "circle", "triangle", "moveto", "drawto", "var", "if", "then", "call","polygon" };
		//string[] variableNames = { };
		/// <summary>
		/// Line of textbox
		/// </summary>
		public string Line { get; set; }
		private TabPage tabPage;
		Color canvasColor = Color.DarkSlateBlue;
		Color textColor = Color.White;
		bool isSaved = false;
		//	bool isNewSave = false;

		Font font = new Font("Arial", 16, FontStyle.Bold);


		/// <summary>
		/// get Active Editor in the tab.
		/// </summary>
		/// <returns>Returns Active Editor in the TAB.</returns>

		private RichTextBox GetActiveEditor()
		{
			tabPage = TabControl.SelectedTab;
			RichTextBox rtb = null;
			if (tabPage != null)
			{
				rtb = tabPage.Controls[0] as RichTextBox;
			}

			return rtb;


		}

		private void AddLineNumbers()
		{
			Point pt = new Point(0, 0);
			int First_Index = GetActiveEditor().GetCharIndexFromPosition(pt);
			int First_Line = GetActiveEditor().GetLineFromCharIndex(First_Index);
			pt.X = ClientRectangle.Width;
			pt.Y = ClientRectangle.Height;
			int Last_Index = GetActiveEditor().GetCharIndexFromPosition(pt);
			int Last_Line = GetActiveEditor().GetLineFromCharIndex(Last_Index);
			richLine.SelectionAlignment = HorizontalAlignment.Center;
			//richLine.SelectionFont= font;
			richLine.Text = "\n";
			for (int i = First_Line; i <= Last_Line; i++)
			{
				richLine.Font = font;
				richLine.Text += i + 1 + "\n";
			}
		}


		//private RichTextBox GetActiveTabName()
		//{
		//string	tabName = TabControl.SelectedTab.Name;

		//	return tabName;
		//}
		/// <summary>
		/// Create new documents 
		/// </summary>
		/// 

		void TabPage_KeyPress(object sender, KeyPressEventArgs e)
		//void TabPage_KeyPress(object sender, KeyEventArgs e)
		{
			try
			{
				AddLineNumbers();
			}
			catch (Exception ex)
			{

				Console.WriteLine("Exception Message: " + ex.Message);
			}


		}

		private void CreateNewDocument()
		{
			tabPage = new TabPage("Untitled Paint Document");

			RichTextBox textBox = new RichTextBox
			{
				SelectionFont = font,
				//	textBox.SelectionColor = System.Drawing.Color.Black;
				Dock = DockStyle.Fill,
				ForeColor = textColor,
				BackColor = canvasColor,
				Cursor = Cursors.Default,

			};
			//	statusStrip1.Text = "tesaldskfjladf";
			tabPage.Controls.Add(textBox);
			tabPage.Name = "New";

			//tabPage.PreviewKeyDown = true;
			//tabPage.KeyDown += TabPage_KeyPress;

			tabPage.Focus();
			TabControl.KeyPress += new KeyPressEventHandler(TabPage_KeyPress);
			//	tabPage.KeyPress += AddLineNumbers();
			TabControl.TabPages.Add(tabPage);
			TabControl.SelectTab(tabPage);

		}

		/// <summary>
		/// To save file.
		/// </summary>
		private void SaveFile()
		{

			if (GetActiveEditor().TextLength == 0)
			{
				MessageBox.Show("Please Write some text first. Empty file cannot be saved.", "Warning");

			}
			else
			{

				string tabName = TabControl.SelectedTab.Name;
				if (tabName == "New")
				{
					SaveFileDialog saveFileDialog = new SaveFileDialog
					{
						InitialDirectory = @"D:\",
						Title = "Save text Files",
						CheckFileExists = false,
						CheckPathExists = false,
						DefaultExt = "txt",
						RestoreDirectory = true,
						Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*",
						FilterIndex = 1,
						AddExtension = true
					};
					if (saveFileDialog.ShowDialog() == DialogResult.OK)
					{
						string fileName = saveFileDialog.FileName;
						GetActiveEditor().SaveFile(fileName, RichTextBoxStreamType.PlainText);
						isSaved = true;
						RemoveCurrentDocument();
						//sw.Write(GetActiveEditor().Text);
						tabPage = new TabPage(fileName);
						RichTextBox textBox = new RichTextBox();
						textBox.LoadFile(fileName, RichTextBoxStreamType.PlainText);
						textBox.SelectionFont = font;
						//	textBox.SelectionColor = System.Drawing.Color.Black;
						textBox.Dock = DockStyle.Fill;
						textBox.ForeColor = textColor;
						textBox.BackColor = canvasColor;
						tabPage.Controls.Add(textBox);
						tabPage.Name = fileName;
						tabPage.Focus();
						TabControl.TabPages.Add(tabPage);
						TabControl.SelectTab(tabPage);
					}
				}
				else
				{
					try
					{
						GetActiveEditor().SaveFile(tabName, RichTextBoxStreamType.PlainText);
						//	MessageBox.Show("Saved Successfully");
					}
					catch (Exception ex)
					{

						Console.WriteLine("Exception Message: " + ex.Message);

						MessageBox.Show("Exception:" + ex.Message);

					}

				}
			}

		}

		private void SaveAsFile()
		{

			if (GetActiveEditor().TextLength == 0)
			{
				MessageBox.Show("Please Write some text first. Empty file cannot be saved.", "Warning");

			}
			else
			{
				SaveFileDialog saveFileDialog = new SaveFileDialog
				{
					InitialDirectory = @"D:\",
					Title = "Save text Files",
					CheckFileExists = false,
					CheckPathExists = false,
					DefaultExt = "txt",
					RestoreDirectory = true,
					Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*",
					FilterIndex = 1,
					AddExtension = true
				};
				if (saveFileDialog.ShowDialog() == DialogResult.OK)
				{
					string fileName = saveFileDialog.FileName;
					GetActiveEditor().SaveFile(fileName, RichTextBoxStreamType.PlainText);
					isSaved = true;
					RemoveCurrentDocument();
					//sw.Write(GetActiveEditor().Text);
					tabPage = new TabPage(fileName);
					RichTextBox textBox = new RichTextBox();
					textBox.LoadFile(fileName, RichTextBoxStreamType.PlainText);
					textBox.SelectionFont = font;
					//	textBox.SelectionColor = System.Drawing.Color.Black;
					textBox.Dock = DockStyle.Fill;
					textBox.ForeColor = textColor;
					textBox.BackColor = canvasColor;
					tabPage.Controls.Add(textBox);
					tabPage.Name = fileName;
					tabPage.Focus();
					TabControl.TabPages.Add(tabPage);
					TabControl.SelectTab(tabPage);
				}
			}
		}

		/// <summary>
		/// To Open File 
		/// </summary>
		private void OpenFile()
		{
			OpenFileDialog openFD = new OpenFileDialog
			{
				InitialDirectory = "D:",
				Title = "Open a Text File",
				FileName = "",
				Filter = "Text Files|*.txt|Word Documents|*.doc"
			};
			if (openFD.ShowDialog() != DialogResult.Cancel)
			{
				string Chosen_File = openFD.FileName;

				//	MessageBox.Show(Chosen_File);
				tabPage = new TabPage(Chosen_File);
				RichTextBox textBox = new RichTextBox();
				textBox.LoadFile(Chosen_File, RichTextBoxStreamType.PlainText);
				textBox.SelectionFont = font;
				//	textBox.SelectionColor = System.Drawing.Color.Black;
				textBox.Dock = DockStyle.Fill;
				textBox.ForeColor = textColor;
				textBox.BackColor = canvasColor;

				tabPage.Controls.Add(textBox);
				tabPage.Name = Chosen_File;
				tabPage.Focus();
				TabControl.TabPages.Add(tabPage);
				TabControl.SelectTab(tabPage);
			}
		}
		/// <summary>
		/// Removes 
		/// </summary>
		private void RemoveCurrentDocument()
		{
			if (GetActiveEditor().TextLength == 0)
			{
				TabControl.TabPages.Remove(TabControl.SelectedTab);

			}
			else
			{
				if (isSaved == true)
				{
					TabControl.TabPages.Remove(TabControl.SelectedTab);
					isSaved = false;
				}
				else
				{

					if (TabControl.SelectedTab != null)
					{
						var selectedOption = MessageBox.Show("Do you want to Save your Document?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

						if (selectedOption == DialogResult.Yes)

						{
							isSaved = true;
							SaveFile();


						}

						else if (selectedOption == DialogResult.No)

						{
							//	TabControl.TabPages.Remove(TabControl.SelectedTab);
						}

						TabControl.TabPages.Remove(TabControl.SelectedTab);

					}
					else
					{
						//tabPage = new TabPage("Welcome To CPaint")
						//{

						//	//	RichTextBox textBox = new RichTextBox();
						//	//textBox.Font = new Font("Arial", 24, FontStyle.Bold);
						//	////	textBox.SelectionColor = System.Drawing.Color.Black;
						//	//textBox.Dock = DockStyle.Fill;
						//	//textBox.ForeColor = Color.AntiqueWhite;
						//	//textBox.BackColor = canvasColor;

						//	//textBox.Text = "Hello! "+ " Welcome to CPaint." ;
						//	//	tabPage.Controls.Add(textBox);
						//	BackgroundImage = Image.FromFile("D:\\.net\\CPaint\\icons\\cpaintWelcome.jpg"),
						//	//	BackColor = ColorTranslator.FromHtml("#808080"),
						//	BackColor = (Color.BlanchedAlmond),
						//	BackgroundImageLayout = ImageLayout.Center
						//};
						//tabPage.Focus();
						////			TabControl.BackgroundImage = ;
						//TabControl.TabPages.Add(tabPage);
						//	TabControl.SelectTab(tabPage);

						//MessageBox.Show("Please open tabs first. to close.");
					}

				}
			}

		}

		private void BtnFileMenu_Click(object sender, EventArgs e)
		{

		}

		private void BtnFileMenu_MouseHover(object sender, EventArgs e)
		{
			BtnFileMenu.ForeColor = Color.Black;
		}

		private void BtnFileMenu_MouseLeave(object sender, EventArgs e)
		{
			BtnFileMenu.ForeColor = Color.WhiteSmoke;
		}

		private void MainForm_Load(object sender, EventArgs e)
		{
			//Help help = new Help();
			//help.Show();

			CreateNewDocument();

			//tabPage = new TabPage("Welcome To CPaint")
			//{

			//	//	RichTextBox textBox = new RichTextBox();
			//	//textBox.Font = new Font("Arial", 24, FontStyle.Bold);
			//	////	textBox.SelectionColor = System.Drawing.Color.Black;
			//	//textBox.Dock = DockStyle.Fill;
			//	//textBox.ForeColor = Color.AntiqueWhite;
			//	//textBox.BackColor = canvasColor;

			//	//textBox.Text = "Hello! "+ " Welcome to CPaint." ;
			//	//	tabPage.Controls.Add(textBox);
			//	BackgroundImage = Image.FromFile("D:\\.net\\CPaint\\icons\\cpaintWelcome.jpg"),
			//	//	BackColor = ColorTranslator.FromHtml("#808080"),
			//	BackColor = (Color.BlanchedAlmond),
			//	BackgroundImageLayout = ImageLayout.Center
			//};
			//tabPage.Focus();
			////			TabControl.BackgroundImage = ;
			//TabControl.TabPages.Add(tabPage);
			////	TabControl.SelectTab(tabPage);

		}

		private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
		{

		}

		private void BtnNew_Click(object sender, EventArgs e)
		{
			CreateNewDocument();
		}

		private void ToolStripMenuItem1_Click(object sender, EventArgs e)
		{

		}

		private void BtnCopy_Click(object sender, EventArgs e)
		{
			try
			{
				GetActiveEditor().Copy();
			}
			catch (Exception ex)
			{

				Console.WriteLine("Exception Message: " + ex.Message);
			}

		}

		private void BtnCut_Click(object sender, EventArgs e)
		{
			try
			{
				GetActiveEditor().Cut();
			}
			catch (Exception ex)
			{

				Console.WriteLine("Exception Message: " + ex.Message);
			}


		}

		private void BtnPaste_Click(object sender, EventArgs e)
		{
			try
			{
				GetActiveEditor().Paste();
			}
			catch (Exception ex)
			{

				Console.WriteLine("Exception Message: " + ex.Message);
			}

		}

		private void BtnSelectAll_Click(object sender, EventArgs e)
		{
			try
			{

				GetActiveEditor().SelectAll();
			}
			catch (Exception ex)
			{

				Console.WriteLine("Exception Message: " + ex.Message);
			}
		}

		private void ToolStripContainer1_TopToolStripPanel_Click(object sender, EventArgs e)
		{

		}

		private void TabControl_SelectedIndexChanged(object sender, EventArgs e)
		{

		}

		private void ToolStripContainer1_ContentPanel_Load(object sender, EventArgs e)
		{

		}

		private void RedoToolStripMenuItem_Click(object sender, EventArgs e)
		{
			try
			{
				GetActiveEditor().Redo();

			}
			catch (Exception ex)
			{

				Console.WriteLine("Exception Message: " + ex.Message);
			}
		}

		private void UndoToolStripMenuItem_Click(object sender, EventArgs e)
		{
			try
			{
				GetActiveEditor().Undo();

			}
			catch (Exception ex)
			{

				Console.WriteLine("Exception Message: " + ex.Message);
			}
		}

		private void ToolStripButton1_Click(object sender, EventArgs e)
		{
			try
			{
				CreateNewDocument();

			}
			catch (Exception ex)
			{

				Console.WriteLine("Exception Message: " + ex.Message);
			}
		}


		private void ToolStripButton2_Click(object sender, EventArgs e)
		{
			try
			{
				SaveFile();

			}
			catch (Exception ex)
			{
				MessageBox.Show("Cannot Save Document." + ex.Message);
				Console.WriteLine("Exception Message: " + ex.Message);
			}
		}

		private void ToolStripButton4_Click(object sender, EventArgs e)
		{
			try
			{
				GetActiveEditor().SelectAll();

			}
			catch (Exception ex)
			{

				Console.WriteLine("Exception Message: " + ex.Message);
			}
		}

		private void ToolStripButton5_Click(object sender, EventArgs e)
		{
			try
			{
				GetActiveEditor().Copy();

			}
			catch (Exception ex)
			{

				Console.WriteLine("Exception Message: " + ex.Message);
			}
		}

		private void ToolStripButton6_Click(object sender, EventArgs e)
		{
			try
			{
				GetActiveEditor().Cut();

			}
			catch (Exception ex)
			{

				Console.WriteLine("Exception Message: " + ex.Message);
			}
		}

		private void ToolStripButton7_Click(object sender, EventArgs e)
		{
			try
			{
				GetActiveEditor().Paste();

			}
			catch (Exception ex)
			{

				Console.WriteLine("Exception Message: " + ex.Message);
			}
		}

		private void ToolStripButton8_Click(object sender, EventArgs e)
		{
			try
			{

				GetActiveEditor().Undo();
			}
			catch (Exception ex)
			{

				Console.WriteLine("Exception Message: " + ex.Message);
			}
		}

		private void ToolStripButton9_Click(object sender, EventArgs e)
		{
			try
			{
				GetActiveEditor().Redo();

			}
			catch (Exception ex)
			{

				Console.WriteLine("Exception Message: " + ex.Message);
			}
		}

		private void BtnCloseCurrentTab_Click(object sender, EventArgs e)
		{
			try
			{
				RemoveCurrentDocument();

			}
			catch (Exception ex)
			{

				Console.WriteLine("Exception Message: " + ex.Message);
			}


		}

		private void ToolBtnClose_Click(object sender, EventArgs e)
		{

			try
			{
				RemoveCurrentDocument();

			}
			catch (Exception ex)
			{

				Console.WriteLine("Exception Message: " + ex.Message);
			}

		}

		private void BtnCloseAllTabs_Click(object sender, EventArgs e)
		{
			try
			{
				TabControl.TabPages.Clear();

			}
			catch (Exception ex)
			{

				Console.WriteLine("Exception Message: " + ex.Message);
			}
		}

		private void ToolStripButton1_Click_1(object sender, EventArgs e)
		{
			try
			{
				TabControl.TabPages.Clear();

			}
			catch (Exception ex)
			{

				Console.WriteLine("Exception Message: " + ex.Message);
			}
		}

		private void ToolStripMenuItem2_Click(object sender, EventArgs e)
		{

		}

#pragma warning disable IDE1006 // Naming Styles
		private void toolStripMenuItem9_Click(object sender, EventArgs e)
#pragma warning restore IDE1006 // Naming Styles
		{
			Help help = new Help();
			help.Show();
		}

		private void ToolStripButton1_Click_2(object sender, EventArgs e)
		{
			try
			{


				float zoom = GetActiveEditor().ZoomFactor;
				if (zoom + 1 < 10)
					GetActiveEditor().ZoomFactor = zoom + 1;

			}
			catch (Exception ex)
			{

				Console.WriteLine("Exception Message: " + ex.Message);
			}
		}

		private void ToolStripButton2_Click_1(object sender, EventArgs e)
		{
			try
			{


				float zoom = GetActiveEditor().ZoomFactor;
				if (zoom - 1 > 0)
					GetActiveEditor().ZoomFactor = zoom - 1;

			}
			catch (Exception ex)
			{

				Console.WriteLine("Exception Message: " + ex.Message);
			}
		}

		private void ToolStripMenuItem5_Click(object sender, EventArgs e)
		{
			try
			{


				float zoom = GetActiveEditor().ZoomFactor;
				if (zoom + 1 < 10)
					GetActiveEditor().ZoomFactor = zoom + 1;

			}
			catch (Exception ex)
			{

				Console.WriteLine("Exception Message: " + ex.Message);
			}
		}

		private void ToolStripMenuItem4_Click(object sender, EventArgs e)
		{
			try
			{


				float zoom = GetActiveEditor().ZoomFactor;
				if (zoom - 1 > 0)
					GetActiveEditor().ZoomFactor = zoom - 1;

			}
			catch (Exception ex)
			{

				Console.WriteLine("Exception Message: " + ex.Message);
			}
		}

		private void ToolStripButton1_Click_3(object sender, EventArgs e)
		{
			FontDialog f = new FontDialog
			{
				ShowColor = true
			};
			if (f.ShowDialog() == DialogResult.OK)
			{
				GetActiveEditor().SelectAll();
				GetActiveEditor().SelectionFont = f.Font;
				GetActiveEditor().SelectionColor = f.Color;
				textColor = f.Color;
				font = f.Font;
			}

		}

		private void ToolStripButton1_Click_4(object sender, EventArgs e)
		{

			try
			{
				ColorDialog color = new ColorDialog
				{
					AllowFullOpen = false
				};

				if (color.ShowDialog() == DialogResult.OK)
				{

					canvasColor = color.Color;
					ToolBtnBgColor.BackColor = color.Color;
					GetActiveEditor().BackColor = color.Color;
					//listBox1.ForeColor = colorDlg.Color;
				}
			}
			catch (Exception ex)
			{

				Console.WriteLine("Exception Message: " + ex.Message);
			}


		}

		private void BtnSave_Click(object sender, EventArgs e)
		{
			try
			{


				SaveFile();

			}
			catch (Exception ex)
			{
				MessageBox.Show("Cannot Save Document." + ex.Message);
				Console.WriteLine("Exception Message: " + ex.Message);
			}
		}



		private void BtnOpen_Click(object sender, EventArgs e)
		{
			try
			{
				OpenFile();
			}
			catch (Exception ex)
			{

				Console.WriteLine("Exception Message: " + ex.Message);
			}

		}

		private void ToolStripButton1_Click_5(object sender, EventArgs e)
		{

		}

		private void ToolBtnOpen_Click(object sender, EventArgs e)
		{
			try
			{
				OpenFile();
			}
			catch (Exception ex)
			{

				Console.WriteLine("Exception Message: " + ex.Message);
			}
		}

		private void BtnSaveAs_Click(object sender, EventArgs e)
		{
			try
			{
				SaveAsFile();
			}
			catch (Exception ex)
			{

				Console.WriteLine("Exception Message: " + ex.Message);
			}


		}

		private void ToolStrip2_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
		{

		}

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

		private bool IsNumeric(string number)
		{
			bool result;
			try
			{
				Convert.ToInt32(number);
				result = true;
			}
			catch
			{
				result = false;
			}

			return result;
		}



		//public int CheckVariables(string name)
		//{

		//	for (int i = 0; i < variableCounter; i++)
		//	{
		//		if (variableNames[i] == name)
		//		{
		//			return i;
		//		}

		//	}
		//	return -1;
		//}

		/// <summary>
		/// Check variables whether it is already defined or not defined 
		/// </summary>
		/// <param name="name">Variable Name</param>
		/// <returns>value of variable or if variable not found then not_found key word</returns>
		public string CheckVariables(string name)
		{
			if (variableList.ContainsKey(name))
			{
				string value = variableList.FirstOrDefault(x => x.Key == name).Value;

				return value;
			}

			return "not_found";
		}




		/// <summary>
		/// this compile class compiles the code, it checks for the valid syntax and throws the exceptions according to syntax and shows success messages 
		/// </summary>
		/// <param name="line">Line indicates the single line </param>
		/// <returns>error or success message </returns>
		public string Compile(string line)
		{
			//string syntaxName = "";
			string message = "";
			string[] code = line.Split(new char[] { ',', '(', ')', '=', ' ' }, StringSplitOptions.RemoveEmptyEntries);
			int count = code.Count();

			Console.WriteLine(count);


			if (IsSyntax(code[0]))
			{
				syntaxName = code[0].Trim().ToLower();

				//	MessageBox.Show(syntaxName + count + methodName);
				if (syntaxName.Equals("circle"))
				{
					if (count == 2)
					{
						if (IsNumeric(code[1].Trim()))
						{
							message = "Success :- " + code[0] + "(" + code[1] + ") is correct syntax and parameter.";
						}
						else if (getVariableValue(code[1].Trim()) != -1)
						{
							message = "Success :- " + code[0] + "(" + code[1] + ") is correct syntax and parameter.";
						}
						else
						{
							message = "Error :- Invalid Parameter near " + code[0] + " Please check and run the program again. Example: circle(radius) ";
							Console.WriteLine(message);
						}
					}
					else
					{
						message = "Error :- Invalid Parameter near " + code[0] + " Please check and run the program again. Example: circle(radius)";
						Console.WriteLine(message);
					}

				}
				else if (syntaxName.Equals("rectangle"))
				{
					if (count == 3)
					{
						if (IsNumeric(code[1].Trim()) && IsNumeric(code[2].Trim()))
						{
							message = "Success :- " + code[0] + "(" + code[1] + "," + code[2] + ") is correct syntax and parameter.";

						}
						else if ((getVariableValue(code[1].Trim()) != -1) && (getVariableValue(code[2].Trim()) != -1))
						{
							message = "Success :- " + code[0] + "(" + code[1] + "," + code[2] + ") is correct syntax and parameter.";
						}
						else
						{
							message = "Error :- Invalid Parameter near " + code[0] + " Please check and run the program again. Example: rectangle(Width,Height)";
							Console.WriteLine(message);

						}
					}
					else
					{
						message = "Error :- Invalid Parameter near " + code[0] + " Please check and run the program again. Example: rectangle(Width, Height)";
						Console.WriteLine(message);
					}
				}
				else if (syntaxName.Equals("triangle"))
				{
					if (count == 7)
					{
						if (IsNumeric(code[1].Trim()) && IsNumeric(code[2].Trim()) && IsNumeric(code[3].Trim()) && IsNumeric(code[4].Trim()) && IsNumeric(code[5].Trim()) && IsNumeric(code[6].Trim()))
						{
							message = "Success :- " + code[0] + "((" + code[1] + "," + code[2] + ")" + "(" + code[3] + ", " + code[4] + "(" + code[5] + ", " + code[6] + ")) is correct syntax and parameter.";
						}
						else if ((getVariableValue(code[1].Trim()) != -1) && (getVariableValue(code[2].Trim()) != -1) && (getVariableValue(code[3].Trim()) != -1) && (getVariableValue(code[4].Trim()) != -1) && (getVariableValue(code[5].Trim()) != -1) && (getVariableValue(code[6].Trim()) != -1))
						{
							message = "Success :- " + code[0] + "((" + code[1] + "," + code[2] + ")" + "(" + code[3] + ", " + code[4] + "(" + code[5] + ", " + code[6] + ")) is correct syntax and parameter.";
						}
						else
						{
							message = "Error :- Invalid Parameter near " + code[0] + " Please check and run the program again. Example: triangle((X-axis2,Y-axis2),(X-axis3,Y-axis3)). Note that initial position is current pen position.";
							Console.WriteLine(message);
						}
					}
					else
					{
						message = "Error :- Invalid Parameter near " + code[0] + " Please check and run the program again. Example: triangle((X-axis2,Y-axis2),(X-axis3,Y-axis3)). Note that initial position is current pen position.";
						Console.WriteLine(message);
					}
				}


				else if (syntaxName.Equals("polygon"))
				{
					if (count == 11)
					{
						if (IsNumeric(code[1].Trim()) && IsNumeric(code[2].Trim()) && IsNumeric(code[3].Trim()) && IsNumeric(code[4].Trim()) && IsNumeric(code[5].Trim()) && IsNumeric(code[6].Trim()) && IsNumeric(code[7].Trim()) && IsNumeric(code[8].Trim()) && IsNumeric(code[9].Trim()) && IsNumeric(code[10].Trim()))
						{
							message = "Success :- " + code[0] + "((" + code[1] + "," + code[2] + ")" + "(" + code[3] + ", " + code[4] + "(" + code[5] + ", " + code[6] + ")) is correct syntax and parameter.";
						}
						else if ((getVariableValue(code[1].Trim()) != -1) && (getVariableValue(code[2].Trim()) != -1) && (getVariableValue(code[3].Trim()) != -1) && (getVariableValue(code[4].Trim()) != -1) && (getVariableValue(code[5].Trim()) != -1) && (getVariableValue(code[6].Trim()) != -1) && (getVariableValue(code[7].Trim()) != -1) && (getVariableValue(code[8].Trim()) != -1) && (getVariableValue(code[9].Trim()) != -1) && (getVariableValue(code[10].Trim()) != -1))
						{
							message = "Success :- " + code[0] + "((" + code[1] + "," + code[2] + ")" + "(" + code[3] + ", " + code[4] + "(" + code[5] + ", " + code[6] + ")) is correct syntax and parameter.";
						}
						else
						{
							message = "Error :- Invalid Parameter near. Please check and run the program again. Example: triangle((X-axis2,Y-axis2),(X-axis3,Y-axis3)). Note that initial position is current pen position.";
							Console.WriteLine(message);
						}
					}
					else
					{
						message = "Error :- Invalid Parameter near. Please check and run the program again. Example: triangle((X-axis2,Y-axis2),(X-axis3,Y-axis3)). Note that initial position is current pen position.";
						Console.WriteLine(message);
					}
				}

				else if (syntaxName.Equals("drawto"))
				{
					if (count == 5)
					{
						if (IsNumeric(code[1].Trim()) && IsNumeric(code[2].Trim()) && IsNumeric(code[3].Trim()) && IsNumeric(code[4].Trim()))
						{
							message = "Success :- " + code[0] + "(" + code[1] + "," + code[2] + "," + code[3] + "," + code[4] + ") is correct syntax and parameter.";
						}
						else if ((getVariableValue(code[1].Trim()) != -1) && (getVariableValue(code[2].Trim()) != -1) && (getVariableValue(code[3].Trim()) != -1) && (getVariableValue(code[4].Trim()) != -1))
						{
							message = "Success :- " + code[0] + "(" + code[1] + "," + code[2] + "," + code[3] + "," + code[4] + ") is correct syntax and parameter.";
						}
						else
						{
							message = "Error :- Invalid Parameter near " + code[0] + " Please check and run the program again. Example: drawto(X-axis2,Y-axis2). Note that initial points is current pen position.";
							Console.WriteLine(message);
						}
					}
					else
					{
						message = "Error :- Invalid Parameter near " + code[0] + " Please check and run the program again. Example: drawto(X-axis2,Y-axis2). Note that initial points is current pen position.";
						Console.WriteLine(message);
					}
				}
				else if (syntaxName.Equals("moveto"))
				{
					if (count == 3)
					{
						if (IsNumeric(code[1].Trim()) && IsNumeric(code[2].Trim()))
						{
							message = "Success :- " + code[0] + "(" + code[1] + "," + code[2] + ") is correct syntax and parameter.";
						}
						else if ((getVariableValue(code[1].Trim()) != -1) && (getVariableValue(code[2].Trim()) != -1))
						{
							message = "Success :- " + code[0] + "(" + code[1] + "," + code[2] + ") is correct syntax and parameter.";
						}
						else
						{
							message = "Error :- Invalid Parameter near " + code[0] + " Please check and run the program again. Example: moveto(X-axis,Y-axis)";
							Console.WriteLine(message);
						}
					}
					else
					{
						message = "Error :- Invalid Parameter near " + code[0] + " Please check and run the program again. Example: move to (X-axis,Y-axis)";
						Console.WriteLine(message);

					}
				}
				else if (syntaxName.Equals("reset"))
				{

					message = "Success: Command Reset is Correct syntax";

				}
				else if (syntaxName.Equals("clear"))
				{
					//					message = "Success :- Clear command found";
					message = "Error :- Command found but please enter " + code[0] + " in command line below.";
					Console.WriteLine(message);
				}
				else if (syntaxName.Equals("var"))
				{
					if (count == 3)
					{
						if (IsSyntax(code[1]) == false && IsNumeric(code[1]) == false)
						{
							string found = CheckVariables(code[1].Trim());
							if (found == "not_found")
							{
								//	MessageBox.Show(found);
								if (IsNumeric(code[2].Trim()))
								{
									//variableList.Add(code[1].Trim(), code[2].Trim());
									message = "Success :- variable declared is correct syntax and parameter.";
									//	MessageBox.Show("variable declared");
								}
								else
								{
									if (IsSyntax(code[2]) == false)
									{
										found = CheckVariables(code[2].Trim());
										if (found == "not_found")
										{
											message = "Error :- Variable name " + code[2] + " cannot be found";
											Console.WriteLine(message);
										}
										else
										{
											//variableList.Add(code[1].Trim(), code[2].Trim());
											message = "Success :- variable declared is correct syntax and parameter.";
											//	MessageBox.Show("variable declared");
										}
									}
									else
									{
										message = "Error :- Invalid Variable Name. " + code[2] + " is a name of syntax. Please use another variable.";
										Console.WriteLine(message);
									}
								}
							}

							else
							{
								message = "Error :- Variable name " + code[1] + " already declared. Please use another variable.";
								Console.WriteLine(message);
							}

						}
						else
						{
							message = "Error :- Invalid Variable Name. " + code[1] + " is a name of syntax. Please use another variable.";
							Console.WriteLine(message);
						}
						//	MessageBox.Show(message);
					}

					else
					{
						message = "Error :- Invalid Variable Declaration near " + code[0] + " Please check and run the program again. Example: var variableName=value";
						Console.WriteLine(message);

					}


				}
				else if (syntaxName.Equals("call"))
				{
					if (code[1].Trim().ToLower().Equals(methodName.ToLower()))
					{
						if (isparameter == false && count == 2)
						{
							//	MessageBox.Show("method with no parameter declared");
							message = "Success :- variable declared is correct syntax and parameter.";
							//	MessageBox.Show("Parameter one found declared");
						}
						else if (count == 3 && isparameter1 == true)
						{
							parameter1 = getVariableValue(code[2]);
							//	MessageBox.Show("method with one parameter declared");
							message = "Success :- variable declared is correct syntax and parameter.";
							//	MessageBox.Show("Parameter one found declared");
						}
						else if (count == 4 && isparameter2 == true)
						{
							parameter1 = getVariableValue(code[2]);
							parameter2 = getVariableValue(code[3]);
							//	MessageBox.Show("method with 2 parameter declared");
							message = "Success :- variable declared is correct syntax and parameter.";
							//	MessageBox.Show("Parameter 2 found declared");
						}
						else
						{
							message = "Error :- Invalid Method Parameter.";
							Console.WriteLine(message);

						}
					}
					else
					{
						message = "Error :- Invalid Method Name or method not declared yet.";
						Console.WriteLine(message);
					}
				}
				else if (syntaxName.Equals("if"))
				{
					string[] ifCondition = line.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
					int ifcount = ifCondition.Count();
					if (ifcount == 6)
					{
						if (getVariableValue(ifCondition[1]) == getVariableValue(ifCondition[3]))
						{
							string[] split = ifCondition[5].Split(new char[] { '+' }, StringSplitOptions.RemoveEmptyEntries);
							if (getVariableValue(split[0])!= -1)
							{
								message = "Success :- variable declared is correct syntax and parameter.";
							}
							else
							{
								message = "Error :- Invalid IF Condition.";
								Console.WriteLine(message);
							}
						}
						else
						{
							message = "Error :- Invalid Method Name or method not declared yet.";
							Console.WriteLine(message);
						}


					}
					else
					{
						message = "Error :- Incorrect If condition.";
						Console.WriteLine(message);
					}

				}
			}
			else
			{
				if (CheckVariables(code[0]) != "not_found" && getVariableValue(line) != -1)
				{
					message = "Success :- variable increment is correct syntax and parameter.";
					//	MessageBox.Show("variable declared");
				}
				else
				{
					message = "Error :- Invalid Syntax. " + code[0] + " Please check and run the program again ok.";
					Console.WriteLine(message);
				}
			}






			return message;
		}




		private void closeOutput()
		{
			Form[] forms = Application.OpenForms.Cast<Form>().ToArray();
			foreach (Form thisForm in forms)
			{
				if (thisForm.Name != "MainForm") thisForm.Close();
			}
		}

		//private void MessageShow(string message)
		//{
		//	consoleBox.Text += message;
		//}

		/// <summary>
		/// Resets the X-axis and Y-axis pen position
		/// </summary>

		private void Reset()
		{
			initX = 0;
			initY = 0;
			radius = 0; height = 0; width = 0; x1 = 0; y1 = 0; x2 = 0; y2 = 0; x3 = 0; y3 = 0; x4 = 0; y4 = 0; x5 = 0; y5 = 0;
			variableList.Clear();
			forLoop.Clear();
			method.Clear();
			isparameter = false;
			isparameter1 = false;
			isparameter2 = false;
			parameter1 = 0;
			parameter2 = 0;
			methodName = null;
			loopStart = false;
			loopEnd = false;
			methodStart = false;
			methodEnd = false;
			loopSize = 0;
			rand = 1;
			syntaxName = null;
		}


		/// <summary>
		/// This method calculates/ get  the variable which are in dictionary form in variableList with keyword and value
		/// </summary>
		/// <param name="variable">pre defined variables</param>
		/// <returns>value of variable in integer form</returns>
		public int getVariableValue(string variable)
		{
			int result = -1;
			string v;
			//check for variable declaration or like radius + 5 and split by + sign 
			string[] code = variable.Split(new char[] { '+' }, StringSplitOptions.RemoveEmptyEntries);
			int count = code.Count();
			//check if addition of variable is done or not 	
			if (count == 1)
			{
				//check if it is variable or value
				if (IsNumeric(code[0].Trim()))
				{
					result = Convert.ToInt32(code[0].Trim());
				}
				else
				{
					//get variable value if it is not variable 
					v = CheckVariables(code[0].Trim());
					if (IsNumeric(v))
					{
						result = Convert.ToInt32(v);
					}
					else
					{
						result = -1;
					}
				}

			}
			else if (count == 2) //if it has variable + value or value + variable 
			{
				int value1;
				int value2;

				if (IsNumeric(code[0].Trim()))
				{
					value1 = Convert.ToInt32(code[0].Trim());

					if (IsNumeric(code[1].Trim()))
					{
						value2 = Convert.ToInt32(code[1].Trim());
						result = value1 + value2;
					}
					else
					{
						v = CheckVariables(code[0].Trim());

						if (IsNumeric(v))
						{
							value2 = Convert.ToInt32(v);
							result = value1 + value2;






						}
						else
						{
							result = -1;
						}
					}


				}
				else
				{
					v = CheckVariables(code[0].Trim());

					if (IsNumeric(v))
					{
						value1 = Convert.ToInt32(v);

						if (IsNumeric(code[1].Trim()))
						{
							value2 = Convert.ToInt32(code[1].Trim());
							result = value1 + value2;
							//	variableList.Remove(code[0].Trim());
							//	variableList.Add(code[0].Trim(), result.ToString());
						}
						else
						{
							v = CheckVariables(code[1].Trim());
							if (IsNumeric(v))
							{
								value2 = Convert.ToInt32(v);
								result = value1 + value2;
							}
							else
							{
								result = -1;
							}
						}
					}
					else
					{

						result = -1;

					}
				}
			}
			return result;
		}

		private bool checkLoopStart(string line)
		{
			bool result = false;
			string[] code = line.Split(new char[] { ',', '(', ')', '=', ' ' }, StringSplitOptions.RemoveEmptyEntries);
			syntaxName = code[0].Trim().ToLower();

			if (syntaxName.Equals("loop"))
			{
				if (IsNumeric(code[1].Trim()))
				{
					result = true;
					loopStart = true;
					loopSize = Convert.ToInt32(code[1].Trim());
				}
				else if (CheckVariables(code[1].Trim()) != "not_found")
				{
					result = true;
					loopSize = getVariableValue(code[1].Trim());
				}

			}
			return result;
		}

		private bool checkLoopEnd(string line)
		{
			bool result = false;
			string[] code = line.Split(new char[] { ',', '(', ')', '=', ' ' }, StringSplitOptions.RemoveEmptyEntries);
			syntaxName = code[0].Trim().ToLower();
			if (syntaxName.Equals("endloop"))
			{
				loopEnd = true;
				result = true;
			}
			return result;
		}

		private bool checkMethodStart(string line)
		{
			bool result = false;
			string[] code = line.Split(new char[] { ',', '(', ')', '=', ' ' }, StringSplitOptions.RemoveEmptyEntries);
			syntaxName = code[0].Trim().ToLower();
			int count = code.Count();

			if (count == 2)
			{
				if (syntaxName.Equals("method"))
				{
					methodName = code[1].Trim();
					result = true;
					methodStart = true;
					isparameter = false;
					isparameter1 = false;
					isparameter2 = false;
				}
			}
			else if (count == 3)
			{
				if (syntaxName.Equals("method"))
				{
					methodName = code[1].Trim();
					isparameter1 = true;
					isparameter2 = false;
					isparameter = true;
					result = true;
					methodStart = true;
					variableList.Add("parameter1", code[2].Trim());
				}
			}
			else if (count == 4)
			{
				if (syntaxName.Equals("method"))
				{
					methodName = code[1].Trim();
					isparameter1 = true;
					isparameter2 = true;
					isparameter = true;
					result = true;
					methodStart = true;
					variableList.Add("parameter2", code[3].Trim());
				}
			}


			return result;
		}

		private bool checkMethodEnd(string line)
		{
			bool result = false;
			string[] code = line.Split(new char[] { ',', '(', ')', '=', ' ' }, StringSplitOptions.RemoveEmptyEntries);
			syntaxName = code[0].Trim().ToLower();
			if (syntaxName.Equals("endmethod"))
			{
				methodEnd = true;
				result = true;
			}
			return result;
		}



		private void execute()
		{
			consoleBox.Clear();
			consoleBox.Text = " \n CPaint Compiler:- Compiling Started... \n";
			bool drawShape = false;
			bool showOutput = false;
			Reset();
			closeOutput();

			Output outputWindow = new Output();
			//Compiler compiler = new Compiler();
			string message = "";
			string[] lines = GetActiveEditor().Lines;
			lines = lines.Where(x => !string.IsNullOrEmpty(x)).ToArray();

			if (lines == null || lines.Length == 0)
			{
				consoleBox.Text += "\n Error: Compiling Failed. Empty File.";
			}
			else
			{
				foreach (var line in lines)
				{
					try
					{
						if (loopStart == false)
						{
							if (checkLoopStart(line) == true)
							{
								loopStart = true;
								//		MessageBox.Show(loopStart + "isSaved" + line);
								continue;
							}

						}

						if (methodStart == false)
						{
							if (checkMethodStart(line) == true)
							{
								methodStart = true;
								continue;
							}
							//	MessageBox.Show(methodStart + "isSaved" + line);

						}

						if (loopStart == true && loopEnd == false)
						{

							if (checkLoopEnd(line) == true)
							{
								loopEnd = true;
								//	MessageBox.Show(line + "inside");
								if (loopStart == true && loopEnd == true)
								{
									//loop here
									//	MessageBox.Show(line + "finally end" + loopSize);


									for (int j = 0; j < loopSize; j++)
									{


										foreach (var item in forLoop.Values)
										{
											message = Compile(item);
											if (message.Contains("Success"))
											{
												string[] code = item.Split(new char[] { ',', '(', ')', '=', ' ', '+' }, StringSplitOptions.RemoveEmptyEntries);
												syntaxName = code[0].Trim().ToLower();
												consoleBox.Text += "\n" + message;
												if (syntaxName.Equals("circle"))
												{
													radius = getVariableValue(code[1].Trim());

													drawShape = true;
												}
												else if (syntaxName.Equals("rectangle"))
												{

													width = getVariableValue(code[1].Trim());
													height = getVariableValue(code[2].Trim());
													drawShape = true;
												}
												else if (syntaxName.Equals("triangle"))
												{
													x1 = getVariableValue(code[1].Trim());
													y1 = getVariableValue(code[2].Trim());

													x2 = getVariableValue(code[3].Trim());
													y2 = getVariableValue(code[4].Trim());

													x3 = getVariableValue(code[5].Trim());
													y3 = getVariableValue(code[6].Trim());
													drawShape = true;
												}
												else if (syntaxName.Equals("polygon"))
												{
													x1 = getVariableValue(code[1].Trim());
													y1 = getVariableValue(code[2].Trim());

													x2 = getVariableValue(code[3].Trim());
													y2 = getVariableValue(code[4].Trim());

													x3 = getVariableValue(code[5].Trim());
													y3 = getVariableValue(code[6].Trim());

													x4 = getVariableValue(code[7].Trim());
													y5 = getVariableValue(code[8].Trim());

													x4 = getVariableValue(code[9].Trim());
													y5 = getVariableValue(code[10].Trim());
													drawShape = true;
												}
												else if (syntaxName.Equals("drawto"))
												{
													x1 = getVariableValue(code[1].Trim());
													y1 = getVariableValue(code[2].Trim());

													x2 = getVariableValue(code[3].Trim());
													y2 = getVariableValue(code[4].Trim());
													drawShape = true;
												}
												else if (syntaxName.Equals("moveto"))
												{
													initX = getVariableValue(code[1].Trim());
													initY = getVariableValue(code[2].Trim());

													consoleBox.Text += "\n Moveto set successfully to (" + initX + "," + initY + ").";
													drawShape = false;
												}
												else if (syntaxName.Equals("reset"))
												{
													Reset();
													consoleBox.Text += "\n Moveto reset successfully to (" + initX + "," + initY + ").";

													drawShape = false;
												}
												else if (syntaxName.Equals("clear"))
												{
													GetActiveEditor().Text = "";
													consoleBox.Text = "";

													outputWindow.ClearOutput();
													outputWindow.Show();

													consoleBox.Text += "\n Clear command executed Successfully. \n";
												}
												else if (syntaxName.Equals("var"))
												{
													variableList.Add(code[1].Trim(), code[2].Trim());
													//consoleBox.Text += "\n Moveto reset successfully to (" + initX + "," + initY + ").";
													//		MessageBox.Show("variable" + code[1] + "is variable " + code[2]);
													drawShape = false;
												}
												else if (syntaxName.Equals("if"))
												{
													drawShape = false;
													string[] ifCondition = line.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
													int ifcount = ifCondition.Count();
													if (ifcount == 6)
													{
														if (getVariableValue(ifCondition[1]) == getVariableValue(ifCondition[3]))
														{
															string[] split = ifCondition[5].Split(new char[] { '+' }, StringSplitOptions.RemoveEmptyEntries);
															if (getVariableValue(split[0]) != -1)
															{
															int	newValue = getVariableValue(split[0]) + getVariableValue(split[1]);

																variableList.Remove(split[0]);
																variableList.Add(split[0], newValue.ToString());
															}
															else
															{
																message = "Error :- Invalid IF Condition.";
																Console.WriteLine(message);
																consoleBox.Text += message;
															}
														}
														else
														{
															message = "Error :- Invalid Method Name or method not declared yet.";
															Console.WriteLine(message);
															consoleBox.Text += message;
														}


													}
													else
													{
														message = "Error :- Incorrect If condition.";
														Console.WriteLine(message);
														consoleBox.Text += message;
													}

												}


												else if (syntaxName.Equals("call"))
												{
													if (isparameter == false)
													{
														foreach (var c in method.Values)
														{
															string[] method = c.Split(new char[] { ',', '(', ')', '=', ' ' }, StringSplitOptions.RemoveEmptyEntries);
															if (method[0].Trim().ToLower() == "circle")
															{
																syntaxName = "circle";
																radius = getVariableValue(method[1].Trim());
															}
															else if (method[0].Trim().ToLower() == "rectangle")
															{
																syntaxName = "rectangle";
																height = getVariableValue(method[1]);
																width = getVariableValue(method[1]);
															}
															showOutput = true;
															Shape compiledShape = ShapeFactory.CreateShape(syntaxName, initX, initY, radius, height, width, x1, y1, x2, y2, x3, y3, x4, y4, x5, y5);
															outputWindow.Shapes.Add(compiledShape);
														}
													}
													else if (isparameter == true)
													{
														foreach (var ca in method.Values)
														{
															string[] method = ca.Split(new char[] { ',', '(', ')', '=', ' ' }, StringSplitOptions.RemoveEmptyEntries);
															int countMethod = method.Count();

															if (method[0].Trim().ToLower() == "circle" && isparameter1 == true)
															{
																syntaxName = "circle";
																//	radius = parameter1;
																radius = getVariableValue(parameter1.ToString());
															}
															else if (method[0].Trim().ToLower() == "rectangle" && isparameter2 == true)
															{
																syntaxName = "rectangle";
																//	height = parameter1;
																//	width = parameter2;
																height = getVariableValue(parameter1.ToString());
																width = getVariableValue(parameter2.ToString());
															}
															else
															{
																message = "Error :- Parameter Error ";
																Console.WriteLine(message);
																consoleBox.Text += "\n" + message;
																break;
															}
															showOutput = true;
															Shape compiledShape = ShapeFactory.CreateShape(syntaxName, initX, initY, radius, height, width, x1, y1, x2, y2, x3, y3, x4, y4, x5, y5);
															outputWindow.Shapes.Add(compiledShape);
														}


													}


													drawShape = false;

												}
												else
												{
													if (CheckVariables(code[0]) != "not_found" && getVariableValue(item) != -1)
													{
														int newValue = getVariableValue(item);
														variableList.Remove(code[0]);
														variableList.Add(code[0], newValue.ToString());
														drawShape = false;
													}
													else
													{
														message = "Error :- Invalid Syntax.";
														Console.WriteLine(message);
														consoleBox.Text += "\n" + message;
														break;
													}
												}


												if (drawShape)
												{
													showOutput = true;
													Shape compiledShape = ShapeFactory.CreateShape(syntaxName, initX, initY, radius, height, width, x1, y1, x2, y2, x3, y3, x4, y4, x5, y5);

													outputWindow.Shapes.Add(compiledShape);
												}


											}
											else
											{
												consoleBox.Text += "\n" + message;
												showOutput = false;
												break;
											}
										}
									}

								}
							}
							else
							{
								//	MessageBox.Show(rand + "  ");
								forLoop.Add(rand++, line);
								//	MessageBox.Show(rand + "  ");
							}

						}

						else if (methodStart == true && methodEnd == false)
						{
							if (checkMethodEnd(line) == true)
							{
								methodEnd = true;
								//	MessageBox.Show(line + "method ended");
								continue;

							}
							else
							{
								method.Add(rand++, line);
								//	MessageBox.Show("added line" + line);
								continue;
							}
						}

						else
						{
							message = Compile(line);
							if (message.Contains("Success"))
							{
								string[] code = line.Split(new char[] { ',', '(', ')', '=', ' ' }, StringSplitOptions.RemoveEmptyEntries);
								syntaxName = code[0].Trim().ToLower();
								consoleBox.Text += "\n" + message;
								if (syntaxName.Equals("circle"))
								{
									radius = getVariableValue(code[1].Trim());

									drawShape = true;
								}
								else if (syntaxName.Equals("rectangle"))
								{

									width = getVariableValue(code[1].Trim());
									height = getVariableValue(code[2].Trim());
									drawShape = true;
								}
								else if (syntaxName.Equals("triangle"))
								{
									x1 = getVariableValue(code[1].Trim());
									y1 = getVariableValue(code[2].Trim());

									x2 = getVariableValue(code[3].Trim());
									y2 = getVariableValue(code[4].Trim());

									x3 = getVariableValue(code[5].Trim());
									y3 = getVariableValue(code[6].Trim());
									drawShape = true;
								}
								else if (syntaxName.Equals("polygon"))
								{
									x1 = getVariableValue(code[1].Trim());
									y1 = getVariableValue(code[2].Trim());

									x2 = getVariableValue(code[3].Trim());
									y2 = getVariableValue(code[4].Trim());

									x3 = getVariableValue(code[5].Trim());
									y3 = getVariableValue(code[6].Trim());

									x4 = getVariableValue(code[7].Trim());
									y5 = getVariableValue(code[8].Trim());

									x4 = getVariableValue(code[9].Trim());
									y5 = getVariableValue(code[10].Trim());
									drawShape = true;
								}
								else if (syntaxName.Equals("drawto"))
								{
									x1 = getVariableValue(code[1].Trim());
									y1 = getVariableValue(code[2].Trim());

									x2 = getVariableValue(code[3].Trim());
									y2 = getVariableValue(code[4].Trim());
									drawShape = true;
								}
								else if (syntaxName.Equals("moveto"))
								{
									initX = getVariableValue(code[1].Trim());
									initY = getVariableValue(code[2].Trim());

									consoleBox.Text += "\n Moveto set successfully to (" + initX + "," + initY + ").";
									drawShape = false;
								}
								else if (syntaxName.Equals("reset"))
								{
									Reset();
									consoleBox.Text += "\n Moveto reset successfully to (" + initX + "," + initY + ").";

									drawShape = false;
								}
								else if (syntaxName.Equals("clear"))
								{
									GetActiveEditor().Text = "";
									consoleBox.Text = "";

									outputWindow.ClearOutput();
									outputWindow.Show();

									consoleBox.Text += "\n Clear command executed Successfully. \n";
								}
								else if (syntaxName.Equals("var"))
								{
									variableList.Add(code[1].Trim(), code[2].Trim());
									//consoleBox.Text += "\n Moveto reset successfully to (" + initX + "," + initY + ").";
									//	MessageBox.Show("variable" + code[1] + "is variable " + code[2]);
									drawShape = false;
								}
								else if (syntaxName.Equals("if"))
								{
									drawShape = false;
									string[] ifCondition = line.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
									int ifcount = ifCondition.Count();
									if (ifcount == 6)
									{
										if (getVariableValue(ifCondition[1]) == getVariableValue(ifCondition[3]))
										{
											string[] split = ifCondition[5].Split(new char[] { '+' }, StringSplitOptions.RemoveEmptyEntries);
											if (getVariableValue(split[0]) != -1)
											{
												int newValue = getVariableValue(split[0]) + getVariableValue(split[1]);

												variableList.Remove(split[0]);
												variableList.Add(split[0], newValue.ToString());
											}
											else
											{
												message = "Error :- Invalid IF Condition.";
												Console.WriteLine(message);
												consoleBox.Text += message;
											}
										}
										else
										{
											message = "Error :- Invalid Method Name or method not declared yet.";
											Console.WriteLine(message);
											consoleBox.Text += message;
										}


									}
									else
									{
										message = "Error :- Incorrect If condition.";
										Console.WriteLine(message);
										consoleBox.Text += message;
									}

								}

								else if (syntaxName.Equals("call"))
								{
									if (isparameter == false)
									{
										foreach (var item in method.Values)
										{
											string[] method = item.Split(new char[] { ',', '(', ')', '=', ' ' }, StringSplitOptions.RemoveEmptyEntries);
											if (method[0].Trim().ToLower() == "circle")
											{
												syntaxName = "circle";
												radius = getVariableValue(method[1].Trim());
											}
											else if (method[0].Trim().ToLower() == "rectangle")
											{
												syntaxName = "rectangle";
												height = getVariableValue(method[1]);
												width = getVariableValue(method[1]);
											}
											showOutput = true;
											Shape compiledShape = ShapeFactory.CreateShape(syntaxName, initX, initY, radius, height, width, x1, y1, x2, y2, x3, y3, x4, y4, x5, y5);
											outputWindow.Shapes.Add(compiledShape);
										}
									}
									else if (isparameter == true)
									{
										foreach (var item in method.Values)
										{
											string[] method = item.Split(new char[] { ',', '(', ')', '=', ' ' }, StringSplitOptions.RemoveEmptyEntries);
											int countMethod = method.Count();

											if (method[0].Trim().ToLower() == "circle" && isparameter1 == true)
											{
												syntaxName = "circle";
												//	radius = parameter1;
												radius = getVariableValue(parameter1.ToString());
											}
											else if (method[0].Trim().ToLower() == "rectangle" && isparameter2 == true)
											{
												syntaxName = "rectangle";
												//	height = parameter1;
												//	width = parameter2;
												height = getVariableValue(parameter1.ToString());
												width = getVariableValue(parameter2.ToString());
											}
											else
											{
												message = "Error :- Parameter Error ";
												Console.WriteLine(message);
												consoleBox.Text += "\n" + message;
												break;
											}
											showOutput = true;
											Shape compiledShape = ShapeFactory.CreateShape(syntaxName, initX, initY, radius, height, width, x1, y1, x2, y2, x3, y3, x4, y4, x5, y5);
											outputWindow.Shapes.Add(compiledShape);
										}


									}

									drawShape = false;


								}


								if (drawShape)
								{
									showOutput = true;
									Shape compiledShape = ShapeFactory.CreateShape(syntaxName, initX, initY, radius, height, width, x1, y1, x2, y2, x3, y3, x4, y4, x5, y5);

									outputWindow.Shapes.Add(compiledShape);
								}


							}
							else
							{
								consoleBox.Text += "\n" + message;
								showOutput = false;
								break;
							}
						}

					}
					catch (Exception ex)
					{
						message = "Error :- Error in Drawing Shapes. " + ex.Message;
						Console.WriteLine(message);
						consoleBox.Text += "\n" + message;
					}
				}
				if (showOutput)
				{
					//outputWindow.MdiParent = this;
					outputWindow.Show();
					outputWindow.Invalidate();
					//outputWindow.Refresh();
				}
			}
		}

		private void debug()
		{
			//variableList.Add("admin", "1");
			Reset();
			consoleBox.Clear();
			consoleBox.Text = " \n CPaint Compiler:- Compiling Started... \n";
			closeOutput();

			//Compiler compiler = new Compiler();
			string message = "";
			string[] lines = GetActiveEditor().Lines;
			lines = lines.Where(x => !string.IsNullOrEmpty(x)).ToArray();

			if (lines == null || lines.Length == 0)
			{
				consoleBox.Text += "\n Error: Compiling Failed. Empty File.";
			}
			else
			{
				foreach (var line in lines)
				{
					message = Compile(line);
					consoleBox.Text += "\n" + message;

				}

			}
		}

		private void toolStripMenuItem6_Click(object sender, EventArgs e)
		{
			debug();
		}

		private void toolStripMenuItem3_Click(object sender, EventArgs e)
		{
			execute();
		}

		private void ToolBtnDebug_Click(object sender, EventArgs e)
		{
			debug();

		}

		private void TabControl_Selecting(object sender, TabControlCancelEventArgs e)
		{
			try
			{
				AddLineNumbers();
			}
			catch (Exception ex)
			{

				Console.WriteLine("Exception Message: " + ex.Message);
			}


		}

		private void TabControl_Deselecting(object sender, TabControlCancelEventArgs e)
		{
			try
			{
				AddLineNumbers();
			}
			catch (Exception ex)
			{
				Console.WriteLine("Exception Message: " + ex.Message);
			}


		}

		private void richLine_TextChanged(object sender, EventArgs e)
		{

		}

		private void ToolBtnRun_Click(object sender, EventArgs e)
		{

			execute();
		}

		/// <summary>
		/// used for Command in console box when enter key is pressed . 
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void consoleBox_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Enter)
			{
				try
				{
					int cursorPosition = consoleBox.SelectionStart;
					int lineIndex = consoleBox.GetLineFromCharIndex(cursorPosition);
					string lineText = consoleBox.Lines[lineIndex];
					string[] code = lineText.Split(' ', ',', '(', ')');
					code = code.Where(x => !string.IsNullOrEmpty(x)).ToArray();
					if (code[0].ToLower() == "clear")
					{
						try
						{
							GetActiveEditor().Text = "";
							consoleBox.Text = "";

							closeOutput();
							Output outputWindow = new Output();

							outputWindow.ClearOutput();
							outputWindow.Show();

							consoleBox.Text += "\n Clear command executed Successfully. \n";
						}
						catch (Exception ex)
						{
							Console.WriteLine("Exception Message: " + ex.Message);
							consoleBox.Text += "\n Command Execution Failed. \n";
						}
					}
					else if (code[0].ToLower() == "run")
					{
						try
						{
							execute();
							consoleBox.Text += "\n Run command executed Successfully. \n";
						}
						catch (Exception ex)
						{

							Console.WriteLine("Exception Message: " + ex.Message);
							consoleBox.Text += "\n Command Execution Failed. \n";
						}

					}
					else if (code[0].ToLower() == "reset")
					{
						try
						{
							Reset();
							consoleBox.Text += "\n Pen position set successfully. (" + initX + "," + initY + ").";

							consoleBox.Text = "\n Reset command executed Successfully. \n";
						}
						catch (Exception ex)
						{

							Console.WriteLine("Exception Message: " + ex.Message);
							consoleBox.Text += "\n Reset Command Execution Failed. \n";
						}


					}
					else if (code[0].ToLower() == "save")
					{
						try
						{
							SaveFile();
							consoleBox.Text += "\n Save command executed Successfully. \n";
						}
						catch (Exception ex)
						{

							Console.WriteLine("Exception Message: " + ex.Message);
							consoleBox.Text += "\n Command Execution Failed. \n";
						}

					}
					else if (code[0].ToLower() == "saveas")
					{
						try
						{
							SaveAsFile();
							consoleBox.Text += "\n SaveAs command executed Successfully. \n";
						}
						catch (Exception ex)
						{

							Console.WriteLine("Exception Message: " + ex.Message);
							consoleBox.Text += "\n Command Execution Failed. \n";
						}
					}
					else if (code[0].ToLower() == "close")
					{
						try
						{
							RemoveCurrentDocument();
							consoleBox.Text += "\n Close command executed Successfully. \n";
						}
						catch (Exception ex)
						{

							Console.WriteLine("Exception Message: " + ex.Message);
							consoleBox.Text += "\n Command Execution Failed. \n";
						}

					}
					else if (code[0].ToLower() == "open")
					{
						try
						{
							OpenFile();
							consoleBox.Text += "\n Open command executed Successfully. \n";
						}
						catch (Exception ex)
						{

							Console.WriteLine("Exception Message: " + ex.Message);
							consoleBox.Text += " \n Command Execution Failed. \n";
						}
					}

				}
				catch (Exception ex)
				{

					Console.WriteLine("Exception Message: " + ex.Message);

				}


			}
		}

		private void pictureBox1_Click(object sender, EventArgs e)
		{




		}

		private void pictureBox1_Paint(object sender, PaintEventArgs e)
		{

		}
	}
}
