using System;
using System.Collections.Generic;

namespace DotnetCore22.Domain.Model
{
    public partial class ListingStateChange
    {
        public System.Guid Id { get; set; }
        public System.Guid ListingId { get; set; }
        public Nullable<System.Guid> UserId { get; set; }
        public byte CurrentStateId { get; set; }
        public byte PreviousStateId { get; set; }
        public string Description { get; set; }
        public System.DateTime Date { get; set; }
        public virtual Listing Listing { get; set; }
        public virtual ListingState ListingState { get; set; }
        public virtual ListingState ListingState1 { get; set; }
        public virtual User User { get; set; }
    }
}
