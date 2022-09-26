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
        public int location_id { get; set; }

        List<Employee> _employees = new List<Employee>();
        employees db = new employees();

        public EmployeesForm()
        {
            InitializeComponent();
            this.MouseDown += new MouseEventHandler(this.EmployeesForm_MouseDown);
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
            UpdateDatagridView();
        }

        private void UpdateDatagridView()
        {
            _employees = db.GetEmployees(location_id);

            dgvEmployees.Rows.Clear();
            foreach (Employee _employee in _employees)
            {
                dgvEmployees.Rows.Add(
                    _employee.id, 
                    _employee.name, 
                    _employee.birthday, 
                    _employee.age, 
                    _employee.address, 
                    _employee.contact, 
                    _employee.timeAvailability.ToString(),
                    _employee.morning.ToString(),
                    _employee.afternoon.ToString()
                    );
            }
        }

        private void txtSearchEmployee_TextChanged(object sender, EventArgs e)
        {
            if (txtSearchEmployee.Text == "")
            {
                UpdateDatagridView();
            }
            else
            {
                _employees = db.GetEmployees(location_id, txtSearchEmployee.Text);

                dgvEmployees.Rows.Clear();
                foreach (Employee _employee in _employees)
                {
                    dgvEmployees.Rows.Add(
                        _employee.id,
                        _employee.name,
                        _employee.birthday,
                        _employee.age,
                        _employee.address,
                        _employee.contact,
                        _employee.timeAvailability.ToString(),
                        _employee.morning.ToString(),
                        _employee.afternoon.ToString()
                        );
                }
            }
        }

        #region EMPLOYEES_CONTROLS

        private void btnAdd_Click(object sender, EventArgs e)
        {
            using (EmployeesManagerForm _employeesManagerForm = new EmployeesManagerForm() { EmployeeInfo = new Employee() })
            {
                if (_employeesManagerForm.ShowDialog() == DialogResult.OK)
                {
                    Employee _employee = _employeesManagerForm.EmployeeInfo;
                    dgvEmployees.Rows.Add(
                        _employee.id, 
                        _employee.name, 
                        _employee.birthday, 
                        _employee.age, 
                        _employee.address, 
                        _employee.contact, 
                        "N/A", 
                        _employee.morning.ToString(), 
                        _employee.afternoon.ToString()
                    );
                }
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dgvEmployees.SelectedRows)
            {
                using (EmployeesManagerForm _employeesManagerForm = new EmployeesManagerForm())
                {
                    Employee _employee = GetEmployeeFromDatagridview(row);
                    _employeesManagerForm.EmployeeInfo = _employee;

                    if (_employeesManagerForm.ShowDialog() == DialogResult.OK)
                    {
                        row.Cells[0].Value = _employee.id;
                        row.Cells[1].Value = _employee.name;
                        row.Cells[2].Value = _employee.birthday;
                        row.Cells[3].Value = _employee.age;
                        row.Cells[4].Value = _employee.address;
                        row.Cells[5].Value = _employee.contact;

                        row.Cells[7].Value = _employee.morning.ToString();
                        row.Cells[8].Value = _employee.afternoon.ToString();
                    }
                }

                break;
            }


        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvEmployees.Rows.Count <= 0) return;

            bool SuccessArchived = false;
            
            for (int i = dgvEmployees.Rows.Count - 1; i >= 0; i--)
            {
                DataGridViewRow row = dgvEmployees.Rows[i];
                if (row.Selected)
                {
                    CustomDialogBox ask = new CustomDialogBox() { 
                        message_alert = "Do you want to delete this employee? \n" + row.Cells[1].Value.ToString() 
                    };

                    if (ask.ShowDialog() == DialogResult.Yes)
                    {
                        int employee_id = (Int32)row.Cells[0].Value;
                        db.ArchiveEmployee(employee_id);

                        SuccessArchived = true;
                    }
                }
            }

            if (SuccessArchived)
            {
                UpdateDatagridView();
            }
        }

        private void btnDone_Click(object sender, EventArgs e)
        {
            bool isSaved = false;

            foreach (DataGridViewRow row in dgvEmployees.Rows)
            {
                try
                {
                    Employee _employee = GetEmployeeFromDatagridview(row);

                    if (EmployeeWasUpdated(_employee) || IsEmployeeExist(_employee) == false)
                    {
                        CustomDialogBox ask = new CustomDialogBox()
                        {
                            message_alert = "Do you want to save this employee? \n" + row.Cells[1].Value
                        };

                        if (ask.ShowDialog() == DialogResult.Yes)
                        {
                            db.InsertEmployee(_employee, location_id);
                            isSaved = true;
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }

            if (isSaved) 
            {
                UpdateDatagridView();
                MessageBox.Show("Done Saving!");
            }
        }

        private bool IsEmployeeExist(Employee _employee)
        {
            foreach (Employee employee in _employees)
            {
                if (employee.id == _employee.id)
                {
                    return true;
                }
            }
            return false;
        }

        private bool EmployeeWasUpdated(Employee _employee)
        {
            foreach (Employee employee in _employees)
            {
                if (employee.id == _employee.id)
                {
                    if (employee.name != _employee.name) return true;
                    if (employee.age != _employee.age) return true;
                    if (employee.birthday != _employee.birthday) return true;
                    if (employee.contact != _employee.contact) return true;
                    if (employee.address != _employee.address) return true;
                    if (employee.timeAvailability.ToString() != _employee.timeAvailability.ToString()) return true;
                    if (employee.morning.ToString() != _employee.morning.ToString()) return true;
                    if (employee.afternoon.ToString() != _employee.afternoon.ToString()) return true;
                }
            }
            return false;
        }

        private Employee GetEmployeeFromDatagridview(DataGridViewRow row)
        {
            Employee _employee = new Employee();
            _employee.id = Convert.ToInt32(row.Cells[0].Value);
            _employee.name = (string)row.Cells[1].Value;
            _employee.birthday = (string)row.Cells[2].Value;
            _employee.age = Convert.ToInt32(row.Cells[3].Value);
            _employee.address = (string)row.Cells[4].Value;
            _employee.contact = (string)row.Cells[5].Value;

            if (_employee.name == "" || _employee.name is null)
            {
                throw new Exception("Employee name cannot be blank");
            }

            TimeAvailability _timeAvailability = new TimeAvailability();
            string avail = "";

            if (row.Cells[6].Value != null)
            {
                avail = (string)row.Cells[6].Value;

                bool isValid = _timeAvailability.ParseFromString(avail);
                if (isValid == false)
                {
                    throw new Exception("Time availability you provided was unable to parse. Please use correct format like Monday, Tuesday, Wednesday etc.");
                }
            }
            _employee.timeAvailability = _timeAvailability;

            _timeAvailability = new TimeAvailability();
            _timeAvailability.ParseFromString(Convert.ToString(row.Cells[7].Value));
            _employee.morning = _timeAvailability;

            _timeAvailability = new TimeAvailability();
            _timeAvailability.ParseFromString(Convert.ToString(row.Cells[8].Value));
            _employee.afternoon = _timeAvailability;

            return _employee;
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
