using System;
using System.IO;
using System.Drawing;
using System.Drawing.Printing;
using System.Collections.Generic;
using System.Windows.Forms;
using Microsoft.VisualBasic.FileIO;
using CoffeeNegraWinForms.Class;
using CoffeeNegraWinForms.Database;
using iTextSharp.text.pdf;
using iTextSharp.text;

namespace CoffeeNegraWinForms.Forms
{
    public partial class ScheduleForm : Form
    {
        public int location_id { get; set; }

        public ScheduleForm()
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

        private void ScheduleForm_Load(object sender, EventArgs e)
        {
            dgvMorning.Rows.Clear();
            dgvAfternoon.Rows.Clear();

            employees _employees = new employees();
            List<Employee> AllEmployees = new List<Employee>(_employees.GetEmployees(location_id));

            foreach (Employee employee in AllEmployees)
            {
                if (employee.morning.ToString() != "N/A") 
                {
                    dgvMorning.Rows.Add(employee.morning.toShowOnDataGridView(employee.name));
                }

                if (employee.afternoon.ToString() != "N/A")
                {
                    dgvAfternoon.Rows.Add(employee.afternoon.toShowOnDataGridView(employee.name));
                }
            }
        }

        private void btnUpload_Click(object sender, EventArgs e)
        {
            string path = Path.Combine(Environment.CurrentDirectory, "schedules.csv");

            TextFieldParser parser = new TextFieldParser(path);
            parser.HasFieldsEnclosedInQuotes = true;
            parser.SetDelimiters(",");

            while (!parser.EndOfData)
            {
                string[] fields = parser.ReadFields();
                string employeeName = fields[0].Trim();
                string workShift = fields[1].Trim();
                string workDays = fields[2].Trim();

                TimeAvailability _availability = new TimeAvailability();
                _availability.ParseFromString(workDays);

                if (workShift == "0")
                {
                    dgvMorning.Rows.Add(_availability.toShowOnDataGridView(employeeName));
                }
                else
                {
                    dgvAfternoon.Rows.Add(_availability.toShowOnDataGridView(employeeName));
                }
            }
            parser.Close();
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            DialogResult confirm = MessageBox.Show("Do you want to generate report?", "Schedule Report", MessageBoxButtons.YesNo);
            if (confirm == DialogResult.No) { return; }
            if (dgvMorning.Rows.Count == 0) { MessageBox.Show("Unable to fetch data. Rows is currently empty"); return; }

            iTextSharp.text.Font FontH1 = new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 12, iTextSharp.text.Font.BOLD);
            iTextSharp.text.Font FontH2 = new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 8, iTextSharp.text.Font.BOLD, BaseColor.DARK_GRAY);
            iTextSharp.text.Font FontP = new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 11, iTextSharp.text.Font.NORMAL);

            PdfPTable pdfTable = new PdfPTable(dgvMorning.Columns.Count);
            pdfTable.WidthPercentage = 100;
            pdfTable.HorizontalAlignment = PdfPCell.ALIGN_CENTER;


            // MORNING SHIFT
            foreach (DataGridViewColumn column in dgvMorning.Columns)
            {
                PdfPCell cell = new PdfPCell(new Phrase(column.HeaderText, FontH1)) { PaddingTop = 7, PaddingBottom = 7 };
                cell.HorizontalAlignment = PdfPCell.ALIGN_CENTER;
                pdfTable.AddCell(cell);
            }
            foreach (string column in new string[] { "8:00 AM - 2:00 PM", "8:00 AM - 2:00 PM", "8:00 AM - 2:00 PM", "8:00 AM - 2:00 PM", "8:00 AM - 2:00 PM", "8:00 AM - 2:00 PM", "8:00 AM - 2:00 PM" })
            {
                PdfPCell cell = new PdfPCell(new Phrase(column, FontH2));
                cell.HorizontalAlignment = PdfPCell.ALIGN_CENTER;
                pdfTable.AddCell(cell);
            }

            foreach (DataGridViewRow row in dgvMorning.Rows)
            {
                foreach (DataGridViewCell cell in row.Cells)
                {
                    PdfPCell _cell = new PdfPCell(new Phrase("", FontP)) { PaddingTop = 7, PaddingBottom = 7, HorizontalAlignment = PdfPCell.ALIGN_CENTER };
                    if (cell.Value == null) 
                    {
                        pdfTable.AddCell(_cell);
                    }
                    else
                    {
                        _cell = new PdfPCell(new Phrase(cell.Value.ToString(), FontP)) { PaddingTop = 7, PaddingBottom = 7, HorizontalAlignment = PdfPCell.ALIGN_CENTER };
                        pdfTable.AddCell(_cell);
                    }
                }
            }

            // AFTERNOON SHIFT
            foreach (string column in new string[] { "2:00 PM - 8:00 PM", "2:00 PM - 8:00 PM", "2:00 PM - 8:00 PM", "2:00 PM - 8:00 PM", "2:00 PM - 8:00 PM", "2:00 PM - 8:00 PM", "2:00 PM - 8:00 PM" })
            {
                PdfPCell cell = new PdfPCell(new Phrase(column, FontH2));
                cell.HorizontalAlignment = PdfPCell.ALIGN_CENTER;
                pdfTable.AddCell(cell);
            }
            foreach (DataGridViewRow row in dgvAfternoon.Rows)
            {
                foreach (DataGridViewCell cell in row.Cells)
                {
                    PdfPCell _cell = new PdfPCell(new Phrase("", FontP)) { PaddingTop = 7, PaddingBottom = 7, HorizontalAlignment = PdfPCell.ALIGN_CENTER };
                    if (cell.Value == null)
                    {
                        pdfTable.AddCell(_cell);
                    }
                    else
                    {
                        _cell = new PdfPCell(new Phrase(cell.Value.ToString(), FontP)) { PaddingTop = 7, PaddingBottom = 7, HorizontalAlignment = PdfPCell.ALIGN_CENTER };
                        pdfTable.AddCell(_cell);
                    }
                }
            }

            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "PDF (*.pdf)|*.pdf";
            sfd.FileName = "schedule.pdf";

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
