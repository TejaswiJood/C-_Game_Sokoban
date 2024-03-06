
// Tejaswi Singh Jood
// 8845744

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TJoodQGame
{
	public partial class QGameControl : Form
	{
		public QGameControl()
		{
			InitializeComponent();
		}

		// No functanality given to Play button. It will just show a not working messagebox
		private void btnPlay_Click(object sender, EventArgs e)
		{
			PlayForm play = new PlayForm();
			play.Show();
		}

		// It will create and display a new game desig form
		private void btnDesign_Click(object sender, EventArgs e)
		{
			DesignForm form = new DesignForm();
			form.Show();
		}

		// it will close the loaded application
		private void btnExit_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}
	}
}
