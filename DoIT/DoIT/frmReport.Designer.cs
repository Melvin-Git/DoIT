namespace DoIT
{
    partial class frmReport
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmReport));
            this.txbMail = new System.Windows.Forms.TextBox();
            this.rtbMeldung = new System.Windows.Forms.RichTextBox();
            this.lblMessage = new System.Windows.Forms.Label();
            this.lblMail = new System.Windows.Forms.Label();
            this.btnSend = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txbMail
            // 
            this.txbMail.Location = new System.Drawing.Point(12, 49);
            this.txbMail.Name = "txbMail";
            this.txbMail.Size = new System.Drawing.Size(260, 20);
            this.txbMail.TabIndex = 0;
            // 
            // rtbMeldung
            // 
            this.rtbMeldung.Location = new System.Drawing.Point(12, 126);
            this.rtbMeldung.Name = "rtbMeldung";
            this.rtbMeldung.Size = new System.Drawing.Size(260, 123);
            this.rtbMeldung.TabIndex = 1;
            this.rtbMeldung.Text = "";
            // 
            // lblMessage
            // 
            this.lblMessage.AutoSize = true;
            this.lblMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMessage.Location = new System.Drawing.Point(9, 92);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(69, 18);
            this.lblMessage.TabIndex = 2;
            this.lblMessage.Text = "Message";
            // 
            // lblMail
            // 
            this.lblMail.AutoSize = true;
            this.lblMail.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMail.Location = new System.Drawing.Point(9, 23);
            this.lblMail.Name = "lblMail";
            this.lblMail.Size = new System.Drawing.Size(45, 18);
            this.lblMail.TabIndex = 3;
            this.lblMail.Text = "Email";
            // 
            // btnSend
            // 
            this.btnSend.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnSend.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSend.Font = new System.Drawing.Font("MS Reference Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSend.Location = new System.Drawing.Point(12, 270);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(259, 41);
            this.btnSend.TabIndex = 4;
            this.btnSend.Text = "Send";
            this.btnSend.UseVisualStyleBackColor = false;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // frmReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(284, 323);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.lblMail);
            this.Controls.Add(this.lblMessage);
            this.Controls.Add(this.rtbMeldung);
            this.Controls.Add(this.txbMail);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmReport";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Report Bug / Wish";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txbMail;
        private System.Windows.Forms.RichTextBox rtbMeldung;
        private System.Windows.Forms.Label lblMessage;
        private System.Windows.Forms.Label lblMail;
        private System.Windows.Forms.Button btnSend;
    }
}