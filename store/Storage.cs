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
    
    public partial class Storage
    {
        public long id_storage { get; set; }
        public long product { get; set; }
        public System.DateTime data_delivery { get; set; }
        public long amount { get; set; }
    
        public virtual Products Products { get; set; }
    }
}
