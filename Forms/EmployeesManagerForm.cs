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

            TimeAvailability _timeAvailability = new TimeAvailability() {
                Monday=cbMonday.Checked,
                Tuesday=cbTuesday.Checked,
                Wednesday = cbWednesday.Checked,
                Thursday = cbThursday.Checked,
                Friday = cbFriday.Checked,
                Saturday = cbSaturday.Checked,
                Sunday = cbSunday.Checked,
            };

            EmployeeInfo.timeAvailability = _timeAvailability;

            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
