//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace FinalMath.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class HEAD
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public HEAD()
        {
            this.DISHEADS = new HashSet<DISHEAD>();
            this.DUES = new HashSet<DUE>();
        }
    
        public int HEAD_ID { get; set; }
        public Nullable<int> HEADTYPE_FID { get; set; }
        public string HEAD_NAME { get; set; }
        public bool isActive { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DISHEAD> DISHEADS { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DUE> DUES { get; set; }
        public virtual HEADTYPE HEADTYPE { get; set; }
    }
}
