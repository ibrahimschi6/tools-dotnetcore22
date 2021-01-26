using System;
using System.Collections.Generic;

namespace DotnetCore22.Domain.Model
{
    public partial class ListingInspactationCycleResult
    {
        public System.Guid Id { get; set; }
        public System.Guid ListingCycleId { get; set; }
        public byte CheckItemId { get; set; }
        public bool IsValid { get; set; }
        public string Description { get; set; }
        public virtual ListingInspectationCheckItem ListingInspectationCheckItem { get; set; }
        public virtual ListingInspectationCycle ListingInspectationCycle { get; set; }
    }
}
