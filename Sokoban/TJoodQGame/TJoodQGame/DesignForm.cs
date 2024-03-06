// Tejaswi Singh Jood
// 8845744
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TJoodQGame
{
	public partial class DesignForm : Form
	{
		public DesignForm()
		{
			InitializeComponent();
		}

		private int numRows; // Rows provided
		private int numCols; // Column provides 
		private List<PictureBox> grid = new List<PictureBox>(); // to store data of the grid created
		
		private int num = 0; // just to check how many times the form has been clicked (succesfully i.e. how many times the grid has been made)
		private void btnGenerate_Click(object sender, EventArgs e)
		{			
			if(int.TryParse(txtRow.Text, out numRows) && int.TryParse(txtColumn.Text, out numCols))
			{
				if (numRows > 0 && numCols > 0)
				{
					if (num == 0) // if its the first time then no data loosing warnig message
					{
						CreateGrid(numRows, numCols);
					}
					else
					{
						DialogResult result = MessageBox.Show("Do you want to creat a new level?\n If you do the current level will be lost.", "Level Lost", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
						if (result == DialogResult.Yes)
						{
							CreateGrid(numRows, numCols);
						}
						else if (result == DialogResult.No)
						{
							return;
						}
					}				
				}
				else
				{
					MessageBox.Show("Please enter positive values for rows and columns.", "Error",MessageBoxButtons.OK ,MessageBoxIcon.Error);					
				}				
			}
			else
			{
				MessageBox.Show("Invalid input for rows or columns.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void CreateGrid(int x, int y)
		{
			this.num++;
			gridPanel.Controls.Clear(); // saving all the pictureboxes/grid in a panel
			grid.Clear(); // list
			for (int row = 0; row < x; row++)
			{
				for (int col = 0; col < y; col++)
				{
					PictureBox cell = new PictureBox
					{
						Name = row.ToString() + col.ToString(),
						SizeMode = PictureBoxSizeMode.StretchImage,
						Size = new Size(70, 70),
						BorderStyle = BorderStyle.FixedSingle,
						Location = new Point(col * 70, row * 70),
						Tag = "0" // all are null in the starting
					};
					cell.Click += (s, e) => Cell_Clicked(s, e, cell);
					gridPanel.Controls.Add(cell); // Adding to the panel
					grid.Add(cell); // Adding to the list
				}
			}
			gridPanel.Size = new Size(y * 75,x*75); // Re-sizing to panel size to accomodate all the grids/pictureboxes
		}

		private Tool selectedTool = Tool.Null; // Initializing if no tool is selected

		private enum Tool {Null, Wall, GDoor, RDoor, GBox, RBox }

		/// <summary>
		/// Will change the clicked picturebox/grid image 
		/// Will give a tag to the picturebox/grid to compare afterwords
		/// </summary>
		/// <param name="Cell_Clicked"></param>
		private void Cell_Clicked(object sender, EventArgs e, PictureBox cell)
		{
			switch (selectedTool)
			{
				case Tool.Null:
					cell.Image = null;
					cell.Tag = "0";
					break;
				case Tool.Wall:
					cell.Image = Properties.Resources.Brick;
					cell.Tag= "1";
					break;
				case Tool.GDoor:
					cell.Image = Properties.Resources.GreenDoor;
					cell.Tag= "2";
					break;
				case Tool.GBox:
					cell.Image = Properties.Resources.GreenBox;
					cell.Tag = "3";
					break;
				case Tool.RDoor:
					cell.Image = Properties.Resources.RedDoor;
					cell.Tag= "4";
					break;
				case Tool.RBox:
					cell.Image = Properties.Resources.RedBox;
					cell.Tag= "5";
					break;			
			}
		}

		
		/// <summary>
		/// Will selectt the corresponding tool as mentioned in the button
		/// </summary>
		/// <param name="button_Click"></param>
		private void btnWall_Click(object sender, EventArgs e)
		{			
			this.selectedTool = Tool.Wall;
		}

		private void btnNull_Click(object sender, EventArgs e)
		{
			this.selectedTool = Tool.Null;
		}

		private void btnGreen_Click(object sender, EventArgs e)
		{
			this.selectedTool = Tool.GBox;
		}

		private void btnRed_Click(object sender, EventArgs e)
		{
			this.selectedTool = Tool.RBox;
		}

		private void btnGDoor_Click(object sender, EventArgs e)
		{
			this.selectedTool = Tool.GDoor;
		}

		private void btnRDoor_Click(object sender, EventArgs e)
		{
			this.selectedTool = Tool.RDoor;
		}



		
		
		
		private void DesignForm_Load(object sender, EventArgs e)
		{

		}

		/// <summary>
		/// - Extract data from the grid list
		/// - Open up a Save File Dialog box
		/// - Save the file in text file format
		/// - Show a messagebox when saved
		/// </summary>
		/// <param name="saveToolStripMenuItem_Click"></param>
		private void saveToolStripMenuItem_Click(object sender, EventArgs e)
		{
			SaveFileDialog saveFileDialog = new SaveFileDialog();
			saveFileDialog.Title = "Save your Q-Game";
			saveFileDialog.Filter = "Text Files (*txt)|*txt";
			saveFileDialog.DefaultExt = "txt";
			saveFileDialog.RestoreDirectory = true;
			saveFileDialog.FileName = "*.txt";
			int wall = 0, box = 0, door = 0;
			if (saveFileDialog.ShowDialog() == DialogResult.OK)
			{
				using (Stream s = File.Open(saveFileDialog.FileName, FileMode.CreateNew))
				using (StreamWriter sw = new StreamWriter(s))
				{
					sw.WriteLine(numRows);
					sw.WriteLine(numCols);
					foreach (PictureBox cell in grid)
					{
						string name = cell.Name;
						sw.WriteLine(name[0]);
						sw.WriteLine(name[1]);
						sw.WriteLine(cell.Tag.ToString());
						if (cell.Tag.ToString() == "1")
						{
							wall++;
						}
						else if (cell.Tag.ToString() == "2")
						{
							door++;
						}
						else if (cell.Tag.ToString() == "3")
						{
							box++;
						}
						else if (cell.Tag.ToString() == "4")
						{
							door++;
						}
						else if (cell.Tag.ToString() == "5")
						{
							box++;
						}
					}
				}
				MessageBox.Show($" File Saved successfully: \n Total number of walls : {wall}\n Total number of doors : {door}\n Total number of boxes : {box}", "QGame Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
		}

		private void closeToolStripMenuItem_Click(object sender, EventArgs e)
		{
			this.Close();
			
		}

		private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
		{

		}
	}
}
