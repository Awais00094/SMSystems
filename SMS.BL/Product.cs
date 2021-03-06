//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SMS.BL
{
    using System;
    using System.Collections.Generic;
    
    public partial class Product
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Product()
        {
            this.ProductStocks = new HashSet<ProductStock>();
            this.PurchaseDetails = new HashSet<PurchaseDetail>();
            this.ShoppingDetails = new HashSet<ShoppingDetail>();
        }
    
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
    
        public virtual CategoriesFor CategoriesFor { get; set; }
        public virtual Color Color { get; set; }
        public virtual Company Company { get; set; }
        public virtual ProductCategory ProductCategory { get; set; }
        public virtual Size Size { get; set; }
        public virtual Status Status { get; set; }
        public virtual User User { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ProductStock> ProductStocks { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PurchaseDetail> PurchaseDetails { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ShoppingDetail> ShoppingDetails { get; set; }
    }
}
