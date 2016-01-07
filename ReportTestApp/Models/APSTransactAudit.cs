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
    
    public partial class APSTransactAudit
    {
        public int APSTransactAudit_Key { get; set; }
        public Nullable<System.DateTime> TransactionDate { get; set; }
        public string TransactionType { get; set; }
        public string UserName { get; set; }
        public string AuditComments { get; set; }
        public string APSTransact_Key { get; set; }
        public string Organization_Key { get; set; }
        public string Batch_Num { get; set; }
        public string Vendor_Key { get; set; }
        public string InvoiceNumber { get; set; }
        public Nullable<System.DateTime> InvoiceDate { get; set; }
        public Nullable<System.DateTime> DueDate { get; set; }
        public string CheckNumber { get; set; }
        public Nullable<System.DateTime> PaymentDate { get; set; }
        public Nullable<System.DateTime> ReleaseDate { get; set; }
        public string Resource_Type_Key { get; set; }
        public string Activity_Key { get; set; }
        public Nullable<System.DateTime> TaskDate { get; set; }
        public string Road_Key { get; set; }
        public Nullable<decimal> BegMP { get; set; }
        public Nullable<decimal> EndMP { get; set; }
        public string FromLocation { get; set; }
        public string ToLocation { get; set; }
        public Nullable<decimal> Production { get; set; }
        public string Project_Key { get; set; }
        public string ProjectSub_Key { get; set; }
        public string RBF_Key { get; set; }
        public string Mgt_Unit_Key { get; set; }
        public string Program_Key { get; set; }
        public string Zone_Key { get; set; }
        public string APSBudgetDetail_Key { get; set; }
        public decimal Quantity { get; set; }
        public decimal Unit_Cost { get; set; }
        public Nullable<decimal> ExtendedCost { get; set; }
        public string Inventory_Location_Key { get; set; }
        public string Contract_Key { get; set; }
        public byte Inventory_Post { get; set; }
        public byte CAS_Post { get; set; }
        public byte PostToAR { get; set; }
        public string UOM_Key { get; set; }
        public string Description { get; set; }
        public string Comments { get; set; }
        public string PONumber { get; set; }
        public byte Voided { get; set; }
        public string User1 { get; set; }
        public string User2 { get; set; }
        public string User3 { get; set; }
        public string User4 { get; set; }
        public string User5 { get; set; }
        public string User6 { get; set; }
        public string User7 { get; set; }
        public string User8 { get; set; }
        public string User9 { get; set; }
        public string User10 { get; set; }
        public byte ImportedFromInvRec { get; set; }
        public Nullable<System.DateTime> DateStamp { get; set; }
        public byte[] TimeStamp { get; set; }
        public string SecurityUser_Key { get; set; }
    
        public virtual Organization Organization { get; set; }
        public virtual ProjectSub ProjectSub { get; set; }
    }
}
