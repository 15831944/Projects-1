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
    
    public partial class SCET_STAT_ITEM
    {
        public int ID { get; set; }
        public short POS { get; set; }
        public string D_K { get; set; }
        public string SMETKA { get; set; }
        public string PARTIDA { get; set; }
        public string TXT { get; set; }
    
        public virtual SCET_STAT SCET_STAT { get; set; }
    }
}
