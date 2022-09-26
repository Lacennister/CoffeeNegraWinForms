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

namespace CoffeeNegraWinForms.Forms
{
    public partial class ForgotPasswordForm : Form
    {
        public ForgotPasswordForm()
        {
            InitializeComponent();
        }

        private void btnVerify_Click(object sender, EventArgs e)
        {
            users user = new users();

            if (txtUsername.Text == "")
            {
                MessageBox.Show("Username is empty");
                return;
            }

            DateTime birthday = dtBirthday.Value;

            if (user.VerifyAccount(txtUsername.Text, birthday))
            {
                gbPassword.Enabled = true;
            }
            else
            {
                MessageBox.Show("Unable to verify the account. Username or birthday not match");
                gbPassword.Enabled = false;
            }
        }

        private void btnChangePassword_Click(object sender, EventArgs e)
        {
            users user = new users();

            string username = txtUsername.Text;
            DateTime birthday = dtBirthday.Value;

            string new_password = txtNewPassword.Text;
            string confirm_password = txtConfirmPassword.Text;

            if (new_password != confirm_password)
            {
                MessageBox.Show("New password is not match to confirm password"); 
                return;
            }

            if (user.ChangePassword(new_password, username, birthday))
            {
                MessageBox.Show("Password successfully changed!");
                this.Close();
            }
        }
    }
}
