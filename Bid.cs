//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace OnlineAuctioningSystem
{
    using System;
    using System.Collections.Generic;
    
    public partial class Bid
    {
        public int id { get; set; }
        public Nullable<int> productId { get; set; }
        public Nullable<double> bidPrice { get; set; }
        public Nullable<int> customerId { get; set; }
        public Nullable<bool> isDeleted { get; set; }
    
        public virtual Customer Customer { get; set; }
        public virtual Product Product { get; set; }
    }
}
