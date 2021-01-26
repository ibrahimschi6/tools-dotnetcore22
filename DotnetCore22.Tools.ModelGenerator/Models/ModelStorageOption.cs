using System;
using System.Collections.Generic;

namespace DotnetCore22.Domain.Model
{
    public partial class ModelStorageOption
    {
        public ModelStorageOption()
        {
            this.DailySalePrices = new List<DailySalePrice>();
            this.ListingInspectationCycles = new List<ListingInspectationCycle>();
            this.RecentSolds = new List<RecentSold>();
        }

        public System.Guid Id { get; set; }
        public System.Guid Modeld { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public virtual ICollection<DailySalePrice> DailySalePrices { get; set; }
        public virtual ICollection<ListingInspectationCycle> ListingInspectationCycles { get; set; }
        public virtual Model Model { get; set; }
        public virtual ICollection<RecentSold> RecentSolds { get; set; }
    }
}
