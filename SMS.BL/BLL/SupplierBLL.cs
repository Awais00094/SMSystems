﻿using SMS.BL;
using SMS.BL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMS.BL.BLL
{
    public class SupplierBLL
    {
        public static List<ComboboxList> GetCitiesForCombobox()
        {
            SMSEntities db = new SMSEntities();
            List<ComboboxList> list = new List<ComboboxList>();
            list = db.Cities
                        .Select(x => new ComboboxList
                        {
                            ID = x.ID,
                            Name = x.Name,
                        }).ToList();
            return list;
        }
        public static long AddSupplier(SupplierModel model)
        {
            long SupplierID = -1;
            SMSEntities db = new SMSEntities();
            Supplier suplier = new Supplier();
            suplier.CityID = model.CityID;
            suplier.CompanyName = model.CompanyName;
            suplier.Name = model.Name;
            suplier.StatusID = model.StatusID;
            suplier.IsActive = model.IsActive;
            suplier.ContactNo = model.ContactNo;
            suplier.UserID = model.UserID;
            suplier.dtDate = model.dtDate;
            db.Suppliers.Add(suplier);
            db.SaveChanges();
            SupplierID = suplier.ID;
            if (SupplierID != -1)
            {
                return SupplierID;
            }
            return SupplierID;
        }
        public static bool UpdateSupplier(SupplierModel model)
        {
            bool result = false;

            SMSEntities db = new SMSEntities();
            Supplier supplier = new Supplier();
            supplier = db.Suppliers.Where(x => x.ID == model.ID).FirstOrDefault();

            if (supplier != null)
            {
                supplier.Name = model.Name;
                supplier.CompanyName = model.CompanyName;
                supplier.ContactNo = model.ContactNo;
                supplier.CityID = model.CityID;
                supplier.dtDate = model.dtDate;
                db.Suppliers.Attach(supplier);
                db.Entry(supplier).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();
                result = true;
            }
            return result;
        }
        public static List<SupplierList> GetSupplierList()
        {
            SMSEntities db = new SMSEntities();
            List<SupplierList> list = new List<SupplierList>();
            list = db.Suppliers
                     .Where(x => x.StatusID == 1)
                     .Select(x => new SupplierList
                     {
                         ID = x.ID,
                         Name = x.Name,
                         CompanyName = x.CompanyName.ToString(),
                         ContactNo = x.ContactNo.ToString(),
                         City = x.City.Name,
                         Date = x.dtDate.ToString()                  
                     }).ToList();
            return list;
        }
        public static Supplier GetSupplierByID(long ID)
        {
            SMSEntities db = new SMSEntities();
            Supplier s = new Supplier();

            s = db.Suppliers.Where(x => x.ID == ID && x.StatusID==1).FirstOrDefault();
            return s;
        }
        public static decimal GetSupplierTotalRemainingAmount(long ID)
        {
            SMSEntities db = new SMSEntities();
            SupplierDetail sd = new SupplierDetail();

            sd = db.SupplierDetails.Where(x => x.SupplierID == ID).FirstOrDefault();
            if(sd!=null)
            {
                return sd.TotalRemaining.Value;
            }
            return -1;
        }
        public static long AddSupplierPayment(SupplierPaymentModel model)
        {
            //long SupplierID = -1;
            SMSEntities db = new SMSEntities();
            SupplierDetail supplierdetail = new SupplierDetail();

            using (var dbContextTransaction = db.Database.BeginTransaction())
            {
                try
                {
                    supplierdetail = db.SupplierDetails.Where(x => x.SupplierID == model.SupplierID).FirstOrDefault();
                    if (supplierdetail != null)
                    {
                        supplierdetail.dtDate = model.dtDate;
                        //supplierdetail.SupplierID = model.SupplierID;
                        supplierdetail.TotalPaid += model.AmoutPay;
                        supplierdetail.TotalRemaining = supplierdetail.TotalRemaining - model.AmoutPay;
                        db.SupplierDetails.Attach(supplierdetail);
                        db.Entry(supplierdetail).State = System.Data.Entity.EntityState.Modified;
                        db.SaveChanges();

                        Transaction transaction = new Transaction();
                        transaction.dCredit = model.AmoutPay;
                        transaction.dtDate = System.DateTime.Now;
                        transaction.SupplierID = supplierdetail.SupplierID;
                        transaction.StatusID = 1;
                    }

                    dbContextTransaction.Commit();
                    return supplierdetail.ID;
                }
                catch (Exception)
                {
                    dbContextTransaction.Rollback();
                    return -1;
                }
            }


        }
    }
}
