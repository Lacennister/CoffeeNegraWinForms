using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CoffeeNegraWinForms.Forms
{
    public partial class HomeForm : Form
    {
        public HomeForm()
        {
            InitializeComponent();
            this.SidebarPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.SidebarPanel_MouseDown);
        }

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


        #region FORM_DECLARATIONS
        BranchForm _branchForm = new BranchForm();
        EmployeesForm _employeesForm = new EmployeesForm();
        ScheduleForm _scheduleForm = new ScheduleForm();
        public object _currentForm = null;
        #endregion

        private void btnLocation_Click(object sender, EventArgs e)
        {

        }

        private void btnStaMaria_Click(object sender, EventArgs e)
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

        private void btnPulilan_Click(object sender, EventArgs e)
        {

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
            }
        }

        private void btnSchedule_Click(object sender, EventArgs e)
        {

        }
    }
}
