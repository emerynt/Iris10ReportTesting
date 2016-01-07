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
    
    public partial class RISMaintenanceType
    {
        public RISMaintenanceType()
        {
            this.RISMaintenanceSchedules = new HashSet<RISMaintenanceSchedule>();
            this.RISMaintenanceScheduleHistories = new HashSet<RISMaintenanceScheduleHistory>();
            this.RISSurfaceTypes = new HashSet<RISSurfaceType>();
            this.RISSurfaceTypeHistories = new HashSet<RISSurfaceTypeHistory>();
        }
    
        public string RISMaintenanceType_Key { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string NameDesc { get; set; }
        public string DescName { get; set; }
        public byte Active { get; set; }
        public Nullable<System.DateTime> Datestamp { get; set; }
        public string SecurityUser_Key { get; set; }
        public bool IsSystemData { get; set; }
    
        public virtual ICollection<RISMaintenanceSchedule> RISMaintenanceSchedules { get; set; }
        public virtual ICollection<RISMaintenanceScheduleHistory> RISMaintenanceScheduleHistories { get; set; }
        public virtual ICollection<RISSurfaceType> RISSurfaceTypes { get; set; }
        public virtual ICollection<RISSurfaceTypeHistory> RISSurfaceTypeHistories { get; set; }
    }
}
