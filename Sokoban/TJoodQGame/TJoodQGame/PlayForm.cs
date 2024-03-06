using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Drawing;
using System.Security.Policy;


namespace TJoodQGame
{
	public partial class PlayForm : Form
	{
		public PlayForm()
		{
			InitializeComponent();
		}		
		int row = 0;
		int col = 0;
		int numRows = 0;
		int numCols = 0;
		bool selected = false;
		int moves = 0;

		int cursor = 0;
		// it tells the line we are on in the text file.
		
		Cell cell;
		int[,] cellType;
		// it is to know on what row and column the celltype is being selected.
		Cell[,] grid;



		/// <summary>
		/// it will reset the variables and disable the buttons
		/// </summary>
		private void Reset()
		{
			gridPanel.Controls.Clear();
			txtBox.Text = "0";
			txtMoves.Text = "0";
			UP.Enabled = false;
			Down.Enabled = false;
			Left.Enabled = false;
			Right.Enabled = false;
			selected = false;
			moves = 0;
			numRows = 0; numCols = 0;
			row = 0; col = 0;
			cursor = 0;			
		}
		private void DisplayLevel(string level)
		{
			Reset();
			StreamReader sr = new StreamReader(level);
			numRows = int.Parse(sr.ReadLine());
			numCols = int.Parse(sr.ReadLine());
			cellType = new int[numRows, numCols];
			grid = new Cell[numRows, numCols];
			for (int r = 0; r < numRows; r++)
			{
				for (int c = 0; c < numCols*3; c++)
				{
					int celltype = int.Parse(sr.ReadLine());
					cursor++;

					// if the cursor is 3 it will return back to zero.
					// this is coz their are 3 field related one cell/grid
					// i.e. rownumber, columnnumber and type
					if(cursor == 3)
					{
						cursor = 0;
						cellType[r,c/3] = celltype;
					}
				}				
			}
			for (int r = 0;r < numRows; r++)
			{
				for(int c = 0;c < numCols; c++)
				{
					// writing the code as per the type of the cell
					Cell cell = new Cell(this);
					if (cellType[r, c] == 0)
					{
						cell.Tag = "null";
						cell.Size = new Size(50, 50);
						cell.Image = null;
						cell.Location = new Point(52 * c, 52 * r);
						gridPanel.Controls.Add(cell);
						grid[r, c] = cell;
					}
					else if (cellType[r, c] == 1)
					{
						cell.Tag = "wall";
						cell.Size = new Size(50, 50);
						cell.Image = Properties.Resources.Brick;
						cell.Location = new Point(52*c, 52*r);
						gridPanel.Controls.Add(cell);
						grid[r,c] = cell;
					}
					else if (cellType[r, c] == 2)
					{
						cell.Tag = "greenDoor";
						cell.Size = new Size(50, 50);
						cell.Image = Properties.Resources.GreenDoor;
						cell.Location = new Point(52 * c, 52 * r);
						gridPanel.Controls.Add(cell);
						grid[r, c] = cell;
					}
					else if (cellType[r, c] == 3)
					{
						cell.Tag = "greenBox";
						cell.Size = new Size(50, 50);
						cell.Image = Properties.Resources.GreenBox;
						cell.Location = new Point(52 * c, 52 * r);
						gridPanel.Controls.Add(cell);
						grid[r, c] = cell;
						cell.Click += cellSelected; // only if it is suppose to move

					}
					else if (cellType[r, c] == 4)
					{
						cell.Tag = "redDoor";
						cell.Size = new Size(50, 50);
						cell.Image = Properties.Resources.RedDoor;
						cell.Location = new Point(52 * c, 52 * r);
						gridPanel.Controls.Add(cell);
						grid[r, c] = cell;
					}
					else if (cellType[r, c] == 5)
					{
						cell.Tag = "redBox";
						cell.Size = new Size(50, 50);
						cell.Image = Properties.Resources.RedBox;
						cell.Location = new Point(52 * c, 52 * r);
						gridPanel.Controls.Add(cell);
						grid[r, c] = cell;
						cell.Click += cellSelected; // only if it is suppose to move
                    }
				
				}
			}
			boxCount();			
			UP.Enabled = true;
			Down.Enabled = true;
			Left.Enabled = true;
			Right.Enabled = true;
			
		}

		private void Cell_Click(object sender, EventArgs e)
		{
			throw new NotImplementedException();
		}

		private void boxCount()
		{
			int b = 0;

			for (int r = 0; r < numRows; r++)
			{
				for (int c = 0; c < numCols; c++)
				{
					if ((grid[r, c].Tag == "greenBox") || (grid[r,c].Tag == "redBox"))
					{
						b++;
					}					
				}
			}
			txtBox.Text = b.ToString();

			if (b == 0)
			{
				MessageBox.Show("Congratulations!\nGame End","You WON",MessageBoxButtons.OK,MessageBoxIcon.Warning);
				Reset();
			}
		}

		private Cell getCellGrid(int r, int c)
		{
			// this will return the selected cell/grid
			return grid[r, c];
			
					
		}

		private void loadToolStripMenuItem_Click(object sender, EventArgs e)
		{
			OpenFileDialog ofd = new OpenFileDialog();
			if (ofd.ShowDialog() == DialogResult.OK)
			{
				string level = ofd.FileName;
				DisplayLevel(level);
			}

		}
		// this is to select the selectable box.
		private void cellSelected(object sender, EventArgs e)
		{
			selected = true;
			cell = (Cell)sender;
			cell.BorderStyle = BorderStyle.FixedSingle;
			col = cell.Left / 50;
			row = cell.Top / 50;
		}

