//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace QLHS.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class favourite
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public favourite()
        {
            this.favourite_item = new HashSet<favourite_item>();
        }
    
        public int id { get; set; }
        public Nullable<long> user_id { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<favourite_item> favourite_item { get; set; }
        public virtual user user { get; set; }
    }
}
