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
    
    public partial class SWSManagementSectionAudit
    {
        public int SWSManagementSectionAudit_Key { get; set; }
        public Nullable<System.DateTime> TransactionDate { get; set; }
        public string TransactionType { get; set; }
        public string UserName { get; set; }
        public string AuditComments { get; set; }
        public string SWSManagementSection_Key { get; set; }
        public string ManagementSectionID { get; set; }
        public string Road_Key { get; set; }
        public decimal BeginMilepost { get; set; }
        public decimal EndMilepost { get; set; }
        public string BeginLocation { get; set; }
        public string EndLocation { get; set; }
        public Nullable<System.DateTime> DateOfConstruction { get; set; }
        public string SWSSubGrade_Key { get; set; }
        public string SWSLookupFederalFunctionalClass_Key { get; set; }
        public string SWSLookupCountyFunctionalClass_Key { get; set; }
        public string SWSLookupSurface_Key { get; set; }
        public double SurfaceWidth { get; set; }
        public Nullable<decimal> SurfaceLengthMiles { get; set; }
        public Nullable<decimal> SurfaceLengthFeet { get; set; }
        public Nullable<double> SurfaceArea { get; set; }
        public Nullable<int> InspectionRating { get; set; }
        public Nullable<System.DateTime> RatingDate { get; set; }
        public string SWSLookupRoadRating_Key { get; set; }
        public string SWSLookupRoadDesiredRating_Key { get; set; }
        public string SWSLookupRatingType_Key { get; set; }
        public string Fiscal_Key { get; set; }
        public string SWSMaintenanceType_Key { get; set; }
        public double NumberOfLanes { get; set; }
        public double LaneWidth { get; set; }
        public string SWSLookupLaneDirection_Key { get; set; }
        public Nullable<double> LaneMiles { get; set; }
        public string RISMaintenanceDistrict_Key { get; set; }
        public string SWSLookupJurisdiction_Key { get; set; }
        public string SWSLookupCity_Key { get; set; }
        public Nullable<byte> MPO { get; set; }
        public Nullable<byte> CanInspect { get; set; }
        public Nullable<double> WheelPathLengthFeet { get; set; }
        public string Comments { get; set; }
        public Nullable<decimal> StructuralNumberTotal { get; set; }
        public Nullable<byte> MigratedFromStreetSaver { get; set; }
        public Nullable<byte> MigratedFromRIS { get; set; }
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
        public string Flag { get; set; }
        public Nullable<System.DateTime> CreateDate { get; set; }
        public Nullable<System.DateTime> DateStamp { get; set; }
        public string SecurityUser_Key { get; set; }
    
        public virtual SWSLookupCity SWSLookupCity { get; set; }
        public virtual SWSLookupCountyFunctionalClass SWSLookupCountyFunctionalClass { get; set; }
        public virtual SWSLookupFederalFunctionalClass SWSLookupFederalFunctionalClass { get; set; }
        public virtual SWSLookupJurisdiction SWSLookupJurisdiction { get; set; }
        public virtual SWSLookupLaneDirection SWSLookupLaneDirection { get; set; }
        public virtual SWSLookupRatingType SWSLookupRatingType { get; set; }
        public virtual SWSLookupRoadRating SWSLookupRoadRating { get; set; }
        public virtual SWSLookupSurface SWSLookupSurface { get; set; }
        public virtual SWSMaintenanceType SWSMaintenanceType { get; set; }
        public virtual SWSManagementSection SWSManagementSection { get; set; }
        public virtual SWSSubGrade SWSSubGrade { get; set; }
    }
}
