//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WMS.DAL
{
    using System;
    using System.Collections.Generic;
    
    public partial class Sensors
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Sensors()
        {
            this.Values = new HashSet<Values>();
        }
    
        public int ID { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
        public Nullable<double> LAT { get; set; }
        public Nullable<double> LNG { get; set; }
        public string Radius { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Values> Values { get; set; }
    }
}
