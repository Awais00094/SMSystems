using SMS.BL.Enum;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMS.BL.BLL
{
    public class ShoppingBLL
    {
        public static SMSError CreateShopping(ref long? ShoppingID,
                                              DateTime? ShoppingDate,
                                              int TotalPairsQuantity,
                                              decimal TotalSalePrice,
                                              decimal TotalDiscountPrice,
                                              long? ReturnedShoppingID,
                                              string CustomerName,
                                              string CustomerNumber,
                                              DataTable utblShoppingDetail,
                                              long? UserID
                                              )
        {
            try
            {
                SQLBLL sql = new SQLBLL();
                Hashtable inputParameters = new Hashtable();
                Hashtable outputParameters = new Hashtable();

                outputParameters.Add("ShoppingID", ShoppingID);

                inputParameters.Add("ShoppingDate", ShoppingDate);
                inputParameters.Add("TotalPairsQuantity", TotalPairsQuantity);
                inputParameters.Add("TotalSalePrice", TotalSalePrice);
                inputParameters.Add("TotalDiscountPrice", TotalDiscountPrice);
                inputParameters.Add("ReturnedShoppingID", ReturnedShoppingID);
                inputParameters.Add("CustomerName", CustomerName);
                inputParameters.Add("CustomerNumber", CustomerNumber);
                inputParameters.Add("UserID", UserID);
                return sql.RunCommand(inputParameters, "utblShoppingDetail", utblShoppingDetail, outputParameters, "tblShopping_Insert");
            }
            catch (Exception ex) { throw ex; }
        }
    }
}
