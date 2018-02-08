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
    
    public partial class Shopping
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Shopping()
        {
            this.ShoppingInvoices = new HashSet<ShoppingInvoice>();
            this.Transactions = new HashSet<Transaction>();
        }
    
        public long ID { get; set; }
        public Nullable<long> TotalPairs { get; set; }
        public Nullable<decimal> DiscountValue { get; set; }
        public Nullable<decimal> TotalSalePrice { get; set; }
        public Nullable<decimal> DiscountedSalePrice { get; set; }
        public Nullable<System.DateTime> dtDate { get; set; }
        public Nullable<long> StatusID { get; set; }
        public Nullable<long> ReturnedShoppingID { get; set; }
        public Nullable<long> UserID { get; set; }
    
        public virtual Shopping Shopping1 { get; set; }
        public virtual Shopping Shopping2 { get; set; }
        public virtual Status Status { get; set; }
        public virtual User User { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ShoppingInvoice> ShoppingInvoices { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Transaction> Transactions { get; set; }
    }
}
