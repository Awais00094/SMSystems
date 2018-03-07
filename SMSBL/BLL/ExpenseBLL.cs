using SMSBL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMSBL.BLL
{
    public class ExpenseBLL
    {
        public static List<ComboboxList> GetExpenseTypeDataForCombobox()
        {
            SMSEntities db = new SMSEntities();
            List<ComboboxList> list = new List<ComboboxList>();
            list = db.ExpenseTypes
                        .Where(x => x.IsDeleted == false)
                        .Select(x => new ComboboxList
                        {
                            ID = x.ID,
                            Name = x.Name,
                        }).ToList();
            return list;
        }
        public static long AddExpense(Expense model)
        {
            long ExpenseID = -1;
            long TransID = -1;
            SMSEntities db = new SMSEntities();
            Expens expense = new Expens();
            expense.Amount = model.Amount;
            expense.Description = model.Description;
            expense.dtDate = model.dtDate;
            expense.StatusID = 1;
            expense.ExpenseTypeID = model.ExpenseTypeID;
            db.Expenses.Add(expense);
            db.SaveChanges();
            ExpenseID = expense.ID;
            if (ExpenseID != -1)
            {
                TransactionModel trans = new TransactionModel();
                trans.dCredit = model.Amount;
                trans.dDebit = 0;
                trans.dtDate = DateTime.Now;
                trans.ExpenseID = expense.ID;
                trans.StatusID = Convert.ToInt64(Enum.Status.Active);
                trans.PurchaseID = null;
                trans.PurchasePaymentID = null;
                trans.ShoppingID = null;
                trans.SupplierID = null;
                trans.UserID = null;

                TransID=TransactionsBLL.InsertTransactionEntry(trans);
                return expense.ID;
            }

            return ExpenseID;
        }
        public static bool UpdateExpense(Expense model)
        {
            bool result = false;

            decimal ExpenseAmount = 0;
            SMSEntities db = new SMSEntities();
            Expens expense = new Expens();
            expense = db.Expenses.Where(x => x.ID == model.ID && x.StatusID==1).FirstOrDefault();
            ExpenseAmount = expense.Amount.GetValueOrDefault();

            if (expense != null)
            {
                expense.Amount = model.Amount;
                expense.Description = model.Description;
                expense.dtDate = model.dtDate;
                expense.ExpenseTypeID = model.ExpenseTypeID;
                db.Expenses.Attach(expense);
                db.Entry(expense).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();

                if (ExpenseAmount != model.Amount)
                {
                    TransactionModel trans = new TransactionModel();                  
                    trans.dCredit = expense.Amount.GetValueOrDefault();
                    trans.dtDate = model.dtDate;
                    trans.ExpenseID = expense.ID;
                    TransactionsBLL.UpdateExpenseTransactionEntry(trans);                   
                }
                result = true;
                return result; 
            }
            return result;
        }
        public static List<ExpenseList> GetExpenseList()
        {
            SMSEntities db = new SMSEntities();
            List<ExpenseList> list = new List<ExpenseList>();
            list = db.Expenses
                     .Where(x => x.StatusID == 1)
                     .Select(x => new ExpenseList
                     {
                         ID = x.ID,
                         Amount = x.Amount.ToString(),
                         ExpenseType = x.ExpenseType.Name,
                         DateTime = x.dtDate.ToString(),
                         Description = x.Description            
                     }).ToList();
            return list;
        }
        public static Expens GetExpenseByID(long ID)
        {
            SMSEntities db = new SMSEntities();
            Expens expense = new Expens();

            expense = db.Expenses.Where(x => x.ID == ID && x.StatusID == 1).FirstOrDefault();
            return expense;
        }

    }
}
