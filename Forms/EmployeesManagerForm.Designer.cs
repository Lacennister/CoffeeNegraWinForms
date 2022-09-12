
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
            this.cbSunday = new System.Windows.Forms.CheckBox();
            this.cbSaturday = new System.Windows.Forms.CheckBox();
            this.cbFriday = new System.Windows.Forms.CheckBox();
            this.cbThursday = new System.Windows.Forms.CheckBox();
            this.cbWednesday = new System.Windows.Forms.CheckBox();
            this.cbTuesday = new System.Windows.Forms.CheckBox();
            this.cbMonday = new System.Windows.Forms.CheckBox();
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
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numAge)).BeginInit();
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
            this.btnDone.Location = new System.Drawing.Point(380, 360);
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
            this.btnClose.Location = new System.Drawing.Point(25, 360);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(90, 35);
            this.btnClose.TabIndex = 2;
            this.btnClose.Text = "Close";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbSunday);
            this.groupBox1.Controls.Add(this.cbSaturday);
            this.groupBox1.Controls.Add(this.cbFriday);
            this.groupBox1.Controls.Add(this.cbThursday);
            this.groupBox1.Controls.Add(this.cbWednesday);
            this.groupBox1.Controls.Add(this.cbTuesday);
            this.groupBox1.Controls.Add(this.cbMonday);
            this.groupBox1.Location = new System.Drawing.Point(314, 28);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(156, 313);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Time Availability";
            // 
            // cbSunday
            // 
            this.cbSunday.AutoSize = true;
            this.cbSunday.Location = new System.Drawing.Point(17, 261);
            this.cbSunday.Name = "cbSunday";
            this.cbSunday.Size = new System.Drawing.Size(78, 21);
            this.cbSunday.TabIndex = 12;
            this.cbSunday.Text = "Sunday";
            this.cbSunday.UseVisualStyleBackColor = true;
            // 
            // cbSaturday
            // 
            this.cbSaturday.AutoSize = true;
            this.cbSaturday.Location = new System.Drawing.Point(17, 223);
            this.cbSaturday.Name = "cbSaturday";
            this.cbSaturday.Size = new System.Drawing.Size(87, 21);
            this.cbSaturday.TabIndex = 11;
            this.cbSaturday.Text = "Saturday";
            this.cbSaturday.UseVisualStyleBackColor = true;
            // 
            // cbFriday
            // 
            this.cbFriday.AutoSize = true;
            this.cbFriday.Location = new System.Drawing.Point(17, 187);
            this.cbFriday.Name = "cbFriday";
            this.cbFriday.Size = new System.Drawing.Size(69, 21);
            this.cbFriday.TabIndex = 10;
            this.cbFriday.Text = "Friday";
            this.cbFriday.UseVisualStyleBackColor = true;
            // 
            // cbThursday
            // 
            this.cbThursday.AutoSize = true;
            this.cbThursday.Location = new System.Drawing.Point(17, 150);
            this.cbThursday.Name = "cbThursday";
            this.cbThursday.Size = new System.Drawing.Size(90, 21);
            this.cbThursday.TabIndex = 9;
            this.cbThursday.Text = "Thursday";
            this.cbThursday.UseVisualStyleBackColor = true;
            // 
            // cbWednesday
            // 
            this.cbWednesday.AutoSize = true;
            this.cbWednesday.Location = new System.Drawing.Point(17, 114);
            this.cbWednesday.Name = "cbWednesday";
            this.cbWednesday.Size = new System.Drawing.Size(105, 21);
            this.cbWednesday.TabIndex = 8;
            this.cbWednesday.Text = "Wednesday";
            this.cbWednesday.UseVisualStyleBackColor = true;
            // 
            // cbTuesday
            // 
            this.cbTuesday.AutoSize = true;
            this.cbTuesday.Location = new System.Drawing.Point(17, 78);
            this.cbTuesday.Name = "cbTuesday";
            this.cbTuesday.Size = new System.Drawing.Size(85, 21);
            this.cbTuesday.TabIndex = 7;
            this.cbTuesday.Text = "Tuesday";
            this.cbTuesday.UseVisualStyleBackColor = true;
            // 
            // cbMonday
            // 
            this.cbMonday.AutoSize = true;
            this.cbMonday.Location = new System.Drawing.Point(17, 43);
            this.cbMonday.Name = "cbMonday";
            this.cbMonday.Size = new System.Drawing.Size(80, 21);
            this.cbMonday.TabIndex = 6;
            this.cbMonday.Text = "Monday";
            this.cbMonday.UseVisualStyleBackColor = true;
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
            this.groupBox2.Location = new System.Drawing.Point(25, 28);
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
            this.numAge.Name = "numAge";
            this.numAge.Size = new System.Drawing.Size(90, 36);
            this.numAge.TabIndex = 3;
            this.numAge.UpDownButtonFillColor = System.Drawing.Color.White;
            // 
            // EmployeesManagerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(501, 407);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnDone);
            this.Controls.Add(this.btnClose);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "EmployeesManagerForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "EmployeesManagerForm";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numAge)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button btnDone;
        private Guna.UI2.WinForms.Guna2Button btnClose;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox cbFriday;
        private System.Windows.Forms.CheckBox cbThursday;
        private System.Windows.Forms.CheckBox cbWednesday;
        private System.Windows.Forms.CheckBox cbTuesday;
        private System.Windows.Forms.CheckBox cbMonday;
        private System.Windows.Forms.CheckBox cbSunday;
        private System.Windows.Forms.CheckBox cbSaturday;
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
    }
}