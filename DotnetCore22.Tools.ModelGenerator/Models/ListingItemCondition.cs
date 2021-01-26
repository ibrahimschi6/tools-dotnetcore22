using System;
using System.Collections.Generic;

namespace DotnetCore22.Domain.Model
{
    public partial class ListingItemCondition
    {
        public ListingItemCondition()
        {
            this.ListingInspectationCycles = new List<ListingInspectationCycle>();
            this.Listings = new List<Listing>();
        }

        public byte Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public byte Order { get; set; }
        public virtual ICollection<ListingInspectationCycle> ListingInspectationCycles { get; set; }
        public virtual ICollection<Listing> Listings { get; set; }
    }
}
