//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Admin.Modal
{
    using System;
    using System.Collections.Generic;
    
    public partial class SmsConfirmation
    {
        public int Id { get; set; }
        public int EmpId { get; set; }
        public string PNR { get; set; }
        public System.DateTime CreateDate { get; set; }
        public bool IsSendSMS { get; set; }
        public bool IsGivenFeedback { get; set; }
        public string Phone { get; set; }
    }
}
