using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CoffeeNegraWinForms.Forms;

namespace CoffeeNegraWinForms
{
    public partial class Form1 : Form
    {
        Form _branchForm = new BranchForm();
        Form _employeesForm = new EmployeesForm();
        Form _currentForm = null;

        public Form1()
        {
            InitializeComponent();
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            setCurrentForm();
            _currentForm = _branchForm;
            _branchForm.MdiParent = this;
            _branchForm.Show();
        }

        private void btnEmployees_Click(object sender, EventArgs e)
        {
            setCurrentForm();
            _currentForm = _employeesForm;
            _employeesForm.MdiParent = this;
            _employeesForm.Show();
        }

        private void setCurrentForm()
        {
            if (_currentForm != null)
            {
                _currentForm.MdiParent = null;
            }
        }
    }
}
