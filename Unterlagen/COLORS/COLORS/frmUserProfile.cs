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
    public partial class frmUserProfile : Form
    {

        public frmUserProfile(Image i, string username, string rank, string score)
        {
            InitializeComponent();
            pctbxUserpic.Image = i;
            lblUsername.Text = username;
            this.Text = username;
            lblRank.Text = rank;
            lblScore.Text = score;
        }

        private void frmUserProfile_Load(object sender, EventArgs e)
        {
            System.Drawing.Drawing2D.GraphicsPath gp = new System.Drawing.Drawing2D.GraphicsPath();
            gp.AddEllipse(0, 0, pctbxUserpic.Width - 3, pctbxUserpic.Height - 3);
            Region rg = new Region(gp);
            pctbxUserpic.Region = rg;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
