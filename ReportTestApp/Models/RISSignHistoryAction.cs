//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ReportTestApp.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class RISSignHistoryAction
    {
        public RISSignHistoryAction()
        {
            this.RISSignHistories = new HashSet<RISSignHistory>();
        }
    
        public string RISSignHistoryAction_Key { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string NameDesc { get; set; }
        public string DescName { get; set; }
        public Nullable<System.DateTime> CreateDate { get; set; }
        public Nullable<System.DateTime> Datestamp { get; set; }
        public string SecurityUser_Key { get; set; }
        public bool IsSystemData { get; set; }
    
        public virtual ICollection<RISSignHistory> RISSignHistories { get; set; }
    }
}
