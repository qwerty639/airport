//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace AIRPORT.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class PATH
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public PATH()
        {
            this.DATE = new HashSet<DATE>();
            this.TICKETS = new HashSet<TICKETS>();
        }
    
        public int ID { get; set; }
        public int DISTANCE { get; set; }
        public string DEPARTURE { get; set; }
        public string DESTINATION { get; set; }
        public int IDTYPE { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DATE> DATE { get; set; }
        public virtual TYPE TYPE { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TICKETS> TICKETS { get; set; }
    }
}
