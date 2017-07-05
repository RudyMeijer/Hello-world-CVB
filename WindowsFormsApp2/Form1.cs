using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void btnLoad_Click(object sender, EventArgs e)
		{
			axCVimage1.LoadImageByDialog();
			axCVdisplay1.Image = axCVimage1.Image;
		}

		private void btnSnap_Click(object sender, EventArgs e)
		{
			axCVimage1.Snap();
			axCVdisplay1.Refresh();
		}

		private void chkLive_CheckedChanged(object sender, EventArgs e)
		{
			axCVimage1.Grab = chkLive.Checked;
		}

		private void axCVimage1_ImageSnaped(object sender, EventArgs e)
		{
			axCVdisplay1.Refresh();
		}
	}
}
