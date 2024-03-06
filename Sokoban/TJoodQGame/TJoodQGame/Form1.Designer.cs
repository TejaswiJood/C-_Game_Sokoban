namespace TJoodQGame
{
	partial class QGameControl
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
			this.btnDesign = new System.Windows.Forms.Button();
			this.btnPlay = new System.Windows.Forms.Button();
			this.btnExit = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// btnDesign
			// 
			this.btnDesign.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnDesign.ForeColor = System.Drawing.Color.Black;
			this.btnDesign.Location = new System.Drawing.Point(19, 33);
			this.btnDesign.Name = "btnDesign";
			this.btnDesign.Size = new System.Drawing.Size(169, 74);
			this.btnDesign.TabIndex = 0;
			this.btnDesign.Text = "Design";
			this.btnDesign.UseVisualStyleBackColor = true;
			this.btnDesign.Click += new System.EventHandler(this.btnDesign_Click);
			// 
			// btnPlay
			// 
			this.btnPlay.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnPlay.ForeColor = System.Drawing.Color.Black;
			this.btnPlay.Location = new System.Drawing.Point(407, 33);
			this.btnPlay.Name = "btnPlay";
			this.btnPlay.Size = new System.Drawing.Size(169, 74);
			this.btnPlay.TabIndex = 1;
			this.btnPlay.Text = "Play";
			this.btnPlay.UseVisualStyleBackColor = true;
			this.btnPlay.Click += new System.EventHandler(this.btnPlay_Click);
			// 
			// btnExit
			// 
			this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnExit.ForeColor = System.Drawing.Color.Black;
			this.btnExit.Location = new System.Drawing.Point(213, 142);
			this.btnExit.Name = "btnExit";
			this.btnExit.Size = new System.Drawing.Size(169, 74);
			this.btnExit.TabIndex = 2;
			this.btnExit.Text = "Exit";
			this.btnExit.UseVisualStyleBackColor = true;
			this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
			// 
			// QGameControl
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(603, 236);
			this.Controls.Add(this.btnExit);
			this.Controls.Add(this.btnPlay);
			this.Controls.Add(this.btnDesign);
			this.Name = "QGameControl";
			this.Text = "QGame Control Panel";
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button btnDesign;
		private System.Windows.Forms.Button btnPlay;
		private System.Windows.Forms.Button btnExit;
	}
}

