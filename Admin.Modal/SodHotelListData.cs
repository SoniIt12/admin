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
    
    public partial class SodHotelListData
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public SodHotelListData()
        {
            this.SodHotelPriceListMasters = new HashSet<SodHotelPriceListMaster>();
        }
    
        public long ID { get; set; }
        public string HotelName { get; set; }
        public string City { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public string PrimaryEmail { get; set; }
        public string SecondaryEmail { get; set; }
        public string HotelCode { get; set; }
        public string StationCode { get; set; }
        public string Status { get; set; }
        public string GMname { get; set; }
        public bool IsTaxIncluded { get; set; }
        public Nullable<System.DateTime> ContractStartDate { get; set; }
        public Nullable<System.DateTime> ContractEndDate { get; set; }
        public string ContractFile { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SodHotelPriceListMaster> SodHotelPriceListMasters { get; set; }
    }
}
