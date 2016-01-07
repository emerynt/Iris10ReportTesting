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
    
    public partial class Transact
    {
        public string Transact_Key { get; set; }
        public string Batch_Num { get; set; }
        public System.DateTime Task_Date { get; set; }
        public string Crew_Num { get; set; }
        public string Fiscal_Key { get; set; }
        public string Activity_Key { get; set; }
        public Nullable<decimal> Production { get; set; }
        public string Employee_Key { get; set; }
        public string Equipment_Key { get; set; }
        public string ResourceClass_Key { get; set; }
        public string Resource_Type_Key { get; set; }
        public Nullable<decimal> Quantity { get; set; }
        public string UOM_Key { get; set; }
        public string Pay_Type_Key { get; set; }
        public string Premium_Key { get; set; }
        public Nullable<decimal> Class_Rate { get; set; }
        public Nullable<decimal> Bill_Rate { get; set; }
        public Nullable<decimal> Resource_Rate { get; set; }
        public bool Overridden_Labor_Rate { get; set; }
        public Nullable<decimal> Employee_Rate { get; set; }
        public Nullable<decimal> Fringe_Rate { get; set; }
        public Nullable<decimal> OH_Rate { get; set; }
        public Nullable<decimal> Other_Rate { get; set; }
        public Nullable<decimal> Pay_Factor { get; set; }
        public Nullable<decimal> Premium_Amount { get; set; }
        public Nullable<decimal> Premium_Percentage { get; set; }
        public string Description { get; set; }
        public string Inventory_Location_Key { get; set; }
        public string Mgt_Unit_Key { get; set; }
        public string Program_Key { get; set; }
        public string Zone_Key { get; set; }
        public string Project_Key { get; set; }
        public string RBF_Key { get; set; }
        public string Road_Key { get; set; }
        public string RoadName_Key { get; set; }
        public Nullable<decimal> Beg_Point { get; set; }
        public Nullable<decimal> End_Point { get; set; }
        public string FromLocation { get; set; }
        public string ToLocation { get; set; }
        public string Reason_Key { get; set; }
        public string SRSRequestNumber { get; set; }
        public string APSTransact_Key { get; set; }
        public Nullable<byte> PostedFromAPS { get; set; }
        public string Comments { get; set; }
        public bool ExportMMS { get; set; }
        public Nullable<bool> ExportARS { get; set; }
        public Nullable<byte> ExportARSDeleted { get; set; }
        public byte FuelImport { get; set; }
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
        public decimal OHCost { get; set; }
        public byte OH_Calc_Method { get; set; }
        public byte FixedEmployeeRate { get; set; }
        public Nullable<decimal> EmployeeHourlyRateWithPremium { get; set; }
        public Nullable<decimal> EmployeeHourlyRateWithPremiumPayFactor { get; set; }
        public Nullable<decimal> PemiumHourlyRate { get; set; }
        public Nullable<decimal> TotalClassCost { get; set; }
        public Nullable<decimal> TotalResourceCost { get; set; }
        public Nullable<decimal> TotalBillCost { get; set; }
        public Nullable<decimal> TotalLaborWithFringeOH { get; set; }
        public Nullable<decimal> TotalLaborWithoutFringeOH { get; set; }
        public Nullable<decimal> TotalLaborWithoutFringeOHOther { get; set; }
        public Nullable<decimal> TotalLaborWithoutOH { get; set; }
        public Nullable<decimal> TotalOHWithFringe { get; set; }
        public Nullable<decimal> TotalOHWithoutFringe { get; set; }
        public string RecordID { get; set; }
        public Nullable<System.DateTime> TimecardDatestamp { get; set; }
        public Nullable<System.DateTime> CreateDate { get; set; }
        public Nullable<System.DateTime> DateStamp { get; set; }
        public string SecurityUser_Key { get; set; }
        public Nullable<decimal> TotalFringe { get; set; }
        public string ProjectSub_Key { get; set; }
        public string CreatedBySecurityUser_Key { get; set; }
        public string PostedBySecurityUser_Key { get; set; }
        public Nullable<System.DateTime> PostedDate { get; set; }
        public Nullable<decimal> TotalLaborWithoutOHOther { get; set; }
        public string Vendor_Key { get; set; }
        public string Timecard_Key { get; set; }
    
        public virtual Activity Activity { get; set; }
        public virtual Employee Employee { get; set; }
        public virtual Equipment Equipment { get; set; }
        public virtual Fiscal Fiscal { get; set; }
        public virtual Inventory_Location Inventory_Location { get; set; }
        public virtual Mgt_Unit Mgt_Unit { get; set; }
        public virtual Pay_Type Pay_Type { get; set; }
        public virtual Premium Premium { get; set; }
        public virtual Program Program { get; set; }
        public virtual Project Project { get; set; }
        public virtual ProjectSub ProjectSub { get; set; }
        public virtual RBF RBF { get; set; }
        public virtual Reason Reason { get; set; }
        public virtual Resource_Type Resource_Type { get; set; }
        public virtual ResourceClass ResourceClass { get; set; }
        public virtual Road Road { get; set; }
        public virtual RoadName RoadName { get; set; }
        public virtual SecurityUser SecurityUser { get; set; }
        public virtual SecurityUser SecurityUser1 { get; set; }
        public virtual SecurityUser SecurityUser2 { get; set; }
        public virtual Vendor Vendor { get; set; }
        public virtual UOM UOM { get; set; }
        public virtual Zone Zone { get; set; }
    }
}
