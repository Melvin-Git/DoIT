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
    public partial class frmReport : Form
    {
        public frmReport()
        {
            InitializeComponent();
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            try
            {
                System.IO.StreamWriter report = new System.IO.StreamWriter("c:\\temp\\DoIT-Report.txt", true);
                report.WriteLine("mailto:" + txbMail.Text + "/" + rtbMeldung.Text + "\r\n");
                report.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show("Unable to Send\r\n\r\n" + "Details: " + ex.Message, "Error", MessageBoxButtons.OK);
            }
            Close();
        }
    }
}
