using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMSBL.Entities
{
    //CommonModel is for  CategoriesFor, Color, Category, Company, ExpenseType, ProductCategories
    public class CommonModel
    {
        public long ID { get; set; }
        public string Name { get; set; }
        public int TableNo { get; set; }
        public string Description { get; set; }
    }
}
