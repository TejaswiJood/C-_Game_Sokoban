namespace TJoodQGame
{
	partial class PlayForm
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
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.loadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.gridPanel = new System.Windows.Forms.Panel();
			this.Left = new System.Windows.Forms.Button();
			this.Down = new System.Windows.Forms.Button();
			this.Right = new System.Windows.Forms.Button();
			this.UP = new System.Windows.Forms.Button();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.txtMoves = new System.Windows.Forms.TextBox();
			this.txtBox = new System.Windows.Forms.TextBox();
			this.menuStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// menuStrip1
			// 
			this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
			this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(1560, 38);
			this.menuStrip1.TabIndex = 0;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// fileToolStripMenuItem
			// 
			this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loadToolStripMenuItem,
            this.closeToolStripMenuItem});
			this.fileToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
			this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
			this.fileToolStripMenuItem.Size = new System.Drawing.Size(64, 34);
			this.fileToolStripMenuItem.Text = "File";
			// 
			// loadToolStripMenuItem
			// 
			this.loadToolStripMenuItem.Name = "loadToolStripMenuItem";
			this.loadToolStripMenuItem.Size = new System.Drawing.Size(171, 38);
			this.loadToolStripMenuItem.Text = "Load";
			this.loadToolStripMenuItem.Click += new System.EventHandler(this.loadToolStripMenuItem_Click);
			// 
			// closeToolStripMenuItem
			// 
			this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
			this.closeToolStripMenuItem.Size = new System.Drawing.Size(171, 38);
			this.closeToolStripMenuItem.Text = "Close";
			// 
			// gridPanel
			// 
			this.gridPanel.Location = new System.Drawing.Point(13, 42);
			this.gridPanel.Name = "gridPanel";
			this.gridPanel.Size = new System.Drawing.Size(1112, 795);
			this.gridPanel.TabIndex = 1;
			// 
			// Left
			// 
			this.Left.Location = new System.Drawing.Point(1156, 394);
			this.Left.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.Left.Name = "Left";
			this.Left.Size = new System.Drawing.Size(110, 110);
			this.Left.TabIndex = 7;
			this.Left.Text = "LEFT";
			this.Left.UseVisualStyleBackColor = true;
			this.Left.Click += new System.EventHandler(this.Left_Click);
			// 
			// Down
			// 
			this.Down.Location = new System.Drawing.Point(1266, 504);
			this.Down.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.Down.Name = "Down";
			this.Down.Size = new System.Drawing.Size(110, 110);
			this.Down.TabIndex = 8;
			this.Down.Text = "DOWN";
			this.Down.UseVisualStyleBackColor = true;
			this.Down.Click += new System.EventHandler(this.Down_Click);
			// 
			// Right
			// 
			this.Right.Location = new System.Drawing.Point(1376, 394);
			this.Right.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.Right.Name = "Right";
			this.Right.Size = new System.Drawing.Size(110, 110);
			this.Right.TabIndex = 9;
			this.Right.Text = "RIGHT";
			this.Right.UseVisualStyleBackColor = true;
			this.Right.Click += new System.EventHandler(this.Right_Click);
			// 
			// UP
			// 
			this.UP.Location = new System.Drawing.Point(1266, 284);
			this.UP.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.UP.Name = "UP";
			this.UP.Size = new System.Drawing.Size(110, 110);
			this.UP.TabIndex = 10;
			this.UP.Text = "UP";
			this.UP.UseVisualStyleBackColor = true;
			this.UP.Click += new System.EventHandler(this.UP_Click);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Century Schoolbook", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(1186, 140);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(247, 22);
			this.label2.TabIndex = 12;
			this.label2.Text = "Number of remaining boxes:";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Century Schoolbook", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(1186, 67);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(161, 22);
			this.label1.TabIndex = 11;
			this.label1.Text = "Number of moves:";
			// 
			// txtMoves
			// 
			this.txtMoves.Location = new System.Drawing.Point(1190, 92);
			this.txtMoves.Name = "txtMoves";
			this.txtMoves.Size = new System.Drawing.Size(243, 26);
			this.txtMoves.TabIndex = 13;
			// 
			// txtBox
			// 
			this.txtBox.Location = new System.Drawing.Point(1190, 165);
			this.txtBox.Name = "txtBox";
			this.txtBox.Size = new System.Drawing.Size(243, 26);
			this.txtBox.TabIndex = 14;
			// 
			// PlayForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1560, 866);
			this.Controls.Add(this.txtBox);
			this.Controls.Add(this.txtMoves);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.Left);
			this.Controls.Add(this.Down);
			this.Controls.Add(this.Right);
			this.Controls.Add(this.UP);
			this.Controls.Add(this.gridPanel);
			this.Controls.Add(this.menuStrip1);
			this.MainMenuStrip = this.menuStrip1;
			this.Name = "PlayForm";
			this.Text = "PlayForm";
			this.Load += new System.EventHandler(this.PlayForm_Load);
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem loadToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
		private System.Windows.Forms.Panel gridPanel;
		private System.Windows.Forms.Button Left;
		private System.Windows.Forms.Button Down;
		private System.Windows.Forms.Button Right;
		private System.Windows.Forms.Button UP;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox txtMoves;
		private System.Windows.Forms.TextBox txtBox;
	}
}