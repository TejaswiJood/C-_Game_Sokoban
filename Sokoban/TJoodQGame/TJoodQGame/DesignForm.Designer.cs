namespace TJoodQGame
{
	partial class DesignForm
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
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DesignForm));
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.txtRow = new System.Windows.Forms.TextBox();
			this.txtColumn = new System.Windows.Forms.TextBox();
			this.btnGenerate = new System.Windows.Forms.Button();
			this.gridPanel = new System.Windows.Forms.Panel();
			this.imageList = new System.Windows.Forms.ImageList(this.components);
			this.btnWall = new System.Windows.Forms.Button();
			this.btnRDoor = new System.Windows.Forms.Button();
			this.btnGDoor = new System.Windows.Forms.Button();
			this.btnRed = new System.Windows.Forms.Button();
			this.btnGreen = new System.Windows.Forms.Button();
			this.btnNull = new System.Windows.Forms.Button();
			this.pictureBox2 = new System.Windows.Forms.PictureBox();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.pictureBox3 = new System.Windows.Forms.PictureBox();
			this.pictureBox4 = new System.Windows.Forms.PictureBox();
			this.pictureBox5 = new System.Windows.Forms.PictureBox();
			this.pictureBox6 = new System.Windows.Forms.PictureBox();
			this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.panel1 = new System.Windows.Forms.Panel();
			this.label3 = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
			this.menuStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(33, 56);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(57, 20);
			this.label1.TabIndex = 0;
			this.label1.Text = "Rows :";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(244, 56);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(71, 20);
			this.label2.TabIndex = 1;
			this.label2.Text = "Column :";
			// 
			// txtRow
			// 
			this.txtRow.Location = new System.Drawing.Point(96, 53);
			this.txtRow.Name = "txtRow";
			this.txtRow.Size = new System.Drawing.Size(100, 26);
			this.txtRow.TabIndex = 2;
			// 
			// txtColumn
			// 
			this.txtColumn.Location = new System.Drawing.Point(312, 53);
			this.txtColumn.Name = "txtColumn";
			this.txtColumn.Size = new System.Drawing.Size(100, 26);
			this.txtColumn.TabIndex = 3;
			// 
			// btnGenerate
			// 
			this.btnGenerate.Location = new System.Drawing.Point(460, 49);
			this.btnGenerate.Name = "btnGenerate";
			this.btnGenerate.Size = new System.Drawing.Size(120, 35);
			this.btnGenerate.TabIndex = 4;
			this.btnGenerate.Text = "Generate";
			this.btnGenerate.UseVisualStyleBackColor = true;
			this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
			// 
			// gridPanel
			// 
			this.gridPanel.BackColor = System.Drawing.SystemColors.ButtonFace;
			this.gridPanel.Location = new System.Drawing.Point(211, 106);
			this.gridPanel.Name = "gridPanel";
			this.gridPanel.Size = new System.Drawing.Size(688, 450);
			this.gridPanel.TabIndex = 5;
			// 
			// imageList
			// 
			this.imageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList.ImageStream")));
			this.imageList.TransparentColor = System.Drawing.Color.Transparent;
			this.imageList.Images.SetKeyName(0, "Brick.jpg");
			this.imageList.Images.SetKeyName(1, "GreenBox.jpg");
			this.imageList.Images.SetKeyName(2, "GreenDoor.jpg");
			this.imageList.Images.SetKeyName(3, "RedBox.png");
			this.imageList.Images.SetKeyName(4, "RedDoor.jpg");
			// 
			// btnWall
			// 
			this.btnWall.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnWall.Location = new System.Drawing.Point(11, 235);
			this.btnWall.Name = "btnWall";
			this.btnWall.Size = new System.Drawing.Size(187, 70);
			this.btnWall.TabIndex = 6;
			this.btnWall.Text = "Wall";
			this.btnWall.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnWall.UseVisualStyleBackColor = true;
			this.btnWall.Click += new System.EventHandler(this.btnWall_Click);
			// 
			// btnRDoor
			// 
			this.btnRDoor.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnRDoor.Location = new System.Drawing.Point(11, 535);
			this.btnRDoor.Name = "btnRDoor";
			this.btnRDoor.Size = new System.Drawing.Size(187, 70);
			this.btnRDoor.TabIndex = 8;
			this.btnRDoor.Text = "Red Door";
			this.btnRDoor.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnRDoor.UseVisualStyleBackColor = true;
			this.btnRDoor.Click += new System.EventHandler(this.btnRDoor_Click);
			// 
			// btnGDoor
			// 
			this.btnGDoor.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnGDoor.Location = new System.Drawing.Point(11, 460);
			this.btnGDoor.Name = "btnGDoor";
			this.btnGDoor.Size = new System.Drawing.Size(187, 70);
			this.btnGDoor.TabIndex = 9;
			this.btnGDoor.Text = "Green Door";
			this.btnGDoor.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnGDoor.UseVisualStyleBackColor = true;
			this.btnGDoor.Click += new System.EventHandler(this.btnGDoor_Click);
			// 
			// btnRed
			// 
			this.btnRed.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnRed.Location = new System.Drawing.Point(11, 385);
			this.btnRed.Name = "btnRed";
			this.btnRed.Size = new System.Drawing.Size(187, 70);
			this.btnRed.TabIndex = 10;
			this.btnRed.Text = "Red Box";
			this.btnRed.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnRed.UseVisualStyleBackColor = true;
			this.btnRed.Click += new System.EventHandler(this.btnRed_Click);
			// 
			// btnGreen
			// 
			this.btnGreen.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnGreen.Location = new System.Drawing.Point(11, 310);
			this.btnGreen.Name = "btnGreen";
			this.btnGreen.Size = new System.Drawing.Size(187, 70);
			this.btnGreen.TabIndex = 11;
			this.btnGreen.Text = "Green Box";
			this.btnGreen.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnGreen.UseVisualStyleBackColor = true;
			this.btnGreen.Click += new System.EventHandler(this.btnGreen_Click);
			// 
			// btnNull
			// 
			this.btnNull.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnNull.Location = new System.Drawing.Point(11, 160);
			this.btnNull.Name = "btnNull";
			this.btnNull.Size = new System.Drawing.Size(187, 70);
			this.btnNull.TabIndex = 12;
			this.btnNull.Text = "Null";
			this.btnNull.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnNull.UseVisualStyleBackColor = true;
			this.btnNull.Click += new System.EventHandler(this.btnNull_Click);
			// 
			// pictureBox2
			// 
			this.pictureBox2.Location = new System.Drawing.Point(20, 165);
			this.pictureBox2.Name = "pictureBox2";
			this.pictureBox2.Size = new System.Drawing.Size(58, 58);
			this.pictureBox2.TabIndex = 14;
			this.pictureBox2.TabStop = false;
			this.pictureBox2.Click += new System.EventHandler(this.btnNull_Click);
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = global::TJoodQGame.Properties.Resources.Brick;
			this.pictureBox1.Location = new System.Drawing.Point(21, 240);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(58, 57);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox1.TabIndex = 13;
			this.pictureBox1.TabStop = false;
			this.pictureBox1.Click += new System.EventHandler(this.btnWall_Click);
			// 
			// pictureBox3
			// 
			this.pictureBox3.Image = global::TJoodQGame.Properties.Resources.GreenBox;
			this.pictureBox3.Location = new System.Drawing.Point(21, 316);
			this.pictureBox3.Name = "pictureBox3";
			this.pictureBox3.Size = new System.Drawing.Size(58, 58);
			this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox3.TabIndex = 16;
			this.pictureBox3.TabStop = false;
			this.pictureBox3.Click += new System.EventHandler(this.btnGreen_Click);
			// 
			// pictureBox4
			// 
			this.pictureBox4.Image = global::TJoodQGame.Properties.Resources.RedBox;
			this.pictureBox4.Location = new System.Drawing.Point(22, 391);
			this.pictureBox4.Name = "pictureBox4";
			this.pictureBox4.Size = new System.Drawing.Size(58, 57);
			this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox4.TabIndex = 15;
			this.pictureBox4.TabStop = false;
			this.pictureBox4.Click += new System.EventHandler(this.btnRed_Click);
			// 
			// pictureBox5
			// 
			this.pictureBox5.Image = global::TJoodQGame.Properties.Resources.GreenDoor;
			this.pictureBox5.Location = new System.Drawing.Point(22, 466);
			this.pictureBox5.Name = "pictureBox5";
			this.pictureBox5.Size = new System.Drawing.Size(58, 58);
			this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox5.TabIndex = 18;
			this.pictureBox5.TabStop = false;
			this.pictureBox5.Click += new System.EventHandler(this.btnGDoor_Click);
			// 
			// pictureBox6
			// 
			this.pictureBox6.Image = global::TJoodQGame.Properties.Resources.RedDoor;
			this.pictureBox6.Location = new System.Drawing.Point(23, 541);
			this.pictureBox6.Name = "pictureBox6";
			this.pictureBox6.Size = new System.Drawing.Size(58, 57);
			this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox6.TabIndex = 17;
			this.pictureBox6.TabStop = false;
			this.pictureBox6.Click += new System.EventHandler(this.btnRDoor_Click);
			// 
			// menuStrip1
			// 
			this.menuStrip1.BackColor = System.Drawing.SystemColors.ButtonFace;
			this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 11F);
			this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
			this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(1004, 38);
			this.menuStrip1.TabIndex = 20;
			this.menuStrip1.Text = "menuStrip1";
			this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
			// 
			// fileToolStripMenuItem
			// 
			this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveToolStripMenuItem,
            this.closeToolStripMenuItem});
			this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
			this.fileToolStripMenuItem.Size = new System.Drawing.Size(62, 34);
			this.fileToolStripMenuItem.Text = "File";
			// 
			// saveToolStripMenuItem
			// 
			this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
			this.saveToolStripMenuItem.Size = new System.Drawing.Size(169, 38);
			this.saveToolStripMenuItem.Text = "Save";
			this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
			// 
			// closeToolStripMenuItem
			// 
			this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
			this.closeToolStripMenuItem.Size = new System.Drawing.Size(169, 38);
			this.closeToolStripMenuItem.Text = "Close";
			this.closeToolStripMenuItem.Click += new System.EventHandler(this.closeToolStripMenuItem_Click);
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.SystemColors.ControlLight;
			this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.panel1.Location = new System.Drawing.Point(0, 43);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(1004, 49);
			this.panel1.TabIndex = 21;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(60, 119);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(102, 29);
			this.label3.TabIndex = 22;
			this.label3.Text = "Toolbox";
			// 
			// DesignForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1004, 651);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.pictureBox5);
			this.Controls.Add(this.pictureBox6);
			this.Controls.Add(this.pictureBox3);
			this.Controls.Add(this.pictureBox4);
			this.Controls.Add(this.pictureBox2);
			this.Controls.Add(this.btnNull);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.btnGreen);
			this.Controls.Add(this.btnRed);
			this.Controls.Add(this.btnGDoor);
			this.Controls.Add(this.btnRDoor);
			this.Controls.Add(this.btnWall);
			this.Controls.Add(this.gridPanel);
			this.Controls.Add(this.btnGenerate);
			this.Controls.Add(this.txtColumn);
			this.Controls.Add(this.txtRow);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.menuStrip1);
			this.Controls.Add(this.panel1);
			this.MainMenuStrip = this.menuStrip1;
			this.Name = "DesignForm";
			this.Text = "DesignForm";
			this.Load += new System.EventHandler(this.DesignForm_Load);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox txtRow;
		private System.Windows.Forms.TextBox txtColumn;
		private System.Windows.Forms.Button btnGenerate;
		private System.Windows.Forms.Panel gridPanel;
		private System.Windows.Forms.ImageList imageList;
		private System.Windows.Forms.Button btnWall;
		private System.Windows.Forms.Button btnRDoor;
		private System.Windows.Forms.Button btnGDoor;
		private System.Windows.Forms.Button btnRed;
		private System.Windows.Forms.Button btnGreen;
		private System.Windows.Forms.Button btnNull;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.PictureBox pictureBox2;
		private System.Windows.Forms.PictureBox pictureBox3;
		private System.Windows.Forms.PictureBox pictureBox4;
		private System.Windows.Forms.PictureBox pictureBox5;
		private System.Windows.Forms.PictureBox pictureBox6;
		private System.Windows.Forms.SaveFileDialog saveFileDialog1;
		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Label label3;
	}
}