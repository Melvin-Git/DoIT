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
    public partial class frmMain : Form
    {
        User activeUser;
        int difference = 40;
        int r;
        int g;
        int b;

        public frmMain(User u)
        {
            InitializeComponent();

            activeUser = u;
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            this.Focus();
            //Rounding Picturebox
            System.Drawing.Drawing2D.GraphicsPath gp = new System.Drawing.Drawing2D.GraphicsPath();
            gp.AddEllipse(0, 0, pctbxUserpic.Width, pctbxUserpic.Height);
            Region rg = new Region(gp);
            pctbxUserpic.Region = rg;
            pctbxUserpic.Image = activeUser.stringToImage(activeUser.getPicture());

            lblUsername.Text = activeUser.getName();

            //Starting game
            colorFields();
        }

        private void colorFields()
        {
            Random ranrgb = new Random();
            r = ranrgb.Next(50, 205);
            g = ranrgb.Next(50, 205);
            b = ranrgb.Next(50, 205);

            foreach (PictureBox p in panel1.Controls)
            {
                p.BackColor = Color.FromArgb(r, g, b);
            }

            Random ranfield = new Random();
            int x = ranfield.Next(1, 4);
            int y = ranfield.Next(1, 4);

            if (x == 1 && y == 1)
            {
                pctbx1_1.BackColor = Color.FromArgb(r, g + difference, b);
            }

            else if (x == 1 && y == 2)
            {
                pctbx1_2.BackColor = Color.FromArgb(r - difference, g + difference - 3, b);
            }

            else if (x == 1 && y == 3)
            {
                pctbx1_3.BackColor = Color.FromArgb(r + difference, g - difference - 3, b);
            }

            else if (x == 2 && y == 1)
            {
                pctbx2_1.BackColor = Color.FromArgb(r, g, b + difference);
            }

            else if (x == 2 && y == 2)
            {
                pctbx2_2.BackColor = Color.FromArgb(r, g, b + difference);
            }

            else if (x == 2 && y == 3)
            {
                pctbx2_3.BackColor = Color.FromArgb(r - difference, g, b + difference);
            }

            else if (x == 3 && y == 1)
            {
                pctbx3_1.BackColor = Color.FromArgb(r + difference - 8, g, b - difference);
            }

            else if (x == 3 && y == 2)
            {
                pctbx3_2.BackColor = Color.FromArgb(r, g, b + difference);
            }

            else if (x == 3 && y == 3)
            {
                pctbx3_3.BackColor = Color.FromArgb(r - difference, g - difference, b - difference);
            }

            if (difference != 1)
            {
                difference -= 1;
            }
        }

        private void pctbx1_1_Click(object sender, EventArgs e)
        {
            checkResult(pctbx1_1);
        }

        private void pctbx1_2_Click(object sender, EventArgs e)
        {
            checkResult(pctbx1_2);
        }

        private void pctbx1_3_Click(object sender, EventArgs e)
        {
            checkResult(pctbx1_3);
        }

        private void pctbx2_1_Click(object sender, EventArgs e)
        {
            checkResult(pctbx2_1);
        }

        private void pctbx2_2_Click(object sender, EventArgs e)
        {
            checkResult(pctbx2_2);
        }

        private void pctbx2_3_Click(object sender, EventArgs e)
        {
            checkResult(pctbx2_3);
        }

        private void pctbx3_1_Click(object sender, EventArgs e)
        {
            checkResult(pctbx3_1);
        }

        private void pctbx3_2_Click(object sender, EventArgs e)
        {
            checkResult(pctbx3_2);
        }

        private void pctbx3_3_Click(object sender, EventArgs e)
        {
            checkResult(pctbx3_3);
        }

        private void checkResult(PictureBox p)
        {
            Color c = p.BackColor;
            if (c != Color.FromArgb(r, g, b))
            {
                lblPoints.Text = Convert.ToString(Convert.ToInt32(lblPoints.Text) + 1);
                colorFields();
            }

            else
            {
                activeUser.setScore(Convert.ToInt32(lblPoints.Text));
                activeUser.sort();
                lblLost.Visible = true;

                this.Enabled = false;
                this.Cursor = Cursors.WaitCursor;
                serializeXML sXML = new serializeXML();
                sXML.serialize(activeUser);
                this.Cursor = Cursors.Default;
                this.Enabled = true;
                
                foreach (PictureBox _p in panel1.Controls)
                {
                    _p.Enabled = false;
                    if (_p.BackColor != Color.FromArgb(r, g, b))
                    {
                        _p.BackgroundImage = Properties.Resources.X;                        
                    }
                }
            }
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

        private void btnClose_Click(object sender, EventArgs e)
        {
            if (lblLost.Visible == false)
            {
                if (MessageBox.Show("Are you sure you want to quit the game? Your Score will be lost!", "Exit?", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    frmMenu.gameRunning = false;
                    this.Close();
                }
            }

            else
            {
                frmMenu.gameRunning = false;
                this.Close();
            }
        }

        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (frmMenu.gameRunning == true)
            {
                if (lblLost.Visible == false)
                {
                    if (MessageBox.Show("Are you sure you want to quit the game? Your Score will be lost!", "Exit?", MessageBoxButtons.OKCancel) == DialogResult.OK)
                    {
                        frmMenu.gameRunning = false;
                    }

                    else
                    {
                        e.Cancel = true;
                    }
                }

                else
                {
                    frmMenu.gameRunning = false;
                }
            }

            Application.OpenForms["frmMenu"].Show();
        }

        private void btnRestart_Click(object sender, EventArgs e)
        {
            if (lblLost.Visible == false)
            {
                if (MessageBox.Show("Do you want to restart the game? Your actual score will be lost!", "Restart?", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    restartGame();
                }
            }
            else
            {
                restartGame();
            }
        }

        private void restartGame()
        {
            foreach (PictureBox p in panel1.Controls)
            {
                p.BackgroundImage = null;
                p.Enabled = true;
            }

            lblLost.Visible = false;
            lblPoints.Text = "0";
            difference = 40;
            colorFields();
        }

        private void pctbxUserpic_Click(object sender, EventArgs e)
        {
            frmUserProfile profile = new frmUserProfile(pctbxUserpic.Image, lblUsername.Text, "--", lblPoints.Text);
            profile.ShowDialog();
        }

        private void lblUsername_Click(object sender, EventArgs e)
        {
            frmUserProfile profile = new frmUserProfile(pctbxUserpic.Image, lblUsername.Text, "--", lblPoints.Text);
            profile.ShowDialog();
        }
    }
}
