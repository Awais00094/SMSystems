using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMS.BL.Entities
{
    public class ExpenseList
    {
        public long ID { get; set; }
        public string ExpenseType { get; set; }
        public string Amount { get; set; }
        public string DateTime { get; set; }
        public string Description { get; set; }    
    }
}
