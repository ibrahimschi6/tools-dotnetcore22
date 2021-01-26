using System;
using System.Collections.Generic;

namespace DotnetCore22.Domain.Model
{
    public partial class RecentSold
    {
        public System.Guid Id { get; set; }
        public System.Guid ModelStorageId { get; set; }
        public decimal AveragePrice { get; set; }
        public decimal LastPrice { get; set; }
        public decimal LowestPrice { get; set; }
        public short Count { get; set; }
        public System.DateTime Date { get; set; }
        public virtual ModelStorageOption ModelStorageOption { get; set; }
    }
}
