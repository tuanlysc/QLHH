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
    
    public partial class order
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public order()
        {
            this.order_detail = new HashSet<order_detail>();
        }
    
        public int id { get; set; }
        public string address_ship { get; set; }
        public Nullable<System.DateTime> date_order { get; set; }
        public string full_name { get; set; }
        public string note { get; set; }
        public string phone { get; set; }
        public Nullable<int> status { get; set; }
        public long sum_money { get; set; }
        public Nullable<long> user_id { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<order_detail> order_detail { get; set; }
        public virtual user user { get; set; }
    }
}