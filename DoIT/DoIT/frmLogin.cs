using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace DoIT
{
    public partial class FrmLogin : Form
    {
        // Move Form Variables.
        public const int WmNclbuttondown = 0xA1;
        public const int HtCaption = 0x2;

        public FrmLogin()
        {
            InitializeComponent();
        }

        [DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int msg, int wParam, int lParam);

        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        private void btnRegister_Click(object sender, EventArgs e)
        {
            var username = txbRegisterUsername.Text;
            var password1 = txbRegisterPassword.Text;
            var password2 = txbRegisterPasswordRepeat.Text;

            // Check if Passwords match
            if (CheckIfPasswordsMatch(password1, password2) == false)
            {
                return;
            }

            if (CheckIfUserExists(username))
            {
                return;
            }

            RegisterUser(txbRegisterUsername.Text, txbRegisterPassword.Text);

            Login(0, "", "");
        }

        // Methods
        private bool CheckIfPasswordsMatch(string pw1, string pw2)
        {
            var match = true;
            const string noMatchText = "The passwords you typed in do not match!";
            const string noMatchTitle = "Passwords do not match";

            if (!pw1.Equals(pw2))
            {
                match = false;
                MessageBox.Show(noMatchText, noMatchTitle);
            }

            return match;
        }

        private bool CheckIfUserExists(string username)
        {
            var exists = false;
            const string existsText = "A user with this username already exists. Please choose another username";
            const string existsTitle = "User exists";

            foreach (var user in Program.Users)
            {
                if (user.Username == username)
                {
                    exists = true;
                    MessageBox.Show(existsText, existsTitle);
                    break;
                }
            }

            return exists;
        }

        private static void RegisterUser(string username, string password)
        {
            var user = new User
            {
                Username = username,
                Password = password
            };
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

            // Load Screen for the user.
            var main = new FrmMain();
            main.Show();
            Hide();
        }

        // The following Methods contain the MoveForm function.
        private void scSplitContainer_Panel1_MouseDown(object sender, MouseEventArgs e)
        {
            MoveForm(e);
        }

        private void scSplitContainer_Panel2_MouseDown(object sender, MouseEventArgs e)
        {
            MoveForm(e);
        }

        private void pnlSignIn_MouseDown(object sender, MouseEventArgs e)
        {
            MoveForm(e);
        }

        private void pnlRegister_MouseDown(object sender, MouseEventArgs e)
        {
            MoveForm(e);
        }

        private void MoveForm(MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left) return;
            ReleaseCapture();
            SendMessage(Handle, WmNclbuttondown, HtCaption, 0);
        }
    }
}