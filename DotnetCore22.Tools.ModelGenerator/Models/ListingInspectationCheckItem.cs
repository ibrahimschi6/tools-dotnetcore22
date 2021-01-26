using System;
using System.Collections.Generic;

namespace DotnetCore22.Domain.Model
{
    public partial class ListingInspectationCheckItem
    {
        public ListingInspectationCheckItem()
        {
            this.ListingInspactationCycleResults = new List<ListingInspactationCycleResult>();
        }

        public byte Id { get; set; }
        public string Name { get; set; }
        public virtual ICollection<ListingInspactationCycleResult> ListingInspactationCycleResults { get; set; }
    }
}
