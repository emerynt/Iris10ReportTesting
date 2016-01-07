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
    
    public partial class Inventory
    {
        public Inventory()
        {
            this.Inventory_Location = new HashSet<Inventory_Location>();
            this.InventoryTransfers = new HashSet<InventoryTransfer>();
        }
    
        public string Inventory_Key { get; set; }
        public string ResourceClass_Key { get; set; }
        public string InventoryCategory_Key { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string NameDesc { get; set; }
        public string DescName { get; set; }
        public string Source_Key { get; set; }
        public string UOM_Key { get; set; }
        public Nullable<decimal> Markup { get; set; }
        public string Vendor_Key { get; set; }
        public Nullable<decimal> Receipt_Tolerance { get; set; }
        public Nullable<decimal> Cost_Tolerance { get; set; }
        public string ABC_Code { get; set; }
        public Nullable<decimal> Reorder_Point { get; set; }
        public Nullable<decimal> Safety_Stock { get; set; }
        public Nullable<decimal> Min_Order_Qty { get; set; }
        public Nullable<decimal> Max_Order_Qty { get; set; }
        public Nullable<short> Lead_Time { get; set; }
        public Nullable<byte> FuelInventoryItem { get; set; }
        public byte AllowNegativeQuantity { get; set; }
        public string NotUsed2 { get; set; }
        public string NotUsed3 { get; set; }
        public string NotUsed4 { get; set; }
        public string NotUsed5 { get; set; }
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
        public int AttachedDocuments { get; set; }
        public Nullable<System.DateTime> CreateDate { get; set; }
        public Nullable<System.DateTime> DateStamp { get; set; }
        public string SecurityUser_Key { get; set; }
        public string CRWResourceClassUVW_Key { get; set; }
    
        public virtual InventoryCategory InventoryCategory { get; set; }
        public virtual ResourceClass ResourceClass { get; set; }
        public virtual ICollection<Inventory_Location> Inventory_Location { get; set; }
        public virtual Source Source { get; set; }
        public virtual UOM UOM { get; set; }
        public virtual Vendor Vendor { get; set; }
        public virtual ICollection<InventoryTransfer> InventoryTransfers { get; set; }
    }
}
