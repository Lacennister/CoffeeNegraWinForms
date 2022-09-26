
namespace CoffeeNegraWinForms.Forms
{
    partial class EmployeesManagerForm
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
            this.btnDone = new Guna.UI2.WinForms.Guna2Button();
            this.btnClose = new Guna.UI2.WinForms.Guna2Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbSundayMorning = new System.Windows.Forms.CheckBox();
            this.cbSaturdayMorning = new System.Windows.Forms.CheckBox();
            this.cbFridayMorning = new System.Windows.Forms.CheckBox();
            this.cbThursdayMorning = new System.Windows.Forms.CheckBox();
            this.cbWednesdayMorning = new System.Windows.Forms.CheckBox();
            this.cbTuesdayMorning = new System.Windows.Forms.CheckBox();
            this.cbMondayMorning = new System.Windows.Forms.CheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtContact = new Guna.UI2.WinForms.Guna2TextBox();
            this.dtBirthday = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.txtAddress = new Guna.UI2.WinForms.Guna2TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtFullname = new Guna.UI2.WinForms.Guna2TextBox();
            this.numAge = new Guna.UI2.WinForms.Guna2NumericUpDown();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.cbSundayAfternoon = new System.Windows.Forms.CheckBox();
            this.cbSaturdayAfternoon = new System.Windows.Forms.CheckBox();
            this.cbFridayAfternoon = new System.Windows.Forms.CheckBox();
            this.cbThursdayAfternoon = new System.Windows.Forms.CheckBox();
            this.cbWednesdayAfternoon = new System.Windows.Forms.CheckBox();
            this.cbTuesdayAfternoon = new System.Windows.Forms.CheckBox();
            this.cbMondayAfternoon = new System.Windows.Forms.CheckBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numAge)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
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
            this.btnDone.Location = new System.Drawing.Point(554, 342);
            this.btnDone.Name = "btnDone";
            this.btnDone.Size = new System.Drawing.Size(90, 35);
            this.btnDone.TabIndex = 13;
            this.btnDone.Text = "Done";
            this.btnDone.Click += new System.EventHandler(this.btnDone_Click);
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.Transparent;
            this.btnClose.BorderRadius = 5;
            this.btnClose.BorderThickness = 1;
            this.btnClose.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnClose.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnClose.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnClose.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnClose.FillColor = System.Drawing.Color.Transparent;
            this.btnClose.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnClose.ForeColor = System.Drawing.Color.Black;
            this.btnClose.Location = new System.Drawing.Point(13, 342);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(90, 35);
            this.btnClose.TabIndex = 2;
            this.btnClose.Text = "Close";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbSundayMorning);
            this.groupBox1.Controls.Add(this.cbSaturdayMorning);
            this.groupBox1.Controls.Add(this.cbFridayMorning);
            this.groupBox1.Controls.Add(this.cbThursdayMorning);
            this.groupBox1.Controls.Add(this.cbWednesdayMorning);
            this.groupBox1.Controls.Add(this.cbTuesdayMorning);
            this.groupBox1.Controls.Add(this.cbMondayMorning);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(302, 23);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(168, 313);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Morning Shift";
            // 
            // cbSundayMorning
            // 
            this.cbSundayMorning.AutoSize = true;
            this.cbSundayMorning.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbSundayMorning.Location = new System.Drawing.Point(17, 261);
            this.cbSundayMorning.Name = "cbSundayMorning";
            this.cbSundayMorning.Size = new System.Drawing.Size(76, 23);
            this.cbSundayMorning.TabIndex = 12;
            this.cbSundayMorning.Text = "Sunday";
            this.cbSundayMorning.UseVisualStyleBackColor = true;
            // 
            // cbSaturdayMorning
            // 
            this.cbSaturdayMorning.AutoSize = true;
            this.cbSaturdayMorning.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbSaturdayMorning.Location = new System.Drawing.Point(17, 223);
            this.cbSaturdayMorning.Name = "cbSaturdayMorning";
            this.cbSaturdayMorning.Size = new System.Drawing.Size(85, 23);
            this.cbSaturdayMorning.TabIndex = 11;
            this.cbSaturdayMorning.Text = "Saturday";
            this.cbSaturdayMorning.UseVisualStyleBackColor = true;
            // 
            // cbFridayMorning
            // 
            this.cbFridayMorning.AutoSize = true;
            this.cbFridayMorning.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbFridayMorning.Location = new System.Drawing.Point(17, 187);
            this.cbFridayMorning.Name = "cbFridayMorning";
            this.cbFridayMorning.Size = new System.Drawing.Size(68, 23);
            this.cbFridayMorning.TabIndex = 10;
            this.cbFridayMorning.Text = "Friday";
            this.cbFridayMorning.UseVisualStyleBackColor = true;
            // 
            // cbThursdayMorning
            // 
            this.cbThursdayMorning.AutoSize = true;
            this.cbThursdayMorning.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbThursdayMorning.Location = new System.Drawing.Point(17, 150);
            this.cbThursdayMorning.Name = "cbThursdayMorning";
            this.cbThursdayMorning.Size = new System.Drawing.Size(87, 23);
            this.cbThursdayMorning.TabIndex = 9;
            this.cbThursdayMorning.Text = "Thursday";
            this.cbThursdayMorning.UseVisualStyleBackColor = true;
            // 
            // cbWednesdayMorning
            // 
            this.cbWednesdayMorning.AutoSize = true;
            this.cbWednesdayMorning.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbWednesdayMorning.Location = new System.Drawing.Point(17, 114);
            this.cbWednesdayMorning.Name = "cbWednesdayMorning";
            this.cbWednesdayMorning.Size = new System.Drawing.Size(101, 23);
            this.cbWednesdayMorning.TabIndex = 8;
            this.cbWednesdayMorning.Text = "Wednesday";
            this.cbWednesdayMorning.UseVisualStyleBackColor = true;
            // 
            // cbTuesdayMorning
            // 
            this.cbTuesdayMorning.AutoSize = true;
            this.cbTuesdayMorning.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbTuesdayMorning.Location = new System.Drawing.Point(17, 78);
            this.cbTuesdayMorning.Name = "cbTuesdayMorning";
            this.cbTuesdayMorning.Size = new System.Drawing.Size(81, 23);
            this.cbTuesdayMorning.TabIndex = 7;
            this.cbTuesdayMorning.Text = "Tuesday";
            this.cbTuesdayMorning.UseVisualStyleBackColor = true;
            // 
            // cbMondayMorning
            // 
            this.cbMondayMorning.AutoSize = true;
            this.cbMondayMorning.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbMondayMorning.Location = new System.Drawing.Point(17, 43);
            this.cbMondayMorning.Name = "cbMondayMorning";
            this.cbMondayMorning.Size = new System.Drawing.Size(82, 23);
            this.cbMondayMorning.TabIndex = 6;
            this.cbMondayMorning.Text = "Monday";
            this.cbMondayMorning.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.txtContact);
            this.groupBox2.Controls.Add(this.dtBirthday);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.txtAddress);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.txtFullname);
            this.groupBox2.Controls.Add(this.numAge);
            this.groupBox2.Location = new System.Drawing.Point(13, 23);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(283, 313);
            this.groupBox2.TabIndex = 18;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Employee Information";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 243);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(110, 17);
            this.label4.TabIndex = 27;
            this.label4.Text = "Contact Number";
            // 
            // txtContact
            // 
            this.txtContact.BorderRadius = 5;
            this.txtContact.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtContact.DefaultText = "";
            this.txtContact.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtContact.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtContact.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtContact.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtContact.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtContact.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtContact.ForeColor = System.Drawing.Color.Black;
            this.txtContact.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtContact.Location = new System.Drawing.Point(16, 263);
            this.txtContact.Name = "txtContact";
            this.txtContact.PasswordChar = '\0';
            this.txtContact.PlaceholderText = "";
            this.txtContact.SelectedText = "";
            this.txtContact.Size = new System.Drawing.Size(254, 36);
            this.txtContact.TabIndex = 5;
            // 
            // dtBirthday
            // 
            this.dtBirthday.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtBirthday.Location = new System.Drawing.Point(16, 132);
            this.dtBirthday.Name = "dtBirthday";
            this.dtBirthday.Size = new System.Drawing.Size(158, 22);
            this.dtBirthday.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 177);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 17);
            this.label5.TabIndex = 23;
            this.label5.Text = "Address";
            // 
            // txtAddress
            // 
            this.txtAddress.BorderRadius = 5;
            this.txtAddress.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtAddress.DefaultText = "";
            this.txtAddress.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtAddress.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtAddress.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtAddress.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtAddress.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtAddress.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtAddress.ForeColor = System.Drawing.Color.Black;
            this.txtAddress.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtAddress.Location = new System.Drawing.Point(16, 197);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.PasswordChar = '\0';
            this.txtAddress.PlaceholderText = "";
            this.txtAddress.SelectedText = "";
            this.txtAddress.Size = new System.Drawing.Size(254, 36);
            this.txtAddress.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 105);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 17);
            this.label3.TabIndex = 21;
            this.label3.Text = "Birthday";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(177, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 17);
            this.label2.TabIndex = 20;
            this.label2.Text = "Age";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 17);
            this.label1.TabIndex = 19;
            this.label1.Text = "Fullname";
            // 
            // txtFullname
            // 
            this.txtFullname.BorderRadius = 5;
            this.txtFullname.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtFullname.DefaultText = "";
            this.txtFullname.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtFullname.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtFullname.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtFullname.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtFullname.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtFullname.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtFullname.ForeColor = System.Drawing.Color.Black;
            this.txtFullname.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtFullname.Location = new System.Drawing.Point(16, 53);
            this.txtFullname.Name = "txtFullname";
            this.txtFullname.PasswordChar = '\0';
            this.txtFullname.PlaceholderText = "";
            this.txtFullname.SelectedText = "";
            this.txtFullname.Size = new System.Drawing.Size(254, 36);
            this.txtFullname.TabIndex = 1;
            // 
            // numAge
            // 
            this.numAge.BackColor = System.Drawing.Color.Transparent;
            this.numAge.BorderRadius = 5;
            this.numAge.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.numAge.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.numAge.Location = new System.Drawing.Point(180, 125);
            this.numAge.Minimum = new decimal(new int[] {
            18,
            0,
            0,
            0});
            this.numAge.Name = "numAge";
            this.numAge.Size = new System.Drawing.Size(90, 36);
            this.numAge.TabIndex = 3;
            this.numAge.UpDownButtonFillColor = System.Drawing.Color.White;
            this.numAge.Value = new decimal(new int[] {
            18,
            0,
            0,
            0});
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.cbSundayAfternoon);
            this.groupBox4.Controls.Add(this.cbSaturdayAfternoon);
            this.groupBox4.Controls.Add(this.cbFridayAfternoon);
            this.groupBox4.Controls.Add(this.cbThursdayAfternoon);
            this.groupBox4.Controls.Add(this.cbWednesdayAfternoon);
            this.groupBox4.Controls.Add(this.cbTuesdayAfternoon);
            this.groupBox4.Controls.Add(this.cbMondayAfternoon);
            this.groupBox4.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(476, 23);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(168, 313);
            this.groupBox4.TabIndex = 14;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Afternoon Shift";
            // 
            // cbSundayAfternoon
            // 
            this.cbSundayAfternoon.AutoSize = true;
            this.cbSundayAfternoon.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbSundayAfternoon.Location = new System.Drawing.Point(17, 261);
            this.cbSundayAfternoon.Name = "cbSundayAfternoon";
            this.cbSundayAfternoon.Size = new System.Drawing.Size(76, 23);
            this.cbSundayAfternoon.TabIndex = 12;
            this.cbSundayAfternoon.Text = "Sunday";
            this.cbSundayAfternoon.UseVisualStyleBackColor = true;
            // 
            // cbSaturdayAfternoon
            // 
            this.cbSaturdayAfternoon.AutoSize = true;
            this.cbSaturdayAfternoon.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbSaturdayAfternoon.Location = new System.Drawing.Point(17, 223);
            this.cbSaturdayAfternoon.Name = "cbSaturdayAfternoon";
            this.cbSaturdayAfternoon.Size = new System.Drawing.Size(85, 23);
            this.cbSaturdayAfternoon.TabIndex = 11;
            this.cbSaturdayAfternoon.Text = "Saturday";
            this.cbSaturdayAfternoon.UseVisualStyleBackColor = true;
            // 
            // cbFridayAfternoon
            // 
            this.cbFridayAfternoon.AutoSize = true;
            this.cbFridayAfternoon.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbFridayAfternoon.Location = new System.Drawing.Point(17, 187);
            this.cbFridayAfternoon.Name = "cbFridayAfternoon";
            this.cbFridayAfternoon.Size = new System.Drawing.Size(68, 23);
            this.cbFridayAfternoon.TabIndex = 10;
            this.cbFridayAfternoon.Text = "Friday";
            this.cbFridayAfternoon.UseVisualStyleBackColor = true;
            // 
            // cbThursdayAfternoon
            // 
            this.cbThursdayAfternoon.AutoSize = true;
            this.cbThursdayAfternoon.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbThursdayAfternoon.Location = new System.Drawing.Point(17, 150);
            this.cbThursdayAfternoon.Name = "cbThursdayAfternoon";
            this.cbThursdayAfternoon.Size = new System.Drawing.Size(87, 23);
            this.cbThursdayAfternoon.TabIndex = 9;
            this.cbThursdayAfternoon.Text = "Thursday";
            this.cbThursdayAfternoon.UseVisualStyleBackColor = true;
            // 
            // cbWednesdayAfternoon
            // 
            this.cbWednesdayAfternoon.AutoSize = true;
            this.cbWednesdayAfternoon.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbWednesdayAfternoon.Location = new System.Drawing.Point(17, 114);
            this.cbWednesdayAfternoon.Name = "cbWednesdayAfternoon";
            this.cbWednesdayAfternoon.Size = new System.Drawing.Size(101, 23);
            this.cbWednesdayAfternoon.TabIndex = 8;
            this.cbWednesdayAfternoon.Text = "Wednesday";
            this.cbWednesdayAfternoon.UseVisualStyleBackColor = true;
            // 
            // cbTuesdayAfternoon
            // 
            this.cbTuesdayAfternoon.AutoSize = true;
            this.cbTuesdayAfternoon.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbTuesdayAfternoon.Location = new System.Drawing.Point(17, 78);
            this.cbTuesdayAfternoon.Name = "cbTuesdayAfternoon";
            this.cbTuesdayAfternoon.Size = new System.Drawing.Size(81, 23);
            this.cbTuesdayAfternoon.TabIndex = 7;
            this.cbTuesdayAfternoon.Text = "Tuesday";
            this.cbTuesdayAfternoon.UseVisualStyleBackColor = true;
            // 
            // cbMondayAfternoon
            // 
            this.cbMondayAfternoon.AutoSize = true;
            this.cbMondayAfternoon.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbMondayAfternoon.Location = new System.Drawing.Point(17, 43);
            this.cbMondayAfternoon.Name = "cbMondayAfternoon";
            this.cbMondayAfternoon.Size = new System.Drawing.Size(82, 23);
            this.cbMondayAfternoon.TabIndex = 6;
            this.cbMondayAfternoon.Text = "Monday";
            this.cbMondayAfternoon.UseVisualStyleBackColor = true;
            // 
            // EmployeesManagerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(658, 389);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnDone);
            this.Controls.Add(this.btnClose);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "EmployeesManagerForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "EmployeesManagerForm";
            this.Load += new System.EventHandler(this.EmployeesManagerForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numAge)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button btnDone;
        private Guna.UI2.WinForms.Guna2Button btnClose;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox cbFridayMorning;
        private System.Windows.Forms.CheckBox cbThursdayMorning;
        private System.Windows.Forms.CheckBox cbWednesdayMorning;
        private System.Windows.Forms.CheckBox cbTuesdayMorning;
        private System.Windows.Forms.CheckBox cbMondayMorning;
        private System.Windows.Forms.CheckBox cbSundayMorning;
        private System.Windows.Forms.CheckBox cbSaturdayMorning;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label4;
        private Guna.UI2.WinForms.Guna2TextBox txtContact;
        private System.Windows.Forms.DateTimePicker dtBirthday;
        private System.Windows.Forms.Label label5;
        private Guna.UI2.WinForms.Guna2TextBox txtAddress;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2TextBox txtFullname;
        private Guna.UI2.WinForms.Guna2NumericUpDown numAge;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.CheckBox cbSundayAfternoon;
        private System.Windows.Forms.CheckBox cbSaturdayAfternoon;
        private System.Windows.Forms.CheckBox cbFridayAfternoon;
        private System.Windows.Forms.CheckBox cbThursdayAfternoon;
        private System.Windows.Forms.CheckBox cbWednesdayAfternoon;
        private System.Windows.Forms.CheckBox cbTuesdayAfternoon;
        private System.Windows.Forms.CheckBox cbMondayAfternoon;
    }
}