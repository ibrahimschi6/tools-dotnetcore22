using System;
using System.Collections.Generic;

namespace DotnetCore22.Domain.Model
{
    public partial class OrderState
    {
        public OrderState()
        {
            this.OrderStateChanges = new List<OrderStateChange>();
            this.OrderStateChanges1 = new List<OrderStateChange>();
        }

        public byte Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public virtual ICollection<OrderStateChange> OrderStateChanges { get; set; }
        public virtual ICollection<OrderStateChange> OrderStateChanges1 { get; set; }
    }
}
