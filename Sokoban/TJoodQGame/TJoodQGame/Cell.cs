using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace TJoodQGame
{
	public class Cell : PictureBox
	{
		PlayForm play;
		public int cellTool { get; set; }		

		public Cell(PlayForm play)
		{
			this.play = play;
			this.cellTool = cellTool;
			this.SizeMode = PictureBoxSizeMode.StretchImage;
			
		}
	}
}
