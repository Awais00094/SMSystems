using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMS.BL.Entities
{
    public class PurchaseProductDetailItem
    {
        public long ID { get; set; }
        public string  ArticalNo { get; set; }
        public int Quantity { get; set; }
        public decimal  RetailPrice { get; set; }
        public decimal  WSalePrice { get; set; }
        public decimal TotalValue { get; set; }
    }
}
