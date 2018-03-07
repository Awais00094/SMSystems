using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMSBL.Entities
{
    public class ProductList
    {
        public long ID { get; set; }
        public string ArticalNo { get; set; }
        public string Size { get; set; }
        public string Company { get; set; }
        public string Color { get; set; }
        public string CategoryFor { get; set; }
        public string SalePrice { get; set; }
        public string MinDiscount { get; set; }
        public string MaxDiscount { get; set; }
        public string ShoeType { get; set; }
    }
}
