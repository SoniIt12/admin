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
    
    public partial class FeedBackGroupMaster
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public FeedBackGroupMaster()
        {
            this.FeedBackParameterMasters = new HashSet<FeedBackParameterMaster>();
        }
    
        public int GroupId { get; set; }
        public string GroupName { get; set; }
        public Nullable<bool> IsActive { get; set; }
        public Nullable<int> LevelID { get; set; }
    
        public virtual FeedBackLevelMaster FeedBackLevelMaster { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FeedBackParameterMaster> FeedBackParameterMasters { get; set; }
    }
}
