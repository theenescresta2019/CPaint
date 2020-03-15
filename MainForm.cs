using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
		Font font = new Font("Arial", 12, FontStyle.Bold);
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
			
			RichTextBox textBox = new RichTextBox();
			textBox.SelectionFont =font;
		//	textBox.SelectionColor = System.Drawing.Color.Black;
			textBox.Dock = DockStyle.Fill;
			textBox.ForeColor = textColor;
			textBox.BackColor = canvasColor;
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
			tabPage = new TabPage("Welcome in CPaint");

			RichTextBox textBox = new RichTextBox();
			textBox.Font = new Font("Arial", 24, FontStyle.Bold);
			//	textBox.SelectionColor = System.Drawing.Color.Black;
			textBox.Dock = DockStyle.Fill;
			textBox.ForeColor = Color.AntiqueWhite;
			textBox.BackColor = canvasColor;

			textBox.Text = "Hello! user"+ "Welcome to CPaint."+ "You Cant";
			tabPage.Controls.Add(textBox);
			tabPage.Focus();
			TabControl.TabPages.Add(tabPage);
			TabControl.SelectTab(tabPage);

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

		private void toolStripMenuItem2_Click(object sender, EventArgs e)
		{

		}

		private void toolStripMenuItem9_Click(object sender, EventArgs e)
		{

		}

		private void toolStripButton1_Click_2(object sender, EventArgs e)
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

		private void toolStripButton2_Click_1(object sender, EventArgs e)
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

		private void toolStripMenuItem5_Click(object sender, EventArgs e)
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

		private void toolStripMenuItem4_Click(object sender, EventArgs e)
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

		private void toolStripButton1_Click_3(object sender, EventArgs e)
		{
			FontDialog f = new FontDialog();
			f.ShowColor = true;
			if(f.ShowDialog()== DialogResult.OK){
				GetActiveEditor().SelectAll();
				GetActiveEditor().SelectionFont = f.Font;
				GetActiveEditor().SelectionColor = f.Color;
				textColor = f.Color;
				font = f.Font;
			}

		}

		private void toolStripButton1_Click_4(object sender, EventArgs e)
		{

			try
			{
				ColorDialog color = new ColorDialog();
				color.AllowFullOpen = false;

				if (color.ShowDialog() == DialogResult.OK)
				{

					ToolBtnBgColor.BackColor = color.Color;
					GetActiveEditor().BackColor = color.Color;
					canvasColor = color.Color;
					//listBox1.ForeColor = colorDlg.Color;
				}
			}
			catch (Exception ex)
			{

				Console.WriteLine("Exception Message: " + ex.Message);
			}
			

		}
	}
}
