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
    
    public partial class HotelRequestApproval
    {
        public long Id { get; set; }
        public Nullable<long> TravelRequestId { get; set; }
        public System.DateTime RequestDate { get; set; }
        public string HotelName { get; set; }
        public string HotelAddress { get; set; }
        public string HotelPhone { get; set; }
        public string HotelType { get; set; }
        public string PrimaryEmail { get; set; }
        public string SecondaryEmail { get; set; }
        public string Remarks { get; set; }
        public string Status { get; set; }
        public string HotelConfirmationNo { get; set; }
        public Nullable<System.DateTime> ApprovalDate { get; set; }
        public Nullable<int> clubId { get; set; }
        public string HotelCode { get; set; }
        public Nullable<decimal> HotelPrice { get; set; }
        public string FlightNo { get; set; }
        public string ETA { get; set; }
        public bool IsTaxIncluded { get; set; }
        public Nullable<int> HotelRequestId { get; set; }
    }
}
