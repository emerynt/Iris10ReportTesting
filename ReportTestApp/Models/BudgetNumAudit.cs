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
    
    public partial class BudgetNumAudit
    {
        public int BudgetNumAudit_Key { get; set; }
        public Nullable<System.DateTime> TransactionDate { get; set; }
        public string TransactionType { get; set; }
        public string UserName { get; set; }
        public string BudgetNum_Key { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string LongName { get; set; }
        public string BudgetType { get; set; }
        public byte Active { get; set; }
        public int AttachedDocuments { get; set; }
        public Nullable<System.DateTime> Datestamp { get; set; }
        public byte[] TimeStamp { get; set; }
        public string SecurityUser_Key { get; set; }
    }
}
