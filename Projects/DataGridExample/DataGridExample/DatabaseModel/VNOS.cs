//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DataGridExample.DatabaseModel
{
    using System;
    using System.Collections.Generic;
    
    public partial class VNOS
    {
        public VNOS()
        {
            this.VNOSINVOICE = new HashSet<VNOSINVOICE>();
            this.VNOSRAZHODI = new HashSet<VNOSRAZHODI>();
        }
    
        public string VNOSKOD { get; set; }
        public Nullable<System.DateTime> DATA { get; set; }
        public Nullable<int> KOD { get; set; }
        public string DIG_CODE { get; set; }
        public Nullable<decimal> SUMAVAL { get; set; }
        public Nullable<decimal> VALKURS { get; set; }
        public Nullable<decimal> SUMALV { get; set; }
        public Nullable<int> OPR_ID { get; set; }
        public string TYPDOC { get; set; }
    
        public virtual ICollection<VNOSINVOICE> VNOSINVOICE { get; set; }
        public virtual ICollection<VNOSRAZHODI> VNOSRAZHODI { get; set; }
    }
}
