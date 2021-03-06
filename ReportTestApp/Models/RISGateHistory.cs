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
    
    public partial class RISGateHistory
    {
        public string RISGateHistory_Key { get; set; }
        public string RISGate_Key { get; set; }
        public Nullable<System.DateTime> HistoryDate { get; set; }
        public string RISLookupGateHistoryAction_Key { get; set; }
        public string RISLookupCondition_Key { get; set; }
        public string RISLookupGateHistoryMaintenance_Key { get; set; }
        public string RISLookupGateHistoryBaseMaintenance_Key { get; set; }
        public string RISLookupGateHistoryWingMaintenance_Key { get; set; }
        public string Employee { get; set; }
        public string Comment { get; set; }
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
        public Nullable<System.DateTime> CreateDate { get; set; }
        public Nullable<System.DateTime> DateStamp { get; set; }
        public string SecurityUser_Key { get; set; }
    
        public virtual RISGate RISGate { get; set; }
        public virtual RISLookupCondition RISLookupCondition { get; set; }
        public virtual RISLookupGateHistoryAction RISLookupGateHistoryAction { get; set; }
        public virtual RISLookupGateHistoryBaseMaintenance RISLookupGateHistoryBaseMaintenance { get; set; }
        public virtual RISLookupGateHistoryMaintenance RISLookupGateHistoryMaintenance { get; set; }
        public virtual RISLookupGateHistoryWingMaintenance RISLookupGateHistoryWingMaintenance { get; set; }
        public virtual SecurityUser SecurityUser { get; set; }
    }
}
