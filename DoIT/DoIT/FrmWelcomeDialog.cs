using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoIT
{
    public partial class FrmWelcomeDialog : Form
    {
        public FrmWelcomeDialog(string username)
        {
            InitializeComponent();
            label1.Text = "Welcome " + username;
        }
    }
}
