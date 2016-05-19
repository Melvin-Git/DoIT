namespace DoIT
{
    partial class FrmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.mnuMenustrip = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuImport = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuExport = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuNewCalendar = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuDeleteCalendar = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuReportBugs = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.calDatePicker = new System.Windows.Forms.MonthCalendar();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dgv_main = new System.Windows.Forms.DataGridView();
            this.colDone = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.colDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDeadline = new System.Windows.Forms.DataGridViewButtonColumn();
            this.colPriority = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.colReminder = new System.Windows.Forms.DataGridViewButtonColumn();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.tsplblCopyright = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblUserName = new System.Windows.Forms.Label();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.lvCalendars = new System.Windows.Forms.ListView();
            this.lblSearch = new System.Windows.Forms.Label();
            this.txbSearch = new System.Windows.Forms.TextBox();
            this.mnuMenustrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_main)).BeginInit();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // mnuMenustrip
            // 
            this.mnuMenustrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.mnuMenustrip.Location = new System.Drawing.Point(0, 0);
            this.mnuMenustrip.Name = "mnuMenustrip";
            this.mnuMenustrip.Size = new System.Drawing.Size(1018, 24);
            this.mnuMenustrip.TabIndex = 0;
            this.mnuMenustrip.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuImport,
            this.mnuExport,
            this.toolStripMenuItem1,
            this.mnuNewCalendar,
            this.mnuDeleteCalendar});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // mnuImport
            // 
            this.mnuImport.Name = "mnuImport";
            this.mnuImport.Size = new System.Drawing.Size(157, 22);
            this.mnuImport.Text = "Import";
            // 
            // mnuExport
            // 
            this.mnuExport.Name = "mnuExport";
            this.mnuExport.Size = new System.Drawing.Size(157, 22);
            this.mnuExport.Text = "Export";
            this.mnuExport.Click += new System.EventHandler(this.exportToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(154, 6);
            // 
            // mnuNewCalendar
            // 
            this.mnuNewCalendar.Name = "mnuNewCalendar";
            this.mnuNewCalendar.Size = new System.Drawing.Size(157, 22);
            this.mnuNewCalendar.Text = "New Calendar";
            this.mnuNewCalendar.Click += new System.EventHandler(this.mnuNewCalendar_Click);
            // 
            // mnuDeleteCalendar
            // 
            this.mnuDeleteCalendar.Name = "mnuDeleteCalendar";
            this.mnuDeleteCalendar.Size = new System.Drawing.Size(157, 22);
            this.mnuDeleteCalendar.Text = "Delete Calendar";
            this.mnuDeleteCalendar.Click += new System.EventHandler(this.mnuDeleteCalendar_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuReportBugs,
            this.mnuAbout});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // mnuReportBugs
            // 
            this.mnuReportBugs.Name = "mnuReportBugs";
            this.mnuReportBugs.Size = new System.Drawing.Size(138, 22);
            this.mnuReportBugs.Text = "Report Bugs";
            this.mnuReportBugs.Click += new System.EventHandler(this.mnuReportBugs_Click);
            // 
            // mnuAbout
            // 
            this.mnuAbout.Name = "mnuAbout";
            this.mnuAbout.Size = new System.Drawing.Size(138, 22);
            this.mnuAbout.Text = "About";
            // 
            // calDatePicker
            // 
            this.calDatePicker.CalendarDimensions = new System.Drawing.Size(1, 3);
            this.calDatePicker.Location = new System.Drawing.Point(9, 15);
            this.calDatePicker.Name = "calDatePicker";
            this.calDatePicker.TabIndex = 2;
