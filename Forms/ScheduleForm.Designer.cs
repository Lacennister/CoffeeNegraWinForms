
namespace CoffeeNegraWinForms.Forms
{
    partial class ScheduleForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnDone = new Guna.UI2.WinForms.Guna2Button();
            this.btnEdit = new Guna.UI2.WinForms.Guna2Button();
            this.btnAdd = new Guna.UI2.WinForms.Guna2Button();
            this.dgvScheduleMorning = new System.Windows.Forms.DataGridView();
            this.monday = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tuesday = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.wednesday = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.thursday = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.friday = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.saturday = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sunday = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvScheduleMorning)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnDone);
            this.panel1.Controls.Add(this.btnEdit);
            this.panel1.Controls.Add(this.btnAdd);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 377);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(700, 55);
            this.panel1.TabIndex = 2;
            // 
            // btnDone
            // 
            this.btnDone.BackColor = System.Drawing.Color.Transparent;
            this.btnDone.BorderRadius = 5;
            this.btnDone.BorderThickness = 1;
            this.btnDone.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnDone.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnDone.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnDone.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnDone.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btnDone.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnDone.ForeColor = System.Drawing.Color.Black;
            this.btnDone.Location = new System.Drawing.Point(598, 10);
            this.btnDone.Name = "btnDone";
            this.btnDone.Size = new System.Drawing.Size(90, 35);
            this.btnDone.TabIndex = 3;
            this.btnDone.Text = "Print";
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.Color.Transparent;
            this.btnEdit.BorderRadius = 5;
            this.btnEdit.BorderThickness = 1;
            this.btnEdit.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnEdit.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnEdit.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnEdit.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnEdit.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btnEdit.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnEdit.ForeColor = System.Drawing.Color.Black;
            this.btnEdit.Location = new System.Drawing.Point(108, 10);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(90, 35);
            this.btnEdit.TabIndex = 1;
            this.btnEdit.Text = "Modify";
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.Transparent;
            this.btnAdd.BorderRadius = 5;
            this.btnAdd.BorderThickness = 1;
            this.btnAdd.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAdd.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAdd.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAdd.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAdd.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btnAdd.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnAdd.ForeColor = System.Drawing.Color.Black;
            this.btnAdd.Location = new System.Drawing.Point(12, 10);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(90, 35);
            this.btnAdd.TabIndex = 0;
            this.btnAdd.Text = "Generate";
            // 
            // dgvScheduleMorning
            // 
            this.dgvScheduleMorning.AllowUserToDeleteRows = false;
            this.dgvScheduleMorning.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvScheduleMorning.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvScheduleMorning.BackgroundColor = System.Drawing.Color.White;
            this.dgvScheduleMorning.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvScheduleMorning.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvScheduleMorning.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvScheduleMorning.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.monday,
            this.tuesday,
            this.wednesday,
            this.thursday,
            this.friday,
            this.saturday,
            this.sunday});
            this.dgvScheduleMorning.Location = new System.Drawing.Point(1, 44);
            this.dgvScheduleMorning.MultiSelect = false;
            this.dgvScheduleMorning.Name = "dgvScheduleMorning";
            this.dgvScheduleMorning.RowHeadersVisible = false;
            this.dgvScheduleMorning.RowHeadersWidth = 51;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvScheduleMorning.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvScheduleMorning.RowTemplate.Height = 24;
            this.dgvScheduleMorning.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvScheduleMorning.Size = new System.Drawing.Size(695, 160);
            this.dgvScheduleMorning.TabIndex = 5;
            // 
            // monday
            // 
            this.monday.HeaderText = "Monday";
            this.monday.MinimumWidth = 6;
            this.monday.Name = "monday";
            // 
            // tuesday
            // 
            this.tuesday.HeaderText = "Tuesday";
            this.tuesday.MinimumWidth = 6;
            this.tuesday.Name = "tuesday";
            // 
            // wednesday
            // 
            this.wednesday.HeaderText = "Wednesday";
            this.wednesday.MinimumWidth = 6;
            this.wednesday.Name = "wednesday";
            // 
            // thursday
            // 
            this.thursday.HeaderText = "Thursday";
            this.thursday.MinimumWidth = 6;
            this.thursday.Name = "thursday";
            // 
            // friday
            // 
            this.friday.HeaderText = "Friday";
            this.friday.MinimumWidth = 6;
            this.friday.Name = "friday";
            // 
            // saturday
            // 
            this.saturday.HeaderText = "Saturday";
            this.saturday.MinimumWidth = 6;
            this.saturday.Name = "saturday";
            // 
            // sunday
            // 
            this.sunday.HeaderText = "Sunday";
            this.sunday.MinimumWidth = 6;
            this.sunday.Name = "sunday";
            // 
            // ScheduleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(700, 432);
            this.Controls.Add(this.dgvScheduleMorning);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ScheduleForm";
            this.Text = "ScheduleForm";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvScheduleMorning)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private Guna.UI2.WinForms.Guna2Button btnDone;
        private Guna.UI2.WinForms.Guna2Button btnEdit;
        private Guna.UI2.WinForms.Guna2Button btnAdd;
        private System.Windows.Forms.DataGridView dgvScheduleMorning;
        private System.Windows.Forms.DataGridViewTextBoxColumn monday;
        private System.Windows.Forms.DataGridViewTextBoxColumn tuesday;
        private System.Windows.Forms.DataGridViewTextBoxColumn wednesday;
        private System.Windows.Forms.DataGridViewTextBoxColumn thursday;
        private System.Windows.Forms.DataGridViewTextBoxColumn friday;
        private System.Windows.Forms.DataGridViewTextBoxColumn saturday;
        private System.Windows.Forms.DataGridViewTextBoxColumn sunday;
    }
}