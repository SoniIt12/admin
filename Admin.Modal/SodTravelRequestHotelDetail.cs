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
    
    public partial class SodTravelRequestHotelDetail
    {
        public long ID { get; set; }
        public Nullable<long> TravelRequestID { get; set; }
        public string HotelReferenceID { get; set; }
        public string City { get; set; }
        public string EmployeeCode { get; set; }
        public Nullable<System.DateTime> CheckInDate { get; set; }
        public Nullable<System.DateTime> CheckOutDate { get; set; }
        public Nullable<int> NoOfGuest { get; set; }
        public Nullable<System.DateTime> EntryDate { get; set; }
        public string HotelCode { get; set; }
        public string HotelName { get; set; }
        public string HotelAddress { get; set; }
        public string HotelPhoneNo { get; set; }
        public Nullable<byte> IsAllocated { get; set; }
        public string Remarks_Status { get; set; }
        public string CheckinTime { get; set; }
        public string CheckoutTime { get; set; }
        public string PrimaryEmail { get; set; }
        public string SecondaryEmail { get; set; }
        public string HotelType { get; set; }
        public string HotelStatus { get; set; }
        public string HotelConfirmationNo { get; set; }
        public Nullable<bool> AirportTransport { get; set; }
        public string usercancellation { get; set; }
        public Nullable<byte> IsCancelled { get; set; }
        public Nullable<int> clubId { get; set; }
        public string HodApprovalStatus { get; set; }
        public decimal HotelPrice { get; set; }
        public Nullable<bool> IsCabRequiredAsPerETA { get; set; }
        public string CabPickupTime { get; set; }
        public string CheckinTimeHotel { get; set; }
        public string CheckoutTimeHotel { get; set; }
        public bool UserCheckinCheckoutUpdate { get; set; }
        public Nullable<int> HotelRequestId { get; set; }
        public string Occupancy { get; set; }
    }
}
