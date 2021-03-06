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
    
    public partial class RISCulvert
    {
        public string RISCulvert_Key { get; set; }
        public string Road_Key { get; set; }
        public decimal Milepost { get; set; }
        public Nullable<System.DateTime> InstallationDate { get; set; }
        public string RISLookupCulvertPlacement_Key { get; set; }
        public string DirectionOfFlow { get; set; }
        public Nullable<double> Length { get; set; }
        public Nullable<double> OffsetDistance { get; set; }
        public Nullable<double> CoverDepthInlet { get; set; }
        public Nullable<double> CoverDepth { get; set; }
        public Nullable<double> CoverDepthOutlet { get; set; }
        public Nullable<double> Slope { get; set; }
        public Nullable<double> Skew { get; set; }
        public string RISLookupCulvertCarried_Key { get; set; }
        public string NamedBody { get; set; }
        public string RISLookupCulvertSystem_Key { get; set; }
        public string RISLookupCulvertShape_Key { get; set; }
        public string RISLookupCulvertMaterial_Key { get; set; }
        public string RISLookupCulvertMaterial2_Key { get; set; }
        public string RISLookupCulvertCoating_Key { get; set; }
        public string RISLookupCulvertInlet_Key { get; set; }
        public string RISLookupCulvertOutlet_Key { get; set; }
        public Nullable<double> RiseHeight { get; set; }
        public Nullable<double> SpanWidth { get; set; }
        public Nullable<short> NumberCulverts { get; set; }
        public string RISLookupCulvertQuantity_Key { get; set; }
        public Nullable<double> DistanceSpannedFeet { get; set; }
        public Nullable<System.DateTime> ConditionDate { get; set; }
        public string RISLookupCulvertCondition_Key { get; set; }
        public string Assessment { get; set; }
        public string RISLookupCulvertDrainage_Key { get; set; }
        public string RISMaintenanceDistrict_Key { get; set; }
        public byte MarkerInPlace { get; set; }
        public string AssetNumber { get; set; }
        public string Comments { get; set; }
        public Nullable<double> XCoordinate { get; set; }
        public Nullable<double> YCoordinate { get; set; }
        public Nullable<double> ZCoordinate { get; set; }
        public System.Data.Spatial.DbGeometry GISLocation { get; set; }
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
        public Nullable<int> AttachedDocuments { get; set; }
        public string Flag { get; set; }
        public byte Active { get; set; }
        public Nullable<System.DateTime> CreateDate { get; set; }
        public Nullable<System.DateTime> DateStamp { get; set; }
        public string SecurityUser_Key { get; set; }
    
        public virtual RISLookupCulvertCarried RISLookupCulvertCarried { get; set; }
        public virtual RISLookupCulvertCoating RISLookupCulvertCoating { get; set; }
        public virtual RISLookupCulvertCondition RISLookupCulvertCondition { get; set; }
        public virtual RISLookupCulvertDrainage RISLookupCulvertDrainage { get; set; }
        public virtual RISLookupCulvertInlet RISLookupCulvertInlet { get; set; }
        public virtual RISLookupCulvertMaterial RISLookupCulvertMaterial { get; set; }
        public virtual RISLookupCulvertMaterial RISLookupCulvertMaterial1 { get; set; }
        public virtual RISLookupCulvertOutlet RISLookupCulvertOutlet { get; set; }
        public virtual RISLookupCulvertPlacement RISLookupCulvertPlacement { get; set; }
        public virtual RISLookupCulvertQuantity RISLookupCulvertQuantity { get; set; }
        public virtual RISLookupCulvertShape RISLookupCulvertShape { get; set; }
        public virtual RISLookupCulvertSystem RISLookupCulvertSystem { get; set; }
        public virtual RISMaintenanceDistrict RISMaintenanceDistrict { get; set; }
        public virtual Road Road { get; set; }
    }
}
