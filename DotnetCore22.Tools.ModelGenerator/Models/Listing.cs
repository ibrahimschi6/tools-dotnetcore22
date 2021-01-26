using System;
using System.Collections.Generic;

namespace DotnetCore22.Domain.Model
{
    public partial class Listing
    {
        public Listing()
        {
            this.Feedbacks = new List<Feedback>();
            this.ListingInspectationCycles = new List<ListingInspectationCycle>();
            this.ListingsComments = new List<ListingsComment>();
            this.ListingsPhotos = new List<ListingsPhoto>();
            this.ListingStateChanges = new List<ListingStateChange>();
            this.ListingValidationCycles = new List<ListingValidationCycle>();
            this.Orders = new List<Order>();
            this.UsersBlockedListings = new List<UsersBlockedListing>();
            this.UsersFavoriteListings = new List<UsersFavoriteListing>();
            this.ListingAccessoryOptions = new List<ListingAccessoryOption>();
        }

        public System.Guid Id { get; set; }
        public string Code { get; set; }
        public System.Guid SellerUserId { get; set; }
        public System.Guid ModelId { get; set; }
        public System.Guid ModelColorId { get; set; }
        public System.Guid ModelStorageId { get; set; }
        public byte ConditionId { get; set; }
        public string Headline { get; set; }
        public string Description { get; set; }
        public string IMEI { get; set; }
        public decimal Price { get; set; }
        public string AccessoriesDescription { get; set; }
        public byte CityId { get; set; }
        public long ShowCount { get; set; }
        public byte ListingStateId { get; set; }
        public System.DateTime CreateDate { get; set; }
        public Nullable<System.DateTime> UpdateDate { get; set; }
        public virtual City City { get; set; }
        public virtual ICollection<Feedback> Feedbacks { get; set; }
        public virtual ICollection<ListingInspectationCycle> ListingInspectationCycles { get; set; }
        public virtual ListingItemCondition ListingItemCondition { get; set; }
        public virtual ListingState ListingState { get; set; }
        public virtual Model Model { get; set; }
        public virtual User User { get; set; }
        public virtual ICollection<ListingsComment> ListingsComments { get; set; }
        public virtual ICollection<ListingsPhoto> ListingsPhotos { get; set; }
        public virtual ICollection<ListingStateChange> ListingStateChanges { get; set; }
        public virtual ICollection<ListingValidationCycle> ListingValidationCycles { get; set; }
        public virtual ICollection<Order> Orders { get; set; }
        public virtual ICollection<UsersBlockedListing> UsersBlockedListings { get; set; }
        public virtual ICollection<UsersFavoriteListing> UsersFavoriteListings { get; set; }
        public virtual ICollection<ListingAccessoryOption> ListingAccessoryOptions { get; set; }
    }
}
