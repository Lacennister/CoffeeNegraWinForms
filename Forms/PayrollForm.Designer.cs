
namespace CoffeeNegraWinForms.Forms
{
    partial class PayrollForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnPrint = new Guna.UI2.WinForms.Guna2Button();
            this.btnCalculate = new Guna.UI2.WinForms.Guna2Button();
            this.dgvPayroll = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSalaryPerHour = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnEditDeduction = new Guna.UI2.WinForms.Guna2Button();
            this.employee = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.total_work_hours = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Basic = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Holiday = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.total_deduction = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.total_salary = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalHolidayHours = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPayroll)).BeginInit();
            this.SuspendLayout();
            // 
            // btnPrint
            // 
            this.btnPrint.BackColor = System.Drawing.Color.Transparent;
            this.btnPrint.BorderRadius = 5;
            this.btnPrint.BorderThickness = 1;
            this.btnPrint.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnPrint.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnPrint.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnPrint.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnPrint.FillColor = System.Drawing.Color.NavajoWhite;
            this.btnPrint.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnPrint.ForeColor = System.Drawing.Color.Black;
            this.btnPrint.Location = new System.Drawing.Point(636, 338);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(100, 35);
            this.btnPrint.TabIndex = 3;
            this.btnPrint.Text = "Print";
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // btnCalculate
            // 
            this.btnCalculate.BackColor = System.Drawing.Color.Transparent;
            this.btnCalculate.BorderRadius = 5;
            this.btnCalculate.BorderThickness = 1;
            this.btnCalculate.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnCalculate.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnCalculate.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnCalculate.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnCalculate.FillColor = System.Drawing.Color.NavajoWhite;
            this.btnCalculate.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnCalculate.ForeColor = System.Drawing.Color.Black;
            this.btnCalculate.Location = new System.Drawing.Point(12, 338);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(119, 35);
            this.btnCalculate.TabIndex = 2;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // dgvPayroll
            // 
            this.dgvPayroll.AllowUserToAddRows = false;
            this.dgvPayroll.AllowUserToDeleteRows = false;
            this.dgvPayroll.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPayroll.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvPayroll.BackgroundColor = System.Drawing.Color.Linen;
            this.dgvPayroll.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvPayroll.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.NavajoWhite;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 7.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPayroll.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvPayroll.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPayroll.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.employee,
            this.total_work_hours,
            this.Basic,
            this.Holiday,
            this.total_deduction,
            this.total_salary,
            this.TotalHolidayHours});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvPayroll.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvPayroll.EnableHeadersVisualStyles = false;
            this.dgvPayroll.Location = new System.Drawing.Point(12, 49);
            this.dgvPayroll.MultiSelect = false;
            this.dgvPayroll.Name = "dgvPayroll";
            this.dgvPayroll.ReadOnly = true;
            this.dgvPayroll.RowHeadersVisible = false;
            this.dgvPayroll.RowHeadersWidth = 51;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.Linen;
            dataGridViewCellStyle3.Padding = new System.Windows.Forms.Padding(0, 5, 0, 5);
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPayroll.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvPayroll.RowTemplate.Height = 24;
            this.dgvPayroll.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgvPayroll.Size = new System.Drawing.Size(724, 283);
            this.dgvPayroll.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(432, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 23);
            this.label1.TabIndex = 14;
            this.label1.Text = "Salary per hour :";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtSalaryPerHour
            // 
            this.txtSalaryPerHour.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSalaryPerHour.Location = new System.Drawing.Point(574, 11);
            this.txtSalaryPerHour.Name = "txtSalaryPerHour";
            this.txtSalaryPerHour.Size = new System.Drawing.Size(57, 27);
            this.txtSalaryPerHour.TabIndex = 15;
            this.txtSalaryPerHour.Text = "52";
            this.txtSalaryPerHour.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(637, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 19);
            this.label3.TabIndex = 18;
            this.label3.Text = "php";
            // 
            // btnEditDeduction
            // 
            this.btnEditDeduction.BackColor = System.Drawing.Color.Transparent;
            this.btnEditDeduction.BorderRadius = 5;
            this.btnEditDeduction.BorderThickness = 1;
            this.btnEditDeduction.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnEditDeduction.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnEditDeduction.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnEditDeduction.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnEditDeduction.FillColor = System.Drawing.Color.NavajoWhite;
            this.btnEditDeduction.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnEditDeduction.ForeColor = System.Drawing.Color.Black;
            this.btnEditDeduction.Location = new System.Drawing.Point(137, 338);
            this.btnEditDeduction.Name = "btnEditDeduction";
            this.btnEditDeduction.Size = new System.Drawing.Size(153, 35);
            this.btnEditDeduction.TabIndex = 20;
            this.btnEditDeduction.Text = "Edit Deduction";
            this.btnEditDeduction.Click += new System.EventHandler(this.btnEditDeduction_Click);
            // 
            // employee
            // 
            this.employee.HeaderText = "Employee";
            this.employee.MinimumWidth = 6;
            this.employee.Name = "employee";
            this.employee.ReadOnly = true;
            // 
            // total_work_hours
            // 
            this.total_work_hours.HeaderText = "Total Work Hours";
            this.total_work_hours.MinimumWidth = 6;
            this.total_work_hours.Name = "total_work_hours";
            this.total_work_hours.ReadOnly = true;
            // 
            // Basic
            // 
            this.Basic.HeaderText = "Basic";
            this.Basic.MinimumWidth = 6;
            this.Basic.Name = "Basic";
            this.Basic.ReadOnly = true;
            // 
            // Holiday
            // 
            this.Holiday.HeaderText = "Holiday";
            this.Holiday.MinimumWidth = 6;
            this.Holiday.Name = "Holiday";
            this.Holiday.ReadOnly = true;
            // 
            // total_deduction
            // 
            this.total_deduction.HeaderText = "Total Deduction";
            this.total_deduction.MinimumWidth = 6;
            this.total_deduction.Name = "total_deduction";
            this.total_deduction.ReadOnly = true;
            // 
            // total_salary
            // 
            this.total_salary.HeaderText = "Total Salary";
            this.total_salary.MinimumWidth = 6;
            this.total_salary.Name = "total_salary";
            this.total_salary.ReadOnly = true;
            // 
            // TotalHolidayHours
            // 
            this.TotalHolidayHours.HeaderText = "TotalHolidayHours";
            this.TotalHolidayHours.MinimumWidth = 6;
            this.TotalHolidayHours.Name = "TotalHolidayHours";
            this.TotalHolidayHours.ReadOnly = true;
            this.TotalHolidayHours.Visible = false;
            // 
            // PayrollForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Linen;
            this.ClientSize = new System.Drawing.Size(748, 385);
            this.Controls.Add(this.btnEditDeduction);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtSalaryPerHour);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvPayroll);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.btnCalculate);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PayrollForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PayrollForm";
            this.Load += new System.EventHandler(this.PayrollForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPayroll)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button btnPrint;
        private Guna.UI2.WinForms.Guna2Button btnCalculate;
        private System.Windows.Forms.DataGridView dgvPayroll;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSalaryPerHour;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2Button btnEditDeduction;
        private System.Windows.Forms.DataGridViewTextBoxColumn employee;
        private System.Windows.Forms.DataGridViewTextBoxColumn total_work_hours;
        private System.Windows.Forms.DataGridViewTextBoxColumn Basic;
        private System.Windows.Forms.DataGridViewTextBoxColumn Holiday;
        private System.Windows.Forms.DataGridViewTextBoxColumn total_deduction;
        private System.Windows.Forms.DataGridViewTextBoxColumn total_salary;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalHolidayHours;
    }
}