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
    
    public partial class SWSLookupRoadRating
    {
        public SWSLookupRoadRating()
        {
            this.SWSInspectionHistories = new HashSet<SWSInspectionHistory>();
            this.SWSMaintenanceEntries = new HashSet<SWSMaintenanceEntry>();
            this.SWSMaintenanceEntries1 = new HashSet<SWSMaintenanceEntry>();
            this.SWSMaintenanceHistories = new HashSet<SWSMaintenanceHistory>();
            this.SWSManagementSections = new HashSet<SWSManagementSection>();
            this.SWSManagementSectionAudits = new HashSet<SWSManagementSectionAudit>();
            this.SWSRoadRatingEntries = new HashSet<SWSRoadRatingEntry>();
            this.SWSRoadRatingHistories = new HashSet<SWSRoadRatingHistory>();
        }
    
        public string SWSLookupRoadRating_Key { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string NameDesc { get; set; }
        public string DescName { get; set; }
        public bool IsSystemData { get; set; }
    
        public virtual ICollection<SWSInspectionHistory> SWSInspectionHistories { get; set; }
        public virtual ICollection<SWSMaintenanceEntry> SWSMaintenanceEntries { get; set; }
        public virtual ICollection<SWSMaintenanceEntry> SWSMaintenanceEntries1 { get; set; }
        public virtual ICollection<SWSMaintenanceHistory> SWSMaintenanceHistories { get; set; }
        public virtual ICollection<SWSManagementSection> SWSManagementSections { get; set; }
        public virtual ICollection<SWSManagementSectionAudit> SWSManagementSectionAudits { get; set; }
        public virtual ICollection<SWSRoadRatingEntry> SWSRoadRatingEntries { get; set; }
        public virtual ICollection<SWSRoadRatingHistory> SWSRoadRatingHistories { get; set; }
    }
}
