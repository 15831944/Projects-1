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
    
    public partial class PART_LOG
    {
        public decimal SEQ { get; set; }
        public string PARTNUMBER { get; set; }
        public string OLD_DIG_CODE { get; set; }
        public Nullable<decimal> OLD_PRICE { get; set; }
        public string NEW_DIG_CODE { get; set; }
        public Nullable<decimal> NEW_PRICE { get; set; }
        public Nullable<System.DateTime> TS { get; set; }
        public string TABLE_NAME { get; set; }
        public string TYP { get; set; }
        public string USER_NAME { get; set; }
        public Nullable<int> KONTRAGENT { get; set; }
    }
}
