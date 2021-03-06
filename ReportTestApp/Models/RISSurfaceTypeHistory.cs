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
    
    public partial class RISSurfaceTypeHistory
    {
        public string RISSurfaceTypeHistory_Key { get; set; }
        public string RISSurfaceType_Key { get; set; }
        public Nullable<System.DateTime> HistoryDate { get; set; }
        public string RISLookupSurfaceTypeRating_Key { get; set; }
        public string RISMaintenanceType_Key { get; set; }
        public Nullable<decimal> BeginMilepost { get; set; }
        public Nullable<decimal> EndMilepost { get; set; }
        public string Comments { get; set; }
        public byte GASB34 { get; set; }
        public string Project_Key { get; set; }
        public Nullable<decimal> Cost { get; set; }
        public Nullable<decimal> SalvageValue { get; set; }
        public Nullable<int> ExpectedLife { get; set; }
        public Nullable<decimal> DepreciationThisYear { get; set; }
        public Nullable<decimal> TotalDepreciation { get; set; }
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
        public byte Active { get; set; }
        public Nullable<System.DateTime> CreateDate { get; set; }
        public Nullable<System.DateTime> Datestamp { get; set; }
        public string SecurityUser_Key { get; set; }
    
        public virtual Project Project { get; set; }
        public virtual RISLookupSurfaceTypeRating RISLookupSurfaceTypeRating { get; set; }
        public virtual RISMaintenanceType RISMaintenanceType { get; set; }
    }
}
