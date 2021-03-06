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
    
    public partial class Inv_Transact
    {
        public int Inv_Transact_Key { get; set; }
        public string Inventory_Location_Key { get; set; }
        public string Transaction_Type { get; set; }
        public Nullable<System.DateTime> Inv_Date { get; set; }
        public string Vendor_Key { get; set; }
        public string Tracking_Number { get; set; }
        public Nullable<decimal> PrevQuantity { get; set; }
        public Nullable<decimal> PrevPriceValue { get; set; }
        public decimal Quantity { get; set; }
        public decimal Price_Value { get; set; }
        public Nullable<decimal> Adjusted_Quantity { get; set; }
        public Nullable<decimal> Adjusted_Price_Value { get; set; }
        public Nullable<decimal> Total_Cost_Change { get; set; }
        public Nullable<decimal> Labor_Cost { get; set; }
        public Nullable<decimal> Equipment_Cost { get; set; }
        public string Comments { get; set; }
        public string Transact_Key { get; set; }
        public Nullable<System.DateTime> CreateDate { get; set; }
        public Nullable<System.DateTime> DateStamp { get; set; }
        public string SecurityUser_Key { get; set; }
    
        public virtual Inventory_Location Inventory_Location { get; set; }
        public virtual Vendor Vendor { get; set; }
    }
}
