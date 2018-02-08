using SMS.BL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMS.BL.BLL
{
    public class ProductBLL
    {
        public static List<ComboboxList> GetSizeDataForCombobox()
        {
            SMSEntities db = new SMSEntities();
            List<ComboboxList> list = new List<ComboboxList>();
            list = db.Sizes
                        .Where(x => x.IsDeleted == false)
                        .Select(x => new ComboboxList
                        {
                            ID = x.ID,
                            Name = x.Name,
                        }).ToList();
            return list;
        }
        public static List<ComboboxList> GetColorDataForCombobox()
        {
            SMSEntities db = new SMSEntities();
            List<ComboboxList> list = new List<ComboboxList>();
            list = db.Colors
                        .Where(x => x.IsDeleted == false)
                        .Select(x => new ComboboxList
                        {
                            ID = x.ID,
                            Name = x.Name,
                        }).ToList();
            return list;
        }
        public static List<ComboboxList> GetCategoryForDataForCombobox()
        {
            SMSEntities db = new SMSEntities();
            List<ComboboxList> list = new List<ComboboxList>();
            list = db.CategoriesFors
                        .Where(x => x.IsDeleted == false)
                        .Select(x => new ComboboxList
                        {
                            ID = x.ID,
                            Name = x.Name,
                        }).ToList();
            return list;
        }
        public static List<ComboboxList> GetCompanyDataForCombobox()
        {
            SMSEntities db = new SMSEntities();
            List<ComboboxList> list = new List<ComboboxList>();
            list = db.Companies
                        .Where(x => x.IsDeleted == false)
                        .Select(x => new ComboboxList
                        {
                            ID = x.ID,
                            Name = x.Name,
                        }).ToList();
            return list;
        }
        public static List<ComboboxList> GetShoeTypesDataForCombobox()
        {
            SMSEntities db = new SMSEntities();
            List<ComboboxList> list = new List<ComboboxList>();
            list = db.ProductCategories
                        .Where(x => x.IsDeleted == false)
                        .Select(x => new ComboboxList
                        {
                            ID = x.ID,
                            Name = x.Name,
                        }).ToList();
            return list;
        }

        public static long AddProduct(ProductModel model)
        {
            long ProductID = -1;
            SMSEntities db = new SMSEntities();
            Product product = new Product();

            product.ArticalNo = model.ArticalNo;
            product.CategoryForID = model.CategoryForID;
            product.CategoryID = model.CategoryID;
            product.ColorID = model.ColorID;
            product.CompanyID = model.CompanyID;
            product.dtDate = model.dtDate;
            product.MaxDiscount = model.MaxDiscount;
            product.MinDiscount = model.MinDiscount;
            product.SalePrice = model.SalePrice;
            product.ShowForShop = model.ShowForShop;
            product.SizeID = model.SizeID;
            product.StatusID = 1;

            db.Products.Add(product);
            db.SaveChanges();
            ProductID = product.ID;

            if (ProductID != -1)
            {
                return ProductID;
            }

            return ProductID;
        }
        public static bool UpdateProduct(ProductModel model)
        {
            bool updated = false;
            SMSEntities db = new SMSEntities();
            Product product = new Product();
            product = db.Products.Where(x => x.ID == model.ID).FirstOrDefault();
            if(product!=null)
            {
                product.ArticalNo = model.ArticalNo;
                product.CategoryForID = model.CategoryForID;
                product.CategoryID = model.CategoryID;
                product.ColorID = model.ColorID;
                product.CompanyID = model.CompanyID;
                product.dtDate = model.dtDate;
                product.MaxDiscount = model.MaxDiscount;
                product.MinDiscount = model.MinDiscount;
                product.SalePrice = model.SalePrice;
                product.ShowForShop = model.ShowForShop;
                product.SizeID = model.SizeID;
                product.StatusID = 1;

                db.Products.Attach(product);
                db.Entry(product).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();
                updated = true;               
            }           

            return updated;
        }
        public static List<ProductList> GetProductList()
        {
            SMSEntities db = new SMSEntities();
            List<ProductList> list = new List<ProductList>();

            list = db.Products
                       .Where(x => x.StatusID == 1)
                       .Select(x => new ProductList
                       {
                           ID = x.ID,
                           ArticalNo = x.ArticalNo,
                           Size = x.Size.Name,
                           Company = x.Company.Name,
                           CategoryFor = x.CategoriesFor.Name,
                           Color = x.Color.Name,
                           ShoeType = x.ProductCategory.Name,
                           SalePrice = x.SalePrice.ToString(),
                           MinDiscount = x.MinDiscount.ToString(),
                           MaxDiscount =x.MaxDiscount.ToString( )                           
                       }).ToList();
            return list;

        }
        public static Product GetProductByID(long ID)
        {
            SMSEntities db = new SMSEntities();
            Product p = new Product();

            p = db.Products.Where(x => x.ID == ID).FirstOrDefault();
            return p;
        }
    }
}
