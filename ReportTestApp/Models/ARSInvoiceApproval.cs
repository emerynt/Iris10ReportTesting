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
    
    public partial class ARSInvoiceApproval
    {
        public string ARSInvoiceApproval_Key { get; set; }
        public string Organization_Key { get; set; }
        public string InvoiceNumber { get; set; }
        public string Resource_Type_Key { get; set; }
        public string Transact_Key { get; set; }
        public string Customer_Key { get; set; }
        public string Activity_Key { get; set; }
        public string Project_Key { get; set; }
        public string ARSBudgetDetail_Key { get; set; }
        public string ARSContract_Key { get; set; }
        public Nullable<System.DateTime> DateOfService { get; set; }
        public string Description { get; set; }
        public decimal Quantity { get; set; }
        public decimal BillRate { get; set; }
        public Nullable<decimal> ExtendedCost { get; set; }
        public string UOM_Key { get; set; }
        public string Comments { get; set; }
        public Nullable<byte> Approved { get; set; }
        public string Error_Message { get; set; }
        public Nullable<System.DateTime> DateStamp { get; set; }
        public string SecurityUser_Key { get; set; }
    
        public virtual Activity Activity { get; set; }
        public virtual ARSBudgetDetail ARSBudgetDetail { get; set; }
        public virtual ARSContract ARSContract { get; set; }
        public virtual Organization Organization { get; set; }
        public virtual Resource_Type Resource_Type { get; set; }
        public virtual Customer Customer { get; set; }
        public virtual Project Project { get; set; }
        public virtual UOM UOM { get; set; }
    }
}
