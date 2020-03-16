using System;
using System.Drawing;
using System.IO;
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
		Color canvasColor = Color.Gray;
		Color textColor = Color.White;
		Font font = new Font("Arial", 16, FontStyle.Bold);
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

		private void CreateNewDocument()
		{
			tabPage = new TabPage("Untitled Paint Document");

			RichTextBox textBox = new RichTextBox
			{
				SelectionFont = font,
				//	textBox.SelectionColor = System.Drawing.Color.Black;
				Dock = DockStyle.Fill,
				ForeColor = textColor,
				BackColor = canvasColor
			};
			tabPage.Controls.Add(textBox);
			tabPage.Focus();
			TabControl.TabPages.Add(tabPage);
			TabControl.SelectTab(tabPage);
			
		}

		private void RemoveCurrentDocument()
		{
			if(TabControl.SelectedTab != null)
			{

			TabControl.TabPages.Remove(TabControl.SelectedTab);
			}
			else
			{
				MessageBox.Show("Please open tabs first to close.");
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

		private void SaveFile()
		{
			SaveFileDialog saveFileDialog1 = new SaveFileDialog();
			saveFileDialog1.InitialDirectory = "D:";
			saveFileDialog1.RestoreDirectory = true;
			saveFileDialog1.Title = "Save File";
			//	saveFileDialog1.CheckFileExists = true;
			//	saveFileDialog1.CheckPathExists = true;
			saveFileDialog1.DefaultExt = "txt";
			saveFileDialog1.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";
		//	saveFileDialog1.FilterIndex = 1;
			saveFileDialog1.RestoreDirectory = true;
			if (saveFileDialog1.ShowDialog() == DialogResult.OK)
			{
				using (Stream s = File.Open(saveFileDialog1.FileName, FileMode.CreateNew))

				using (StreamWriter sw=new StreamWriter(s))
				{
					//sw.Write(GetActiveEditor().Text);
					var fileName = saveFileDialog1.FileName;
					tabPage = new TabPage(fileName);
					RichTextBox textBox = new RichTextBox();
					textBox.LoadFile(fileName, RichTextBoxStreamType.PlainText);
					textBox.SelectionFont = font;
					//	textBox.SelectionColor = System.Drawing.Color.Black;
					textBox.Dock = DockStyle.Fill;
					textBox.ForeColor = textColor;
					textBox.BackColor = canvasColor;
					tabPage.Controls.Add(textBox);
					tabPage.Focus();
					TabControl.TabPages.Add(tabPage);
					TabControl.SelectTab(tabPage);
					RemoveCurrentDocument();
				}





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
			if (f.ShowDialog()== DialogResult.OK){
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
			
		}

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
				tabPage = new TabPage(Chosen_File);
				RichTextBox textBox = new RichTextBox();
				textBox.LoadFile(Chosen_File, RichTextBoxStreamType.PlainText);
				textBox.SelectionFont = font;
				//	textBox.SelectionColor = System.Drawing.Color.Black;
				textBox.Dock = DockStyle.Fill;
				textBox.ForeColor = textColor;
				textBox.BackColor = canvasColor;
				tabPage.Controls.Add(textBox);
				tabPage.Focus();
				TabControl.TabPages.Add(tabPage);
				TabControl.SelectTab(tabPage);
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
	}
}
