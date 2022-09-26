using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CoffeeNegraWinForms.Database;
using CoffeeNegraWinForms.Class;
using CoffeeNegraWinForms.Forms;

namespace CoffeeNegraWinForms.Forms
{
    public partial class LoginForm : Form
    {
        public HomeForm _home;

        public LoginForm()
        {
            InitializeComponent();
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.LoginForm_MouseDown);
            this.txtPassword.KeyDown += new KeyEventHandler(this.Password_Keydown);
            this.txtUsername.KeyDown += new KeyEventHandler(this.Username_Keydown);
        }

        #region FORM_MOVE
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        private void LoginForm_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }
        #endregion

        private void LoginForm_Load(object sender, EventArgs e)
        {
            _home = new HomeForm();
        }

        private void Username_Keydown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                txtPassword.Focus();
            }
        }

        private void Password_Keydown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                btnLogin.PerformClick();
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            users _user = new users();

            User user = new User();
            user = _user.GetUser(txtUsername.Text, txtPassword.Text);

            if (user.username is null)
            {
                MessageBox.Show("Authentication failed. Username or password mismatch");
                txtPassword.Focus();
                return;
            }

            _home._currentUser = user;
            _home.Show();
            this.Hide();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnForgotPassword_Click(object sender, EventArgs e)
        {
            ForgotPasswordForm _form = new ForgotPasswordForm();
            _form.ShowDialog();
        }
    }
}
