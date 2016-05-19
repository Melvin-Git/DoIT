using System;
using System.Windows.Forms;

namespace DoIT
{
    public partial class frmCalDialog : Form
    {
        public frmCalDialog(string date)
        {
            InitializeComponent();

            var splittedString = date.Split(default(string[]), StringSplitOptions.RemoveEmptyEntries);

            Date = splittedString[0];
            Time = splittedString[2];
        }

        // Properties

        // Date

        private string Date { get; set; }

        // Time

        private string Time { get; set; }

        private void calDatePicker_DateChanged(object sender, DateRangeEventArgs e)
        {
            lblSelectedDate.Text = e.Start.ToString(Program.DateTimeFormats[0]);
        }

        private void frmCalDialog_Load(object sender, EventArgs e)
        {
            lblSelectedDate.Text = Date;
            txbTime.Text = Time;
        }

        public string getDateTime()
        {
            return lblSelectedDate.Text + " , " + txbTime.Text;
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            // IMPLEMENT: Check Time Format

            DialogResult = DialogResult.OK;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
    }
}