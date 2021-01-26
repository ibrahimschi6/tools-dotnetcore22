using System;
using System.Collections.Generic;

namespace DotnetCore22.Domain.Model
{
    public partial class City
    {
        public City()
        {
            this.Buyers = new List<Buyer>();
            this.Listings = new List<Listing>();
            this.Sellers = new List<Seller>();
        }

        public byte Id { get; set; }
        public string Name { get; set; }
        public virtual ICollection<Buyer> Buyers { get; set; }
        public virtual ICollection<Listing> Listings { get; set; }
        public virtual ICollection<Seller> Sellers { get; set; }
    }
}
