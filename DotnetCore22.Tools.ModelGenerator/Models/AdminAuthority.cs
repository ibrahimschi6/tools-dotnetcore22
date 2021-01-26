using System;
using System.Collections.Generic;

namespace DotnetCore22.Domain.Model
{
    public partial class AdminAuthority
    {
        public AdminAuthority()
        {
            this.AdminRoles = new List<AdminRole>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Controller { get; set; }
        public string Action { get; set; }
        public string Area { get; set; }
        public virtual ICollection<AdminRole> AdminRoles { get; set; }
    }
}
