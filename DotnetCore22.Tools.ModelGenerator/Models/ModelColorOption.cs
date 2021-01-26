using System;
using System.Collections.Generic;

namespace DotnetCore22.Domain.Model
{
    public partial class ModelColorOption
    {
        public ModelColorOption()
        {
            this.ListingInspectationCycles = new List<ListingInspectationCycle>();
        }

        public System.Guid Id { get; set; }
        public System.Guid Modeld { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public virtual ICollection<ListingInspectationCycle> ListingInspectationCycles { get; set; }
        public virtual Model Model { get; set; }
    }
}
