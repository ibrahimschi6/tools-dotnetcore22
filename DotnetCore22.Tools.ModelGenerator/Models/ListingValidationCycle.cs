using System;
using System.Collections.Generic;

namespace DotnetCore22.Domain.Model
{
    public partial class ListingValidationCycle
    {
        public ListingValidationCycle()
        {
            this.ListingValidationCycleResults = new List<ListingValidationCycleResult>();
        }

        public System.Guid Id { get; set; }
        public System.Guid ListingId { get; set; }
        public System.Guid ValidatorUserId { get; set; }
        public System.DateTime Date { get; set; }
        public virtual AdminUser AdminUser { get; set; }
        public virtual Listing Listing { get; set; }
        public virtual ICollection<ListingValidationCycleResult> ListingValidationCycleResults { get; set; }
    }
}
