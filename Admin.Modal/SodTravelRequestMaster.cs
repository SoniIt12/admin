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
    
    public partial class SodTravelRequestMaster
    {
        public long TravelRequestId { get; set; }
        public string TravelRequestCode { get; set; }
        public int TravelRequestTypeId { get; set; }
        public System.DateTime RequestDate { get; set; }
        public short SodBookingTypeId { get; set; }
        public string BookingFor { get; set; }
        public Nullable<short> IsMandatoryTravel { get; set; }
        public string ReasonForMandatoryTravel { get; set; }
        public string ReasonForTravel { get; set; }
        public int RequestedEmpId { get; set; }
        public string RequestedEmpCode { get; set; }
        public string RequestedEmpName { get; set; }
        public string RequestedEmpDesignation { get; set; }
        public string RequestedEmpDept { get; set; }
        public string EmailId { get; set; }
        public string Phno { get; set; }
        public Nullable<short> Passengers { get; set; }
        public string Meals { get; set; }
        public string Pnr { get; set; }
        public decimal PnrAmount { get; set; }
        public string PassEmailId { get; set; }
        public string PassAddressLine1 { get; set; }
        public string PassAddressLine2 { get; set; }
        public string PassCity { get; set; }
        public string PassCountry { get; set; }
        public string CLevelApprover1 { get; set; }
        public string CLevelApprover2 { get; set; }
        public string BookingStatus { get; set; }
        public Nullable<System.DateTime> StatusDate { get; set; }
        public string Title { get; set; }
        public Nullable<bool> IsCabRequired { get; set; }
        public Nullable<bool> IsAmountPaidByTraveller { get; set; }
        public Nullable<bool> IsHotelRequired { get; set; }
        public Nullable<bool> IsOKtoBoard { get; set; }
        public bool HotelApproval { get; set; }
    }
}
