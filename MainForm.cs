using System;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace CPaint
{
	public partial class MainForm : Form
	{
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

		public void AddLineNumbers()
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
				Cursor=Cursors.Default,
				
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
				MessageBox.Show("Please Write some text first. Empty file cannot be saved.","Warning");

			}
			else
			{

		



			//			string name = GetActiveEditor().Name;
			//string tabName = TabControl.SelectedTab.Name;
			//string tabName = TabControl.TabPages[TabControl.SelectedIndex].Name.ToString();
			//	MessageBox.Show(TabControl.SelectedTab.Name);
		
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
					MessageBox.Show("Saved Successfully");
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


				//			string name = GetActiveEditor().Name;
				//string tabName = TabControl.SelectedTab.Name;
				//string tabName = TabControl.TabPages[TabControl.SelectedIndex].Name.ToString();
				//	MessageBox.Show(TabControl.SelectedTab.Name);

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

				MessageBox.Show(Chosen_File);
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
			tabPage = new TabPage("Welcome To CPaint")
			{

				//	RichTextBox textBox = new RichTextBox();
				//textBox.Font = new Font("Arial", 24, FontStyle.Bold);
				////	textBox.SelectionColor = System.Drawing.Color.Black;
				//textBox.Dock = DockStyle.Fill;
				//textBox.ForeColor = Color.AntiqueWhite;
				//textBox.BackColor = canvasColor;

				//textBox.Text = "Hello! "+ " Welcome to CPaint." ;
				//	tabPage.Controls.Add(textBox);
				BackgroundImage = Image.FromFile("D:\\.net\\CPaint\\icons\\cpaintWelcome.jpg"),
				//	BackColor = ColorTranslator.FromHtml("#808080"),
				BackColor = (Color.BlanchedAlmond),
				BackgroundImageLayout = ImageLayout.Center
			};
			tabPage.Focus();
			//			TabControl.BackgroundImage = ;
			TabControl.TabPages.Add(tabPage);
			//	TabControl.SelectTab(tabPage);

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

		private void ToolBtnDebug_Click(object sender, EventArgs e)
		{
			string allText = GetActiveEditor().Text;

		string[] lines=	Regex.Split(allText, Environment.NewLine);
			Console.WriteLine(String.Join(",", lines));
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
	}
}
