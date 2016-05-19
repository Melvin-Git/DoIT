using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.IO;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace DoIT
{
    public partial class FrmMain : Form
    {
        // private List<Calendar> _activeCalendars = new List<Calendar>();
        private User _activeUser;
        private bool _inhibitAutoCheck;
        private Calendar _activeCalendar;

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
            listCalendars();

            var task = new UserTask();
            task.Status = TaskStatus.Open;
            task.Description = "Test";
            task.Deadline = new DateTime(2016, 07, 20);
            task.Priority = 3;
            task.Reminder = new DateTime(2016, 07, 20);

            dgv_main.Rows.Add();

            var list = new List<UserTask>();
            list.Add(task);
            list.Add(task);
            RefillDatagridview(list);
        }

        private void listCalendars()
        {
            if (lvCalendars.Items.Count != 0)
            {
                var items = lvCalendars.Items.Count;
                for (var i = 0; i < items; i++)
                {
                    lvCalendars.Items.RemoveAt(0);
                }
            }

            foreach (var cal in _activeUser.Calendars)
            {
                lvCalendars.Items.Add(new ListViewItem(cal.Name) { Tag = cal.Index });
            }
        }

        /*private void calDatePicker_DateChanged(object sender, DateRangeEventArgs e)
        {
            RefillDatagridview(getTasksForSelectedDay(e.End));
        }

        private List<UserTask> getTasksForSelectedDay(DateTime date)
        {
            var _TasksToday = new List<UserTask>();

            foreach (var task in _activeCalendar.Tasks)
            {
                if (task.Deadline.Equals(date))
                {
                    _TasksToday.Add(task);
                }
            }

            return _TasksToday;
        }*/

        private void RefillDatagridview(List<UserTask> tasks)
        {
            // Empty Datagridview
            var rowCount = dgv_main.RowCount;
            for (var i = 1; i < rowCount; i++)
            {
                dgv_main.Rows.RemoveAt(0);
            }

            // Create Rows
            foreach (var task in tasks)
            {
                // Datagridview Columns: [Status] , [Description] , [Date] , [Priority] , [Reminder]
                var status = task.Status;
                var description = task.Description;
                var date = task.Deadline.ToString(Program.DateTimeFormats[2]);
                int priority;
                var reminder = task.Reminder.ToString(Program.DateTimeFormats[2]);

                var row = new DataGridViewRow();
                dgv_main.Rows.Add(row);
                var rowIndex = dgv_main.RowCount - 2;

                dgv_main.Rows[rowIndex].Cells[0].Value = status;
                dgv_main.Rows[rowIndex].Cells[1].Value = description;
                dgv_main.Rows[rowIndex].Cells[2].Value = date;

                // Priority
                switch (task.Priority)
                {
                    case 0:
                        priority = 0;
                        break;
                    case 1:
                        priority = 3;
                        break;
                    case 2:
                        priority = 2;
                        break;
                    case 3:
                        priority = 1;
                        break;
                    default:
                        priority = 0;
                        break;
                }

                DataGridViewComboBoxCell cell = (DataGridViewComboBoxCell) dgv_main.Rows[rowIndex].Cells[3];
                dgv_main.Rows[rowIndex].Cells[3].Value = cell.Items[priority];
                dgv_main.Rows[rowIndex].Cells[4].Value = reminder;
            }
        }

        private void mnuNewCalendar_Click(object sender, EventArgs e)
        {
            _activeUser.AddCalendar(null, null);
            listCalendars();
            lvCalendars.Items[lvCalendars.Items.Count - 1].Focused = true;
            lvCalendars.FocusedItem.BeginEdit();
        }

        private void UpdateCalendarNames()
        {
            foreach (ListViewItem item in lvCalendars.Items)
            {
                foreach (var cal in _activeUser.Calendars)
                {
                    if ((int)item.Tag == cal.Index)
                    {
                        cal.Name = item.Text;
                    }
                }
            }
        }

        private void lvCalendars_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            lvCalendars.FocusedItem.BeginEdit();
            lvCalendars.FocusedItem.Checked = !lvCalendars.FocusedItem.Checked;
        }

        private void lvCalendars_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateCalendarNames();
            if (lvCalendars.FocusedItem != null)
            {
                foreach (var cal in _activeUser.Calendars)
                {
                    if ((int)lvCalendars.FocusedItem.Tag == cal.Index)
                    {
                        _activeCalendar = cal;
                    }
                }
            }
        }

        // Do not change Checkbox state after a MouseDoubleClick
        private void lvCalendars_MouseDown(object sender, MouseEventArgs e)
        {
            _inhibitAutoCheck = true;
        }

        private void lvCalendars_MouseUp(object sender, MouseEventArgs e)
        {
            _inhibitAutoCheck = false;
        }

        private void lvCalendars_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            if (_inhibitAutoCheck)
                e.NewValue = e.CurrentValue;
        }

        private void dgv_main_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == dgv_main.RowCount - 1)
            {
                return;
            }

            var senderGrid = (DataGridView) sender;

            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn && e.RowIndex >= 0)
            {
                DataGridViewButtonCell cell = (DataGridViewButtonCell)senderGrid.Rows[e.RowIndex].Cells[e.ColumnIndex];
                var _calDialog = new frmCalDialog(cell.Value.ToString());
                if (_calDialog.ShowDialog() == DialogResult.OK)
                {
                    // IMPLEMENT: UserTask (depending on index)

                    cell.Value = _calDialog.getDateTime();
                }
            }
        }

        private void mnuReportBugs_Click(object sender, EventArgs e)
        {
            var _report = new FrmReport();
            _report.ShowDialog();
        }

        private void mnuDeleteCalendar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(
                "Are you sure that you want to permanently delete " + lvCalendars.FocusedItem.Text + "?",
                "Delete Calendar", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                foreach (var cal in _activeUser.Calendars)
                {
                    if (cal.Index == (int) lvCalendars.FocusedItem.Tag)
                    {
                        _activeUser.Calendars.Remove(cal);
                        lvCalendars.FocusedItem.Remove();
                        lvCalendars.FocusedItem = lvCalendars.Items[0];
                        break;
                    }
                }
            }
        }

        private
            void txbSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                string searchval = txbSearch.Text;
                foreach (DataGridViewRow ro in dgv_main.Rows)
                {
                    if(ro.Index == dgv_main.RowCount - 1)
                    {
                        break;
                    }

                    if (ro.Cells[1].Value.ToString().Equals(searchval))
                    {
                        ro.Selected = true;
                        ro.Cells[1].Style.BackColor = Color.Coral;
                    }
                }                
            }
        }

        private void mnuAbout_Click(object sender, EventArgs e)
        {
            var about = new frmAbout();
            about.ShowDialog();
        }
    }
}