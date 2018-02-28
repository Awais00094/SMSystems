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
    public partial class AddExpenseForm : Form
    {
        protected override CreateParams CreateParams
        {
            get
            {
                const int CS_DROPSHADOW = 0x20000;
                CreateParams cp = base.CreateParams;
                cp.ClassStyle |= CS_DROPSHADOW;
                return cp;
            }
        }
        public AddExpenseForm()
        {
            InitializeComponent();
            FillExpenseTypeComboBox();
        }

        private void Addbtn_Click(object sender, EventArgs e)
        {
            try
            {
                long ID = -1;
                Expense model = new Expense();
                model.Amount = Convert.ToDecimal(this.AddAmounttxt.Text);
                model.Description = this.DescriptionAddtxt.Text;
                model.dtDate = this.AddExpensedateTimePicker.Value;
                model.ExpenseTypeID = Convert.ToInt64(this.AddExpenseTypeCombo.SelectedValue);
                if (this.AddAmounttxt.Text != null || this.AddAmounttxt.Text != "")
                {
                     ID= ExpenseBLL.AddExpense(model);
                    if (ID != -1)
                    {
                        MessageBox.Show("Expense Added Successfully !..." + ID);
                        this.AddAmounttxt.Text = "";
                        this.DescriptionAddtxt.Text = "";
                    }
                    else
                    {
                        MessageBox.Show("Data Not Added Successfully!...");
                    }
                }
                else
                {
                    MessageBox.Show("Amount Field Cannot be null or empty!...");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Exception Occurs" + ex.Message);
            }

        }

        private void close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void addAClose_Click(object sender, EventArgs e)
        {
            try
            {
                long ID = -1;
                Expense model = new Expense();
                model.Amount = Convert.ToDecimal(this.AddAmounttxt.Text);
                model.Description = this.DescriptionAddtxt.Text;
                model.dtDate = this.AddExpensedateTimePicker.Value;
                model.ExpenseTypeID = Convert.ToInt64(this.AddExpenseTypeCombo.SelectedValue);
                if (this.AddAmounttxt.Text != null || this.AddAmounttxt.Text != "")
                {
                    ID = ExpenseBLL.AddExpense(model);
                    if (ID != -1)
                    {
                        MessageBox.Show("Expense Added Successfully !..." + ID);
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Data Not Added Successfully!...");
                    }
                }
                else
                {
                    MessageBox.Show("Amount Field Cannot be null or empty!...");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Exception Occurs" + ex.Message);
            }


        }
        public void FillExpenseTypeComboBox()
        {
            var ExpenseTypelist = ExpenseBLL.GetExpenseTypeDataForCombobox();
            AddExpenseTypeCombo.DataSource = ExpenseTypelist;
            AddExpenseTypeCombo.DisplayMember = "Name";
            AddExpenseTypeCombo.ValueMember = "ID";
        }
        private void ExpenseTypeCombo_DropDown(object sender, EventArgs e)
        {
            FillExpenseTypeComboBox();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
