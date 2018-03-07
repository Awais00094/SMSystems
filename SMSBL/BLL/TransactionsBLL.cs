using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SMSBL.Entities;
using System.Threading.Tasks;

namespace SMSBL.BLL
{
    public class TransactionsBLL
    {
        public static long InsertTransactionEntry(TransactionModel model)
        {
            SMSEntities db = new SMSEntities();
            Transaction transaction = new Transaction();

            transaction.dCredit = model.dCredit;
            transaction.dDebit = model.dDebit;
            transaction.dtDate = model.dtDate;
            transaction.ExpenseID = model.ExpenseID;
            transaction.PurchaseID = model.PurchaseID;
            transaction.PurchasePaymentID = model.PurchasePaymentID;
            transaction.ShoppingID = model.ShoppingID;
            transaction.SupplierID = model.SupplierID;
            transaction.UserID = model.UserID;
            transaction.StatusID = model.StatusID;

            db.Transactions.Add(transaction);
            db.SaveChanges();

            return transaction.ID;
        }
        public static long UpdateExpenseTransactionEntry(TransactionModel model)
        {
            SMSEntities db = new SMSEntities();
            Transaction transaction = new Transaction();
                       
            transaction = db.Transactions.Where(x => x.ExpenseID == model.ID).FirstOrDefault();
            if (transaction != null)
            {
                transaction.dCredit = model.dCredit;
                transaction.dtDate = model.dtDate;
                db.Transactions.Attach(transaction);
                db.Entry(transaction).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();
            }
            return transaction.ID;
        }
    }
}
