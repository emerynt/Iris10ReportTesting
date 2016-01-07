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
    
    public partial class SRSSection
    {
        public SRSSection()
        {
            this.SRSRequests = new HashSet<SRSRequest>();
            this.SRSRequestHistories = new HashSet<SRSRequestHistory>();
            this.SRSRequestHistories1 = new HashSet<SRSRequestHistory>();
            this.SRSSectionDetails = new HashSet<SRSSectionDetail>();
            this.SRSSectionRequestCategories = new HashSet<SRSSectionRequestCategory>();
        }
    
        public string SRSSection_Key { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string NameDesc { get; set; }
        public string DescName { get; set; }
        public string SRSRequestCategory_Key { get; set; }
        public string SRSUser_Key { get; set; }
        public byte Active { get; set; }
        public Nullable<System.DateTime> DateStamp { get; set; }
        public Nullable<System.DateTime> CreateDate { get; set; }
        public string SecurityUser_Key { get; set; }
    
        public virtual ICollection<SRSRequest> SRSRequests { get; set; }
        public virtual SRSRequestCategory SRSRequestCategory { get; set; }
        public virtual ICollection<SRSRequestHistory> SRSRequestHistories { get; set; }
        public virtual ICollection<SRSRequestHistory> SRSRequestHistories1 { get; set; }
        public virtual SRSUser SRSUser { get; set; }
        public virtual ICollection<SRSSectionDetail> SRSSectionDetails { get; set; }
        public virtual ICollection<SRSSectionRequestCategory> SRSSectionRequestCategories { get; set; }
    }
}
