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
    
    public partial class FINANCIALYEAR
    {
        public int FINANCIALYEAR_ID { get; set; }
        public string FINANCIAL_YEAR { get; set; }
        public Nullable<System.DateTime> START_DATE { get; set; }
        public Nullable<System.DateTime> END_DATE { get; set; }
        public Nullable<decimal> OPENING_BALANCE { get; set; }
        public bool isActive { get; set; }
    }
}