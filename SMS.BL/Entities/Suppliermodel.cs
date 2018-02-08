using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMS.BL.Entities
{
    public class SupplierModel
    {
        public long ID { get; set; }
        public string Name { get; set; }
        public string CompanyName { get; set; }
        public string ContactNo { get; set; }
        public Nullable<long> CityID { get; set; }
        public Nullable<System.DateTime> dtDate { get; set; }
        public Nullable<bool> IsActive { get; set; }
        public Nullable<long> StatusID { get; set; }
        public Nullable<long> UserID { get; set; }
    }
}
