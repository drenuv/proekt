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
    
    public partial class Users
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Users()
        {
            this.Deals = new HashSet<Deals>();
        }
    
        public long id_user { get; set; }
        public string e_mail { get; set; }
        public string name { get; set; }
        public string phone { get; set; }
        public string password { get; set; }
        public int gender { get; set; }
        public System.DateTime data_registration { get; set; }
        public Nullable<System.DateTime> birthday { get; set; }
        public int type { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Deals> Deals { get; set; }
        public virtual Gender Gender1 { get; set; }
        public virtual User_type User_type { get; set; }
    }
}
