//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace store
{
    using System;
    using System.Collections.Generic;
    
    public partial class Products
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Products()
        {
            this.Deal_product = new HashSet<Deal_product>();
            this.Storage = new HashSet<Storage>();
            this.Type_products = new HashSet<Type_products>();
        }
    
        public long id_product { get; set; }
        public decimal price { get; set; }
        public long manufacturer { get; set; }
        public string barcode { get; set; }
        public string name_product { get; set; }
        public string description { get; set; }
        public byte[] image { get; set; }

        public long amount
        {
            get
            {
                long amount = 0;
                foreach (var i in Storage)
                {
                    amount += i.amount;

                }
                amount -= Deal_product.Count;
                return amount;
            }
        }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Deal_product> Deal_product { get; set; }
        public virtual Manufacturers Manufacturers { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Storage> Storage { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Type_products> Type_products { get; set; }
    }
}
