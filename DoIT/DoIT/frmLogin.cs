using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoIT
{
    public partial class frmLogin : Form
    {
        // Move Form Variables.
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            string username = txbRegisterUsername.Text;
            string password1 = txbRegisterPassword.Text;
            string password2 = txbRegisterPasswordRepeat.Text;

            // Check if Passwords match
            if(CheckIfPasswordsMatch(password1, password2) == false)
            {
                return;
            }

            if(CheckIfUserExists(username) == true)
            {
                return;
            }

            RegisterUser(txbRegisterUsername.Text, txbRegisterPassword.Text);
        }

        // Methods
        private bool CheckIfPasswordsMatch(string pw1, string pw2)
        {
            bool match = true;

            if(!pw1.Equals(pw2))
            {
                match = false;
                MessageBox.Show("The passwords you typed in do not match!", "Passwords do not match");
            }

            return match;
        }

        private bool CheckIfUserExists(string username)
        {
            bool exists = false;

            foreach(var user in Program.Users)
            {
                if(user.getUsername() == username)
                {
                    exists = true;
                    MessageBox.Show("A user with this username already exists. Please choose another username", "User exists");
                    break;
                }
            }

            return exists;
        }

        private void RegisterUser(string username, string password)
        {
            var user = new User();
            user.setUsername(username);
            user.setPassword(password);
            user.AddCalendar("Calendar 1", null);
            Program.Users.Add(user);
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            scSplitContainer.BackgroundImageLayout = ImageLayout.Stretch;
        }

        private void Login(int userindex, string username, string password)
        {
            /*
             * IMPLEMENT: Check if username / password exists / is correct.
             */

            // Set Active User for the Program.
            Program.ActiveUser = Program.Users[userindex];
        }

        // The following Methods contain the MoveForm function.
        private void scSplitContainer_Panel1_MouseDown(object sender, MouseEventArgs e)
        {
            MoveForm(sender, e);
        }

        private void scSplitContainer_Panel2_MouseDown(object sender, MouseEventArgs e)
        {
            MoveForm(sender, e);
        }

        private void pnlSignIn_MouseDown(object sender, MouseEventArgs e)
        {
            MoveForm(sender, e);
        }

        private void pnlRegister_MouseDown(object sender, MouseEventArgs e)
        {
            MoveForm(sender, e);
        }

        private void MoveForm(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }
    }
}
