using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoIT
{
    public partial class frmLogin : Form
    {
        List<User> users = new List<User>();
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
            // Not filled out yet!
            return false;
        }

        private void RegisterUser(string username, string password)
        {
            var user = new User();
            user.setUsername(username);
            user.setPassword(password);
            //user.AddCalendar();
            users.Add(user);
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            scSplitContainer.BackgroundImageLayout = ImageLayout.Stretch;
        }
    }
}
