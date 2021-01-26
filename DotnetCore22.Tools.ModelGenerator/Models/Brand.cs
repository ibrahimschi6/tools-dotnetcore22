using System;
using System.Collections.Generic;

namespace DotnetCore22.Domain.Model
{
    public partial class Brand
    {
        public Brand()
        {
            this.Models = new List<Model>();
        }

        public byte Id { get; set; }
        public string FullCompanyName { get; set; }
        public string Name { get; set; }
        public virtual ICollection<Model> Models { get; set; }
    }
}
