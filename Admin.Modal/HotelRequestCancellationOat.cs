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
    
    public partial class HotelRequestCancellationOat
    {
        public long Id { get; set; }
        public Nullable<long> TravelRequestId { get; set; }
        public Nullable<System.DateTime> CancellationDate { get; set; }
        public string CancellationReason { get; set; }
        public string hotelStatus { get; set; }
        public Nullable<int> HotelRequestId { get; set; }
    }
}
