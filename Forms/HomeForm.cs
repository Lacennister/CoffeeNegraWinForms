using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Guna.UI2.WinForms;
using CoffeeNegraWinForms.Class;
using System.Globalization;

namespace CoffeeNegraWinForms.Forms
{
    public partial class HomeForm : Form
    {
        public User _currentUser { get; set; }

        public HomeForm()
        {
            InitializeComponent();
            this.SidebarPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.SidebarPanel_MouseDown);
        }

        #region FORM_MOVE
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        private void SidebarPanel_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }
        #endregion

        #region FORM_DECLARATIONS

        public LoginForm _loginForm;
        public Guna2Button _activeButton;
        public Guna2Button _activeBranch;
        public object _currentForm = null;

        #endregion

        private void HomeForm_Load(object sender, EventArgs e)
        {
            string welcomeUserName = "";

            if (_currentUser.firstname == "" && _currentUser.lastname == "")
            {
                welcomeUserName = _currentUser.username;
            }
            else
            {
                welcomeUserName = _currentUser.firstname;
            }

            TextInfo textInfo = new CultureInfo("en-US", false).TextInfo;
            lblWelcome.Text = "Welcome " + textInfo.ToTitleCase(welcomeUserName) + "!";
            _loginForm = new LoginForm();
        }

        private void btnLocation_Click(object sender, EventArgs e)
        {
            SetActiveButton((Guna2Button)sender);

            btnStaMaria.Location = new Point(3, 140);
            btnStaMaria.Visible = true;

            btnPulilan.Location = new Point(3, 178);
            btnPulilan.Visible = true;
        }

        private void btnStaMaria_Click(object sender, EventArgs e)
        {
            setCurrentForm();
            SetActiveButton((Guna2Button)sender);

            BranchForm _branchForm = new BranchForm() { branchName = "Sta. Maria" };

            _currentForm = _branchForm;
            _branchForm.MdiParent = this;
            _branchForm.Show();

            btnEmployees.Location = new Point(3, 178);
            btnEmployees.Visible = true;

            btnSchedule.Visible = false;
            btnPayroll.Visible = false;

            btnPulilan.Location = new Point(3, 216);

            _activeBranch = btnStaMaria;
        }

        private void btnEmployees_Click(object sender, EventArgs e)
        {
            setCurrentForm();
            SetActiveButton((Guna2Button)sender);

            EmployeesForm _employeesForm = new EmployeesForm();

            if (_activeBranch == btnStaMaria)
            {
                _employeesForm.location_id = 1;
                btnSchedule.Location = new Point(3, 216);
                btnPayroll.Location = new Point(3, 254);
                btnPulilan.Location = new Point(3, 292);
            }
            else if (_activeBranch == btnPulilan)
            {
                _employeesForm.location_id = 2;
                btnSchedule.Location = new Point(3, 254);
                btnPayroll.Location = new Point(3, 292);
            }

            btnSchedule.Visible = true;
            btnPayroll.Visible = true;

            _currentForm = _employeesForm;
            _employeesForm.MdiParent = this;
            _employeesForm.Show();
        }

        private void btnPulilan_Click(object sender, EventArgs e)
        {
            setCurrentForm();
            SetActiveButton((Guna2Button)sender);

            BranchForm _branchForm = new BranchForm() { branchName = "Pulilan" };

            _currentForm = _branchForm;
            _branchForm.MdiParent = this;
            _branchForm.Show();

            btnPulilan.Location = new Point(3, 178);

            btnEmployees.Location = new Point(3, 216);
            btnEmployees.Visible = true;

            btnSchedule.Visible = false;
            btnPayroll.Visible = false;

            _activeBranch = btnPulilan;
        }

        private void setCurrentForm()
        {
            if (_currentForm != null)
            {
                if(_currentForm.GetType() == typeof(BranchForm))
                {
                    BranchForm _form = (BranchForm)_currentForm;
                    _form.MdiParent = null;
                    _form.Hide();
                }
                if (_currentForm.GetType() == typeof(EmployeesForm))
                {
                    EmployeesForm _form = (EmployeesForm)_currentForm;
                    _form.MdiParent = null;
                    _form.Hide();
                }
                if (_currentForm.GetType() == typeof(ScheduleForm))
                {
                    ScheduleForm _form = (ScheduleForm)_currentForm;
                    _form.MdiParent = null;
                    _form.Hide();
                }
                if (_currentForm.GetType() == typeof(PayrollForm))
                {
                    PayrollForm _form = (PayrollForm)_currentForm;
                    _form.MdiParent = null;
                    _form.Hide();
                }
            }
        }

        private void btnSchedule_Click(object sender, EventArgs e)
        {
            ScheduleForm _scheduleForm = new ScheduleForm();

            if (_currentForm == _scheduleForm) return;
            setCurrentForm();
            SetActiveButton((Guna2Button)sender);

            if (_activeBranch == btnStaMaria)
            {
                _scheduleForm.location_id = 1;
            }
            else if (_activeBranch == btnPulilan)
            {
                _scheduleForm.location_id = 2;
            }

            _currentForm = _scheduleForm;
            _scheduleForm.MdiParent = this;
            _scheduleForm.Show();
        }

        private void btnPayroll_Click(object sender, EventArgs e)
        {
            PayrollForm _payrollForm = new PayrollForm();

            if (_currentForm == _payrollForm) return;
            setCurrentForm();
            SetActiveButton((Guna2Button)sender);

            if (_activeBranch == btnStaMaria)
            {
                _payrollForm.location_id = 1;
            }
            else if (_activeBranch == btnPulilan)
            {
                _payrollForm.location_id = 2;
            }

            _currentForm = _payrollForm;
            _payrollForm.MdiParent = this;
            _payrollForm.Show();
        }

        private void SetActiveButton(Guna2Button button)
        {
            if (_activeButton == button) return;

            button.FillColor = Color.NavajoWhite;
            if (_activeButton != null) _activeButton.FillColor = Color.Linen;
            _activeButton = button;
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to logout?", "Logout", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                this.Close();
                _loginForm.Show();
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnCreateAccount_Click(object sender, EventArgs e)
        {
            CreateUserForm _form = new CreateUserForm();
            _form.ShowDialog();
        }
    }
}
