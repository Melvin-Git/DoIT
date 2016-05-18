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
    public partial class frmUsername : Form
    {
        private bool notcancel = false;

        public frmUsername()
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

        private void frmUsername_Load(object sender, EventArgs e)
        {
            System.Drawing.Drawing2D.GraphicsPath gp = new System.Drawing.Drawing2D.GraphicsPath();
            gp.AddEllipse(0, 0, pctbxUserpic.Width - 3, pctbxUserpic.Height - 3);
            Region rg = new Region(gp);
            pctbxUserpic.Region = rg;
            Application.OpenForms["frmUsername"].BringToFront();
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp; *.png)|*.jpg; *.jpeg; *.gif; *.bmp; *.png";
            if (open.ShowDialog() == DialogResult.OK)
            {
                pctbxUserpic.Image = new Bitmap(open.FileName);
            }
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                notcancel = true;
                User u = new User(textBox1.Text, pctbxUserpic.Image);
                frmMain game = new frmMain(u);
                game.Show();
                this.Close();
            }

            else
            {
                MessageBox.Show("Please enter your name", "Enter your name");
            }
        }

        private void frmUsername_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (notcancel == false)
            {
                this.DialogResult = DialogResult.Cancel;
            }

            else
            {
                this.DialogResult = DialogResult.OK;
            }
        }
    }
}
