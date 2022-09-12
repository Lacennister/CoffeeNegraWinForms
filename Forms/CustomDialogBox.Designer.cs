
namespace CoffeeNegraWinForms.Forms
{
    partial class CustomDialogBox
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
            this.lblMessage = new System.Windows.Forms.Label();
            this.btnNo = new Guna.UI2.WinForms.Guna2Button();
            this.btnYes = new Guna.UI2.WinForms.Guna2Button();
            this.SuspendLayout();
            // 
            // lblMessage
            // 
            this.lblMessage.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMessage.Location = new System.Drawing.Point(12, 21);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(395, 75);
            this.lblMessage.TabIndex = 0;
            this.lblMessage.Text = "{{ message }}";
            this.lblMessage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnNo
            // 
            this.btnNo.BackColor = System.Drawing.Color.Transparent;
            this.btnNo.BorderRadius = 5;
            this.btnNo.BorderThickness = 1;
            this.btnNo.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnNo.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnNo.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnNo.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnNo.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btnNo.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnNo.ForeColor = System.Drawing.Color.Black;
            this.btnNo.Location = new System.Drawing.Point(270, 118);
            this.btnNo.Name = "btnNo";
            this.btnNo.Size = new System.Drawing.Size(90, 35);
            this.btnNo.TabIndex = 5;
            this.btnNo.Text = "No";
            this.btnNo.Click += new System.EventHandler(this.btnNo_Click);
            // 
            // btnYes
            // 
            this.btnYes.BackColor = System.Drawing.Color.Transparent;
            this.btnYes.BorderRadius = 5;
            this.btnYes.BorderThickness = 1;
            this.btnYes.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnYes.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnYes.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnYes.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnYes.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btnYes.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnYes.ForeColor = System.Drawing.Color.Black;
            this.btnYes.Location = new System.Drawing.Point(60, 118);
            this.btnYes.Name = "btnYes";
            this.btnYes.Size = new System.Drawing.Size(90, 35);
            this.btnYes.TabIndex = 4;
            this.btnYes.Text = "Yes";
            this.btnYes.Click += new System.EventHandler(this.btnYes_Click);
            // 
            // CustomDialogBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(419, 165);
            this.Controls.Add(this.btnNo);
            this.Controls.Add(this.btnYes);
            this.Controls.Add(this.lblMessage);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CustomDialogBox";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "CustomDialogBox";
            this.Load += new System.EventHandler(this.CustomDialogBox_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblMessage;
        private Guna.UI2.WinForms.Guna2Button btnNo;
        private Guna.UI2.WinForms.Guna2Button btnYes;
    }
}