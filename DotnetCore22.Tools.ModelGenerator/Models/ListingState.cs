using System;
using System.Collections.Generic;

namespace DotnetCore22.Domain.Model
{
    public partial class ListingState
    {
        public ListingState()
        {
            this.Listings = new List<Listing>();
            this.ListingStateChanges = new List<ListingStateChange>();
            this.ListingStateChanges1 = new List<ListingStateChange>();
        }

        public byte Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public virtual ICollection<Listing> Listings { get; set; }
        public virtual ICollection<ListingStateChange> ListingStateChanges { get; set; }
        public virtual ICollection<ListingStateChange> ListingStateChanges1 { get; set; }
    }
}
