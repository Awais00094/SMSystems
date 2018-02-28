using SMS.BL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMS.BL.BLL
{
    public class ReportBLL
    {
        public static List<StockModel> GetProductStockList()
        {
            SMSEntities db = new SMSEntities();
            List<StockModel> list = new List<StockModel>();
            List<ProductStock> l = db.ProductStocks.Where(x => x.ID > 0).ToList();
            list = db.ProductStocks.Select(x => new StockModel
                                           {
                                            ArticalNo =x.Product.ArticalNo,
                                            TotalStock=x.Quantity.Value
                                        }).ToList();
            return list;
        }

    }
}
