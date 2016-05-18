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
    public partial class frmMenu : Form
    {
        public static bool gameRunning = false;
        public frmMenu()
        {
            InitializeComponent();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            if (gameRunning == false)
            {
                gameRunning = true;
                frmUsername username = new frmUsername();
                this.Hide();
                if (username.ShowDialog() == System.Windows.Forms.DialogResult.Cancel)
                {
                    gameRunning = false;
                    this.Show();
                }
            }

            else
            {
                MessageBox.Show("A game is actually running!", "Game running");
            }
        }

        private void frmMenu_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAbout about = new frmAbout();
            about.ShowDialog();
        }

        private void rulesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmRules rules = new frmRules();
            rules.Show();
        }

        private void btnHelp_Click(object sender, EventArgs e)
        {
            frmRules rules = new frmRules();
            rules.Show();
        }

        private void btnScoreboard_Click(object sender, EventArgs e)
        {
            frmScoreboard scoreboard = new frmScoreboard();
            scoreboard.ShowDialog();
        }
    }
}
