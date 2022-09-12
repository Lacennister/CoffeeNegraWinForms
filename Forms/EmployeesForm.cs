using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CoffeeNegraWinForms.Class;
using CoffeeNegraWinForms.Forms;
using CoffeeNegraWinForms.Database;
using System.Globalization;

namespace CoffeeNegraWinForms.Forms
{
    public partial class EmployeesForm : Form
    {
        List<Employee> _employees = new List<Employee>();
        employees db = new employees();

        private bool isEditing = false;

        public EmployeesForm()
        {
            InitializeComponent();
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.EmployeesForm_MouseDown);
        }

        #region MOVE_FORM
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        private void EmployeesForm_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }
        #endregion

        private void EmployeesForm_Load(object sender, EventArgs e)
        {
            _employees = db.GetEmployees();

            dgvEmployees.Rows.Clear();

            foreach (Employee _employee in _employees)
            {
                dgvEmployees.Rows.Add(_employee.id, _employee.name, _employee.birthday, _employee.age, _employee.address, _employee.contact, _employee.timeAvailability.ToString());
            }
        }

        #region EMPLOYEES_CONTROLS

        private void btnAdd_Click(object sender, EventArgs e)
        {
            dgvEmployees.Rows.Add();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dgvEmployees.Rows.Count <= 0) return;

            isEditing = true;

            foreach (DataGridViewRow row in dgvEmployees.SelectedRows)
            {
                //using (EmployeesManagerForm _employeesManagerForm = new EmployeesManagerForm() { EmployeeInfo = new Employee() })
                //{
                //    if (_employeesManagerForm.ShowDialog() == DialogResult.OK)
                //    {
                //        Employee _employee = _employeesManagerForm.EmployeeInfo;
                //        dgvEmployees.Rows.Add(_employee.id, _employee.name, _employee.birthday, _employee.age, _employee.address, _employee.contact, _employee.timeAvailability.ToString());
                //    }
                //}

                break;
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvEmployees.Rows.Count <= 0) return;
            
            for (int i = dgvEmployees.Rows.Count - 1; dgvEmployees.Rows.Count > i; i--)
            {
                DataGridViewRow row = dgvEmployees.Rows[i];
                if (row.Selected)
                {
                    CustomDialogBox ask = new CustomDialogBox() { 
                        message_alert = "Do you want to delete this employee? \n" + row.Cells[1].Value.ToString() 
                    };

                    if (ask.ShowDialog() == DialogResult.Yes)
                    {
                        dgvEmployees.Rows.Remove(row);
                    }

                    break;
                }
            }
        }

        private void btnDone_Click(object sender, EventArgs e)
        {
            if (isEditing == false)
            {
                foreach (DataGridViewRow row in dgvEmployees.Rows)
                {
                    // IF ID IS NULL, MEANS THIS IS NEWLY ADDED, ASK IF WANT TO SAVE
                    if (row.Cells[0].Value == null || (int)row.Cells[0].Value == 0)
                    {
                        CustomDialogBox ask = new CustomDialogBox()
                        {
                            message_alert = "Do you want to save this employee? " + row.Cells[1].Value
                        };

                        if (ask.ShowDialog() == DialogResult.Yes)
                        {
                            // SAVE TO DATABASE
                            Employee _employee = new Employee();
                            _employee.name = row.Cells[1].Value.ToString();
                            _employee.birthday = row.Cells[2].Value.ToString();
                            _employee.age = Convert.ToInt32(row.Cells[3].Value);
                            _employee.address = row.Cells[4].Value.ToString();
                            _employee.contact = row.Cells[5].Value.ToString();

                            TimeAvailability _timeAvailability = new TimeAvailability();
                            _timeAvailability.ParseFromString(row.Cells[6].Value.ToString());
                            _employee.timeAvailability = _timeAvailability;

                            db.InsertEmployee(_employee);

                            MessageBox.Show("Done Saving!");
                        }
                    }
                }
            }
            else
            {
                foreach (DataGridViewRow row in dgvEmployees.SelectedRows)
                {
                    foreach (Employee _employee in _employees)
                    {
                        int _dgvEmployeeID = (Int32)row.Cells[0].Value;

                        if (_dgvEmployeeID == _employee.id)
                        {

                        }
                    }

                    isEditing = false;
                    break;
                }
            }
            
        }
        private void btnAddViaForm_Click(object sender, EventArgs e)
        {
            using (EmployeesManagerForm _employeesManagerForm = new EmployeesManagerForm() { EmployeeInfo = new Employee() })
            {
                if (_employeesManagerForm.ShowDialog() == DialogResult.OK)
                {
                    Employee _employee = _employeesManagerForm.EmployeeInfo;
                    dgvEmployees.Rows.Add(_employee.id, _employee.name, _employee.birthday, _employee.age, _employee.address, _employee.contact, _employee.timeAvailability.ToString());
                }
            }
        }
        #endregion
    }
}
