using System;
using System.Collections.Generic;

namespace DotnetCore22.Domain.Model
{
    public partial class Model
    {
        public Model()
        {
            this.ListingInspectationCycles = new List<ListingInspectationCycle>();
            this.Listings = new List<Listing>();
            this.ModelColorOptions = new List<ModelColorOption>();
            this.ModelStorageOptions = new List<ModelStorageOption>();
        }

        public System.Guid Id { get; set; }
        public byte BrandId { get; set; }
        public string Name { get; set; }
        public string Specs { get; set; }
        public System.DateTime LaunchDate { get; set; }
        public virtual Brand Brand { get; set; }
        public virtual ICollection<ListingInspectationCycle> ListingInspectationCycles { get; set; }
        public virtual ICollection<Listing> Listings { get; set; }
        public virtual ICollection<ModelColorOption> ModelColorOptions { get; set; }
        public virtual ICollection<ModelStorageOption> ModelStorageOptions { get; set; }
    }
}
