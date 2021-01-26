using System;
using System.Collections.Generic;

namespace DotnetCore22.Domain.Model
{
    public partial class DailySalePrice
    {
        public System.Guid Id { get; set; }
        public System.Guid ModelStorageId { get; set; }
        public decimal RecentSoldAverage { get; set; }
        public decimal LastSold { get; set; }
        public decimal LowestCurrent { get; set; }
        public System.DateTime Date { get; set; }
        public virtual ModelStorageOption ModelStorageOption { get; set; }
    }
}
