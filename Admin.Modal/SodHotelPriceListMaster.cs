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
    
    public partial class SodHotelPriceListMaster
    {
        public long ID { get; set; }
        public Nullable<long> HotelId { get; set; }
        public string HotelCode { get; set; }
        public string StationCode { get; set; }
        public Nullable<decimal> SinglePrice { get; set; }
        public Nullable<decimal> DoublePrice { get; set; }
        public Nullable<short> TCId { get; set; }
        public string AddUser { get; set; }
        public string ModifiedUser { get; set; }
        public Nullable<System.DateTime> AddDate { get; set; }
        public Nullable<System.DateTime> ModifiedDate { get; set; }
    
        public virtual SodHotelListData SodHotelListData { get; set; }
    }
}
