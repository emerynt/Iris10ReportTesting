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
    
    public partial class ARSInvoice
    {
        public ARSInvoice()
        {
            this.ARSInvoiceDetails = new HashSet<ARSInvoiceDetail>();
        }
    
        public string ARSInvoice_Key { get; set; }
        public string Organization_Key { get; set; }
        public string Customer_Key { get; set; }
        public string InvoiceNumber { get; set; }
        public string InvoiceType { get; set; }
        public Nullable<System.DateTime> InvoiceDate { get; set; }
        public decimal InvoiceTotal { get; set; }
        public decimal InvoiceBalance { get; set; }
        public string Description { get; set; }
        public byte PaymentComplete { get; set; }
        public string ReceivedFrom { get; set; }
        public string ReceivedBy { get; set; }
        public string PaymentType { get; set; }
        public string CheckNumber { get; set; }
        public byte Canceled { get; set; }
        public byte Deleted { get; set; }
        public Nullable<System.DateTime> CreateDate { get; set; }
        public Nullable<System.DateTime> DateStamp { get; set; }
        public byte[] TimeStamp { get; set; }
        public string SecurityUser_Key { get; set; }
    
        public virtual Customer Customer { get; set; }
        public virtual Organization Organization { get; set; }
        public virtual ICollection<ARSInvoiceDetail> ARSInvoiceDetails { get; set; }
    }
}
