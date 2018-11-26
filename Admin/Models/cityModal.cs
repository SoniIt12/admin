using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Admin.Models
{
    public class cityModal
    {
       
            ///<summary>
            /// Gets or sets Customers.
            ///</summary>
            public List<Admin.Modal.SodCityCodeMaster> City { get; set; }

            ///<summary>
            /// Gets or sets CurrentPageIndex.
            ///</summary>
            public int CurrentPageIndex { get; set; }

            ///<summary>
            /// Gets or sets PageCount.
            ///</summary>
            public int PageCount { get; set; }
        
    }
}