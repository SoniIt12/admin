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
    
    public partial class ITHFinancialApprovalHOD
    {
        public long Id { get; set; }
        public Nullable<long> TravelRequestId { get; set; }
        public System.DateTime ResponseDate { get; set; }
        public string OriginPlace { get; set; }
        public string DestinationPlace { get; set; }
        public Nullable<System.DateTime> TravelDate { get; set; }
        public string FlightNo { get; set; }
        public string FlightName { get; set; }
        public string DepartureTime { get; set; }
        public string ArrivalTime { get; set; }
        public Nullable<decimal> Amount { get; set; }
        public string FlightType { get; set; }
    }
}
