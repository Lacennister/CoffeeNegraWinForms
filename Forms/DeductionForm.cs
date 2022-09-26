using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CoffeeNegraWinForms.Class;

namespace CoffeeNegraWinForms.Forms
{
    public partial class DeductionForm : Form
    {
        public DeductionForm()
        {
            InitializeComponent();
        }

        public Deduction deduction = new Deduction();
        public List<Deduction> _deductions = new List<Deduction>();

        private void DeductionForm_Load(object sender, EventArgs e)
        {
            _deductions = deduction.GetAll();
            foreach (Deduction d in _deductions)
            {
                dgvDeduction.Rows.Add(d.id, d.name, d.value);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            dgvDeduction.Rows.Add();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dgvDeduction.SelectedRows)
            {
                dgvDeduction.Rows.Remove(row);
                break;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            _deductions.Clear();

            for (int i = 0; i < dgvDeduction.Rows.Count; i++)
            {
                DataGridViewRow row = dgvDeduction.Rows[i];

                int id = i+1;
                string name = row.Cells[1].Value.ToString();
                string value = row.Cells[2].Value.ToString();

                Deduction deduct = new Deduction()
                {
                    id = id,
                    name = name,
                    value = value,
                };

                _deductions.Add(deduct);
            }

            deduction.Save(_deductions);

            this.Close();
        }
    }
}
