using SMS.BL.BLL;
using SMS.BL.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SMSystems
{
    public partial class SupplierForm : Form
    {
        long ID = -1;
        public SupplierForm()
        {
            InitializeComponent();
            ChangingFeildsVisibility(false);
            FillGrid();   
        }

        private void SupplierForm_Load(object sender, EventArgs e)
        {

        }
        protected void ChangingFeildsVisibility(bool state)
        {
            this.updatebtn.Enabled = state;
            this.Deletebtn.Enabled = state;
        }
      
        public void FillGrid()
        {
            var dt = SupplierBLL.GetSupplierList();
            this.SupplierGridView.DataSource = dt;
            this.SupplierGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void updatebtn_Click_1(object sender, EventArgs e)
        {
            UpdateSupplier form = new UpdateSupplier(ID);
            form.ShowDialog();
        }

        private void Addbtn_Click(object sender, EventArgs e)
        {
            AddSupplier form = new AddSupplier();
            form.ShowDialog();
        }

        private void SupplierGridView_SelectionChanged(object sender, EventArgs e)
        {
            if (SupplierGridView.SelectedRows.Count != 0)
            {
                ChangingFeildsVisibility(true);
                ID = Convert.ToInt64(SupplierGridView.SelectedRows[0].Cells[0].Value);
                ChangingFeildsVisibility(true);
            }

        }

        private void AddSupplierPayment_Click(object sender, EventArgs e)
        {
            AddSupplierPayment form = new AddSupplierPayment();
            form.ShowDialog();
        }
    }
}
