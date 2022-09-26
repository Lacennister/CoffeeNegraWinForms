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
    public partial class CreateUserForm : Form
    {
        public CreateUserForm()
        {
            InitializeComponent();
        }

        private void btnCreateAccount_Click(object sender, EventArgs e)
        {
            DateTime dt = new DateTime();

            if (txtBirthdate.Text != "")
            {
                if (DateTime.TryParse(txtBirthdate.Text, out dt) == false) 
                {
                    MessageBox.Show("Unable to parse birth date. Please check");
                    return;
                }
            }
            else
            {
                MessageBox.Show("Birth date cannot be blank.");
                return;
            }

            string password = txtPassword.Text;
            string confirm_password = txtConfirmPassword.Text;

            if (password == "")
            {
                MessageBox.Show("Password is empty");
                return;
            }

            if (password != confirm_password)
            {
                MessageBox.Show("Password is not match to confirm password");
                return;
            }

            string username = txtUsername.Text;
            if (username == "")
            {
                MessageBox.Show("Username is required");
                return;
            }

            try
            {
                users user = new users();
                user.InsertUser(username, password, txtFirstname.Text, txtLastname.Text, dt);
                MessageBox.Show("New account was created successfully.");
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
