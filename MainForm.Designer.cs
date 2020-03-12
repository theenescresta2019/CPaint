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
			this.BtnShare = new System.Windows.Forms.ToolStripMenuItem();
			this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.menuStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// menuStrip1
			// 
			this.menuStrip1.BackColor = System.Drawing.SystemColors.WindowFrame;
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.BtnFileMenu});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(800, 26);
			this.menuStrip1.TabIndex = 1;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// BtnFileMenu
			// 
			this.BtnFileMenu.BackColor = System.Drawing.Color.Transparent;
			this.BtnFileMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.BtnNew,
            this.BtnOpen,
            this.BtnSave,
            this.BtnSaveAs,
            this.BtnShare,
            this.exitToolStripMenuItem});
			this.BtnFileMenu.Font = new System.Drawing.Font("Book Antiqua", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.BtnFileMenu.ForeColor = System.Drawing.SystemColors.ControlLightLight;
			this.BtnFileMenu.ImageTransparentColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
			this.BtnFileMenu.Name = "BtnFileMenu";
			this.BtnFileMenu.Size = new System.Drawing.Size(42, 22);
			this.BtnFileMenu.Text = "File";
			this.BtnFileMenu.BackColorChanged += new System.EventHandler(this.BtnFileMenu_BackColorChanged);
			this.BtnFileMenu.Click += new System.EventHandler(this.BtnFileMenu_Click);
			// 
			// BtnNew
			// 
			this.BtnNew.Image = ((System.Drawing.Image)(resources.GetObject("BtnNew.Image")));
			this.BtnNew.Name = "BtnNew";
			this.BtnNew.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
			this.BtnNew.Size = new System.Drawing.Size(207, 22);
			this.BtnNew.Text = "New";
			// 
			// BtnOpen
			// 
			this.BtnOpen.Image = ((System.Drawing.Image)(resources.GetObject("BtnOpen.Image")));
			this.BtnOpen.Name = "BtnOpen";
			this.BtnOpen.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
			this.BtnOpen.Size = new System.Drawing.Size(186, 22);
			this.BtnOpen.Text = "Open";
			// 
			// BtnSave
			// 
			this.BtnSave.Image = ((System.Drawing.Image)(resources.GetObject("BtnSave.Image")));
			this.BtnSave.Name = "BtnSave";
			this.BtnSave.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
			this.BtnSave.Size = new System.Drawing.Size(186, 22);
			this.BtnSave.Text = "Save";
			// 
			// BtnSaveAs
			// 
			this.BtnSaveAs.Image = ((System.Drawing.Image)(resources.GetObject("BtnSaveAs.Image")));
			this.BtnSaveAs.Name = "BtnSaveAs";
			this.BtnSaveAs.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.S)));
			this.BtnSaveAs.Size = new System.Drawing.Size(186, 22);
			this.BtnSaveAs.Text = "Save As";
			// 
			// BtnShare
			// 
			this.BtnShare.Image = ((System.Drawing.Image)(resources.GetObject("BtnShare.Image")));
			this.BtnShare.Name = "BtnShare";
			this.BtnShare.ShortcutKeys = System.Windows.Forms.Keys.F6;
			this.BtnShare.Size = new System.Drawing.Size(186, 22);
			this.BtnShare.Text = "Share";
			// 
			// exitToolStripMenuItem
			// 
			this.exitToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("exitToolStripMenuItem.Image")));
			this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
			this.exitToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
			this.exitToolStripMenuItem.Text = "Exit";
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.Highlight;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.menuStrip1);
			this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.IsMdiContainer = true;
			this.MainMenuStrip = this.menuStrip1;
			this.Name = "MainForm";
			this.Text = "CPaint";
			this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
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
	}
}

