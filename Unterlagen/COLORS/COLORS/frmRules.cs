using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COLORS
{
    public partial class frmRules : Form
    {
        int picturenumber = 1;
        public frmRules()
        {
            InitializeComponent();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAbout about = new frmAbout();
            about.ShowDialog();
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            picturenumber--;
            lblPicture.Text = Convert.ToString(picturenumber) + " / 3";
            ShowImage(picturenumber);
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            picturenumber++;
            lblPicture.Text = Convert.ToString(picturenumber) + " / 3";
            ShowImage(picturenumber);
        }

        private void ShowImage(int p)
        {
            switch (p)
            {
                case 1:
                    pictureBox1.Image = Properties.Resources.easy;
                    btnPrevious.Enabled = false;
                    return;
                case 2:
                    pictureBox1.Image = Properties.Resources.difficult;
                    btnPrevious.Enabled = true;
                    btnNext.Enabled = true;
                    return;
                case 3:
                    pictureBox1.Image = Properties.Resources.scoreboard;
                    btnNext.Enabled = false;
                    return;
            }
        }
    }
}
