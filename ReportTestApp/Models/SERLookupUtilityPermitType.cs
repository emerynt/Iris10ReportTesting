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
    
    public partial class SERLookupUtilityPermitType
    {
        public SERLookupUtilityPermitType()
        {
            this.SERUtilityPermits = new HashSet<SERUtilityPermit>();
        }
    
        public string SERLookupUtilityPermitType_Key { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string NameDesc { get; set; }
        public string DescName { get; set; }
        public bool IsSystemData { get; set; }
    
        public virtual ICollection<SERUtilityPermit> SERUtilityPermits { get; set; }
    }
}
