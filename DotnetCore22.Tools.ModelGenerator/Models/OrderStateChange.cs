using System;
using System.Collections.Generic;

namespace DotnetCore22.Domain.Model
{
    public partial class OrderStateChange
    {
        public System.Guid Id { get; set; }
        public System.Guid OrderId { get; set; }
        public Nullable<System.Guid> UserId { get; set; }
        public byte CurrentStateId { get; set; }
        public byte PreviousStateId { get; set; }
        public string Description { get; set; }
        public System.DateTime Date { get; set; }
        public virtual Order Order { get; set; }
        public virtual OrderState OrderState { get; set; }
        public virtual OrderState OrderState1 { get; set; }
        public virtual User User { get; set; }
    }
}
