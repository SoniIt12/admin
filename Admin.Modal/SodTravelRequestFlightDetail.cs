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
    
    public partial class SodTravelRequestFlightDetail
    {
        public long Id { get; set; }
        public long TravelRequestId { get; set; }
        public string OriginPlace { get; set; }
        public string DestinationPlace { get; set; }
        public System.DateTime TravelDate { get; set; }
        public string FlightNo { get; set; }
        public string DepartureTime { get; set; }
        public string ArrivalTime { get; set; }
        public string FlightName { get; set; }
        public Nullable<short> FlightTypes { get; set; }
        public Nullable<bool> IsHotelSendSms { get; set; }
    }
}
