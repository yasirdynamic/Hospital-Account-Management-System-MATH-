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
    
    public partial class DISHEAD
    {
        public int DISHEAD_ID { get; set; }
        public Nullable<int> DISTYPEFID { get; set; }
        public Nullable<int> HEADS_FID { get; set; }
        public Nullable<decimal> AMOUNT { get; set; }
    
        public virtual DISTYPE DISTYPE { get; set; }
        public virtual HEAD HEAD { get; set; }
    }
}
