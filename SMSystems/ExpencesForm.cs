using SMSBL.BLL;
using SMSBL.Entities;
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
    public partial class ExpensesForm : Form
    {
        public long ID = -1;
        public ExpensesForm()
        {
            InitializeComponent();
            FillGrid();
            ChangingFeildsVisibility(false);

        }

        private void ExpensesForm_Load(object sender, EventArgs e)
        {
            ExpensesGridView.ClearSelection();
        }
        protected void ChangingFeildsVisibility(bool state)
        {
            //this.updateNametxt.Enabled = state;
            this.updatebtn.Enabled = state;
            this.Deletebtn.Enabled = state;
        }
        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (ExpensesGridView.SelectedRows.Count != 0)
            {
                ChangingFeildsVisibility(true);
                ID = Convert.ToInt64(ExpensesGridView.SelectedRows[0].Cells[0].Value);
            }
            //MessageBox.Show(SizeGridView.SelectedRows[0].Cells[2].Value.ToString());
        }

        private void Addbtn_Click(object sender, EventArgs e)
        {
           
        }
        public void FillGrid()
        {
            var dt = ExpenseBLL.GetExpenseList();
            this.ExpensesGridView.DataSource = dt;
            this.ExpensesGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void updatebtn_Click(object sender, EventArgs e)
        {
            UpdateExpense form = new UpdateExpense(ID);
           // form.FormClosed += new FormClosedEventHandler(child_FormClosed); //add handler to catch when child form is closed
            form.ShowDialog();
            //this.Refresh();        
            FillGrid();
            ChangingFeildsVisibility(false);
        }

        private void Addbtn_Click_1(object sender, EventArgs e)
        {
            AddExpenseForm form = new AddExpenseForm();
            form.ShowDialog();
        }
        //void child_FormClosed(object sender, FormClosedEventArgs e)
        //{
        //    //when child form is closed, this code is executed
        //    this.Refresh();
        //}
    }
}
