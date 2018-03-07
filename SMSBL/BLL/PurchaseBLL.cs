using SMSBL.Entities;
using SMSBL.Enum;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMSBL.BLL
{
    public  class PurchaseBLL
    {
        public static SMSError CreatePurchase(ref long? PurchaseID,
                                               long? SupplierID,
                                               DateTime?  PurchaseDate,
                                               int TotalPairsQuantity,
                                               decimal TotalPurchaseValue,
                                               decimal TotalDiscountValue,
                                               decimal TotalPaidValue,
                                               string PurchaseInvoiceNo,
                                               DataTable utblPurchaseDetail,
                                               long? UserID
                                               )
        {
            try
            {
                SQLBLL sql = new SQLBLL();
                Hashtable inputParameters = new Hashtable();
                Hashtable outputParameters = new Hashtable();

                outputParameters.Add("PurchaseID", PurchaseID);

                inputParameters.Add("SupplierID", SupplierID);
                inputParameters.Add("PurchaseDate", PurchaseDate);
                inputParameters.Add("TotalPairsQuantity", TotalPairsQuantity);
                inputParameters.Add("TotalPurchaseValue", TotalPurchaseValue);
                inputParameters.Add("TotalDiscountValue", TotalDiscountValue);
                inputParameters.Add("TotalPaidValue", TotalPaidValue);
                inputParameters.Add("PurchaseInvoiceNo", PurchaseInvoiceNo);
                inputParameters.Add("UserID", UserID);            
                return sql.RunCommand(inputParameters, "utblPurchaseDetail", utblPurchaseDetail, outputParameters, "tblPurchase_Insert");
            }
            catch (Exception ex) { throw ex; }
        }

        public static List<ComboboxList> GetSupplierCombobox()
        {
            SMSEntities db = new SMSEntities();
            List<ComboboxList> list = new List<ComboboxList>();
            list = db.Suppliers
                        .Select(x => new ComboboxList
                        {
                            ID = x.ID,
                            Name = x.Name,
                        }).ToList();
            return list;
        }
        public static List<ComboboxList> GetSupplierComboboxForPayment()
        {
            SMSEntities db = new SMSEntities();
            List<ComboboxList> list = new List<ComboboxList>();
            list = db.SupplierDetails.Where(x=>x.TotalRemaining>0)
                        .Select(x => new ComboboxList
                        {
                            ID = x.Supplier.ID,
                            Name = x.Supplier.Name,
                        }).ToList();
            return list;
        }
    }
}
