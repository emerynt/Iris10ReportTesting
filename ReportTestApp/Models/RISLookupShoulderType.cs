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
    
    public partial class RISLookupShoulderType
    {
        public RISLookupShoulderType()
        {
            this.RISShoulders = new HashSet<RISShoulder>();
            this.RISShoulders1 = new HashSet<RISShoulder>();
        }
    
        public string RISLookupShoulderType_Key { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string NameDesc { get; set; }
        public string DescName { get; set; }
        public bool IsSystemData { get; set; }
    
        public virtual ICollection<RISShoulder> RISShoulders { get; set; }
        public virtual ICollection<RISShoulder> RISShoulders1 { get; set; }
    }
}
