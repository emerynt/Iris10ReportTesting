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
    
    public partial class ARSPaymentDetail
    {
        public string ARSPaymentDetail_Key { get; set; }
        public string ARSPayment_Key { get; set; }
        public string ARSInvoiceDetail_Key { get; set; }
        public decimal Amount { get; set; }
        public Nullable<System.DateTime> PaymentDate { get; set; }
        public byte Refund { get; set; }
        public string RefundNumber { get; set; }
        public string RefundDescription { get; set; }
        public Nullable<System.DateTime> DateStamp { get; set; }
        public byte[] TimeStamp { get; set; }
        public string SecurityUser_Key { get; set; }
    
        public virtual ARSPayment ARSPayment { get; set; }
    }
}
