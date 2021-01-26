using System;
using System.Collections.Generic;

namespace DotnetCore22.Domain.Model
{
    public partial class ListingsComment
    {
        public System.Guid Id { get; set; }
        public System.Guid UserId { get; set; }
        public System.Guid ListingId { get; set; }
        public string Comment { get; set; }
        public System.DateTime CommentDate { get; set; }
        public virtual Listing Listing { get; set; }
        public virtual User User { get; set; }
    }
}