//            this.calDatePicker.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.calDatePicker_DateChanged);
            // 
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.HeaderText = "+";
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            this.dataGridViewImageColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewImageColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewImageColumn1.Width = 133;
            // 
            // dgv_main
            // 
            this.dgv_main.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_main.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_main.BackgroundColor = System.Drawing.Color.LightSkyBlue;
            this.dgv_main.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_main.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colDone,
            this.colDescription,
            this.colDeadline,
            this.colPriority,
            this.colReminder});
            this.dgv_main.Location = new System.Drawing.Point(199, 44);
            this.dgv_main.Name = "dgv_main";
            this.dgv_main.RowHeadersVisible = false;
            this.dgv_main.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_main.Size = new System.Drawing.Size(597, 437);
            this.dgv_main.TabIndex = 5;
            this.dgv_main.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_main_CellContentClick);
            // 
            // colDone
            // 
            this.colDone.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.colDone.HeaderText = "Done";
            this.colDone.Name = "colDone";
            // 
            // colDescription
            // 
            this.colDescription.HeaderText = "Description";
            this.colDescription.Name = "colDescription";
            // 
            // colDeadline
            // 
            this.colDeadline.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.colDeadline.HeaderText = "Deadline";
            this.colDeadline.Name = "colDeadline";
            this.colDeadline.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colDeadline.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // colPriority
            // 
            this.colPriority.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.colPriority.HeaderText = "Priority";
            this.colPriority.Items.AddRange(new object[] {
            "-",
            "3",
            "2",
            "1"});
            this.colPriority.Name = "colPriority";
            this.colPriority.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colPriority.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // colReminder
            // 
            this.colReminder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.colReminder.HeaderText = "Reminder";
            this.colReminder.Name = "colReminder";
            this.colReminder.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colReminder.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsplblCopyright});
            this.statusStrip1.Location = new System.Drawing.Point(0, 508);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1018, 22);
            this.statusStrip1.TabIndex = 8;
            // 
            // tsplblCopyright
            // 
            this.tsplblCopyright.BackColor = System.Drawing.Color.Transparent;
            this.tsplblCopyright.Name = "tsplblCopyright";
            this.tsplblCopyright.Size = new System.Drawing.Size(46, 17);
            this.tsplblCopyright.Text = "© DoIT";
            // 
            // lblUserName
            // 
            this.lblUserName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lblUserName.AutoSize = true;
            this.lblUserName.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserName.Location = new System.Drawing.Point(199, 22);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(43, 19);
            this.lblUserName.TabIndex = 11;
            this.lblUserName.Text = "User";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 24);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.splitContainer1.Panel1.Controls.Add(this.lvCalendars);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.lblSearch);
            this.splitContainer1.Panel2.Controls.Add(this.txbSearch);
            this.splitContainer1.Panel2.Controls.Add(this.calDatePicker);
            this.splitContainer1.Panel2.Controls.Add(this.dgv_main);
            this.splitContainer1.Panel2.Controls.Add(this.lblUserName);
            this.splitContainer1.Size = new System.Drawing.Size(1018, 484);
            this.splitContainer1.SplitterDistance = 206;
            this.splitContainer1.TabIndex = 13;
            // 
            // lvCalendars
            // 
            this.lvCalendars.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lvCalendars.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lvCalendars.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvCalendars.Font = new System.Drawing.Font("MS Reference Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvCalendars.FullRowSelect = true;
            this.lvCalendars.HideSelection = false;
            this.lvCalendars.LabelEdit = true;
            this.lvCalendars.Location = new System.Drawing.Point(0, 0);
            this.lvCalendars.MultiSelect = false;
            this.lvCalendars.Name = "lvCalendars";
            this.lvCalendars.Size = new System.Drawing.Size(206, 484);
            this.lvCalendars.TabIndex = 0;
            this.lvCalendars.UseCompatibleStateImageBehavior = false;
            this.lvCalendars.View = System.Windows.Forms.View.List;
            this.lvCalendars.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.lvCalendars_ItemCheck);
            this.lvCalendars.SelectedIndexChanged += new System.EventHandler(this.lvCalendars_SelectedIndexChanged);
            this.lvCalendars.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lvCalendars_MouseDoubleClick);
            this.lvCalendars.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lvCalendars_MouseDown);
            this.lvCalendars.MouseUp += new System.Windows.Forms.MouseEventHandler(this.lvCalendars_MouseUp);
            // 
            // lblSearch
            // 
            this.lblSearch.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lblSearch.AutoSize = true;
            this.lblSearch.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearch.Location = new System.Drawing.Point(504, 18);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(58, 18);
            this.lblSearch.TabIndex = 12;
            this.lblSearch.Text = "Search";
            // 
            // txbSearch
            // 
            this.txbSearch.Font = new System.Drawing.Font("MS Reference Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbSearch.Location = new System.Drawing.Point(568, 15);
            this.txbSearch.Name = "txbSearch";
            this.txbSearch.Size = new System.Drawing.Size(228, 26);
            this.txbSearch.TabIndex = 1;
            this.txbSearch.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txbSearch_KeyDown);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1018, 530);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.mnuMenustrip);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.mnuMenustrip;
            this.MinimumSize = new System.Drawing.Size(850, 500);
            this.Name = "FrmMain";
            this.Text = "DoIT";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.mnuMenustrip.ResumeLayout(false);
            this.mnuMenustrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_main)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mnuMenustrip;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnuImport;
        private System.Windows.Forms.ToolStripMenuItem mnuNewCalendar;
        private System.Windows.Forms.ToolStripMenuItem mnuDeleteCalendar;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnuReportBugs;
        private System.Windows.Forms.MonthCalendar calDatePicker;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.DataGridView dgv_main;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel tsplblCopyright;
        private System.Windows.Forms.Label lblUserName;
        private System.Windows.Forms.ToolStripMenuItem mnuExport;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.DataGridViewCheckBoxColumn colDone;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDescription;
        private System.Windows.Forms.DataGridViewButtonColumn colDeadline;
        private System.Windows.Forms.DataGridViewComboBoxColumn colPriority;
        private System.Windows.Forms.DataGridViewButtonColumn colReminder;
        private System.Windows.Forms.ListView lvCalendars;
        private System.Windows.Forms.ToolStripMenuItem mnuAbout;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.TextBox txbSearch;
    }
}

