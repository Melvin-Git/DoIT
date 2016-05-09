namespace DoIT
{
    partial class mainview
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.importToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveCalendarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newCalendarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteCalendarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addNewTaskToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editTaskToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteTaskToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vIEWToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.maxCalenderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hideCalendarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.filterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.searchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.documentationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportBugsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuitmAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.gv_done = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.gv_description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gv_deadline = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gv_priority = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gv_remember = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gv_plus = new System.Windows.Forms.DataGridViewImageColumn();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.gb = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.vIEWToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(839, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.importToolStripMenuItem,
            this.saveCalendarToolStripMenuItem,
            this.newCalendarToolStripMenuItem,
            this.deleteCalendarToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // importToolStripMenuItem
            // 
            this.importToolStripMenuItem.Name = "importToolStripMenuItem";
            this.importToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.importToolStripMenuItem.Text = "Import";
            // 
            // saveCalendarToolStripMenuItem
            // 
            this.saveCalendarToolStripMenuItem.Name = "saveCalendarToolStripMenuItem";
            this.saveCalendarToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.saveCalendarToolStripMenuItem.Text = "Save Calendar";
            // 
            // newCalendarToolStripMenuItem
            // 
            this.newCalendarToolStripMenuItem.Name = "newCalendarToolStripMenuItem";
            this.newCalendarToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.newCalendarToolStripMenuItem.Text = "New Calendar";
            // 
            // deleteCalendarToolStripMenuItem
            // 
            this.deleteCalendarToolStripMenuItem.Name = "deleteCalendarToolStripMenuItem";
            this.deleteCalendarToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.deleteCalendarToolStripMenuItem.Text = "Delete Calendar";
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addNewTaskToolStripMenuItem,
            this.editTaskToolStripMenuItem,
            this.deleteTaskToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // addNewTaskToolStripMenuItem
            // 
            this.addNewTaskToolStripMenuItem.Name = "addNewTaskToolStripMenuItem";
            this.addNewTaskToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.addNewTaskToolStripMenuItem.Text = "Add New Task";
            // 
            // editTaskToolStripMenuItem
            // 
            this.editTaskToolStripMenuItem.Name = "editTaskToolStripMenuItem";
            this.editTaskToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.editTaskToolStripMenuItem.Text = "Edit Task";
            // 
            // deleteTaskToolStripMenuItem
            // 
            this.deleteTaskToolStripMenuItem.Name = "deleteTaskToolStripMenuItem";
            this.deleteTaskToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.deleteTaskToolStripMenuItem.Text = "Delete Task";
            // 
            // vIEWToolStripMenuItem
            // 
            this.vIEWToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.maxCalenderToolStripMenuItem,
            this.hideCalendarToolStripMenuItem,
            this.filterToolStripMenuItem,
            this.searchToolStripMenuItem});
            this.vIEWToolStripMenuItem.Name = "vIEWToolStripMenuItem";
            this.vIEWToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.vIEWToolStripMenuItem.Text = "View";
            // 
            // maxCalenderToolStripMenuItem
            // 
            this.maxCalenderToolStripMenuItem.Name = "maxCalenderToolStripMenuItem";
            this.maxCalenderToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.maxCalenderToolStripMenuItem.Text = "Max. Calendar";
            // 
            // hideCalendarToolStripMenuItem
            // 
            this.hideCalendarToolStripMenuItem.Name = "hideCalendarToolStripMenuItem";
            this.hideCalendarToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.hideCalendarToolStripMenuItem.Text = "Hide Calendar";
            // 
            // filterToolStripMenuItem
            // 
            this.filterToolStripMenuItem.Name = "filterToolStripMenuItem";
            this.filterToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.filterToolStripMenuItem.Text = "Filter";
            // 
            // searchToolStripMenuItem
            // 
            this.searchToolStripMenuItem.Name = "searchToolStripMenuItem";
            this.searchToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.searchToolStripMenuItem.Text = "Search";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.documentationToolStripMenuItem,
            this.reportBugsToolStripMenuItem,
            this.mnuitmAbout});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // documentationToolStripMenuItem
            // 
            this.documentationToolStripMenuItem.Name = "documentationToolStripMenuItem";
            this.documentationToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.documentationToolStripMenuItem.Text = "Documentation";
            // 
            // reportBugsToolStripMenuItem
            // 
            this.reportBugsToolStripMenuItem.Name = "reportBugsToolStripMenuItem";
            this.reportBugsToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.reportBugsToolStripMenuItem.Text = "Report Bugs";
            // 
            // mnuitmAbout
            // 
            this.mnuitmAbout.Name = "mnuitmAbout";
            this.mnuitmAbout.Size = new System.Drawing.Size(157, 22);
            this.mnuitmAbout.Text = "About";
            this.mnuitmAbout.Click += new System.EventHandler(this.mnuitmAbout_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.gv_done,
            this.gv_description,
            this.gv_deadline,
            this.gv_priority,
            this.gv_remember,
            this.gv_plus});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridView1.Location = new System.Drawing.Point(0, 384);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(839, 173);
            this.dataGridView1.TabIndex = 1;
            // 
            // gv_done
            // 
            this.gv_done.HeaderText = "Done";
            this.gv_done.Name = "gv_done";
            // 
            // gv_description
            // 
            this.gv_description.HeaderText = "Description";
            this.gv_description.Name = "gv_description";
            // 
            // gv_deadline
            // 
            this.gv_deadline.HeaderText = "Deadline";
            this.gv_deadline.Name = "gv_deadline";
            // 
            // gv_priority
            // 
            this.gv_priority.HeaderText = "Priority";
            this.gv_priority.Name = "gv_priority";
            // 
            // gv_remember
            // 
            this.gv_remember.HeaderText = "Remember";
            this.gv_remember.Name = "gv_remember";
            // 
            // gv_plus
            // 
            this.gv_plus.HeaderText = "+";
            this.gv_plus.Image = global::DoIT.Properties.Resources._1462208933_editor_pencil_pen_edit_write_glyph;
            this.gv_plus.Name = "gv_plus";
            this.gv_plus.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.gv_plus.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.CalendarDimensions = new System.Drawing.Size(1, 2);
            this.monthCalendar1.Location = new System.Drawing.Point(0, 33);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 2;
            // 
            // gb
            // 
            this.gb.Location = new System.Drawing.Point(190, 44);
            this.gb.Name = "gb";
            this.gb.Size = new System.Drawing.Size(637, 289);
            this.gb.TabIndex = 3;
            this.gb.TabStop = false;
            this.gb.Text = "groupBox1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 353);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "label1";
            // 
            // mainview
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(839, 557);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gb);
            this.Controls.Add(this.monthCalendar1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "mainview";
            this.Text = "DoIT";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem importToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveCalendarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newCalendarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteCalendarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addNewTaskToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editTaskToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteTaskToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vIEWToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem maxCalenderToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hideCalendarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem filterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem searchToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem documentationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportBugsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnuitmAbout;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewCheckBoxColumn gv_done;
        private System.Windows.Forms.DataGridViewTextBoxColumn gv_description;
        private System.Windows.Forms.DataGridViewTextBoxColumn gv_deadline;
        private System.Windows.Forms.DataGridViewTextBoxColumn gv_priority;
        private System.Windows.Forms.DataGridViewTextBoxColumn gv_remember;
        private System.Windows.Forms.DataGridViewImageColumn gv_plus;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.GroupBox gb;
        private System.Windows.Forms.Label label1;
    }
}

