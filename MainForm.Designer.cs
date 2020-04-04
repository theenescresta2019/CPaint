namespace CPaint
{
	partial class MainForm
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.BtnFileMenu = new System.Windows.Forms.ToolStripMenuItem();
			this.BtnNew = new System.Windows.Forms.ToolStripMenuItem();
			this.BtnOpen = new System.Windows.Forms.ToolStripMenuItem();
			this.BtnSave = new System.Windows.Forms.ToolStripMenuItem();
			this.BtnSaveAs = new System.Windows.Forms.ToolStripMenuItem();
			this.BtnCloseCurrentTab = new System.Windows.Forms.ToolStripMenuItem();
			this.BtnCloseAllTabs = new System.Windows.Forms.ToolStripMenuItem();
			this.BtnShare = new System.Windows.Forms.ToolStripMenuItem();
			this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
			this.BtnCopy = new System.Windows.Forms.ToolStripMenuItem();
			this.BtnCut = new System.Windows.Forms.ToolStripMenuItem();
			this.BtnPaste = new System.Windows.Forms.ToolStripMenuItem();
			this.BtnSelectAll = new System.Windows.Forms.ToolStripMenuItem();
			this.redoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.undoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem6 = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem5 = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem7 = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem8 = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem9 = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem10 = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem11 = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem12 = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem13 = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem14 = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem15 = new System.Windows.Forms.ToolStripMenuItem();
			this.TabControl = new System.Windows.Forms.TabControl();
			this.toolStrip1 = new System.Windows.Forms.ToolStrip();
			this.ToolBtnAddNew = new System.Windows.Forms.ToolStripButton();
			this.ToolBtnSave = new System.Windows.Forms.ToolStripButton();
			this.ToolBtnOpen = new System.Windows.Forms.ToolStripButton();
			this.ToolBtnClose = new System.Windows.Forms.ToolStripButton();
			this.ToolBtnSelectAll = new System.Windows.Forms.ToolStripButton();
			this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
			this.ToolBtnCopy = new System.Windows.Forms.ToolStripButton();
			this.ToolBtnCut = new System.Windows.Forms.ToolStripButton();
			this.ToolBtnPaste = new System.Windows.Forms.ToolStripButton();
			this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
			this.ToolBtnUndo = new System.Windows.Forms.ToolStripButton();
			this.ToolBtnRedo = new System.Windows.Forms.ToolStripButton();
			this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
			this.ToolBtnZoomIn = new System.Windows.Forms.ToolStripButton();
			this.ToolBtnZoomOut = new System.Windows.Forms.ToolStripButton();
			this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
			this.ToolBtnDebug = new System.Windows.Forms.ToolStripButton();
			this.ToolBtnRun = new System.Windows.Forms.ToolStripButton();
			this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
			this.ToolBtnSetFont = new System.Windows.Forms.ToolStripButton();
			this.ToolBtnBgColor = new System.Windows.Forms.ToolStripButton();
			this.richLine = new System.Windows.Forms.RichTextBox();
			this.consoleBox = new System.Windows.Forms.RichTextBox();
			this.menuStrip1.SuspendLayout();
			this.toolStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// menuStrip1
			// 
			this.menuStrip1.BackColor = System.Drawing.SystemColors.HotTrack;
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.BtnFileMenu,
            this.toolStripMenuItem1,
            this.toolStripMenuItem2,
            this.toolStripMenuItem9});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(723, 26);
			this.menuStrip1.TabIndex = 1;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// BtnFileMenu
			// 
			this.BtnFileMenu.BackColor = System.Drawing.Color.Transparent;
			this.BtnFileMenu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.BtnFileMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.BtnNew,
            this.BtnOpen,
            this.BtnSave,
            this.BtnSaveAs,
            this.BtnCloseCurrentTab,
            this.BtnCloseAllTabs,
            this.BtnShare,
            this.exitToolStripMenuItem});
			this.BtnFileMenu.Font = new System.Drawing.Font("Book Antiqua", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.BtnFileMenu.ForeColor = System.Drawing.Color.AliceBlue;
			this.BtnFileMenu.ImageTransparentColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
			this.BtnFileMenu.Name = "BtnFileMenu";
			this.BtnFileMenu.Size = new System.Drawing.Size(42, 22);
			this.BtnFileMenu.Text = "File";
			// 
			// BtnNew
			// 
			this.BtnNew.Image = ((System.Drawing.Image)(resources.GetObject("BtnNew.Image")));
			this.BtnNew.Name = "BtnNew";
			this.BtnNew.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
			this.BtnNew.Size = new System.Drawing.Size(243, 22);
			this.BtnNew.Text = "New";
			this.BtnNew.Click += new System.EventHandler(this.BtnNew_Click);
			// 
			// BtnOpen
			// 
			this.BtnOpen.Image = ((System.Drawing.Image)(resources.GetObject("BtnOpen.Image")));
			this.BtnOpen.Name = "BtnOpen";
			this.BtnOpen.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
			this.BtnOpen.Size = new System.Drawing.Size(243, 22);
			this.BtnOpen.Text = "Open";
			this.BtnOpen.Click += new System.EventHandler(this.BtnOpen_Click);
			// 
			// BtnSave
			// 
			this.BtnSave.Image = ((System.Drawing.Image)(resources.GetObject("BtnSave.Image")));
			this.BtnSave.Name = "BtnSave";
			this.BtnSave.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
			this.BtnSave.Size = new System.Drawing.Size(243, 22);
			this.BtnSave.Text = "Save";
			this.BtnSave.Click += new System.EventHandler(this.BtnSave_Click);
			// 
			// BtnSaveAs
			// 
			this.BtnSaveAs.Image = ((System.Drawing.Image)(resources.GetObject("BtnSaveAs.Image")));
			this.BtnSaveAs.Name = "BtnSaveAs";
			this.BtnSaveAs.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.S)));
			this.BtnSaveAs.Size = new System.Drawing.Size(243, 22);
			this.BtnSaveAs.Text = "Save As";
			this.BtnSaveAs.Click += new System.EventHandler(this.BtnSaveAs_Click);
			// 
			// BtnCloseCurrentTab
			// 
			this.BtnCloseCurrentTab.Image = ((System.Drawing.Image)(resources.GetObject("BtnCloseCurrentTab.Image")));
			this.BtnCloseCurrentTab.Name = "BtnCloseCurrentTab";
			this.BtnCloseCurrentTab.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.W)));
			this.BtnCloseCurrentTab.Size = new System.Drawing.Size(243, 22);
			this.BtnCloseCurrentTab.Text = "Close Current Tab";
			this.BtnCloseCurrentTab.Click += new System.EventHandler(this.BtnCloseCurrentTab_Click);
			// 
			// BtnCloseAllTabs
			// 
			this.BtnCloseAllTabs.Image = ((System.Drawing.Image)(resources.GetObject("BtnCloseAllTabs.Image")));
			this.BtnCloseAllTabs.Name = "BtnCloseAllTabs";
			this.BtnCloseAllTabs.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.Q)));
			this.BtnCloseAllTabs.Size = new System.Drawing.Size(243, 22);
			this.BtnCloseAllTabs.Text = "Close All Tab";
			this.BtnCloseAllTabs.Click += new System.EventHandler(this.BtnCloseAllTabs_Click);
			// 
			// BtnShare
			// 
			this.BtnShare.Image = ((System.Drawing.Image)(resources.GetObject("BtnShare.Image")));
			this.BtnShare.Name = "BtnShare";
			this.BtnShare.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F6)));
			this.BtnShare.Size = new System.Drawing.Size(243, 22);
			this.BtnShare.Text = "Share";
			// 
			// exitToolStripMenuItem
			// 
			this.exitToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("exitToolStripMenuItem.Image")));
			this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
			this.exitToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
			this.exitToolStripMenuItem.Size = new System.Drawing.Size(243, 22);
			this.exitToolStripMenuItem.Text = "Exit";
			this.exitToolStripMenuItem.Click += new System.EventHandler(this.ExitToolStripMenuItem_Click);
			// 
			// toolStripMenuItem1
			// 
			this.toolStripMenuItem1.BackColor = System.Drawing.Color.Transparent;
			this.toolStripMenuItem1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.BtnCopy,
            this.BtnCut,
            this.BtnPaste,
            this.BtnSelectAll,
            this.redoToolStripMenuItem,
            this.undoToolStripMenuItem});
			this.toolStripMenuItem1.Font = new System.Drawing.Font("Book Antiqua", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.toolStripMenuItem1.ForeColor = System.Drawing.Color.AliceBlue;
			this.toolStripMenuItem1.ImageTransparentColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
			this.toolStripMenuItem1.Name = "toolStripMenuItem1";
			this.toolStripMenuItem1.Size = new System.Drawing.Size(44, 22);
			this.toolStripMenuItem1.Text = "Edit";
			this.toolStripMenuItem1.Click += new System.EventHandler(this.ToolStripMenuItem1_Click);
			// 
			// BtnCopy
			// 
			this.BtnCopy.Image = ((System.Drawing.Image)(resources.GetObject("BtnCopy.Image")));
			this.BtnCopy.Name = "BtnCopy";
			this.BtnCopy.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
			this.BtnCopy.Size = new System.Drawing.Size(181, 22);
			this.BtnCopy.Text = "Copy";
			this.BtnCopy.Click += new System.EventHandler(this.BtnCopy_Click);
			// 
			// BtnCut
			// 
			this.BtnCut.Image = ((System.Drawing.Image)(resources.GetObject("BtnCut.Image")));
			this.BtnCut.Name = "BtnCut";
			this.BtnCut.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
			this.BtnCut.Size = new System.Drawing.Size(181, 22);
			this.BtnCut.Text = "Cut";
			this.BtnCut.Click += new System.EventHandler(this.BtnCut_Click);
			// 
			// BtnPaste
			// 
			this.BtnPaste.Image = ((System.Drawing.Image)(resources.GetObject("BtnPaste.Image")));
			this.BtnPaste.Name = "BtnPaste";
			this.BtnPaste.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.V)));
			this.BtnPaste.Size = new System.Drawing.Size(181, 22);
			this.BtnPaste.Text = "Paste";
			this.BtnPaste.Click += new System.EventHandler(this.BtnPaste_Click);
			// 
			// BtnSelectAll
			// 
			this.BtnSelectAll.Image = ((System.Drawing.Image)(resources.GetObject("BtnSelectAll.Image")));
			this.BtnSelectAll.Name = "BtnSelectAll";
			this.BtnSelectAll.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.A)));
			this.BtnSelectAll.Size = new System.Drawing.Size(181, 22);
			this.BtnSelectAll.Text = "Select All";
			this.BtnSelectAll.Click += new System.EventHandler(this.BtnSelectAll_Click);
			// 
			// redoToolStripMenuItem
			// 
			this.redoToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("redoToolStripMenuItem.Image")));
			this.redoToolStripMenuItem.Name = "redoToolStripMenuItem";
			this.redoToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Y)));
			this.redoToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
			this.redoToolStripMenuItem.Text = "Redo";
			this.redoToolStripMenuItem.Click += new System.EventHandler(this.RedoToolStripMenuItem_Click);
			// 
			// undoToolStripMenuItem
			// 
			this.undoToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("undoToolStripMenuItem.Image")));
			this.undoToolStripMenuItem.Name = "undoToolStripMenuItem";
			this.undoToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Z)));
			this.undoToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
			this.undoToolStripMenuItem.Text = "Undo";
			this.undoToolStripMenuItem.Click += new System.EventHandler(this.UndoToolStripMenuItem_Click);
			// 
			// toolStripMenuItem2
			// 
			this.toolStripMenuItem2.BackColor = System.Drawing.Color.Transparent;
			this.toolStripMenuItem2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.toolStripMenuItem2.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem6,
            this.toolStripMenuItem3,
            this.toolStripMenuItem5,
            this.toolStripMenuItem4,
            this.toolStripMenuItem7,
            this.toolStripMenuItem8});
			this.toolStripMenuItem2.Font = new System.Drawing.Font("Book Antiqua", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.toolStripMenuItem2.ForeColor = System.Drawing.Color.AliceBlue;
			this.toolStripMenuItem2.ImageTransparentColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
			this.toolStripMenuItem2.Name = "toolStripMenuItem2";
			this.toolStripMenuItem2.Size = new System.Drawing.Size(53, 22);
			this.toolStripMenuItem2.Text = "Tools";
			this.toolStripMenuItem2.Click += new System.EventHandler(this.ToolStripMenuItem2_Click);
			// 
			// toolStripMenuItem6
			// 
			this.toolStripMenuItem6.Image = ((System.Drawing.Image)(resources.GetObject("toolStripMenuItem6.Image")));
			this.toolStripMenuItem6.Name = "toolStripMenuItem6";
			this.toolStripMenuItem6.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D)));
			this.toolStripMenuItem6.Size = new System.Drawing.Size(244, 22);
			this.toolStripMenuItem6.Text = "Debug";
			// 
			// toolStripMenuItem3
			// 
			this.toolStripMenuItem3.Image = ((System.Drawing.Image)(resources.GetObject("toolStripMenuItem3.Image")));
			this.toolStripMenuItem3.Name = "toolStripMenuItem3";
			this.toolStripMenuItem3.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.R)));
			this.toolStripMenuItem3.Size = new System.Drawing.Size(244, 22);
			this.toolStripMenuItem3.Text = "Run";
			// 
			// toolStripMenuItem5
			// 
			this.toolStripMenuItem5.Image = ((System.Drawing.Image)(resources.GetObject("toolStripMenuItem5.Image")));
			this.toolStripMenuItem5.Name = "toolStripMenuItem5";
			this.toolStripMenuItem5.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Oemplus)));
			this.toolStripMenuItem5.Size = new System.Drawing.Size(244, 22);
			this.toolStripMenuItem5.Text = "Zoom In";
			this.toolStripMenuItem5.Click += new System.EventHandler(this.ToolStripMenuItem5_Click);
			// 
			// toolStripMenuItem4
			// 
			this.toolStripMenuItem4.Image = ((System.Drawing.Image)(resources.GetObject("toolStripMenuItem4.Image")));
			this.toolStripMenuItem4.Name = "toolStripMenuItem4";
			this.toolStripMenuItem4.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.OemMinus)));
			this.toolStripMenuItem4.Size = new System.Drawing.Size(244, 22);
			this.toolStripMenuItem4.Text = "Zoom Out";
			this.toolStripMenuItem4.Click += new System.EventHandler(this.ToolStripMenuItem4_Click);
			// 
			// toolStripMenuItem7
			// 
			this.toolStripMenuItem7.Image = ((System.Drawing.Image)(resources.GetObject("toolStripMenuItem7.Image")));
			this.toolStripMenuItem7.Name = "toolStripMenuItem7";
			this.toolStripMenuItem7.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Y)));
			this.toolStripMenuItem7.Size = new System.Drawing.Size(244, 22);
			this.toolStripMenuItem7.Text = "Redo";
			// 
			// toolStripMenuItem8
			// 
			this.toolStripMenuItem8.Image = ((System.Drawing.Image)(resources.GetObject("toolStripMenuItem8.Image")));
			this.toolStripMenuItem8.Name = "toolStripMenuItem8";
			this.toolStripMenuItem8.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Z)));
			this.toolStripMenuItem8.Size = new System.Drawing.Size(244, 22);
			this.toolStripMenuItem8.Text = "Undo";
			// 
			// toolStripMenuItem9
			// 
			this.toolStripMenuItem9.BackColor = System.Drawing.Color.Transparent;
			this.toolStripMenuItem9.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.toolStripMenuItem9.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem10,
            this.toolStripMenuItem11,
            this.toolStripMenuItem12,
            this.toolStripMenuItem13,
            this.toolStripMenuItem14,
            this.toolStripMenuItem15});
			this.toolStripMenuItem9.Font = new System.Drawing.Font("Book Antiqua", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.toolStripMenuItem9.ForeColor = System.Drawing.Color.AliceBlue;
			this.toolStripMenuItem9.Image = ((System.Drawing.Image)(resources.GetObject("toolStripMenuItem9.Image")));
			this.toolStripMenuItem9.ImageTransparentColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
			this.toolStripMenuItem9.Name = "toolStripMenuItem9";
			this.toolStripMenuItem9.Size = new System.Drawing.Size(66, 22);
			this.toolStripMenuItem9.Text = "Help";
			this.toolStripMenuItem9.Click += new System.EventHandler(this.toolStripMenuItem9_Click);
			// 
			// toolStripMenuItem10
			// 
			this.toolStripMenuItem10.Image = ((System.Drawing.Image)(resources.GetObject("toolStripMenuItem10.Image")));
			this.toolStripMenuItem10.Name = "toolStripMenuItem10";
			this.toolStripMenuItem10.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
			this.toolStripMenuItem10.Size = new System.Drawing.Size(181, 22);
			this.toolStripMenuItem10.Text = "Copy";
			// 
			// toolStripMenuItem11
			// 
			this.toolStripMenuItem11.Image = ((System.Drawing.Image)(resources.GetObject("toolStripMenuItem11.Image")));
			this.toolStripMenuItem11.Name = "toolStripMenuItem11";
			this.toolStripMenuItem11.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
			this.toolStripMenuItem11.Size = new System.Drawing.Size(181, 22);
			this.toolStripMenuItem11.Text = "Cut";
			// 
			// toolStripMenuItem12
			// 
			this.toolStripMenuItem12.Image = ((System.Drawing.Image)(resources.GetObject("toolStripMenuItem12.Image")));
			this.toolStripMenuItem12.Name = "toolStripMenuItem12";
			this.toolStripMenuItem12.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.V)));
			this.toolStripMenuItem12.Size = new System.Drawing.Size(181, 22);
			this.toolStripMenuItem12.Text = "Paste";
			// 
			// toolStripMenuItem13
			// 
			this.toolStripMenuItem13.Image = ((System.Drawing.Image)(resources.GetObject("toolStripMenuItem13.Image")));
			this.toolStripMenuItem13.Name = "toolStripMenuItem13";
			this.toolStripMenuItem13.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.A)));
			this.toolStripMenuItem13.Size = new System.Drawing.Size(181, 22);
			this.toolStripMenuItem13.Text = "Select All";
			// 
			// toolStripMenuItem14
			// 
			this.toolStripMenuItem14.Image = ((System.Drawing.Image)(resources.GetObject("toolStripMenuItem14.Image")));
			this.toolStripMenuItem14.Name = "toolStripMenuItem14";
			this.toolStripMenuItem14.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Y)));
			this.toolStripMenuItem14.Size = new System.Drawing.Size(181, 22);
			this.toolStripMenuItem14.Text = "Redo";
			// 
			// toolStripMenuItem15
			// 
			this.toolStripMenuItem15.Image = ((System.Drawing.Image)(resources.GetObject("toolStripMenuItem15.Image")));
			this.toolStripMenuItem15.Name = "toolStripMenuItem15";
			this.toolStripMenuItem15.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Z)));
			this.toolStripMenuItem15.Size = new System.Drawing.Size(181, 22);
			this.toolStripMenuItem15.Text = "Undo";
			// 
			// TabControl
			// 
			this.TabControl.AllowDrop = true;
			this.TabControl.Dock = System.Windows.Forms.DockStyle.Fill;
			this.TabControl.Location = new System.Drawing.Point(33, 51);
			this.TabControl.Name = "TabControl";
			this.TabControl.SelectedIndex = 0;
			this.TabControl.Size = new System.Drawing.Size(690, 380);
			this.TabControl.TabIndex = 1;
			this.TabControl.SelectedIndexChanged += new System.EventHandler(this.TabControl_SelectedIndexChanged);
			this.TabControl.Selecting += new System.Windows.Forms.TabControlCancelEventHandler(this.TabControl_Selecting);
			this.TabControl.Deselecting += new System.Windows.Forms.TabControlCancelEventHandler(this.TabControl_Deselecting);
			// 
			// toolStrip1
			// 
			this.toolStrip1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
			this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolBtnAddNew,
            this.ToolBtnSave,
            this.ToolBtnOpen,
            this.ToolBtnClose,
            this.ToolBtnSelectAll,
            this.toolStripSeparator1,
            this.ToolBtnCopy,
            this.ToolBtnCut,
            this.ToolBtnPaste,
            this.toolStripSeparator2,
            this.ToolBtnUndo,
            this.ToolBtnRedo,
            this.toolStripSeparator3,
            this.ToolBtnZoomIn,
            this.ToolBtnZoomOut,
            this.toolStripSeparator4,
            this.ToolBtnDebug,
            this.ToolBtnRun,
            this.toolStripSeparator5,
            this.ToolBtnSetFont,
            this.ToolBtnBgColor});
			this.toolStrip1.Location = new System.Drawing.Point(0, 26);
			this.toolStrip1.Name = "toolStrip1";
			this.toolStrip1.Size = new System.Drawing.Size(723, 25);
			this.toolStrip1.TabIndex = 2;
			this.toolStrip1.Text = "toolStrip1";
			// 
			// ToolBtnAddNew
			// 
			this.ToolBtnAddNew.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.ToolBtnAddNew.Image = ((System.Drawing.Image)(resources.GetObject("ToolBtnAddNew.Image")));
			this.ToolBtnAddNew.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.ToolBtnAddNew.Name = "ToolBtnAddNew";
			this.ToolBtnAddNew.Size = new System.Drawing.Size(23, 22);
			this.ToolBtnAddNew.Text = "Add New Document";
			this.ToolBtnAddNew.ToolTipText = "Add New Untitled File (Ctrl + N)";
			this.ToolBtnAddNew.Click += new System.EventHandler(this.ToolStripButton1_Click);
			// 
			// ToolBtnSave
			// 
			this.ToolBtnSave.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.ToolBtnSave.Image = ((System.Drawing.Image)(resources.GetObject("ToolBtnSave.Image")));
			this.ToolBtnSave.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.ToolBtnSave.Name = "ToolBtnSave";
			this.ToolBtnSave.Size = new System.Drawing.Size(23, 22);
			this.ToolBtnSave.Text = "ToolBtnSave";
			this.ToolBtnSave.ToolTipText = "Save Current Document (Ctrl + S)";
			this.ToolBtnSave.Click += new System.EventHandler(this.ToolStripButton2_Click);
			// 
			// ToolBtnOpen
			// 
			this.ToolBtnOpen.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.ToolBtnOpen.Image = ((System.Drawing.Image)(resources.GetObject("ToolBtnOpen.Image")));
			this.ToolBtnOpen.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.ToolBtnOpen.Name = "ToolBtnOpen";
			this.ToolBtnOpen.Size = new System.Drawing.Size(23, 22);
			this.ToolBtnOpen.Text = "Open File";
			this.ToolBtnOpen.ToolTipText = "Open File (Ctrl + O)";
			this.ToolBtnOpen.Click += new System.EventHandler(this.ToolBtnOpen_Click);
			// 
			// ToolBtnClose
			// 
			this.ToolBtnClose.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.ToolBtnClose.Image = ((System.Drawing.Image)(resources.GetObject("ToolBtnClose.Image")));
			this.ToolBtnClose.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.ToolBtnClose.Name = "ToolBtnClose";
			this.ToolBtnClose.Size = new System.Drawing.Size(23, 22);
			this.ToolBtnClose.Text = "ToolBtnClose";
			this.ToolBtnClose.ToolTipText = "Close Current Document (Ctrl + W)";
			this.ToolBtnClose.Click += new System.EventHandler(this.ToolBtnClose_Click);
			// 
			// ToolBtnSelectAll
			// 
			this.ToolBtnSelectAll.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.ToolBtnSelectAll.Image = ((System.Drawing.Image)(resources.GetObject("ToolBtnSelectAll.Image")));
			this.ToolBtnSelectAll.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.ToolBtnSelectAll.Name = "ToolBtnSelectAll";
			this.ToolBtnSelectAll.Size = new System.Drawing.Size(23, 22);
			this.ToolBtnSelectAll.Text = "ToolBtnSelectAll";
			this.ToolBtnSelectAll.ToolTipText = "Select All (Ctrl + A)";
			this.ToolBtnSelectAll.Click += new System.EventHandler(this.ToolStripButton4_Click);
			// 
			// toolStripSeparator1
			// 
			this.toolStripSeparator1.Name = "toolStripSeparator1";
			this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
			// 
			// ToolBtnCopy
			// 
			this.ToolBtnCopy.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.ToolBtnCopy.Image = ((System.Drawing.Image)(resources.GetObject("ToolBtnCopy.Image")));
			this.ToolBtnCopy.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.ToolBtnCopy.Name = "ToolBtnCopy";
			this.ToolBtnCopy.Size = new System.Drawing.Size(23, 22);
			this.ToolBtnCopy.Text = "ToolBtnCopy";
			this.ToolBtnCopy.ToolTipText = "Copy (Ctrl + C)";
			this.ToolBtnCopy.Click += new System.EventHandler(this.ToolStripButton5_Click);
			// 
			// ToolBtnCut
			// 
			this.ToolBtnCut.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.ToolBtnCut.Image = ((System.Drawing.Image)(resources.GetObject("ToolBtnCut.Image")));
			this.ToolBtnCut.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.ToolBtnCut.Name = "ToolBtnCut";
			this.ToolBtnCut.Size = new System.Drawing.Size(23, 22);
			this.ToolBtnCut.Text = "ToolBtnCut";
			this.ToolBtnCut.ToolTipText = "Cut (Ctrl + X)";
			this.ToolBtnCut.Click += new System.EventHandler(this.ToolStripButton6_Click);
			// 
			// ToolBtnPaste
			// 
			this.ToolBtnPaste.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.ToolBtnPaste.Image = ((System.Drawing.Image)(resources.GetObject("ToolBtnPaste.Image")));
			this.ToolBtnPaste.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.ToolBtnPaste.Name = "ToolBtnPaste";
			this.ToolBtnPaste.Size = new System.Drawing.Size(23, 22);
			this.ToolBtnPaste.Text = "ToolBtnPaste";
			this.ToolBtnPaste.ToolTipText = "Paste (Ctrl + V )";
			this.ToolBtnPaste.Click += new System.EventHandler(this.ToolStripButton7_Click);
			// 
			// toolStripSeparator2
			// 
			this.toolStripSeparator2.Name = "toolStripSeparator2";
			this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
			// 
			// ToolBtnUndo
			// 
			this.ToolBtnUndo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.ToolBtnUndo.Image = ((System.Drawing.Image)(resources.GetObject("ToolBtnUndo.Image")));
			this.ToolBtnUndo.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.ToolBtnUndo.Name = "ToolBtnUndo";
			this.ToolBtnUndo.Size = new System.Drawing.Size(23, 22);
			this.ToolBtnUndo.Text = "ToolBtnUndo";
			this.ToolBtnUndo.ToolTipText = "Undo (Ctrl + Z )";
			this.ToolBtnUndo.Click += new System.EventHandler(this.ToolStripButton8_Click);
			// 
			// ToolBtnRedo
			// 
			this.ToolBtnRedo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.ToolBtnRedo.Image = ((System.Drawing.Image)(resources.GetObject("ToolBtnRedo.Image")));
			this.ToolBtnRedo.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.ToolBtnRedo.Name = "ToolBtnRedo";
			this.ToolBtnRedo.Size = new System.Drawing.Size(23, 22);
			this.ToolBtnRedo.Text = "ToolBtnRedo";
			this.ToolBtnRedo.ToolTipText = "Redo (Ctrl + Y)";
			this.ToolBtnRedo.Click += new System.EventHandler(this.ToolStripButton9_Click);
			// 
			// toolStripSeparator3
			// 
			this.toolStripSeparator3.Name = "toolStripSeparator3";
			this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
			// 
			// ToolBtnZoomIn
			// 
			this.ToolBtnZoomIn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.ToolBtnZoomIn.Image = ((System.Drawing.Image)(resources.GetObject("ToolBtnZoomIn.Image")));
			this.ToolBtnZoomIn.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.ToolBtnZoomIn.Name = "ToolBtnZoomIn";
			this.ToolBtnZoomIn.Size = new System.Drawing.Size(23, 22);
			this.ToolBtnZoomIn.Text = "ToolBtnZoomIn";
			this.ToolBtnZoomIn.ToolTipText = "Zoom In (Ctrl + +)";
			this.ToolBtnZoomIn.Click += new System.EventHandler(this.ToolStripButton1_Click_2);
			// 
			// ToolBtnZoomOut
			// 
			this.ToolBtnZoomOut.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.ToolBtnZoomOut.Image = ((System.Drawing.Image)(resources.GetObject("ToolBtnZoomOut.Image")));
			this.ToolBtnZoomOut.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.ToolBtnZoomOut.Name = "ToolBtnZoomOut";
			this.ToolBtnZoomOut.Size = new System.Drawing.Size(23, 22);
			this.ToolBtnZoomOut.Text = "ToolBtnZoomOut";
			this.ToolBtnZoomOut.ToolTipText = "Zoom Out (Ctrl + -)";
			this.ToolBtnZoomOut.Click += new System.EventHandler(this.ToolStripButton2_Click_1);
			// 
			// toolStripSeparator4
			// 
			this.toolStripSeparator4.Name = "toolStripSeparator4";
			this.toolStripSeparator4.Size = new System.Drawing.Size(6, 25);
			// 
			// ToolBtnDebug
			// 
			this.ToolBtnDebug.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.ToolBtnDebug.Image = ((System.Drawing.Image)(resources.GetObject("ToolBtnDebug.Image")));
			this.ToolBtnDebug.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.ToolBtnDebug.Name = "ToolBtnDebug";
			this.ToolBtnDebug.Size = new System.Drawing.Size(23, 22);
			this.ToolBtnDebug.Text = "ToolBtnDebug";
			this.ToolBtnDebug.ToolTipText = "Debug (Ctrl + D)";
			this.ToolBtnDebug.Click += new System.EventHandler(this.ToolBtnDebug_Click);
			// 
			// ToolBtnRun
			// 
			this.ToolBtnRun.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.ToolBtnRun.Image = ((System.Drawing.Image)(resources.GetObject("ToolBtnRun.Image")));
			this.ToolBtnRun.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.ToolBtnRun.Name = "ToolBtnRun";
			this.ToolBtnRun.Size = new System.Drawing.Size(23, 22);
			this.ToolBtnRun.Text = "ToolBtnRun";
			this.ToolBtnRun.ToolTipText = "Run/Execute (Ctrl + R)";
			this.ToolBtnRun.Click += new System.EventHandler(this.ToolBtnRun_Click);
			// 
			// toolStripSeparator5
			// 
			this.toolStripSeparator5.Name = "toolStripSeparator5";
			this.toolStripSeparator5.Size = new System.Drawing.Size(6, 25);
			// 
			// ToolBtnSetFont
			// 
			this.ToolBtnSetFont.Image = ((System.Drawing.Image)(resources.GetObject("ToolBtnSetFont.Image")));
			this.ToolBtnSetFont.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.ToolBtnSetFont.Name = "ToolBtnSetFont";
			this.ToolBtnSetFont.Size = new System.Drawing.Size(70, 22);
			this.ToolBtnSetFont.Text = "Set Font";
			this.ToolBtnSetFont.Click += new System.EventHandler(this.ToolStripButton1_Click_3);
			// 
			// ToolBtnBgColor
			// 
			this.ToolBtnBgColor.Image = ((System.Drawing.Image)(resources.GetObject("ToolBtnBgColor.Image")));
			this.ToolBtnBgColor.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.ToolBtnBgColor.Name = "ToolBtnBgColor";
			this.ToolBtnBgColor.Size = new System.Drawing.Size(123, 22);
			this.ToolBtnBgColor.Text = "Background Color";
			this.ToolBtnBgColor.ToolTipText = "Change Background Color";
			this.ToolBtnBgColor.Click += new System.EventHandler(this.ToolStripButton1_Click_4);
			// 
			// richLine
			// 
			this.richLine.BackColor = System.Drawing.Color.DarkSlateBlue;
			this.richLine.Dock = System.Windows.Forms.DockStyle.Left;
			this.richLine.ForeColor = System.Drawing.SystemColors.Window;
			this.richLine.Location = new System.Drawing.Point(0, 51);
			this.richLine.Name = "richLine";
			this.richLine.ReadOnly = true;
			this.richLine.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
			this.richLine.Size = new System.Drawing.Size(33, 380);
			this.richLine.TabIndex = 3;
			this.richLine.Text = "";
			this.richLine.TextChanged += new System.EventHandler(this.richLine_TextChanged);
			// 
			// consoleBox
			// 
			this.consoleBox.BackColor = System.Drawing.Color.Black;
			this.consoleBox.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.consoleBox.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.consoleBox.Font = new System.Drawing.Font("Garamond", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.consoleBox.ForeColor = System.Drawing.SystemColors.Window;
			this.consoleBox.Location = new System.Drawing.Point(33, 231);
			this.consoleBox.Name = "consoleBox";
			this.consoleBox.Size = new System.Drawing.Size(690, 200);
			this.consoleBox.TabIndex = 4;
			this.consoleBox.Text = "";
			this.consoleBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.consoleBox_KeyDown);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.ActiveBorder;
			this.ClientSize = new System.Drawing.Size(723, 431);
			this.Controls.Add(this.consoleBox);
			this.Controls.Add(this.TabControl);
			this.Controls.Add(this.richLine);
			this.Controls.Add(this.toolStrip1);
			this.Controls.Add(this.menuStrip1);
			this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MainMenuStrip = this.menuStrip1;
			this.Name = "MainForm";
			this.Text = "CPaint";
			this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			this.Load += new System.EventHandler(this.MainForm_Load);
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.toolStrip1.ResumeLayout(false);
			this.toolStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ToolStripMenuItem BtnFileMenu;
		private System.Windows.Forms.ToolStripMenuItem BtnNew;
		private System.Windows.Forms.ToolStripMenuItem BtnOpen;
		private System.Windows.Forms.ToolStripMenuItem BtnSave;
		private System.Windows.Forms.ToolStripMenuItem BtnSaveAs;
		private System.Windows.Forms.ToolStripMenuItem BtnShare;
		private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
		private System.Windows.Forms.TabControl TabControl;
		private System.Windows.Forms.ToolStripMenuItem BtnCloseCurrentTab;
		private System.Windows.Forms.ToolStrip toolStrip1;
		private System.Windows.Forms.ToolStripButton ToolBtnAddNew;
		private System.Windows.Forms.ToolStripButton ToolBtnSave;
		private System.Windows.Forms.ToolStripButton ToolBtnClose;
		private System.Windows.Forms.ToolStripButton ToolBtnSelectAll;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
		private System.Windows.Forms.ToolStripButton ToolBtnCopy;
		private System.Windows.Forms.ToolStripButton ToolBtnCut;
		private System.Windows.Forms.ToolStripButton ToolBtnPaste;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
		private System.Windows.Forms.ToolStripButton ToolBtnUndo;
		private System.Windows.Forms.ToolStripButton ToolBtnRedo;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
		private System.Windows.Forms.ToolStripButton ToolBtnRun;
		private System.Windows.Forms.ToolStripMenuItem BtnCloseAllTabs;
		private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
		private System.Windows.Forms.ToolStripMenuItem BtnCopy;
		private System.Windows.Forms.ToolStripMenuItem BtnCut;
		private System.Windows.Forms.ToolStripMenuItem BtnPaste;
		private System.Windows.Forms.ToolStripMenuItem BtnSelectAll;
		private System.Windows.Forms.ToolStripMenuItem redoToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem undoToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
		private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
		private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem4;
		private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem5;
		private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem6;
		private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem7;
		private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem8;
		private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem9;
		private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem10;
		private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem11;
		private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem12;
		private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem13;
		private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem14;
		private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem15;
		private System.Windows.Forms.ToolStripButton ToolBtnZoomIn;
		private System.Windows.Forms.ToolStripButton ToolBtnZoomOut;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
		private System.Windows.Forms.ToolStripButton ToolBtnSetFont;
		private System.Windows.Forms.ToolStripButton ToolBtnDebug;
		private System.Windows.Forms.ToolStripButton ToolBtnBgColor;
		private System.Windows.Forms.ToolStripButton ToolBtnOpen;
		private System.Windows.Forms.RichTextBox richLine;
		private System.Windows.Forms.RichTextBox consoleBox;
	}
}

