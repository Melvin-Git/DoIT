﻿namespace DoIT
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.mnu = new System.Windows.Forms.MenuStrip();
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
<<<<<<< HEAD:DoIT/DoIT/frmMain.designer.cs
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
=======
            this.mnuitmAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.gv_done = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.gv_description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gv_deadline = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gv_priority = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gv_remember = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gv_plus = new System.Windows.Forms.DataGridViewImageColumn();
>>>>>>> Methods:DoIT/DoIT/frmMain.designer.cs
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.dataGridViewCheckBoxColumn1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewImageColumn2 = new System.Windows.Forms.DataGridViewImageColumn();
            this.btnAll = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.tsplblCopyright = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblUser = new System.Windows.Forms.Label();
            this.lblCalendar = new System.Windows.Forms.Label();
            this.lblUserName = new System.Windows.Forms.Label();
            this.lblCalendarName = new System.Windows.Forms.Label();
            this.mnu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // mnu
            // 
            this.mnu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.vIEWToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.mnu.Location = new System.Drawing.Point(0, 0);
            this.mnu.Name = "mnu";
            this.mnu.Size = new System.Drawing.Size(834, 24);
            this.mnu.TabIndex = 0;
            this.mnu.Text = "menuStrip1";
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
            // monthCalendar1
            // 
            this.monthCalendar1.CalendarDimensions = new System.Drawing.Size(1, 2);
            this.monthCalendar1.Location = new System.Drawing.Point(18, 76);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 2;
            // 
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.HeaderText = "+";
            this.dataGridViewImageColumn1.Image = global::DoIT.Properties.Resources._1462208933_editor_pencil_pen_edit_write_glyph1;
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            this.dataGridViewImageColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewImageColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewImageColumn1.Width = 133;
            // 
            // dataGridView2
            // 
            this.dataGridView2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView2.BackgroundColor = System.Drawing.Color.LightSkyBlue;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewCheckBoxColumn1,
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewImageColumn2});
            this.dataGridView2.Location = new System.Drawing.Point(212, 76);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersVisible = false;
            this.dataGridView2.Size = new System.Drawing.Size(610, 346);
            this.dataGridView2.TabIndex = 5;
            // 
            // dataGridViewCheckBoxColumn1
            // 
            this.dataGridViewCheckBoxColumn1.HeaderText = "Done";
            this.dataGridViewCheckBoxColumn1.Name = "dataGridViewCheckBoxColumn1";
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Description";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Deadline";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "Priority";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.HeaderText = "Remember";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewImageColumn2
            // 
            this.dataGridViewImageColumn2.HeaderText = "+";
            this.dataGridViewImageColumn2.Image = ((System.Drawing.Image)(resources.GetObject("dataGridViewImageColumn2.Image")));
            this.dataGridViewImageColumn2.Name = "dataGridViewImageColumn2";
            this.dataGridViewImageColumn2.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewImageColumn2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // btnAll
            // 
            this.btnAll.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnAll.Location = new System.Drawing.Point(18, 399);
            this.btnAll.Name = "btnAll";
            this.btnAll.Size = new System.Drawing.Size(178, 23);
            this.btnAll.TabIndex = 6;
            this.btnAll.Text = "show all task";
            this.btnAll.UseVisualStyleBackColor = true;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsplblCopyright});
            this.statusStrip1.Location = new System.Drawing.Point(0, 439);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(834, 22);
            this.statusStrip1.TabIndex = 8;
            // 
            // tsplblCopyright
            // 
            this.tsplblCopyright.BackColor = System.Drawing.Color.Transparent;
            this.tsplblCopyright.Name = "tsplblCopyright";
            this.tsplblCopyright.Size = new System.Drawing.Size(46, 17);
            this.tsplblCopyright.Text = "© DoIT";
            // 
            // lblUser
            // 
            this.lblUser.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblUser.AutoSize = true;
            this.lblUser.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUser.Location = new System.Drawing.Point(15, 36);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(45, 18);
            this.lblUser.TabIndex = 9;
            this.lblUser.Text = "User:";
            // 
            // lblCalendar
            // 
            this.lblCalendar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblCalendar.AutoSize = true;
            this.lblCalendar.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCalendar.Location = new System.Drawing.Point(209, 36);
            this.lblCalendar.Name = "lblCalendar";
            this.lblCalendar.Size = new System.Drawing.Size(76, 18);
            this.lblCalendar.TabIndex = 10;
            this.lblCalendar.Text = "Calendar:";
            // 
            // lblUserName
            // 
            this.lblUserName.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblUserName.AutoSize = true;
            this.lblUserName.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserName.Location = new System.Drawing.Point(66, 36);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(24, 19);
            this.lblUserName.TabIndex = 11;
            this.lblUserName.Text = "---";
            // 
            // lblCalendarName
            // 
            this.lblCalendarName.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblCalendarName.AutoSize = true;
            this.lblCalendarName.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCalendarName.Location = new System.Drawing.Point(291, 36);
            this.lblCalendarName.Name = "lblCalendarName";
            this.lblCalendarName.Size = new System.Drawing.Size(24, 19);
            this.lblCalendarName.TabIndex = 12;
            this.lblCalendarName.Text = "---";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(834, 461);
            this.Controls.Add(this.lblCalendarName);
            this.Controls.Add(this.lblUserName);
            this.Controls.Add(this.lblCalendar);
            this.Controls.Add(this.lblUser);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.btnAll);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.monthCalendar1);
            this.Controls.Add(this.mnu);
            this.MainMenuStrip = this.mnu;
            this.MinimumSize = new System.Drawing.Size(850, 500);
            this.Name = "frmMain";
            this.Text = "DoIT";
            this.mnu.ResumeLayout(false);
            this.mnu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mnu;
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
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        /*private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn2;*/
        private System.Windows.Forms.Button btnAll;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel tsplblCopyright;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.Label lblCalendar;
        private System.Windows.Forms.Label lblUserName;
        private System.Windows.Forms.Label lblCalendarName;
    }
}

