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
    
    public partial class SecurityObject
    {
        public SecurityObject()
        {
            this.Comments = new HashSet<Comment>();
            this.CountyUtilities = new HashSet<CountyUtility>();
            this.Documents = new HashSet<Document>();
            this.FilterRPTSorts = new HashSet<FilterRPTSort>();
            this.FilterSavedDatas = new HashSet<FilterSavedData>();
            this.FilterSysDatas = new HashSet<FilterSysData>();
            this.GridConfigs = new HashSet<GridConfig>();
            this.LookupValuesDetails = new HashSet<LookupValuesDetail>();
            this.ReportOptions = new HashSet<ReportOption>();
            this.RPTCriterias = new HashSet<RPTCriteria>();
            this.RPTCriteriaSaveds = new HashSet<RPTCriteriaSaved>();
            this.SecurityObjectUses = new HashSet<SecurityObjectUse>();
            this.SecurityUserRights = new HashSet<SecurityUserRight>();
        }
    
        public string SecurityObject_Key { get; set; }
        public string ObjectTitle { get; set; }
        public string Description { get; set; }
        public string Module_Key { get; set; }
        public string ObjectType { get; set; }
        public string FileName { get; set; }
        public byte SummaryDetail { get; set; }
        public string Report_Type_Key { get; set; }
        public string BaseTable { get; set; }
        public string SpecialNotes { get; set; }
        public byte AllCounties { get; set; }
        public byte AllowSort { get; set; }
        public byte Enabled { get; set; }
        public string DisabledDescription { get; set; }
        public byte AllowSecurity { get; set; }
        public string ChildSecurityObject_Key { get; set; }
        public Nullable<System.DateTime> CreateDate { get; set; }
        public Nullable<System.DateTime> DateStamp { get; set; }
        public string SecurityUser_Key { get; set; }
    
        public virtual ICollection<Comment> Comments { get; set; }
        public virtual ICollection<CountyUtility> CountyUtilities { get; set; }
        public virtual ICollection<Document> Documents { get; set; }
        public virtual ICollection<FilterRPTSort> FilterRPTSorts { get; set; }
        public virtual ICollection<FilterSavedData> FilterSavedDatas { get; set; }
        public virtual ICollection<FilterSysData> FilterSysDatas { get; set; }
        public virtual ICollection<GridConfig> GridConfigs { get; set; }
        public virtual ICollection<LookupValuesDetail> LookupValuesDetails { get; set; }
        public virtual Module Module { get; set; }
        public virtual ICollection<ReportOption> ReportOptions { get; set; }
        public virtual ICollection<RPTCriteria> RPTCriterias { get; set; }
        public virtual ICollection<RPTCriteriaSaved> RPTCriteriaSaveds { get; set; }
        public virtual ICollection<SecurityObjectUse> SecurityObjectUses { get; set; }
        public virtual ICollection<SecurityUserRight> SecurityUserRights { get; set; }
    }
}
