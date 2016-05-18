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
    public partial class frmIntro : Form
    {
        public frmIntro()
        {
            InitializeComponent();
        }

        private void frmIntro_Shown(object sender, EventArgs e)
        {
            this.Show();
            this.Activate();
            Application.DoEvents();
            System.Threading.Thread.Sleep(5000);

            frmMenu menu = new frmMenu();
            menu.Show();
            this.Hide();
        }
    }
}
