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
    public partial class BranchForm : Form
    {
        public string branchName { get; set; }

        public BranchForm()
        {
            InitializeComponent();
        }

        private void BranchForm_Load(object sender, EventArgs e)
        {
            lblBranchName.Text = branchName + " Branch";
        }
    }
}
