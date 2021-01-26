using System;
using System.Collections.Generic;

namespace DotnetCore22.Domain.Model
{
    public partial class ListingsPhoto
    {
        public System.Guid Id { get; set; }
        public System.Guid ListingId { get; set; }
        public byte[] Photo { get; set; }
        public string PhotoContentType { get; set; }
        public System.DateTime DateAdded { get; set; }
        public virtual Listing Listing { get; set; }
    }
}
