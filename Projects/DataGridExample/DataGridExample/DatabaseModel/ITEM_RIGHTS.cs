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
    
    public partial class ITEM_RIGHTS
    {
        public string USER_NAME { get; set; }
        public string MENU_TAG { get; set; }
    
        public virtual REG_USER REG_USER { get; set; }
    }
}
