using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoIT
{
    public partial class mainview : Form
    {
        public mainview()
        {
            InitializeComponent();
        }

        // Show About-Box when Menustrip About is clicked.
        private void mnuitmAbout_Click(object sender, EventArgs e)
        {
            var About = new frmAbout();
            About.ShowDialog();
        }
    }
}
