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
    
    public partial class VMSAgentUOM
    {
        public VMSAgentUOM()
        {
            this.VMSPURSReportAgents = new HashSet<VMSPURSReportAgent>();
            this.VMSSprayReportAgents = new HashSet<VMSSprayReportAgent>();
        }
    
        public string VMSAgentUOM_Key { get; set; }
        public string Name { get; set; }
        public Nullable<System.DateTime> DateStamp { get; set; }
        public string SecurityUser_Key { get; set; }
    
        public virtual ICollection<VMSPURSReportAgent> VMSPURSReportAgents { get; set; }
        public virtual ICollection<VMSSprayReportAgent> VMSSprayReportAgents { get; set; }
    }
}
