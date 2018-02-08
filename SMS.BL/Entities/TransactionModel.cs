using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMS.BL.Entities
{
    public class TransactionModel
    {
        public long ID { get; set; }
        public Nullable<decimal> dDebit { get; set; }
        public Nullable<decimal> dCredit { get; set; }
        public Nullable<System.DateTime> dtDate { get; set; }
        public Nullable<long> PurchaseID { get; set; }
        public Nullable<long> ExpenseID { get; set; }
        public Nullable<long> UserID { get; set; }
        public Nullable<long> ShoppingID { get; set; }
        public Nullable<long> PurchasePaymentID { get; set; }
        public Nullable<long> SupplierID { get; set; }
        public Nullable<long> StatusID { get; set; }
    }
}
