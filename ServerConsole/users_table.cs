//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ServerConsole
{
    using System;
    using System.Collections.Generic;
    
    public partial class users_table
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public users_table()
        {
            this.books_table = new HashSet<books_table>();
        }
    
        public int C_user_id { get; set; }
        public string C_last_name { get; set; }
        public string C_name { get; set; }
        public string C_middle_name { get; set; }
        public string C_phone_number { get; set; }
        public string C_adress { get; set; }
        public string C_password { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<books_table> books_table { get; set; }
    }
}
