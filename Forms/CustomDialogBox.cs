using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CoffeeNegraWinForms.Forms
{
    public partial class CustomDialogBox : Form
    {
        public string message_alert { get; set; }

        public CustomDialogBox()
        {
            InitializeComponent();
        }

        private void CustomDialogBox_Load(object sender, EventArgs e)
        {
            lblMessage.Text = message_alert;
        }

        private void btnYes_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Yes;
            this.Close();
        }

        private void btnNo_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.No;
            this.Close();
        }
    }
}
