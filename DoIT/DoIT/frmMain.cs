using System;
using System.Data;
using System.IO;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace DoIT
{
    public partial class FrmMain : Form
    {
        private Calendar _activeCalendar;
        private User _activeUser;

        public FrmMain()
        {
            InitializeComponent();
        }

        private void exportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                var savexml = new SaveFileDialog();
                savexml.DefaultExt = ".xml";
                savexml.Filter = "XML (*.xml)|";
                savexml.RestoreDirectory = true;
                if (DialogResult.OK == savexml.ShowDialog())
                {
                    var ds = new DataSet();
                    var dt = new DataTable();
                    dt.Columns.Add(new DataColumn("Done", Type.GetType("System.Boolean")));
                    dt.Columns.Add(new DataColumn("Description", Type.GetType("System.String")));
                    dt.Columns.Add(new DataColumn("Deadline", Type.GetType("System.String")));
                    dt.Columns.Add(new DataColumn("Priority", Type.GetType("System.String")));
                    dt.Columns.Add(new DataColumn("reminder", Type.GetType("System.String")));
                    var x = 0;

                    ds.Tables.Add(dt);
                    ds.Tables[0].TableName = "Tasks";
                    /*do
                    {
                        DataRow dr = dt.NewRow();
                        dr["Done"] = dgv_main.Rows[x].Cells[0].Value.ToString();
                        dr["Description"] = dgv_main.Rows[x].Cells[1].Value.ToString();
                        dr["Deadline"] = dgv_main.Rows[x].Cells[2].Value.ToString();
                        dr["Priority"] = dgv_main.Rows[x].Cells[3].Value.ToString();
                        dr["reminder"] = dgv_main.Rows[x].Cells[4].Value.ToString();
                        dt.Rows.Add(dr);
                        x++;
                    } while (x < dgv_main.RowCount);*/


                    var serialwirter = new StreamWriter(savexml.FileName);
                    var ser = new XmlSerializer(ds.GetType());
                    ser.Serialize(serialwirter, ds);
                    serialwirter.Close();
                    ds.Clear();
                }
                else
                {
                    Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.StackTrace);
            }
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            _activeUser = Program.ActiveUser;
            _activeCalendar = _activeUser.Calendars[0];

            lblUserName.Text = _activeUser.Username;
            lblCalendarName.Text = _activeCalendar.getName();
        }
    }
}