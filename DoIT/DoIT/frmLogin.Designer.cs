namespace DoIT
{
    partial class FrmLogin
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLogin));
            this.scSplitContainer = new System.Windows.Forms.SplitContainer();
            this.lblCopyright = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.imgLogo = new System.Windows.Forms.PictureBox();
            this.lblSignIn = new System.Windows.Forms.Label();
            this.pnlSignIn = new System.Windows.Forms.Panel();
            this.btnSignIn = new System.Windows.Forms.Button();
            this.txbSignInPassword = new System.Windows.Forms.TextBox();
            this.txbSignInUsername = new System.Windows.Forms.TextBox();
            this.lblSignInPassword = new System.Windows.Forms.Label();
            this.lblSignInUsername = new System.Windows.Forms.Label();
            this.pnlRegister = new System.Windows.Forms.Panel();
            this.btnRegister = new System.Windows.Forms.Button();
            this.txbRegisterPasswordRepeat = new System.Windows.Forms.TextBox();
            this.lblRegisterPasswordRepeat = new System.Windows.Forms.Label();
            this.txbRegisterPassword = new System.Windows.Forms.TextBox();
            this.txbRegisterUsername = new System.Windows.Forms.TextBox();
            this.lblRegisterUsername = new System.Windows.Forms.Label();
            this.lblRegisterPassword = new System.Windows.Forms.Label();
            this.lblRegister = new System.Windows.Forms.Label();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.scSplitContainer)).BeginInit();
            this.scSplitContainer.Panel1.SuspendLayout();
            this.scSplitContainer.Panel2.SuspendLayout();
            this.scSplitContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgLogo)).BeginInit();
            this.pnlSignIn.SuspendLayout();
            this.pnlRegister.SuspendLayout();
            this.SuspendLayout();
            // 
            // scSplitContainer
            // 
            this.scSplitContainer.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.scSplitContainer.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("scSplitContainer.BackgroundImage")));
            this.scSplitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.scSplitContainer.IsSplitterFixed = true;
            this.scSplitContainer.Location = new System.Drawing.Point(0, 0);
            this.scSplitContainer.Name = "scSplitContainer";
            // 
            // scSplitContainer.Panel1
            // 
            this.scSplitContainer.Panel1.BackColor = System.Drawing.Color.Transparent;
            this.scSplitContainer.Panel1.Controls.Add(this.lblCopyright);
            this.scSplitContainer.Panel1.Controls.Add(this.pictureBox2);
            this.scSplitContainer.Panel1.Controls.Add(this.lblTitle);
            this.scSplitContainer.Panel1.Controls.Add(this.imgLogo);
            this.scSplitContainer.Panel1.Controls.Add(this.lblSignIn);
            this.scSplitContainer.Panel1.Controls.Add(this.pnlSignIn);
            this.scSplitContainer.Panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.scSplitContainer_Panel1_MouseDown);
            // 
            // scSplitContainer.Panel2
            // 
            this.scSplitContainer.Panel2.BackColor = System.Drawing.Color.Transparent;
            this.scSplitContainer.Panel2.Controls.Add(this.pnlRegister);
            this.scSplitContainer.Panel2.Controls.Add(this.lblRegister);
            this.scSplitContainer.Panel2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.scSplitContainer_Panel2_MouseDown);
            this.scSplitContainer.Size = new System.Drawing.Size(876, 490);
            this.scSplitContainer.SplitterDistance = 575;
            this.scSplitContainer.TabIndex = 0;
            // 
            // lblCopyright
            // 
            this.lblCopyright.AutoSize = true;
            this.lblCopyright.Font = new System.Drawing.Font("MS Reference Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCopyright.ForeColor = System.Drawing.Color.White;
            this.lblCopyright.Location = new System.Drawing.Point(420, 76);
            this.lblCopyright.Name = "lblCopyright";
            this.lblCopyright.Size = new System.Drawing.Size(148, 19);
            this.lblCopyright.TabIndex = 7;
            this.lblCopyright.Text = "© 2016 - DoIT AG";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(128, 98);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(437, 1);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 6;
            this.pictureBox2.TabStop = false;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Myriad Hebrew", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(118, 50);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(92, 45);
            this.lblTitle.TabIndex = 5;
            this.lblTitle.Text = "DoIT";
            // 
            // imgLogo
            // 
            this.imgLogo.Image = ((System.Drawing.Image)(resources.GetObject("imgLogo.Image")));
            this.imgLogo.Location = new System.Drawing.Point(12, 12);
            this.imgLogo.Name = "imgLogo";
            this.imgLogo.Size = new System.Drawing.Size(100, 100);
            this.imgLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgLogo.TabIndex = 4;
            this.imgLogo.TabStop = false;
            // 
            // lblSignIn
            // 
            this.lblSignIn.AutoSize = true;
            this.lblSignIn.BackColor = System.Drawing.Color.Transparent;
            this.lblSignIn.Font = new System.Drawing.Font("MS Reference Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSignIn.ForeColor = System.Drawing.Color.White;
            this.lblSignIn.Location = new System.Drawing.Point(179, 143);
            this.lblSignIn.Name = "lblSignIn";
            this.lblSignIn.Size = new System.Drawing.Size(117, 29);
            this.lblSignIn.TabIndex = 0;
            this.lblSignIn.Text = "Sign In:";
            this.lblSignIn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pnlSignIn
            // 
            this.pnlSignIn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlSignIn.BackgroundImage")));
            this.pnlSignIn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlSignIn.Controls.Add(this.btnSignIn);
            this.pnlSignIn.Controls.Add(this.txbSignInPassword);
            this.pnlSignIn.Controls.Add(this.txbSignInUsername);
            this.pnlSignIn.Controls.Add(this.lblSignInPassword);
            this.pnlSignIn.Controls.Add(this.lblSignInUsername);
            this.pnlSignIn.Location = new System.Drawing.Point(184, 182);
            this.pnlSignIn.Name = "pnlSignIn";
            this.pnlSignIn.Size = new System.Drawing.Size(308, 308);
            this.pnlSignIn.TabIndex = 1;
            this.pnlSignIn.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnlSignIn_MouseDown);
            // 
            // btnSignIn
            // 
            this.btnSignIn.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnSignIn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSignIn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSignIn.Font = new System.Drawing.Font("MS Reference Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSignIn.Location = new System.Drawing.Point(61, 216);
            this.btnSignIn.Name = "btnSignIn";
            this.btnSignIn.Size = new System.Drawing.Size(189, 56);
            this.btnSignIn.TabIndex = 4;
            this.btnSignIn.Text = "Sign In";
            this.btnSignIn.UseVisualStyleBackColor = false;
            // 
            // txbSignInPassword
            // 
            this.txbSignInPassword.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbSignInPassword.Location = new System.Drawing.Point(17, 162);
            this.txbSignInPassword.Name = "txbSignInPassword";
            this.txbSignInPassword.Size = new System.Drawing.Size(275, 27);
            this.txbSignInPassword.TabIndex = 4;
            // 
            // txbSignInUsername
            // 
            this.txbSignInUsername.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbSignInUsername.Location = new System.Drawing.Point(18, 72);
            this.txbSignInUsername.Name = "txbSignInUsername";
            this.txbSignInUsername.Size = new System.Drawing.Size(275, 27);
            this.txbSignInUsername.TabIndex = 2;
            // 
            // lblSignInPassword
            // 
            this.lblSignInPassword.AutoSize = true;
            this.lblSignInPassword.BackColor = System.Drawing.Color.Transparent;
            this.lblSignInPassword.Font = new System.Drawing.Font("MS Reference Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSignInPassword.Location = new System.Drawing.Point(14, 133);
            this.lblSignInPassword.Name = "lblSignInPassword";
            this.lblSignInPassword.Size = new System.Drawing.Size(109, 24);
            this.lblSignInPassword.TabIndex = 3;
            this.lblSignInPassword.Text = "Password:";
            this.lblSignInPassword.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblSignInUsername
            // 
            this.lblSignInUsername.AutoSize = true;
            this.lblSignInUsername.BackColor = System.Drawing.Color.Transparent;
            this.lblSignInUsername.Font = new System.Drawing.Font("MS Reference Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSignInUsername.Location = new System.Drawing.Point(14, 43);
            this.lblSignInUsername.Name = "lblSignInUsername";
            this.lblSignInUsername.Size = new System.Drawing.Size(114, 24);
            this.lblSignInUsername.TabIndex = 2;
            this.lblSignInUsername.Text = "Username:";
            this.lblSignInUsername.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pnlRegister
            // 
            this.pnlRegister.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlRegister.BackgroundImage")));
            this.pnlRegister.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlRegister.Controls.Add(this.btnRegister);
            this.pnlRegister.Controls.Add(this.txbRegisterPasswordRepeat);
            this.pnlRegister.Controls.Add(this.lblRegisterPasswordRepeat);
            this.pnlRegister.Controls.Add(this.txbRegisterPassword);
            this.pnlRegister.Controls.Add(this.txbRegisterUsername);
            this.pnlRegister.Controls.Add(this.lblRegisterUsername);
            this.pnlRegister.Controls.Add(this.lblRegisterPassword);
            this.pnlRegister.Location = new System.Drawing.Point(8, 78);
            this.pnlRegister.Name = "pnlRegister";
            this.pnlRegister.Size = new System.Drawing.Size(289, 304);
            this.pnlRegister.TabIndex = 3;
            this.pnlRegister.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnlRegister_MouseDown);
            // 
            // btnRegister
            // 
            this.btnRegister.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnRegister.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRegister.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegister.Font = new System.Drawing.Font("MS Reference Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegister.Location = new System.Drawing.Point(55, 213);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(189, 56);
            this.btnRegister.TabIndex = 5;
            this.btnRegister.Text = "Register";
            this.btnRegister.UseVisualStyleBackColor = false;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // txbRegisterPasswordRepeat
            // 
            this.txbRegisterPasswordRepeat.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbRegisterPasswordRepeat.Location = new System.Drawing.Point(25, 167);
            this.txbRegisterPasswordRepeat.Name = "txbRegisterPasswordRepeat";
            this.txbRegisterPasswordRepeat.Size = new System.Drawing.Size(249, 27);
            this.txbRegisterPasswordRepeat.TabIndex = 10;
            // 
            // lblRegisterPasswordRepeat
            // 
            this.lblRegisterPasswordRepeat.AutoSize = true;
            this.lblRegisterPasswordRepeat.BackColor = System.Drawing.Color.Transparent;
            this.lblRegisterPasswordRepeat.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRegisterPasswordRepeat.Location = new System.Drawing.Point(23, 138);
            this.lblRegisterPasswordRepeat.Name = "lblRegisterPasswordRepeat";
            this.lblRegisterPasswordRepeat.Size = new System.Drawing.Size(67, 20);
            this.lblRegisterPasswordRepeat.TabIndex = 9;
            this.lblRegisterPasswordRepeat.Text = "Repeat";
            this.lblRegisterPasswordRepeat.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txbRegisterPassword
            // 
            this.txbRegisterPassword.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbRegisterPassword.Location = new System.Drawing.Point(24, 104);
            this.txbRegisterPassword.Name = "txbRegisterPassword";
            this.txbRegisterPassword.Size = new System.Drawing.Size(250, 27);
            this.txbRegisterPassword.TabIndex = 8;
            // 
            // txbRegisterUsername
            // 
            this.txbRegisterUsername.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbRegisterUsername.Location = new System.Drawing.Point(24, 42);
            this.txbRegisterUsername.Name = "txbRegisterUsername";
            this.txbRegisterUsername.Size = new System.Drawing.Size(250, 27);
            this.txbRegisterUsername.TabIndex = 5;
            // 
            // lblRegisterUsername
            // 
            this.lblRegisterUsername.AutoSize = true;
            this.lblRegisterUsername.BackColor = System.Drawing.Color.Transparent;
            this.lblRegisterUsername.Font = new System.Drawing.Font("MS Reference Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRegisterUsername.Location = new System.Drawing.Point(20, 13);
            this.lblRegisterUsername.Name = "lblRegisterUsername";
            this.lblRegisterUsername.Size = new System.Drawing.Size(114, 24);
            this.lblRegisterUsername.TabIndex = 6;
            this.lblRegisterUsername.Text = "Username:";
            this.lblRegisterUsername.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblRegisterPassword
            // 
            this.lblRegisterPassword.AutoSize = true;
            this.lblRegisterPassword.BackColor = System.Drawing.Color.Transparent;
            this.lblRegisterPassword.Font = new System.Drawing.Font("MS Reference Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRegisterPassword.Location = new System.Drawing.Point(21, 75);
            this.lblRegisterPassword.Name = "lblRegisterPassword";
            this.lblRegisterPassword.Size = new System.Drawing.Size(109, 24);
            this.lblRegisterPassword.TabIndex = 7;
            this.lblRegisterPassword.Text = "Password:";
            this.lblRegisterPassword.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblRegister
            // 
            this.lblRegister.AutoSize = true;
            this.lblRegister.BackColor = System.Drawing.Color.Transparent;
            this.lblRegister.Font = new System.Drawing.Font("MS Reference Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRegister.ForeColor = System.Drawing.Color.White;
            this.lblRegister.Location = new System.Drawing.Point(3, 39);
            this.lblRegister.Name = "lblRegister";
            this.lblRegister.Size = new System.Drawing.Size(131, 29);
            this.lblRegister.TabIndex = 2;
            this.lblRegister.Text = "Register:";
            this.lblRegister.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(876, 490);
            this.Controls.Add(this.scSplitContainer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Welcome to DoIT!";
            this.Load += new System.EventHandler(this.frmLogin_Load);
            this.scSplitContainer.Panel1.ResumeLayout(false);
            this.scSplitContainer.Panel1.PerformLayout();
            this.scSplitContainer.Panel2.ResumeLayout(false);
            this.scSplitContainer.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.scSplitContainer)).EndInit();
            this.scSplitContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgLogo)).EndInit();
            this.pnlSignIn.ResumeLayout(false);
            this.pnlSignIn.PerformLayout();
            this.pnlRegister.ResumeLayout(false);
            this.pnlRegister.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer scSplitContainer;
        private System.Windows.Forms.Label lblSignIn;
        private System.Windows.Forms.Panel pnlSignIn;
        private System.Windows.Forms.Button btnSignIn;
        private System.Windows.Forms.TextBox txbSignInPassword;
        private System.Windows.Forms.TextBox txbSignInUsername;
        private System.Windows.Forms.Label lblSignInPassword;
        private System.Windows.Forms.Label lblSignInUsername;
        private System.Windows.Forms.Panel pnlRegister;
        private System.Windows.Forms.TextBox txbRegisterPasswordRepeat;
        private System.Windows.Forms.Label lblRegisterPasswordRepeat;
        private System.Windows.Forms.TextBox txbRegisterPassword;
        private System.Windows.Forms.TextBox txbRegisterUsername;
        private System.Windows.Forms.Label lblRegisterUsername;
        private System.Windows.Forms.Label lblRegisterPassword;
        private System.Windows.Forms.Label lblRegister;
        private System.Windows.Forms.PictureBox imgLogo;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.Label lblCopyright;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.ImageList imageList1;
    }
}