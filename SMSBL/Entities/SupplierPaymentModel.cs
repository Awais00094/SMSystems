using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMSBL.Entities
{
    public class SupplierPaymentModel
    {
        public long SupplierID { get; set; }
        public DateTime dtDate { get; set; }
        public decimal RemainingAmount { get; set; }
        public decimal AmoutPay { get; set; }
    }
}
