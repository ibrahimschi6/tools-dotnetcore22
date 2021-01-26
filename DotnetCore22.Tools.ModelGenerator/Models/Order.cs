using System;
using System.Collections.Generic;

namespace DotnetCore22.Domain.Model
{
    public partial class Order
    {
        public Order()
        {
            this.OrderStateChanges = new List<OrderStateChange>();
        }

        public System.Guid Id { get; set; }
        public System.Guid ListingId { get; set; }
        public System.Guid BuyerUserId { get; set; }
        public byte OrderStateId { get; set; }
        public decimal TotalPrice { get; set; }
        public decimal SellerAmount { get; set; }
        public decimal PaymentSystemAmount { get; set; }
        public decimal SystemAmount { get; set; }
        public byte InstallmentCount { get; set; }
        public string PaymentReferanceCode { get; set; }
        public string PaymentTransactionCode { get; set; }
        public bool IsMoneyDistributed { get; set; }
        public bool IsCurrent { get; set; }
        public System.DateTime CreateDate { get; set; }
        public Nullable<System.DateTime> UpdateDate { get; set; }
        public virtual Listing Listing { get; set; }
        public virtual ICollection<OrderStateChange> OrderStateChanges { get; set; }
        public virtual User User { get; set; }
    }
}
