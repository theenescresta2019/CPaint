using System;
using CPaint.Compilers;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using CPaint.Class;

namespace CPaint
{
	/// <summary>
	/// Main Interface form 
	/// </summary>
	public partial class MainForm : Form
	{
		int initX, initY, radius = 0, height = 0, width = 0, x2 = 0, y2 = 0, x3 = 0, y3 = 0;
		string shapeName = "";

		Output outputWindow = new Output();
		/// <summary>
		/// initializing all the components 
		/// </summary>
		public MainForm()
		{
			InitializeComponent();
		}

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


		//private void execute()
		//{
		//	Output outputWindow = new Output();
		//	Compiler compiler = new Compiler();
		//	//compiler = new Compiler(outputWindow);
		//	//get all text and save in lines string array
		//	string output = "";
		//	string[] lines = GetActiveEditor().Lines;
		//	lines = lines.Where(x => !string.IsNullOrEmpty(x)).ToArray();
		//	if (lines == null || lines.Length == 0)
		//	{
		//		consoleBox.Text += "\n Error: Compiling Failed. Empty File.";
		//	}
		//	else
		//	{
		//		foreach (var line in lines)
		//		{
		//			output = compiler.Compile(line);
		//			consoleBox.Text += "\n" + output;
		//			if (output.Contains("Error"))
		//			{
		//			break;
		//			}
		//		}

		//	}


		//}

		private void closeOutput()
		{
			Form[] forms = Application.OpenForms.Cast<Form>().ToArray();
			foreach (Form thisForm in forms)
			{
				if (thisForm.Name != "MainForm") thisForm.Close();
			}
		}

		private void MessageShow(string message)
		{
			consoleBox.Text += message;
		}

		/// <summary>
		/// Resets the X-axis and Y-axis pen position
		/// </summary>

		private void Reset()
		{
			initX = 0;
			initY = 0;
			radius = 0; height = 0; width = 0; x2 = 0; y2 = 0; x3 = 0; y3 = 0;
		}



		private bool DeclareVariable(string text)
		{
			bool result = true;




			return result;
		}




		private void execute()
		{
			consoleBox.Clear();
			consoleBox.Text = " \n CPaint Compiler:- Compiling Started... \n";
			bool drawShape = false;
			bool showOutput = false;
			radius = 0; height = 0; width = 0; x2 = 0; y2 = 0; x3 = 0; y3 = 0;
			closeOutput();
			
			Output outputWindow = new Output();
			Compiler compiler = new Compiler();
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
						message = compiler.Compile(line);
						if (message.Contains("Success"))
						{
							string[] code = line.Split(new char[] { ',', '(', ')' }, StringSplitOptions.RemoveEmptyEntries);
							shapeName = code[0].Trim().ToLower();
							consoleBox.Text += "\n" + message;
							if (shapeName.Equals("circle"))
							{
								radius = Convert.ToInt32(code[1].Trim());
								drawShape = true;
							}
							else if (shapeName.Equals("rectangle"))
							{

								width = Convert.ToInt32(code[1].Trim());
								height = Convert.ToInt32(code[2].Trim());
								drawShape = true;
							}
							else if (shapeName.Equals("triangle"))
							{
								x2 = Convert.ToInt32(code[1].Trim());
								y2 = Convert.ToInt32(code[2].Trim());
								x3 = Convert.ToInt32(code[3].Trim());
								y3 = Convert.ToInt32(code[4].Trim());
								drawShape = true;
							}
							else if (shapeName.Equals("drawto"))
							{
								x2 = Convert.ToInt32(code[1].Trim());
								y2 = Convert.ToInt32(code[2].Trim());
								drawShape = true;
							}
							else if (shapeName.Equals("moveto"))
							{

								initX = Convert.ToInt32(code[1].Trim());
								initY = Convert.ToInt32(code[2].Trim());
								consoleBox.Text += "\n Moveto set successfully to (" + initX + "," + initY + ").";
								drawShape = false;
							}
							else if (shapeName.Equals("reset"))
							{
								Reset();
								consoleBox.Text += "\n Moveto reset successfully to (" + initX + "," + initY + ").";

								drawShape = false;
							}
							else if (shapeName.Equals("clear"))
							{
								GetActiveEditor().Text = "";
								consoleBox.Text = "";

								outputWindow.ClearOutput();
								outputWindow.Show();

								consoleBox.Text += "\n Clear command executed Successfully. \n";
							}

							if (drawShape)
							{
								showOutput = true;
							Shape compiledShape = ShapeFactory.CreateShape(shapeName, initX, initY, radius, height, width, x2, y2, x3, y3);

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
					catch (Exception ex)
					{
						message = "Error :- Error in Drawing Shapes. " + ex.Message;
						Console.WriteLine(message);
						consoleBox.Text += "\n" + message;
					}
				}

				if (showOutput) { 
					//outputWindow.MdiParent = this;
					outputWindow.Show();
					outputWindow.Invalidate();
					//outputWindow.Refresh();
				}

			}

		}

		private void debug()
		{
			consoleBox.Clear();
			consoleBox.Text = " \n CPaint Compiler:- Compiling Started... \n";
			closeOutput();

			Compiler compiler = new Compiler();
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
					message = compiler.Compile(line);
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
