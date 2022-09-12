
namespace CoffeeNegraWinForms.Forms
{
    partial class BranchForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.lblBranchName = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(137, 119);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(311, 55);
            this.label1.TabIndex = 0;
            this.label1.Text = "Coffee Negra";
            // 
            // lblBranchName
            // 
            this.lblBranchName.Location = new System.Drawing.Point(147, 199);
            this.lblBranchName.Name = "lblBranchName";
            this.lblBranchName.Size = new System.Drawing.Size(301, 23);
            this.lblBranchName.TabIndex = 1;
            this.lblBranchName.Text = "{{ Branch Name }}";
            this.lblBranchName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BranchForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 350);
            this.Controls.Add(this.lblBranchName);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "BranchForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BranchForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblBranchName;
    }
}