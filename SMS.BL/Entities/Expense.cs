using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMS.BL.Entities
{
    public class Expense
    {
        public long ID { get; set; }
        public long ExpenseTypeID { get; set; }
        public decimal Amount { get; set; }
        public DateTime dtDate { get; set; }
        public string Description { get; set; }
        public long UserID { get; set; }

    }
}
