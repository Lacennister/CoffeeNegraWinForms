using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CoffeeNegraWinForms.Class;

namespace CoffeeNegraWinForms.Forms
{
    public partial class EmployeesManagerForm : Form
    {

        public Employee EmployeeInfo { get; set; }

        public EmployeesManagerForm()
        {
            InitializeComponent();
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.EmployeesManagerForm_MouseDown);
        }

        #region FORM_MOVE
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        private void EmployeesManagerForm_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }
        #endregion

        private void EmployeesManagerForm_Load(object sender, EventArgs e)
        {
            txtFullname.Text = EmployeeInfo.name;

            if (EmployeeInfo.birthday != null)
            {
                CultureInfo cultures = new CultureInfo("en-US");
                dtBirthday.Value = Convert.ToDateTime(EmployeeInfo.birthday, cultures);
            }

            txtAddress.Text = EmployeeInfo.address;

            if (EmployeeInfo.age > 0)
            {
                numAge.Value = EmployeeInfo.age;
            }

            txtContact.Text = EmployeeInfo.contact;

            if (EmployeeInfo.morning != null)
            {
                cbMondayMorning.Checked = EmployeeInfo.morning.Monday;
                cbTuesdayMorning.Checked = EmployeeInfo.morning.Tuesday;
                cbWednesdayMorning.Checked = EmployeeInfo.morning.Wednesday;
                cbThursdayMorning.Checked = EmployeeInfo.morning.Thursday;
                cbFridayMorning.Checked = EmployeeInfo.morning.Friday;
                cbSaturdayMorning.Checked = EmployeeInfo.morning.Saturday;
                cbSundayMorning.Checked = EmployeeInfo.morning.Sunday;
            }

            if (EmployeeInfo.afternoon != null)
            {
                cbMondayAfternoon.Checked = EmployeeInfo.afternoon.Monday;
                cbTuesdayAfternoon.Checked = EmployeeInfo.afternoon.Tuesday;
                cbWednesdayAfternoon.Checked = EmployeeInfo.afternoon.Wednesday;
                cbThursdayAfternoon.Checked = EmployeeInfo.afternoon.Thursday;
                cbFridayAfternoon.Checked = EmployeeInfo.afternoon.Friday;
                cbSaturdayAfternoon.Checked = EmployeeInfo.afternoon.Saturday;
                cbSundayAfternoon.Checked = EmployeeInfo.afternoon.Sunday;
            }
            
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void btnDone_Click(object sender, EventArgs e)
        {
            EmployeeInfo.name = txtFullname.Text;
            EmployeeInfo.birthday = dtBirthday.Value.ToString("MM-dd-yyyy");
            EmployeeInfo.address = txtAddress.Text;
            EmployeeInfo.age = (int)numAge.Value;
            EmployeeInfo.contact = txtContact.Text;

            TimeAvailability morning = new TimeAvailability() {
                Monday=cbMondayMorning.Checked,
                Tuesday=cbTuesdayMorning.Checked,
                Wednesday = cbWednesdayMorning.Checked,
                Thursday = cbThursdayMorning.Checked,
                Friday = cbFridayMorning.Checked,
                Saturday = cbSaturdayMorning.Checked,
                Sunday = cbSundayMorning.Checked,
            };

            TimeAvailability afternoon = new TimeAvailability()
            {
                Monday = cbMondayAfternoon.Checked,
                Tuesday = cbTuesdayAfternoon.Checked,
                Wednesday = cbWednesdayAfternoon.Checked,
                Thursday = cbThursdayAfternoon.Checked,
                Friday = cbFridayAfternoon.Checked,
                Saturday = cbSaturdayAfternoon.Checked,
                Sunday = cbSundayAfternoon.Checked,
            };

            EmployeeInfo.morning = morning;
            EmployeeInfo.afternoon = afternoon;

            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
