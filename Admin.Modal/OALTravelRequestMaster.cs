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
    
    public partial class OALTravelRequestMaster
    {
        public long TravelRequestId { get; set; }
        public string TravelRequestCode { get; set; }
        public System.DateTime RequestDate { get; set; }
        public string ReasonForTravel { get; set; }
        public string Gender { get; set; }
        public Nullable<int> RequestedEmpId { get; set; }
        public string RequestedEmpCode { get; set; }
        public string RequestedEmpName { get; set; }
        public string RequestedEmpDesignation { get; set; }
        public string RequestedEmpDept { get; set; }
        public string EmailId { get; set; }
        public string Phno { get; set; }
        public Nullable<short> Passengers { get; set; }
        public string Meals { get; set; }
        public string Pnr { get; set; }
        public Nullable<decimal> PnrAmount { get; set; }
        public string BookingStatus { get; set; }
        public Nullable<System.DateTime> StatusDate { get; set; }
        public Nullable<bool> IsCabRequired { get; set; }
        public Nullable<bool> IsHotelRequired { get; set; }
        public string address { get; set; }
        public string city { get; set; }
        public string state { get; set; }
        public Nullable<int> RequestedEmpDeptId { get; set; }
        public string ITHResponseStatus { get; set; }
        public string FinancialApproval { get; set; }
    }
}
