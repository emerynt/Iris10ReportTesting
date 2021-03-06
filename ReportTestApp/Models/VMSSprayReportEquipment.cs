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
    
    public partial class VMSSprayReportEquipment
    {
        public string VMSSprayReportEquipment_Key { get; set; }
        public string VMSSprayReport_Key { get; set; }
        public string Equipment_Key { get; set; }
        public double Hours { get; set; }
        public string Activity_Key { get; set; }
        public string VMSSprayDelivery_Key { get; set; }
        public string VMSSprayApplication_Key { get; set; }
        public Nullable<double> SprayPressure { get; set; }
        public string Swath { get; set; }
        public Nullable<System.DateTime> DateStamp { get; set; }
        public string SecurityUser_Key { get; set; }
    
        public virtual Activity Activity { get; set; }
        public virtual Equipment Equipment { get; set; }
        public virtual VMSSprayApplication VMSSprayApplication { get; set; }
        public virtual VMSSprayDelivery VMSSprayDelivery { get; set; }
        public virtual VMSSprayReport VMSSprayReport { get; set; }
    }
}
