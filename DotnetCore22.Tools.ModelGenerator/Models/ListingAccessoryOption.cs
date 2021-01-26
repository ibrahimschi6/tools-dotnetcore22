using System;
using System.Collections.Generic;

namespace DotnetCore22.Domain.Model
{
    public partial class ListingAccessoryOption
    {
        public ListingAccessoryOption()
        {
            this.Listings = new List<Listing>();
        }

        public byte Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public virtual ICollection<Listing> Listings { get; set; }
    }
}
