using System;
using System.Collections.Generic;

namespace DotnetCore22.Domain.Model
{
    public partial class ListingInspectationCycle
    {
        public ListingInspectationCycle()
        {
            this.ListingInspactationCycleResults = new List<ListingInspactationCycleResult>();
        }

        public System.Guid Id { get; set; }
        public System.Guid ListingId { get; set; }
        public System.Guid InspectorUserId { get; set; }
        public System.Guid ReviewerUserId { get; set; }
        public System.DateTime Date { get; set; }
        public System.Guid ModelId { get; set; }
        public System.Guid ModelColorId { get; set; }
        public System.Guid ModelStorageId { get; set; }
        public byte ConditionId { get; set; }
        public bool AccessoryDetailsApproved { get; set; }
        public string AccessoriesDescription { get; set; }
        public bool HasReviewModification { get; set; }
        public virtual AdminUser AdminUser { get; set; }
        public virtual AdminUser AdminUser1 { get; set; }
        public virtual ICollection<ListingInspactationCycleResult> ListingInspactationCycleResults { get; set; }
        public virtual ListingItemCondition ListingItemCondition { get; set; }
        public virtual Listing Listing { get; set; }
        public virtual ModelColorOption ModelColorOption { get; set; }
        public virtual Model Model { get; set; }
        public virtual ModelStorageOption ModelStorageOption { get; set; }
    }
}
