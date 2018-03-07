using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMSBL.Entities
{
    public class ProductModel
    {
        public long ID { get; set; }
        public string ArticalNo { get; set; }
        public Nullable<long> SizeID { get; set; }
        public Nullable<long> CompanyID { get; set; }
        public Nullable<long> ColorID { get; set; }
        public Nullable<long> CategoryForID { get; set; }
        public Nullable<decimal> SalePrice { get; set; }
        public Nullable<System.DateTime> dtDate { get; set; }
        public Nullable<decimal> MinDiscount { get; set; }
        public Nullable<decimal> MaxDiscount { get; set; }
        public Nullable<bool> ShowForShop { get; set; }
        public Nullable<long> CategoryID { get; set; }
        public Nullable<long> StatusID { get; set; }
        public Nullable<long> UserID { get; set; }
        public string ProductImage { get; set; }

    }
}
