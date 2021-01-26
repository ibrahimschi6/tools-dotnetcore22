using System;
using System.Collections.Generic;

namespace DotnetCore22.Domain.Model
{
    public partial class Feedback
    {
        public System.Guid Id { get; set; }
        public byte Type { get; set; }
        public System.Guid ListingId { get; set; }
        public System.Guid BuyerUserId { get; set; }
        public System.Guid SellerUserId { get; set; }
        public byte Point { get; set; }
        public string Comment { get; set; }
        public System.DateTime Date { get; set; }
        public virtual Listing Listing { get; set; }
        public virtual User User { get; set; }
        public virtual User User1 { get; set; }
    }
}
