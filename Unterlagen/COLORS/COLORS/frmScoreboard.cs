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
    public partial class frmScoreboard : Form
    {
        public static List<User> users = new List<User>();
        public frmScoreboard()
        {
            InitializeComponent();
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

        private void frmScoreboard_Load(object sender, EventArgs e)
        {
            buildForm();
        }

        private void buildForm()
        {
            //Get actual Scoreboard
            deserializeXML dsXML = new deserializeXML();
            dsXML.deserialize();

            circlePictureboxes();
            int counter = 0;

            if (counter < users.Count)
            {
                pctbx1.Visible = true;
                foreach (User u in users)
                {
                    if (u.getRank() == counter + 1)
                    {
                        lblName1.Text = u.getName();
                        lblScore1.Text = Convert.ToString(u.getScore());
                        pctbx1.Image = u.stringToImage(u.getPicture());
                    }
                }
                counter++;
            }

            if (counter < users.Count)
            {
                pctbx2.Visible = true;
                foreach (User u in users)
                {
                    if (u.getRank() == counter + 1)
                    {
                        lblName2.Text = u.getName();
                        lblScore2.Text = Convert.ToString(u.getScore());
                        pctbx2.Image = u.stringToImage(u.getPicture());
                    }
                }
                counter++;
            }

            if (counter < users.Count)
            {
                pctbx3.Visible = true;
                foreach (User u in users)
                {
                    if (u.getRank() == counter + 1)
                    {
                        lblName3.Text = u.getName();
                        lblScore3.Text = Convert.ToString(u.getScore());
                        pctbx3.Image = u.stringToImage(u.getPicture());
                    }
                }
                counter++;
            }

            if (counter < users.Count)
            {
                pctbx4.Visible = true;
                foreach (User u in users)
                {
                    if (u.getRank() == counter + 1)
                    {
                        lblName4.Text = u.getName();
                        lblScore4.Text = Convert.ToString(u.getScore());
                        pctbx4.Image = u.stringToImage(u.getPicture());
                    }
                }
                counter++;
            }

            if (counter < users.Count)
            {
                pctbx5.Visible = true;
                foreach (User u in users)
                {
                    if (u.getRank() == counter + 1)
                    {
                        lblName5.Text = u.getName();
                        lblScore5.Text = Convert.ToString(u.getScore());
                        pctbx5.Image = u.stringToImage(u.getPicture());
                    }
                }
                counter++;
            }

            if (counter < users.Count)
            {
                pctbx6.Visible = true;
                foreach (User u in users)
                {
                    if (u.getRank() == counter + 1)
                    {
                        lblName6.Text = u.getName();
                        lblScore6.Text = Convert.ToString(u.getScore());
                        pctbx6.Image = u.stringToImage(u.getPicture());
                    }
                }
                counter++;
            }

            if (counter < users.Count)
            {
                pctbx7.Visible = true;
                foreach (User u in users)
                {
                    if (u.getRank() == counter + 1)
                    {
                        lblName7.Text = u.getName();
                        lblScore7.Text = Convert.ToString(u.getScore());
                        pctbx7.Image = u.stringToImage(u.getPicture());
                    }
                }
                counter++;
            }

            if (counter < users.Count)
            {
                pctbx8.Visible = true;
                foreach (User u in users)
                {
                    if (u.getRank() == counter + 1)
                    {
                        lblName8.Text = u.getName();
                        lblScore8.Text = Convert.ToString(u.getScore());
                        pctbx8.Image = u.stringToImage(u.getPicture());
                    }
                }
                counter++;
            }

            if (counter < users.Count)
            {
                pctbx9.Visible = true;
                foreach (User u in users)
                {
                    if (u.getRank() == counter + 1)
                    {
                        lblName9.Text = u.getName();
                        lblScore9.Text = Convert.ToString(u.getScore());
                        pctbx9.Image = u.stringToImage(u.getPicture());
                    }
                }
                counter++;
            }

            if (counter < users.Count)
            {
                pctbx10.Visible = true;
                foreach (User u in users)
                {
                    if (u.getRank() == counter + 1)
                    {
                        lblName10.Text = u.getName();
                        lblScore10.Text = Convert.ToString(u.getScore());
                        pctbx10.Image = u.stringToImage(u.getPicture());
                    }
                }
                counter++;
            }

            
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void circlePictureboxes()
        {
            System.Drawing.Drawing2D.GraphicsPath gp = new System.Drawing.Drawing2D.GraphicsPath();
            gp.AddEllipse(0, 0, pctbx1.Width - 3, pctbx1.Height - 3);
            Region rg = new Region(gp);
            pctbx1.Region = rg;
            pctbx2.Region = rg;
            pctbx3.Region = rg;
            pctbx4.Region = rg;
            pctbx5.Region = rg;
            pctbx6.Region = rg;
            pctbx7.Region = rg;
            pctbx8.Region = rg;
            pctbx9.Region = rg;
            pctbx10.Region = rg;
        }

        private void frmScoreboard_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F5)
            {
                buildForm();
            }
        }

        private void pctbx1_Click(object sender, EventArgs e)
        {
            frmUserProfile profile = new frmUserProfile(pctbx1.Image, lblName1.Text, lblRank1.Text, lblScore1.Text);
            profile.ShowDialog();
        }

        private void pctbx2_Click(object sender, EventArgs e)
        {
            frmUserProfile profile = new frmUserProfile(pctbx2.Image, lblName2.Text, lblRank2.Text, lblScore2.Text);
            profile.ShowDialog();
        }

        private void pctbx3_Click(object sender, EventArgs e)
        {
            frmUserProfile profile = new frmUserProfile(pctbx3.Image, lblName3.Text, lblRank3.Text, lblScore3.Text);
            profile.ShowDialog();
        }

        private void pctbx4_Click(object sender, EventArgs e)
        {
            frmUserProfile profile = new frmUserProfile(pctbx4.Image, lblName4.Text, lblRank4.Text, lblScore4.Text);
            profile.ShowDialog();
        }

        private void pctbx5_Click(object sender, EventArgs e)
        {
            frmUserProfile profile = new frmUserProfile(pctbx5.Image, lblName5.Text, lblRank5.Text, lblScore5.Text);
            profile.ShowDialog();
        }

        private void pctbx6_Click(object sender, EventArgs e)
        {
            frmUserProfile profile = new frmUserProfile(pctbx6.Image, lblName6.Text, lblRank6.Text, lblScore6.Text);
            profile.ShowDialog();
        }

        private void pctbx7_Click(object sender, EventArgs e)
        {
            frmUserProfile profile = new frmUserProfile(pctbx7.Image, lblName7.Text, lblRank7.Text, lblScore7.Text);
            profile.ShowDialog();
        }

        private void pctbx8_Click(object sender, EventArgs e)
        {
            frmUserProfile profile = new frmUserProfile(pctbx8.Image, lblName8.Text, lblRank8.Text, lblScore8.Text);
            profile.ShowDialog();
        }

        private void pctbx9_Click(object sender, EventArgs e)
        {
            frmUserProfile profile = new frmUserProfile(pctbx9.Image, lblName9.Text, lblRank9.Text, lblScore9.Text);
            profile.ShowDialog();
        }

        private void pctbx10_Click(object sender, EventArgs e)
        {
            frmUserProfile profile = new frmUserProfile(pctbx10.Image, lblName10.Text, lblRank10.Text, lblScore10.Text);
            profile.ShowDialog();
        }
    }
}
