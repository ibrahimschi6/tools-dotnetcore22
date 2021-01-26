using System;
using System.Collections.Generic;

namespace DotnetCore22.Domain.Model
{
    public partial class User
    {
        public User()
        {
            this.Buyers = new List<Buyer>();
            this.Feedbacks = new List<Feedback>();
            this.Feedbacks1 = new List<Feedback>();
            this.Listings = new List<Listing>();
            this.ListingsComments = new List<ListingsComment>();
            this.ListingStateChanges = new List<ListingStateChange>();
            this.Orders = new List<Order>();
            this.OrderStateChanges = new List<OrderStateChange>();
            this.Sellers = new List<Seller>();
            this.UsersBlockedListings = new List<UsersBlockedListing>();
            this.UsersFavoriteListings = new List<UsersFavoriteListing>();
        }

        public System.Guid Id { get; set; }
        public byte AuthorizationSourceId { get; set; }
        public byte AccountType { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string DisplayName { get; set; }
        public string FirsName { get; set; }
        public string LastName { get; set; }
        public byte[] Photo { get; set; }
        public string PhotoContentType { get; set; }
        public byte FeedbackRank { get; set; }
        public int FeedbackCount { get; set; }
        public System.DateTime RegisterDate { get; set; }
        public bool IsAgreementSigned { get; set; }
        public string ActivationCode { get; set; }
        public bool IsActive { get; set; }
        public bool IsDeleted { get; set; }
        public virtual ICollection<Buyer> Buyers { get; set; }
        public virtual ICollection<Feedback> Feedbacks { get; set; }
        public virtual ICollection<Feedback> Feedbacks1 { get; set; }
        public virtual ICollection<Listing> Listings { get; set; }
        public virtual ICollection<ListingsComment> ListingsComments { get; set; }
        public virtual ICollection<ListingStateChange> ListingStateChanges { get; set; }
        public virtual ICollection<Order> Orders { get; set; }
        public virtual ICollection<OrderStateChange> OrderStateChanges { get; set; }
        public virtual ICollection<Seller> Sellers { get; set; }
        public virtual ICollection<UsersBlockedListing> UsersBlockedListings { get; set; }
        public virtual ICollection<UsersFavoriteListing> UsersFavoriteListings { get; set; }
    }
}
