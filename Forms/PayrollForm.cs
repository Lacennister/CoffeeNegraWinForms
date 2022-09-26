using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using CoffeeNegraWinForms.Class;
using iTextSharp.text;
using iTextSharp.text.pdf;

namespace CoffeeNegraWinForms.Forms
{
    public partial class PayrollForm : Form
    {
        public int location_id { get; set; }

        private class EmployeeTotalHours
        {
            public string EmployeeName;
            public double TotalWorkHours;
            public double TotalHolidayWorkHours;
        }

        public PayrollForm()
        {
            InitializeComponent();
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form_MouseDown);
        }

        #region FORM_MOVE
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        private void Form_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }
        #endregion

        private void PayrollForm_Load(object sender, EventArgs e)
        {
            string path = Path.Combine(Environment.CurrentDirectory, "stamaria_payroll.txt");

            if (location_id == 2)
            {
                path = Path.Combine(Environment.CurrentDirectory, "pulilan_payroll.txt");
            }

            string[] lines = File.ReadAllLines(path);
            Dictionary<int, EmployeeTotalHours> employee_dict = new Dictionary<int, EmployeeTotalHours>();

            if (lines.Length > 1)
            {
                for (int i = 0; i < lines.Length; i++)
                {
                    if (lines[i].Trim() == "") { continue; }

                    string[] fields = lines[i].Split('\t');

                    if (fields[0] == "location_id") { continue; }

                    CultureInfo cultures = new CultureInfo("en-US");
                    DateTime time_in = Convert.ToDateTime(fields[3], cultures);
                    DateTime time_out = Convert.ToDateTime(fields[4], cultures);

                    TimeSpan _time = time_out.Subtract(time_in);

                    EmployeeTotalHours _employeeHours = new EmployeeTotalHours()
                    {
                        EmployeeName = fields[2],
                        TotalWorkHours = _time.TotalHours,
                        TotalHolidayWorkHours = 0,
                    };

                    // CHECK IF WORKED ON HOLIDAY
                    if (IsHoliday(time_in))
                    {
                        _employeeHours.TotalHolidayWorkHours = _time.TotalHours;
                    }
                    

                    int employee_id = Convert.ToInt16(fields[1]);
                    if (employee_dict.ContainsKey(employee_id) == false)
                    {
                        employee_dict.Add(employee_id, _employeeHours);
                    }
                    else
                    {
                        employee_dict[employee_id].TotalWorkHours += _time.TotalHours;

                        // CHECK IF WORKED ON HOLIDAY
                        if (IsHoliday(time_in))
                        {
                            employee_dict[employee_id].TotalHolidayWorkHours = _time.TotalHours;
                        }
                    }
                }

                foreach (KeyValuePair<int, EmployeeTotalHours> _e in employee_dict)
                {
                    dgvPayroll.Rows.Add(_e.Value.EmployeeName, _e.Value.TotalWorkHours, "", "", "", "", _e.Value.TotalHolidayWorkHours);
                }
            }
        }

        private bool IsHoliday(DateTime time_in)
        {
            DateTime[] ph_holidays = new DateTime[]
{
                new DateTime(DateTime.Today.Year, 01, 01),
                new DateTime(DateTime.Today.Year, 12, 25),
                new DateTime(DateTime.Today.Year, 12, 30)
            };

            foreach (DateTime ph_holiday in ph_holidays)
            {
                if (ph_holiday.ToString("MM-dd") == time_in.ToString("MM-dd"))
                {
                    return true;
                }
            }

            return false;
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dgvPayroll.Rows)
            {
                int total_holiday_work_hours = Convert.ToInt32(row.Cells[6].Value);
                int total_work_hours = Convert.ToInt32(row.Cells[1].Value);
                int basic_pay = GetBasicPay(total_work_hours);
                int holiday_pay = GetHolidayPay(total_holiday_work_hours);
                decimal total_deduction = GetTotalDeduction(basic_pay);
                decimal salary_net = basic_pay + holiday_pay - total_deduction;

                row.Cells[2].Value = basic_pay;
                row.Cells[3].Value = holiday_pay;
                row.Cells[4].Value = total_deduction;
                row.Cells[5].Value = salary_net;
            }
        }

        private void btnEditDeduction_Click(object sender, EventArgs e)
        {
            DeductionForm _deductionForm = new DeductionForm();
            _deductionForm.ShowDialog();
        }

        private int GetHolidayPay(int total_holiday_work_hours)
        {
            int salary_per_hour = Convert.ToInt32(txtSalaryPerHour.Text);
            int holiday_pay = salary_per_hour * 2 * total_holiday_work_hours;
            return holiday_pay;
        }

        private int GetBasicPay(int total_work_hours)
        {
            int salary_per_hour = Convert.ToInt32(txtSalaryPerHour.Text);
            int basic_pay = salary_per_hour * total_work_hours;
            return basic_pay;
        }

        private decimal GetTotalDeduction(int basic_pay)
        {
            Deduction deductionClass = new Deduction();

            List<Deduction> _deductions = new List<Deduction>();

            _deductions = deductionClass.GetAll();

            decimal total_deductions = 0;

            foreach (Deduction _deduct in _deductions)
            {
                if (_deduct.value == "") continue;

                decimal value;

                if (_deduct.value.Contains("%"))
                {
                    string strValue = _deduct.value.Replace("%", "");
                    value = Convert.ToDecimal(strValue) / 100;
                    total_deductions += basic_pay * value;
                }
                else if(decimal.TryParse(_deduct.value, out value))
                {
                    total_deductions += value;
                }
            }

            return total_deductions;
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            DialogResult confirm = MessageBox.Show("Do you want to generate report?", "Schedule Report", MessageBoxButtons.YesNo);
            if (confirm == DialogResult.No) { return; }
            if (dgvPayroll.Rows.Count == 0) { MessageBox.Show("Unable to fetch data. Rows is currently empty"); return; }

            Font FontH1 = new Font(iTextSharp.text.Font.FontFamily.HELVETICA, 12, iTextSharp.text.Font.BOLD);
            Font FontP = new Font(iTextSharp.text.Font.FontFamily.HELVETICA, 11, iTextSharp.text.Font.NORMAL);

            PdfPTable pdfTable = new PdfPTable(dgvPayroll.Columns.Count);
            pdfTable.WidthPercentage = 100;
            pdfTable.HorizontalAlignment = PdfPCell.ALIGN_CENTER;

            foreach (DataGridViewColumn column in dgvPayroll.Columns)
            {
                PdfPCell cell = new PdfPCell(new Phrase(column.HeaderText, FontH1)) { PaddingTop=7,PaddingBottom=7};
                cell.HorizontalAlignment = PdfPCell.ALIGN_CENTER;
                pdfTable.AddCell(cell);
            }

            foreach (DataGridViewRow row in dgvPayroll.Rows)
            {
                foreach (DataGridViewCell cell in row.Cells)
                {
                    PdfPCell _cell = new PdfPCell(new Phrase(cell.Value.ToString(), FontP)) { Padding=5 };
                    _cell.HorizontalAlignment = PdfPCell.ALIGN_CENTER;

                    pdfTable.AddCell(_cell);
                }
            }

            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "PDF (*.pdf)|*.pdf";
            sfd.FileName = "payroll.pdf";

            if (sfd.ShowDialog() == DialogResult.OK)
            {
                using (FileStream stream = new FileStream(sfd.FileName, FileMode.Create))
                {
                    Document pdfDoc = new Document(PageSize.A4, 10f, 20f, 20f, 10f);
                    PdfWriter.GetInstance(pdfDoc, stream);
                    pdfDoc.Open();
                    pdfDoc.Add(pdfTable);
                    pdfDoc.Close();
                    stream.Close();
                }
                MessageBox.Show("Data extracted successfully!");
            }
        }

    }
}
