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
    
    public partial class ReportBatchAddress
    {
        public int ReportBatchAddress_Key { get; set; }
        public string EmailAddress { get; set; }
        public Nullable<System.DateTime> LastEmailDate { get; set; }
        public bool Active { get; set; }
        public int ReportBatch_Key { get; set; }
    }
}