		private void PlayForm_Load(object sender, EventArgs e)
		{
			//it will start with buttons disabled
			UP.Enabled = false;
			Down.Enabled = false;
			Left.Enabled = false;
			Right.Enabled = false;
		}

		private void UP_Click(object sender, EventArgs e)
		{
			bool wasmoved=false;
			if(selected == true)
			{
				while (true)
				{
					// selecting the next cell when going in the direction 
					Cell next = getCellGrid(row - 1, col);
					if (next.Tag == "null")
					{
						// move if the next cell is null
						grid[row, col] = next;
						cell.Top -= 52;
						row--;
						grid[row, col] = cell;
						wasmoved = true;
						cell.BringToFront();
					}
					else if ((cell.Tag == "greenBox" && next.Tag == "greenDoor") || (cell.Tag == "redBox" && next.Tag == "redDoor"))
					{
						grid[row, col].Tag = "null";
						cell.Top -= 52;
						cell.SendToBack();
						//row--;
						//if(cell.Tag == "greeBox")
						//{
						//	grid[row, col].Tag = "greenDoor";
						//}
						//else
						//{
						//	grid[row, col].Tag = "redDoor";

						//}
						this.Controls.Remove(cell);
						
						moves++;
						
						txtMoves.Text = moves.ToString();
						boxCount();
						break;
						
						
					}
					else
					{
						// will not be allowed to move
						if (wasmoved == true)
						{
							moves++;
						}
						txtMoves.Text = moves.ToString();
						boxCount();
						// to update the textboxes
						break;
					}
				}
			}			
		}

		private void Left_Click(object sender, EventArgs e)
		{
			bool wasmoved = false;
			if (selected == true)
			{
				while (true)
				{
					Cell next = getCellGrid(row, col-1);
					if (next.Tag == "null")
					{
						grid[row, col] = next;
						cell.Left -= 52;
						col--;
						grid[row, col] = cell;
						wasmoved = true;
						cell.BringToFront();
					}
					else if ((cell.Tag == "greenBox" && next.Tag == "greenDoor") || (cell.Tag == "redBox" && next.Tag == "redDoor"))
					{
						grid[row, col].Tag = "null";
						cell.Left -= 52;
						cell.SendToBack();
					//	col--;
					/*	if (cell.Tag == "greeBox")
						{
							grid[row, col].Tag = "greenDoor";
						}
						else
						{
							grid[row, col].Tag = "redDoor";

						}*/
						this.Controls.Remove(cell);

						moves++;

						txtMoves.Text = moves.ToString();
						boxCount();
						break;

					}
					else
					{
						if (wasmoved == true)
						{
							moves++;
						}
						txtMoves.Text = moves.ToString();
						boxCount();
						break;
					}
				}
			}
		}
		private void Right_Click(object sender, EventArgs e)
		{
			bool wasmoved = false;
			if (selected == true)
			{
				while (true)
				{
					Cell next = getCellGrid(row, col+1);
					if (next.Tag == "null")
					{
						grid[row, col] = next;
						cell.Left += 52;
						col++;
						grid[row, col] = cell;
						wasmoved = true;
						cell.BringToFront();
					}
					else if ((cell.Tag == "greenBox" && next.Tag == "greenDoor") || (cell.Tag == "redBox" && next.Tag == "redDoor"))
					{
						grid[row, col].Tag = "null";
						cell.Left += 52;
						cell.SendToBack();
						//col++;
						//if (cell.Tag == "greeBox")
						//{
						//	grid[row, col].Tag = "greenDoor";
						//}
						//else
						//{
						//	grid[row, col].Tag = "redDoor";

						//}
						this.Controls.Remove(cell);

						moves++;

						txtMoves.Text = moves.ToString();
						boxCount();
						break;

					}
					else
					{
						if (wasmoved == true)
						{
							moves++;
						}
						txtMoves.Text = moves.ToString();
						boxCount();
						break;
					}
				}
			}
		}
		private void Down_Click(object sender, EventArgs e)
		{
			bool wasmoved = false;
			if (selected == true)
			{
				while (true)
				{
					Cell next = getCellGrid(row + 1, col);
					if (next.Tag == "null")
					{
						grid[row, col] = next;
						cell.Top += 52;
						row++;
						grid[row, col] = cell;
						wasmoved = true;
						cell.BringToFront();
					}
					else if ((cell.Tag == "greenBox" && next.Tag == "greenDoor")||(cell.Tag == "redBox" && next.Tag == "redDoor"))
					{
						grid[row, col].Tag = "null";
						cell.Top += 52;
						cell.SendToBack();
						//row++;
						//if (cell.Tag == "greeBox")
						//{
						//	grid[row, col].Tag = "greenDoor";
						//}
						//else
						//{
						//	grid[row, col].Tag = "redDoor";

						//}
						this.Controls.Remove(cell);
						
						moves++;

						txtMoves.Text = moves.ToString();
						boxCount();
						break;

					}
					else
					{
						if (wasmoved == true)
						{
							moves++;
						}
						txtMoves.Text = moves.ToString();
						boxCount();
						break;
					}
				}
			}
		}
	}
}
