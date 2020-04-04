namespace CPaint
{
	partial class Output
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
			this.outputArea = new System.Windows.Forms.PictureBox();
			((System.ComponentModel.ISupportInitialize)(this.outputArea)).BeginInit();
			this.SuspendLayout();
			// 
			// outputArea
			// 
			this.outputArea.BackColor = System.Drawing.Color.White;
			this.outputArea.Dock = System.Windows.Forms.DockStyle.Fill;
			this.outputArea.Location = new System.Drawing.Point(0, 0);
			this.outputArea.Name = "outputArea";
			this.outputArea.Size = new System.Drawing.Size(939, 524);
			this.outputArea.TabIndex = 0;
			this.outputArea.TabStop = false;
			this.outputArea.Click += new System.EventHandler(this.outputArea_Click);
			// 
			// Output
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(939, 524);
			this.Controls.Add(this.outputArea);
			this.Name = "Output";
			this.Text = "Output";
			((System.ComponentModel.ISupportInitialize)(this.outputArea)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		public System.Windows.Forms.PictureBox outputArea;
	}
}