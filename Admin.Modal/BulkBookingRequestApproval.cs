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
    
    public partial class BulkBookingRequestApproval
    {
        public long Id { get; set; }
        public long TrRequestId { get; set; }
        public int ApprovedByEmpId { get; set; }
        public System.DateTime ApprovalDate { get; set; }
        public Nullable<short> ApprovalStatus { get; set; }
        public Nullable<short> IsMandatoryTravel { get; set; }
        public string Comment { get; set; }
        public Nullable<int> ApprovedByEmpIdCLevel1 { get; set; }
        public Nullable<int> ApprovedByEmpIdCLevel2 { get; set; }
        public Nullable<short> ApprovalStatusCLevel1 { get; set; }
        public Nullable<short> ApprovalStatusCLevel2 { get; set; }
        public string CLevelComment1 { get; set; }
        public string CLevelComment2 { get; set; }
        public Nullable<System.DateTime> CLevelAppDate1 { get; set; }
        public Nullable<System.DateTime> CLevelAppDate2 { get; set; }
        public Nullable<short> RevenueApprovedStatus { get; set; }
        public Nullable<System.DateTime> RevenueApprovedDate { get; set; }
        public int AddNo { get; set; }
    }
}
