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
    
    public partial class SINTSMET_ANPOK
    {
        public string SMETKA { get; set; }
        public int ID { get; set; }
        public string IS_NOM_REQUIRED { get; set; }
        public Nullable<short> POS { get; set; }
        public Nullable<short> N_SIZE { get; set; }
    
        public virtual ANPOK ANPOK { get; set; }
        public virtual SINTSMET SINTSMET { get; set; }
    }
}
