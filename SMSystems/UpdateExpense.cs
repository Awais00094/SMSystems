using SMSBL;
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
    public partial class UpdateExpense : Form
    {
        long ExpenseID = -1;
        public UpdateExpense(long ID)
        {
            InitializeComponent();
            ExpenseID = ID;
            FillExpenseTypeComboBox();
            FilllForm(ID);
        }
        protected void FilllForm(long id)
        {
            try
            {
                Expens expense = new Expens();
                expense = ExpenseBLL.GetExpenseByID(id);
                if (expense != null)
                {
                    this.Amounttxt.Text=expense.Amount.ToString();
                    this.Descriptiontxt.Text=expense.Description;
                    this.ExpensedateTimePicker.Value=Convert.ToDateTime(expense.dtDate);
                    this.ExpenseTypeCombo.SelectedValue=expense.ExpenseTypeID;
                }
                else
                    MessageBox.Show("No Expense Data Found For Update!...");


            }
            catch (Exception ex)
            {

                MessageBox.Show("Exception Occurs!..." + ex.Message);
            }
        }
        private void btnclose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            try
            {
                
                Expense model = new Expense();
                model.ID = ExpenseID;
                model.Amount = Convert.ToDecimal(this.Amounttxt.Text);
                model.Description = this.Descriptiontxt.Text;
                model.dtDate = this.ExpensedateTimePicker.Value;
                model.ExpenseTypeID = Convert.ToInt64(this.ExpenseTypeCombo.SelectedValue);
                if (this.Amounttxt.Text != null || this.Amounttxt.Text != "")
                {
                     
                    if (ExpenseBLL.UpdateExpense(model))
                    {
                        MessageBox.Show("Expense Updated Successfully !...");
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Data Not Updated Successfully!...");
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

        private void ExpenseTypeCombo_DropDown(object sender, EventArgs e)
        {
            FillExpenseTypeComboBox();
        }
        public void FillExpenseTypeComboBox()
        {
            var ExpenseTypelist = ExpenseBLL.GetExpenseTypeDataForCombobox();
            ExpenseTypeCombo.DataSource = ExpenseTypelist;
            ExpenseTypeCombo.DisplayMember = "Name";
            ExpenseTypeCombo.ValueMember = "ID";
        }

        private void Amounttxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validator.ValidateDecimal(sender, e);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
