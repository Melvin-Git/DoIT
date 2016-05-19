using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.Net.Mail;

namespace DoIT
{
    public partial class FrmReport : Form
    {
        public FrmReport()
        {
            InitializeComponent();
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            Regex reg = new Regex(@"@");
            Match mat = reg.Match(txbMail.Text);
            if (mat.Success)
            {
                MailMessage mail = new MailMessage();
                mail.From = new MailAddress("");
                mail.To.Add("");
                mail.Subject = "Report ToDo";
                mail.Body = "User: " + txbMail.Text + "\r\nMesseage: " + rtbMeldung.Text;
                SmtpClient client = new SmtpClient("", );
                try
                {
                    client.Credentials = new System.Net.NetworkCredential("", "");
                    client.EnableSsl = false;
                    client.Send(mail);
                    MessageBox.Show("Your mail was successfully sent!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Unable to Send\r\n\r\n" + "Details: " + ex.Message, "Error", MessageBoxButtons.OK);
                }
            }
            else
            {
                MessageBox.Show("Your mail is incorrect!");
            }
            Close();
            Close();
        }
    }
}
