using System;
using System.Collections.Generic;

namespace DotnetCore22.Domain.Model
{
    public partial class ListingValidationCheckItem
    {
        public ListingValidationCheckItem()
        {
            this.ListingValidationCycleResults = new List<ListingValidationCycleResult>();
        }

        public byte Id { get; set; }
        public string Name { get; set; }
        public virtual ICollection<ListingValidationCycleResult> ListingValidationCycleResults { get; set; }
    }
}
